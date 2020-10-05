// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.MathTrig
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using ClosedXML.Excel.CalcEngine.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClosedXML.Excel.CalcEngine
{
  internal static class MathTrig
  {
    private static readonly Random _rnd = new Random();

    public static void Register(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      ce.RegisterFunction("ABS", 1, new CalcEngineFunction(MathTrig.Abs));
      ce.RegisterFunction("ACOS", 1, new CalcEngineFunction(MathTrig.Acos));
      ce.RegisterFunction("ACOSH", 1, new CalcEngineFunction(MathTrig.Acosh));
      ce.RegisterFunction("ASIN", 1, new CalcEngineFunction(MathTrig.Asin));
      ce.RegisterFunction("ASINH", 1, new CalcEngineFunction(MathTrig.Asinh));
      ce.RegisterFunction("ATAN", 1, new CalcEngineFunction(MathTrig.Atan));
      ce.RegisterFunction("ATAN2", 2, new CalcEngineFunction(MathTrig.Atan2));
      ce.RegisterFunction("ATANH", 1, new CalcEngineFunction(MathTrig.Atanh));
      ce.RegisterFunction("CEILING", 1, new CalcEngineFunction(MathTrig.Ceiling));
      ce.RegisterFunction("COMBIN", 2, new CalcEngineFunction(MathTrig.Combin));
      ce.RegisterFunction("COS", 1, new CalcEngineFunction(MathTrig.Cos));
      ce.RegisterFunction("COSH", 1, new CalcEngineFunction(MathTrig.Cosh));
      ce.RegisterFunction("DEGREES", 1, new CalcEngineFunction(MathTrig.Degrees));
      ce.RegisterFunction("EVEN", 1, new CalcEngineFunction(MathTrig.Even));
      ce.RegisterFunction("EXP", 1, new CalcEngineFunction(MathTrig.Exp));
      ce.RegisterFunction("FACT", 1, new CalcEngineFunction(MathTrig.Fact));
      ce.RegisterFunction("FACTDOUBLE", 1, new CalcEngineFunction(MathTrig.FactDouble));
      ce.RegisterFunction("FLOOR", 1, new CalcEngineFunction(MathTrig.Floor));
      ce.RegisterFunction("GCD", 1, (int) byte.MaxValue, new CalcEngineFunction(MathTrig.Gcd));
      ce.RegisterFunction("INT", 1, new CalcEngineFunction(MathTrig.Int));
      ce.RegisterFunction("LCM", 1, (int) byte.MaxValue, new CalcEngineFunction(MathTrig.Lcm));
      ce.RegisterFunction("LN", 1, new CalcEngineFunction(MathTrig.Ln));
      ce.RegisterFunction("LOG", 1, 2, new CalcEngineFunction(MathTrig.Log));
      ce.RegisterFunction("LOG10", 1, new CalcEngineFunction(MathTrig.Log10));
      ce.RegisterFunction("MDETERM", 1, new CalcEngineFunction(MathTrig.MDeterm));
      ce.RegisterFunction("MINVERSE", 1, new CalcEngineFunction(MathTrig.MInverse));
      ce.RegisterFunction("MMULT", 2, new CalcEngineFunction(MathTrig.MMult));
      ce.RegisterFunction("MOD", 2, new CalcEngineFunction(MathTrig.Mod));
      ce.RegisterFunction("MROUND", 2, new CalcEngineFunction(MathTrig.MRound));
      ce.RegisterFunction("MULTINOMIAL", 1, (int) byte.MaxValue, new CalcEngineFunction(MathTrig.Multinomial));
      ce.RegisterFunction("ODD", 1, new CalcEngineFunction(MathTrig.Odd));
      ce.RegisterFunction("PI", 0, new CalcEngineFunction(MathTrig.Pi));
      ce.RegisterFunction("POWER", 2, new CalcEngineFunction(MathTrig.Power));
      ce.RegisterFunction("PRODUCT", 1, (int) byte.MaxValue, new CalcEngineFunction(MathTrig.Product));
      ce.RegisterFunction("QUOTIENT", 2, new CalcEngineFunction(MathTrig.Quotient));
      ce.RegisterFunction("RADIANS", 1, new CalcEngineFunction(MathTrig.Radians));
      ce.RegisterFunction("RAND", 0, new CalcEngineFunction(MathTrig.Rand));
      ce.RegisterFunction("RANDBETWEEN", 2, new CalcEngineFunction(MathTrig.RandBetween));
      ce.RegisterFunction("ROMAN", 1, 2, new CalcEngineFunction(MathTrig.Roman));
      ce.RegisterFunction("ROUND", 2, new CalcEngineFunction(MathTrig.Round));
      ce.RegisterFunction("ROUNDDOWN", 2, new CalcEngineFunction(MathTrig.RoundDown));
      ce.RegisterFunction("ROUNDUP", 1, 2, new CalcEngineFunction(MathTrig.RoundUp));
      ce.RegisterFunction("SERIESSUM", 4, new CalcEngineFunction(MathTrig.SeriesSum));
      ce.RegisterFunction("SIGN", 1, new CalcEngineFunction(MathTrig.Sign));
      ce.RegisterFunction("SIN", 1, new CalcEngineFunction(MathTrig.Sin));
      ce.RegisterFunction("SINH", 1, new CalcEngineFunction(MathTrig.Sinh));
      ce.RegisterFunction("SQRT", 1, new CalcEngineFunction(MathTrig.Sqrt));
      ce.RegisterFunction("SQRTPI", 1, new CalcEngineFunction(MathTrig.SqrtPi));
      ce.RegisterFunction("SUBTOTAL", 2, (int) byte.MaxValue, new CalcEngineFunction(MathTrig.Subtotal));
      ce.RegisterFunction("SUM", 1, int.MaxValue, new CalcEngineFunction(MathTrig.Sum));
      ce.RegisterFunction("SUMIF", 2, 3, new CalcEngineFunction(MathTrig.SumIf));
      ce.RegisterFunction("SUMSQ", 1, (int) byte.MaxValue, new CalcEngineFunction(MathTrig.SumSq));
      ce.RegisterFunction("TAN", 1, new CalcEngineFunction(MathTrig.Tan));
      ce.RegisterFunction("TANH", 1, new CalcEngineFunction(MathTrig.Tanh));
      ce.RegisterFunction("TRUNC", 1, new CalcEngineFunction(MathTrig.Trunc));
    }

    private static object Abs(List<Expression> p)
    {
      return (object) Math.Abs((double) p[0]);
    }

    private static object Acos(List<Expression> p)
    {
      return (object) Math.Acos((double) p[0]);
    }

    private static object Asin(List<Expression> p)
    {
      return (object) Math.Asin((double) p[0]);
    }

    private static object Atan(List<Expression> p)
    {
      return (object) Math.Atan((double) p[0]);
    }

    private static object Atan2(List<Expression> p)
    {
      return (object) Math.Atan2((double) p[0], (double) p[1]);
    }

    private static object Ceiling(List<Expression> p)
    {
      return (object) Math.Ceiling((double) p[0]);
    }

    private static object Cos(List<Expression> p)
    {
      return (object) Math.Cos((double) p[0]);
    }

    private static object Cosh(List<Expression> p)
    {
      return (object) Math.Cosh((double) p[0]);
    }

    private static object Exp(List<Expression> p)
    {
      return (object) Math.Exp((double) p[0]);
    }

    private static object Floor(List<Expression> p)
    {
      return (object) Math.Floor((double) p[0]);
    }

    private static object Int(List<Expression> p)
    {
      return (object) (int) (double) p[0];
    }

    private static object Ln(List<Expression> p)
    {
      return (object) Math.Log((double) p[0]);
    }

    private static object Log(List<Expression> p)
    {
      double newBase = p.Count > 1 ? (double) p[1] : 10.0;
      return (object) Math.Log((double) p[0], newBase);
    }

    private static object Log10(List<Expression> p)
    {
      return (object) Math.Log10((double) p[0]);
    }

    private static object Pi(List<Expression> p)
    {
      return (object) Math.PI;
    }

    private static object Power(List<Expression> p)
    {
      return (object) Math.Pow((double) p[0], (double) p[1]);
    }

    private static object Rand(List<Expression> p)
    {
      return (object) MathTrig._rnd.NextDouble();
    }

    private static object RandBetween(List<Expression> p)
    {
      return (object) MathTrig._rnd.Next((int) (double) p[0], (int) (double) p[1]);
    }

    private static object Sign(List<Expression> p)
    {
      return (object) Math.Sign((double) p[0]);
    }

    private static object Sin(List<Expression> p)
    {
      return (object) Math.Sin((double) p[0]);
    }

    private static object Sinh(List<Expression> p)
    {
      return (object) Math.Sinh((double) p[0]);
    }

    private static object Sqrt(List<Expression> p)
    {
      return (object) Math.Sqrt((double) p[0]);
    }

    private static object Sum(List<Expression> p)
    {
      Tally tally = new Tally();
      foreach (Expression e in p)
        tally.Add(e);
      return (object) tally.Sum();
    }

    private static object SumIf(List<Expression> p)
    {
      IEnumerable enumerable1 = p[0] as IEnumerable;
      IEnumerable enumerable2 = p.Count < 3 ? enumerable1 : p[2] as IEnumerable;
      object criteria = p[1].Evaluate();
      List<object> objectList1 = new List<object>();
      foreach (object obj in enumerable1)
        objectList1.Add(obj);
      List<object> objectList2 = new List<object>();
      foreach (object obj in enumerable2)
        objectList2.Add(obj);
      ClosedXML.Excel.CalcEngine.CalcEngine ce = new ClosedXML.Excel.CalcEngine.CalcEngine();
      Tally tally = new Tally();
      for (int index = 0; index < Math.Min(objectList1.Count, objectList2.Count); ++index)
      {
        if (MathTrig.ValueSatisfiesCriteria(objectList1[index], criteria, ce))
          tally.AddValue(objectList2[index]);
      }
      return (object) tally.Sum();
    }

    private static bool ValueSatisfiesCriteria(object value, object criteria, ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      if (value == null)
        return false;
      if (criteria is double)
      {
        if (value is double)
          return (double) value == (double) criteria;
        double result;
        if (double.TryParse(value.ToString(), out result))
          return result == (double) criteria;
        return false;
      }
      string b = criteria as string;
      if (string.IsNullOrEmpty(b))
        return false;
      if ((int) b[0] == 61 || (int) b[0] == 60 || (int) b[0] == 62)
      {
        string str = string.Format("{0}{1}", value, (object) b);
        string pattern = "(\\w+)(\\W+)(\\w+)";
        Match match = Regex.Match(str, pattern);
        double result;
        if (match.Groups.Count == 4 && (!double.TryParse(match.Groups[1].Value, out result) || !double.TryParse(match.Groups[3].Value, out result)))
          str = string.Format("\"{0}\"{1}\"{2}\"", (object) match.Groups[1].Value, (object) match.Groups[2].Value, (object) match.Groups[3].Value);
        return (bool) ce.Evaluate(str);
      }
      if (b.IndexOf('*') <= -1)
        return string.Equals(value.ToString(), b, StringComparison.OrdinalIgnoreCase);
      string pattern1 = b.Replace("\\", "\\\\").Replace(".", "\\").Replace("*", ".*");
      return Regex.IsMatch(value.ToString(), pattern1, RegexOptions.IgnoreCase);
    }

    private static object Tan(List<Expression> p)
    {
      return (object) Math.Tan((double) p[0]);
    }

    private static object Tanh(List<Expression> p)
    {
      return (object) Math.Tanh((double) p[0]);
    }

    private static object Trunc(List<Expression> p)
    {
      return (object) (double) (int) (double) p[0];
    }

    public static double DegreesToRadians(double degrees)
    {
      return Math.PI / 180.0 * degrees;
    }

    public static double RadiansToDegrees(double radians)
    {
      return 180.0 / Math.PI * radians;
    }

    public static double GradsToRadians(double grads)
    {
      return grads / 200.0 * Math.PI;
    }

    public static double RadiansToGrads(double radians)
    {
      return radians / Math.PI * 200.0;
    }

    public static double DegreesToGrads(double degrees)
    {
      return degrees / 9.0 * 10.0;
    }

    public static double GradsToDegrees(double grads)
    {
      return grads / 10.0 * 9.0;
    }

    public static double ASinh(double x)
    {
      return Math.Log(x + Math.Sqrt(x * x + 1.0));
    }

    private static object Acosh(List<Expression> p)
    {
      return (object) XLMath.ACosh((double) p[0]);
    }

    private static object Asinh(List<Expression> p)
    {
      return (object) XLMath.ASinh((double) p[0]);
    }

    private static object Atanh(List<Expression> p)
    {
      return (object) XLMath.ATanh((double) p[0]);
    }

    private static object Combin(List<Expression> p)
    {
      return (object) XLMath.Combin((int) (double) p[0], (int) (double) p[1]);
    }

    private static object Degrees(List<Expression> p)
    {
      return (object) ((double) p[0] * (180.0 / Math.PI));
    }

    private static object Fact(List<Expression> p)
    {
      double num1 = Math.Floor((double) p[0]);
      double num2 = 1.0;
      if (num1 > 1.0)
      {
        for (int index = 2; (double) index <= num1; ++index)
          num2 *= (double) index;
      }
      return (object) num2;
    }

    private static object FactDouble(List<Expression> p)
    {
      double num1 = Math.Floor((double) p[0]);
      double num2 = 1.0;
      if (num1 > 1.0)
      {
        int num3 = Math.Abs(num1 % 2.0) < 1E-10 ? 2 : 1;
        while ((double) num3 <= num1)
        {
          num2 *= (double) num3;
          num3 += 2;
        }
      }
      return (object) num2;
    }

    private static object Gcd(List<Expression> p)
    {
      return (object) p.Select<Expression, int>((Func<Expression, int>) (v => (int) (double) v)).Aggregate<int>(new Func<int, int, int>(MathTrig.Gcd));
    }

    private static int Gcd(int a, int b)
    {
      if (b != 0)
        return MathTrig.Gcd(b, a % b);
      return a;
    }

    private static object Lcm(List<Expression> p)
    {
      return (object) p.Select<Expression, int>((Func<Expression, int>) (v => (int) (double) v)).Aggregate<int>(new Func<int, int, int>(MathTrig.Lcm));
    }

    private static int Lcm(int a, int b)
    {
      if (a == 0 || b == 0)
        return 0;
      return a * (b / MathTrig.Gcd(a, b));
    }

    private static object Mod(List<Expression> p)
    {
      int num1 = (int) Math.Abs((double) p[0]);
      int num2 = (int) (double) p[1];
      int num3 = num1 % num2;
      return (object) (num2 < 0 ? num3 * -1 : num3);
    }

    private static object MRound(List<Expression> p)
    {
      Decimal num1 = (Decimal) (double) p[0];
      Decimal num2 = (Decimal) (double) p[1];
      Decimal num3 = num1 % num2;
      Decimal num4 = Math.Floor(num1 / num2);
      Decimal num5 = num2 / new Decimal(2);
      if (Math.Abs(num3 - num5) <= new Decimal(1, 0, 0, false, (byte) 10))
        return (object) (num2 * num4 + num2);
      return (object) (num2 * num4);
    }

    private static object Multinomial(List<Expression> p)
    {
      return (object) MathTrig.Multinomial(p.Select<Expression, double>((Func<Expression, double>) (v => (double) v)).ToList<double>());
    }

    private static double Multinomial(List<double> numbers)
    {
      double num1 = 0.0;
      foreach (double number in numbers)
        num1 += number;
      double num2 = numbers.Max();
      double[] numArray = new double[(IntPtr) ((uint) numbers.Max() + 1U)];
      foreach (double number in numbers)
      {
        for (int index = 2; (double) index <= number; ++index)
          ++numArray[index];
      }
      for (int index = 2; index < numArray.Length; ++index)
        --numArray[index];
      int index1 = 2;
      double num3 = 1.0;
      double num4 = 1.0;
      for (double num5 = num2 + 1.0; num5 <= num1; ++num5)
      {
        double num6 = 1.0;
        while (num6 < num4 && index1 < numArray.Length)
        {
          if (num3 > numArray[index1])
          {
            ++index1;
            num3 = 1.0;
          }
          else
          {
            num6 *= (double) index1;
            ++num3;
          }
        }
        num4 = num4 / num6 * num5;
      }
      return num4;
    }

    private static object Odd(List<Expression> p)
    {
      int num1 = (int) Math.Ceiling((double) p[0]);
      int num2 = num1 >= 0 ? 1 : -1;
      return (object) (XLMath.IsOdd(num1) ? num1 : num1 + num2);
    }

    private static object Even(List<Expression> p)
    {
      int num1 = (int) Math.Ceiling((double) p[0]);
      int num2 = num1 >= 0 ? 1 : -1;
      return (object) (XLMath.IsEven(num1) ? num1 : num1 + num2);
    }

    private static object Product(List<Expression> p)
    {
      if (p.Count == 0)
        return (object) 0;
      double total = 1.0;
      p.ForEach((Action<Expression>) (v => total *= (double) v));
      return (object) total;
    }

    private static object Quotient(List<Expression> p)
    {
      return (object) (int) ((double) p[0] / (double) p[1]);
    }

    private static object Radians(List<Expression> p)
    {
      return (object) ((double) p[0] * Math.PI / 180.0);
    }

    private static object Roman(List<Expression> p)
    {
      bool result1;
      int result2;
      if (p.Count == 1 || bool.TryParse(p[1]._token.Value.ToString(), out result1) && result1 || int.TryParse(p[1]._token.Value.ToString(), out result2) && result2 == 1)
        return (object) XLMath.ToRoman((int) (double) p[0]);
      throw new ArgumentException("Can only support classic roman types.");
    }

    private static object Round(List<Expression> p)
    {
      double num1 = (double) p[0];
      int digits = (int) (double) p[1];
      if (digits >= 0)
        return (object) Math.Round(num1, digits);
      int num2 = Math.Abs(digits);
      return (object) (Math.Round(num1 / Math.Pow(10.0, (double) num2), 0) * Math.Pow(10.0, (double) num2));
    }

    private static object RoundDown(List<Expression> p)
    {
      double num1 = (double) p[0];
      int num2 = (int) (double) p[1];
      if (num1 >= 0.0)
        return (object) (Math.Floor(num1 * Math.Pow(10.0, (double) num2)) / Math.Pow(10.0, (double) num2));
      return (object) (Math.Ceiling(num1 * Math.Pow(10.0, (double) num2)) / Math.Pow(10.0, (double) num2));
    }

    private static object RoundUp(List<Expression> p)
    {
      double num1 = (double) p[0];
      int num2 = (int) (double) p[1];
      if (num1 >= 0.0)
        return (object) (Math.Ceiling(num1 * Math.Pow(10.0, (double) num2)) / Math.Pow(10.0, (double) num2));
      return (object) (Math.Floor(num1 * Math.Pow(10.0, (double) num2)) / Math.Pow(10.0, (double) num2));
    }

    private static object SeriesSum(List<Expression> p)
    {
      double x = (double) p[0];
      double y = (double) p[1];
      double num1 = (double) p[2];
      XObjectExpression xobjectExpression = p[3] as XObjectExpression;
      if (xobjectExpression == null)
        return (object) ((double) p[3] * Math.Pow(x, y));
      double num2 = 0.0;
      int num3 = 0;
      foreach (object obj in xobjectExpression)
      {
        num2 += (double) obj * Math.Pow(x, y + (double) num3 * num1);
        ++num3;
      }
      return (object) num2;
    }

    private static object SqrtPi(List<Expression> p)
    {
      return (object) Math.Sqrt(Math.PI * (double) p[0]);
    }

    private static object Subtotal(List<Expression> p)
    {
      int num = (int) (double) p[0];
      Tally tally = new Tally(p.Skip<Expression>(1));
      switch (num)
      {
        case 1:
          return (object) tally.Average();
        case 2:
          return (object) tally.Count();
        case 3:
          return (object) tally.CountA();
        case 4:
          return (object) tally.Max();
        case 5:
          return (object) tally.Min();
        case 6:
          return (object) tally.Product();
        case 7:
          return (object) tally.Std();
        case 8:
          return (object) tally.StdP();
        case 9:
          return (object) tally.Sum();
        case 10:
          return (object) tally.Var();
        case 11:
          return (object) tally.VarP();
        default:
          throw new ArgumentException("Function not supported.");
      }
    }

    private static object SumSq(List<Expression> p)
    {
      return (object) new Tally((IEnumerable<Expression>) p).Numerics().Sum<double>((Func<double, double>) (v => Math.Pow(v, 2.0)));
    }

    private static object MMult(List<Expression> p)
    {
      double[,] array1 = MathTrig.GetArray(p[0]);
      double[,] array2 = MathTrig.GetArray(p[1]);
      if (array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
        throw new ArgumentException("Ranges must have the same number of rows and columns.");
      double[,] numArray = new double[array1.GetLength(0), array1.GetLength(1)];
      for (int index1 = 0; index1 < array1.GetLength(0); ++index1)
      {
        for (int index2 = 0; index2 < array2.GetLength(1); ++index2)
        {
          for (int index3 = 0; index3 < array1.GetLength(1); ++index3)
            numArray[index1, index2] += array1[index1, index3] * array2[index3, index2];
        }
      }
      return (object) numArray;
    }

    private static double[,] GetArray(Expression expression)
    {
      XObjectExpression xobjectExpression = expression as XObjectExpression;
      if (xobjectExpression == null)
        return new double[1, 1]{ { (double) expression } };
      IXLRange range = (xobjectExpression.Value as CellRangeReference).Range;
      int length1 = range.RowCount();
      int length2 = range.ColumnCount();
      double[,] numArray = new double[length1, length2];
      for (int index1 = 0; index1 < length1; ++index1)
      {
        for (int index2 = 0; index2 < length2; ++index2)
          numArray[index1, index2] = range.Cell(index1 + 1, index2 + 1).GetDouble();
      }
      return numArray;
    }

    private static object MDeterm(List<Expression> p)
    {
      return (object) new XLMatrix(MathTrig.GetArray(p[0])).Determinant();
    }

    private static object MInverse(List<Expression> p)
    {
      return (object) new XLMatrix(MathTrig.GetArray(p[0])).Invert().mat;
    }
  }
}
