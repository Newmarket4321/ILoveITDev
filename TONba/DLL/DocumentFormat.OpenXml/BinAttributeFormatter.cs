// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.BinAttributeFormatter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Text;

namespace DocumentFormat.OpenXml
{
  internal class BinAttributeFormatter : AttributeFormatter
  {
    internal BinAttributeFormatter(int length)
      : base(length)
    {
    }

    internal override long StringToValue(string strValue)
    {
      long num1 = 0;
      int length = strValue.Length;
      for (int index = 0; index < length; ++index)
      {
        long num2 = (int) strValue[index] != 49 ? ((int) strValue[index] != 48 ? 0L : 0L) : 1L;
        num1 = num2 == 0L ? num1 & ~(num2 << length - 1 - index) : num1 | num2 << length - 1 - index;
      }
      return num1;
    }

    internal override string ValueToString(long longValue)
    {
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = this.length - 1; index >= 0; --index)
        stringBuilder.Append((longValue & (long) (1 << index)) > 0L ? '1' : '0');
      return stringBuilder.ToString();
    }
  }
}
