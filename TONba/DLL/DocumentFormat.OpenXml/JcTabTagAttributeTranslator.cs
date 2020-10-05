// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.JcTabTagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class JcTabTagAttributeTranslator : TagAttributeTranslator
  {
    private static string[] arrayOfOrigTagAttrNames = new string[2]
    {
      "val",
      "val"
    };
    private static string[] arrayOfNewTagAttrNames = new string[2]
    {
      "val",
      "val"
    };
    private static string[] arrayOfOrigTagAttrValues = new string[2]
    {
      "start",
      "end"
    };
    private static string[] arrayOfNewTagAttrValues = new string[2]
    {
      "left",
      "right"
    };
    private static long[] arrayOfTagAttrTraits = new long[2];

    internal JcTabTagAttributeTranslator()
    {
      this.arrayOfOrigAttrNames = JcTabTagAttributeTranslator.arrayOfOrigTagAttrNames;
      this.arrayOfNewAttrNames = JcTabTagAttributeTranslator.arrayOfNewTagAttrNames;
      this.arrayOfOrigAttrValues = JcTabTagAttributeTranslator.arrayOfOrigTagAttrValues;
      this.arrayOfNewAttrValues = JcTabTagAttributeTranslator.arrayOfNewTagAttrValues;
      this.arrayOfAttrTraits = JcTabTagAttributeTranslator.arrayOfTagAttrTraits;
      this.formatter = (AttributeFormatter) null;
    }

    protected override int SetIndex()
    {
      return this.GetIndexByValue();
    }
  }
}
