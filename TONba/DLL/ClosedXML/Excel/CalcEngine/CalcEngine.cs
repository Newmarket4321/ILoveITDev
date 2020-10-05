// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.CalcEngine
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using ClosedXML.Excel.CalcEngine.Functions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClosedXML.Excel.CalcEngine
{
  internal class CalcEngine
  {
    private string _expr;
    private int _len;
    private int _ptr;
    private string _idChars;
    private Token _token;
    private Dictionary<object, Token> _tkTbl;
    private Dictionary<string, FunctionDefinition> _fnTbl;
    private Dictionary<string, object> _vars;
    private object _dataContext;
    private bool _optimize;
    private ExpressionCache _cache;
    private CultureInfo _ci;
    private char _decimal;
    private char _listSep;
    private char _percent;

    public CalcEngine()
    {
      this.CultureInfo = CultureInfo.InvariantCulture;
      this._tkTbl = this.GetSymbolTable();
      this._fnTbl = this.GetFunctionTable();
      this._vars = new Dictionary<string, object>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      this._cache = new ExpressionCache(this);
      this._optimize = true;
    }

    public Expression Parse(string expression)
    {
      this._expr = expression;
      this._len = this._expr.Length;
      this._ptr = 0;
      if (this._len > 0 && (int) this._expr[0] == 61)
        ++this._ptr;
      Expression expression1 = this.ParseExpression();
      if (this._token.ID != TKID.END)
        ClosedXML.Excel.CalcEngine.CalcEngine.Throw();
      if (this._optimize)
        expression1 = expression1.Optimize();
      return expression1;
    }

    public object Evaluate(string expression)
    {
      return (this._cache != null ? this._cache[expression] : this.Parse(expression)).Evaluate();
    }

    public bool CacheExpressions
    {
      get
      {
        return this._cache != null;
      }
      set
      {
        if (value == this.CacheExpressions)
          return;
        this._cache = value ? new ExpressionCache(this) : (ExpressionCache) null;
      }
    }

    public bool OptimizeExpressions
    {
      get
      {
        return this._optimize;
      }
      set
      {
        this._optimize = value;
      }
    }

    public string IdentifierChars
    {
      get
      {
        return this._idChars;
      }
      set
      {
        this._idChars = value;
      }
    }

    public void RegisterFunction(string functionName, int parmMin, int parmMax, CalcEngineFunction fn)
    {
      this._fnTbl.Add(functionName, new FunctionDefinition(parmMin, parmMax, fn));
    }

    public void RegisterFunction(string functionName, int parmCount, CalcEngineFunction fn)
    {
      this.RegisterFunction(functionName, parmCount, parmCount, fn);
    }

    public virtual object GetExternalObject(string identifier)
    {
      return (object) null;
    }

    public virtual object DataContext
    {
      get
      {
        return this._dataContext;
      }
      set
      {
        this._dataContext = value;
      }
    }

    public Dictionary<string, FunctionDefinition> Functions
    {
      get
      {
        return this._fnTbl;
      }
    }

    public Dictionary<string, object> Variables
    {
      get
      {
        return this._vars;
      }
    }

    public CultureInfo CultureInfo
    {
      get
      {
        return this._ci;
      }
      set
      {
        this._ci = value;
        System.Globalization.NumberFormatInfo numberFormat = this._ci.NumberFormat;
        this._decimal = numberFormat.NumberDecimalSeparator[0];
        this._percent = numberFormat.PercentSymbol[0];
        this._listSep = this._ci.TextInfo.ListSeparator[0];
      }
    }

    private Dictionary<object, Token> GetSymbolTable()
    {
      if (this._tkTbl == null)
      {
        this._tkTbl = new Dictionary<object, Token>();
        this.AddToken((object) '&', TKID.CONCAT, TKTYPE.ADDSUB);
        this.AddToken((object) '+', TKID.ADD, TKTYPE.ADDSUB);
        this.AddToken((object) '-', TKID.SUB, TKTYPE.ADDSUB);
        this.AddToken((object) '(', TKID.OPEN, TKTYPE.GROUP);
        this.AddToken((object) ')', TKID.CLOSE, TKTYPE.GROUP);
        this.AddToken((object) '*', TKID.MUL, TKTYPE.MULDIV);
        this.AddToken((object) '.', TKID.PERIOD, TKTYPE.GROUP);
        this.AddToken((object) '/', TKID.DIV, TKTYPE.MULDIV);
        this.AddToken((object) '\\', TKID.DIVINT, TKTYPE.MULDIV);
        this.AddToken((object) '=', TKID.EQ, TKTYPE.COMPARE);
        this.AddToken((object) '>', TKID.GT, TKTYPE.COMPARE);
        this.AddToken((object) '<', TKID.LT, TKTYPE.COMPARE);
        this.AddToken((object) '^', TKID.POWER, TKTYPE.POWER);
        this.AddToken((object) "<>", TKID.NE, TKTYPE.COMPARE);
        this.AddToken((object) ">=", TKID.GE, TKTYPE.COMPARE);
        this.AddToken((object) "<=", TKID.LE, TKTYPE.COMPARE);
      }
      return this._tkTbl;
    }

    private void AddToken(object symbol, TKID id, TKTYPE type)
    {
      Token token = new Token(symbol, id, type);
      this._tkTbl.Add(symbol, token);
    }

    private Dictionary<string, FunctionDefinition> GetFunctionTable()
    {
      if (this._fnTbl == null)
      {
        this._fnTbl = new Dictionary<string, FunctionDefinition>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
        Is.Register(this);
        Logical.Register(this);
        MathTrig.Register(this);
        Text.Register(this);
        Statistical.Register(this);
        DateAndTime.Register(this);
      }
      return this._fnTbl;
    }

    private Expression ParseExpression()
    {
      this.GetToken();
      return this.ParseCompare();
    }

    private Expression ParseCompare()
    {
      Expression exprLeft = this.ParseAddSub();
      while (this._token.Type == TKTYPE.COMPARE)
      {
        Token token = this._token;
        this.GetToken();
        Expression addSub = this.ParseAddSub();
        exprLeft = (Expression) new BinaryExpression(token, exprLeft, addSub);
      }
      return exprLeft;
    }

    private Expression ParseAddSub()
    {
      Expression exprLeft = this.ParseMulDiv();
      while (this._token.Type == TKTYPE.ADDSUB)
      {
        Token token = this._token;
        this.GetToken();
        Expression mulDiv = this.ParseMulDiv();
        exprLeft = (Expression) new BinaryExpression(token, exprLeft, mulDiv);
      }
      return exprLeft;
    }

    private Expression ParseMulDiv()
    {
      Expression exprLeft = this.ParsePower();
      while (this._token.Type == TKTYPE.MULDIV)
      {
        Token token = this._token;
        this.GetToken();
        Expression power = this.ParsePower();
        exprLeft = (Expression) new BinaryExpression(token, exprLeft, power);
      }
      return exprLeft;
    }

    private Expression ParsePower()
    {
      Expression exprLeft = this.ParseUnary();
      while (this._token.Type == TKTYPE.POWER)
      {
        Token token = this._token;
        this.GetToken();
        Expression unary = this.ParseUnary();
        exprLeft = (Expression) new BinaryExpression(token, exprLeft, unary);
      }
      return exprLeft;
    }

    private Expression ParseUnary()
    {
      if (this._token.ID != TKID.ADD && this._token.ID != TKID.SUB)
        return this.ParseAtom();
      Token token = this._token;
      this.GetToken();
      Expression atom = this.ParseAtom();
      return (Expression) new UnaryExpression(token, atom);
    }

    private Expression ParseAtom()
    {
      Expression expression = (Expression) null;
      FunctionDefinition function = (FunctionDefinition) null;
      switch (this._token.Type)
      {
        case TKTYPE.GROUP:
          if (this._token.ID != TKID.OPEN)
            ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Expression expected.");
          this.GetToken();
          expression = this.ParseCompare();
          if (this._token.ID != TKID.CLOSE)
          {
            ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Unbalanced parenthesis.");
            break;
          }
          break;
        case TKTYPE.LITERAL:
          expression = new Expression(this._token);
          break;
        case TKTYPE.IDENTIFIER:
          string str = (string) this._token.Value;
          if (this._fnTbl.TryGetValue(str, out function))
          {
            List<Expression> parameters = this.GetParameters();
            int num = parameters == null ? 0 : parameters.Count;
            if (function.ParmMin != -1 && num < function.ParmMin)
              ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Too few parameters.");
            if (function.ParmMax != -1 && num > function.ParmMax)
              ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Too many parameters.");
            expression = (Expression) new FunctionExpression(function, parameters);
            break;
          }
          if (this._vars.ContainsKey(str))
          {
            expression = (Expression) new VariableExpression(this._vars, str);
            break;
          }
          object externalObject = this.GetExternalObject(str);
          if (externalObject != null)
          {
            expression = (Expression) new XObjectExpression(externalObject);
            break;
          }
          if (this.DataContext != null)
          {
            List<BindingInfo> bindingPath = new List<BindingInfo>();
            for (Token token = this._token; token != null; token = this.GetMember())
              bindingPath.Add(new BindingInfo((string) token.Value, this.GetParameters()));
            expression = (Expression) new BindingExpression(this, bindingPath, this._ci);
            break;
          }
          ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Unexpected identifier");
          break;
      }
      if (expression == null)
        ClosedXML.Excel.CalcEngine.CalcEngine.Throw();
      this.GetToken();
      return expression;
    }

    private void GetToken()
    {
      while (this._ptr < this._len && (int) this._expr[this._ptr] <= 32)
        ++this._ptr;
      if (this._ptr >= this._len)
      {
        this._token = new Token((object) null, TKID.END, TKTYPE.GROUP);
      }
      else
      {
        char ch1 = this._expr[this._ptr];
        bool flag1 = (int) ch1 >= 97 && (int) ch1 <= 122 || (int) ch1 >= 65 && (int) ch1 <= 90;
        bool flag2 = (int) ch1 >= 48 && (int) ch1 <= 57;
        if (!flag1 && !flag2)
        {
          int num = this._ptr + 1 < this._len ? (int) this._expr[this._ptr + 1] : 0;
          if ((int) ch1 != (int) this._decimal || num < 48 || num > 57)
          {
            if ((int) ch1 == (int) this._listSep)
            {
              this._token = new Token((object) ch1, TKID.COMMA, TKTYPE.GROUP);
              ++this._ptr;
              return;
            }
            Token token;
            if (this._tkTbl.TryGetValue((object) ch1, out token))
            {
              this._token = token;
              ++this._ptr;
              if (this._ptr >= this._len || (int) ch1 != 62 && (int) ch1 != 60 || !this._tkTbl.TryGetValue((object) this._expr.Substring(this._ptr - 1, 2), out token))
                return;
              this._token = token;
              ++this._ptr;
              return;
            }
          }
        }
        if (flag2 || (int) ch1 == (int) this._decimal)
        {
          bool flag3 = false;
          bool flag4 = false;
          double num1 = -1.0;
          double num2 = 0.0;
          int length;
          for (length = 0; length + this._ptr < this._len; ++length)
          {
            char ch2 = this._expr[this._ptr + length];
            if ((int) ch2 >= 48 && (int) ch2 <= 57)
            {
              num2 = num2 * 10.0 + (double) ((int) ch2 - 48);
              if (num1 > -1.0)
                num1 *= 10.0;
            }
            else if ((int) ch2 == (int) this._decimal && num1 < 0.0)
              num1 = 1.0;
            else if (((int) ch2 == 69 || (int) ch2 == 101) && !flag3)
            {
              flag3 = true;
              switch (this._expr[this._ptr + length + 1])
              {
                case '+':
                case '-':
                  ++length;
                  continue;
                default:
                  continue;
              }
            }
            else
            {
              if ((int) ch2 == (int) this._percent)
              {
                flag4 = true;
                ++length;
                break;
              }
              break;
            }
          }
          if (!flag3)
          {
            if (num1 > 1.0)
              num2 /= num1;
            if (flag4)
              num2 /= 100.0;
          }
          else
            num2 = ClosedXML.Excel.CalcEngine.CalcEngine.ParseDouble(this._expr.Substring(this._ptr, length), this._ci);
          this._token = new Token((object) num2, TKID.ATOM, TKTYPE.LITERAL);
          this._ptr += length;
        }
        else
        {
          switch (ch1)
          {
            case '"':
              int num3;
              for (num3 = 1; num3 + this._ptr < this._len; ++num3)
              {
                ch1 = this._expr[this._ptr + num3];
                if ((int) ch1 == 34)
                {
                  if ((num3 + this._ptr < this._len - 1 ? (int) this._expr[this._ptr + num3 + 1] : (int) ' ') == 34)
                    ++num3;
                  else
                    break;
                }
              }
              if ((int) ch1 != 34)
                ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Can't find final quote.");
              string str1 = this._expr.Substring(this._ptr + 1, num3 - 1);
              this._ptr += num3 + 1;
              this._token = new Token((object) str1.Replace("\"\"", "\""), TKID.ATOM, TKTYPE.LITERAL);
              break;
            case '#':
              int num4;
              for (num4 = 1; num4 + this._ptr < this._len; ++num4)
              {
                ch1 = this._expr[this._ptr + num4];
                if ((int) ch1 == 35)
                  break;
              }
              if ((int) ch1 != 35)
                ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Can't find final date delimiter ('#').");
              string s = this._expr.Substring(this._ptr + 1, num4 - 1);
              this._ptr += num4 + 1;
              this._token = new Token((object) DateTime.Parse(s, (IFormatProvider) this._ci), TKID.ATOM, TKTYPE.LITERAL);
              break;
            default:
              if (!flag1 && (int) ch1 != 95 && (this._idChars == null || this._idChars.IndexOf(ch1) < 0))
                ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Identifier expected.");
              int length1;
              for (length1 = 1; length1 + this._ptr < this._len; ++length1)
              {
                char ch2 = this._expr[this._ptr + length1];
                if (((int) ch2 < 97 || (int) ch2 > 122) && ((int) ch2 < 65 || (int) ch2 > 90) && ((int) ch2 < 48 || (int) ch2 > 57) && (int) ch2 != 95 && (this._idChars == null || this._idChars.IndexOf(ch2) < 0))
                  break;
              }
              string str2 = this._expr.Substring(this._ptr, length1);
              this._ptr += length1;
              this._token = new Token((object) str2, TKID.ATOM, TKTYPE.IDENTIFIER);
              break;
          }
        }
      }
    }

    private static double ParseDouble(string str, CultureInfo ci)
    {
      if (str.Length <= 0 || (int) str[str.Length - 1] != (int) ci.NumberFormat.PercentSymbol[0])
        return double.Parse(str, NumberStyles.Any, (IFormatProvider) ci);
      str = str.Substring(0, str.Length - 1);
      return double.Parse(str, NumberStyles.Any, (IFormatProvider) ci) / 100.0;
    }

    private List<Expression> GetParameters()
    {
      int ptr1 = this._ptr;
      Token token = this._token;
      this.GetToken();
      if (this._token.ID != TKID.OPEN)
      {
        this._ptr = ptr1;
        this._token = token;
        return (List<Expression>) null;
      }
      int ptr2 = this._ptr;
      this.GetToken();
      if (this._token.ID == TKID.CLOSE)
        return (List<Expression>) null;
      this._ptr = ptr2;
      List<Expression> expressionList = new List<Expression>();
      expressionList.Add(this.ParseExpression());
      while (this._token.ID == TKID.COMMA)
      {
        Expression expression = this.ParseExpression();
        expressionList.Add(expression);
      }
      if (this._token.ID != TKID.CLOSE)
        ClosedXML.Excel.CalcEngine.CalcEngine.Throw();
      return expressionList;
    }

    private Token GetMember()
    {
      int ptr = this._ptr;
      Token token = this._token;
      this.GetToken();
      if (this._token.ID != TKID.PERIOD)
      {
        this._ptr = ptr;
        this._token = token;
        return (Token) null;
      }
      this.GetToken();
      if (this._token.Type != TKTYPE.IDENTIFIER)
        ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Identifier expected");
      return this._token;
    }

    private static void Throw()
    {
      ClosedXML.Excel.CalcEngine.CalcEngine.Throw("Syntax error.");
    }

    private static void Throw(string msg)
    {
      throw new Exception(msg);
    }
  }
}
