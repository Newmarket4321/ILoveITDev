// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.AttributeFormatter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal abstract class AttributeFormatter
  {
    protected int length;

    internal AttributeFormatter(int length)
    {
      this.length = length;
    }

    internal abstract long StringToValue(string strValue);

    internal abstract string ValueToString(long longValue);
  }
}
