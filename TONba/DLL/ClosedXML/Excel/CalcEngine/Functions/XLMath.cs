// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Functions.XLMath
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel.CalcEngine.Functions
{
  public static class XLMath
  {
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

    public static double ACosh(double x)
    {
      return Math.Log(x + Math.Sqrt(x * x - 1.0));
    }

    public static double ATanh(double x)
    {
      return Math.Log((1.0 + x) / (1.0 - x)) / 2.0;
    }

    public static double ACoth(double x)
    {
      return XLMath.ATanh(1.0 / x);
    }

    public static double ASech(double x)
    {
      return XLMath.ACosh(1.0 / x);
    }

    public static double ACsch(double x)
    {
      return XLMath.ASinh(1.0 / x);
    }

    public static double Sech(double x)
    {
      return 1.0 / Math.Cosh(x);
    }

    public static double Csch(double x)
    {
      return 1.0 / Math.Sinh(x);
    }

    public static double Coth(double x)
    {
      return Math.Cosh(x) / Math.Sinh(x);
    }

    public static double Combin(int n, int k)
    {
      if (k == 0)
        return 1.0;
      return (double) n * XLMath.Combin(n - 1, k - 1) / (double) k;
    }

    public static bool IsEven(int value)
    {
      return (double) Math.Abs(value % 2) < 1E-10;
    }

    public static bool IsOdd(int value)
    {
      return (double) Math.Abs(value % 2) > 1E-10;
    }

    public static string ToRoman(int number)
    {
      if (number < 0 || number > 3999)
        throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
      if (number < 1)
        return string.Empty;
      if (number >= 1000)
        return "M" + XLMath.ToRoman(number - 1000);
      if (number >= 900)
        return "CM" + XLMath.ToRoman(number - 900);
      if (number >= 500)
        return "D" + XLMath.ToRoman(number - 500);
      if (number >= 400)
        return "CD" + XLMath.ToRoman(number - 400);
      if (number >= 100)
        return "C" + XLMath.ToRoman(number - 100);
      if (number >= 90)
        return "XC" + XLMath.ToRoman(number - 90);
      if (number >= 50)
        return "L" + XLMath.ToRoman(number - 50);
      if (number >= 40)
        return "XL" + XLMath.ToRoman(number - 40);
      if (number >= 10)
        return "X" + XLMath.ToRoman(number - 10);
      if (number >= 9)
        return "IX" + XLMath.ToRoman(number - 9);
      if (number >= 5)
        return "V" + XLMath.ToRoman(number - 5);
      if (number >= 4)
        return "IV" + XLMath.ToRoman(number - 4);
      if (number >= 1)
        return "I" + XLMath.ToRoman(number - 1);
      throw new ArgumentOutOfRangeException("something bad happened");
    }
  }
}
