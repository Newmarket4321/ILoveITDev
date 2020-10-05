// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Tally
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel.CalcEngine
{
  internal class Tally : IEnumerable<object>, IEnumerable
  {
    private readonly List<object> _list = new List<object>();

    public Tally()
    {
    }

    public Tally(IEnumerable<Expression> p)
    {
      foreach (Expression e in p)
        this.Add(e);
    }

    public void Add(Expression e)
    {
      IEnumerable enumerable1 = e as IEnumerable;
      if (enumerable1 != null)
      {
        foreach (object obj in enumerable1)
          this._list.Add(obj);
      }
      else
      {
        object obj1 = e.Evaluate();
        IEnumerable enumerable2 = obj1 as IEnumerable;
        if (enumerable2 == null || obj1 is string)
        {
          this._list.Add(obj1);
        }
        else
        {
          foreach (object obj2 in enumerable2)
            this._list.Add(obj2);
        }
      }
    }

    public void AddValue(object v)
    {
      this._list.Add(v);
    }

    public double Count()
    {
      return (double) this._list.Count;
    }

    public double CountA()
    {
      double num = 0.0;
      foreach (object obj in this._list)
      {
        IEnumerable enumerable = obj as IEnumerable;
        if (enumerable == null)
        {
          num += Tally.AddCount(obj);
        }
        else
        {
          IEnumerator enumerator = enumerable.GetEnumerator();
          try
          {
            if (enumerator.MoveNext())
            {
              object current = enumerator.Current;
              num += Tally.AddCount(current);
            }
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
        }
      }
      return num;
    }

    private static double AddCount(object value)
    {
      string str = value as string;
      return value != null && (str == null || !XLHelper.IsNullOrWhiteSpace(str)) ? 1.0 : 0.0;
    }

    public List<double> Numerics()
    {
      List<double> retVal = new List<double>();
      foreach (object obj in this._list)
      {
        IEnumerable enumerable = obj as IEnumerable;
        if (enumerable == null)
        {
          Tally.AddNumericValue(obj, retVal);
        }
        else
        {
          IEnumerator enumerator = enumerable.GetEnumerator();
          try
          {
            if (enumerator.MoveNext())
              Tally.AddNumericValue(enumerator.Current, retVal);
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
        }
      }
      return retVal;
    }

    private static void AddNumericValue(object value, List<double> retVal)
    {
      double result;
      if (!double.TryParse(value.ToString(), out result))
        return;
      retVal.Add(result);
    }

    public double Product()
    {
      List<double> doubleList = this.Numerics();
      if (doubleList.Count == 0)
        return 0.0;
      double retVal = 1.0;
      doubleList.ForEach((Action<double>) (n => retVal *= n));
      return retVal;
    }

    public double Sum()
    {
      return this.Numerics().Sum();
    }

    public double Average()
    {
      if (this.Numerics().Count != 0)
        return this.Numerics().Average();
      return 0.0;
    }

    public double Min()
    {
      if (this.Numerics().Count != 0)
        return this.Numerics().Min();
      return 0.0;
    }

    public double Max()
    {
      if (this.Numerics().Count != 0)
        return this.Numerics().Max();
      return 0.0;
    }

    public double Range()
    {
      List<double> source = this.Numerics();
      return source.Max() - source.Min();
    }

    private double Sum2(List<double> nums)
    {
      return nums.Sum<double>((Func<double, double>) (d => d * d));
    }

    public double VarP()
    {
      List<double> source = this.Numerics();
      double num1 = source.Average();
      double num2 = source.Sum<double>((Func<double, double>) (d => d * d));
      if (source.Count > 1)
        return num2 / (double) source.Count - num1 * num1;
      return 0.0;
    }

    public double StdP()
    {
      List<double> source = this.Numerics();
      double num1 = source.Average();
      double num2 = source.Sum<double>((Func<double, double>) (d => d * d));
      if (source.Count > 1)
        return Math.Sqrt(num2 / (double) source.Count - num1 * num1);
      return 0.0;
    }

    public double Var()
    {
      List<double> source = this.Numerics();
      double num1 = source.Average();
      double num2 = source.Sum<double>((Func<double, double>) (d => d * d));
      if (source.Count > 1)
        return (num2 / (double) source.Count - num1 * num1) * (double) source.Count / (double) (source.Count - 1);
      return 0.0;
    }

    public double Std()
    {
      List<double> source = this.Numerics();
      double num = 0.0;
      if (source.Count > 0)
      {
        double avg = source.Average();
        num = Math.Sqrt(source.Sum<double>((Func<double, double>) (d => Math.Pow(d - avg, 2.0))) / (double) (source.Count<double>() - 1));
      }
      return num;
    }

    public IEnumerator<object> GetEnumerator()
    {
      return (IEnumerator<object>) this._list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}
