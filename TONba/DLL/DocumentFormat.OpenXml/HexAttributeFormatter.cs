// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.HexAttributeFormatter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml
{
  internal class HexAttributeFormatter : AttributeFormatter
  {
    internal HexAttributeFormatter(int length)
      : base(length)
    {
    }

    internal override long StringToValue(string strValue)
    {
      long result = 0;
      try
      {
        long.TryParse(strValue, NumberStyles.HexNumber, (IFormatProvider) new CultureInfo("en-US"), out result);
      }
      catch
      {
      }
      return result;
    }

    internal override string ValueToString(long longValue)
    {
      return longValue.ToString("X4");
    }
  }
}
