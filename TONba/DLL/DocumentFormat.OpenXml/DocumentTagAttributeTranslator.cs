// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.DocumentTagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class DocumentTagAttributeTranslator : TagAttributeTranslator
  {
    private static string[] arrayOfOrigTagAttrNames = new string[1]
    {
      "conformance"
    };
    private static string[] arrayOfNewTagAttrNames = new string[1]
    {
      "conformance"
    };
    private static string[] arrayOfOrigTagAttrValues = new string[1]
    {
      "strict"
    };
    private static string[] arrayOfNewTagAttrValues = new string[1]
    {
      ""
    };
    private static long[] arrayOfTagAttrTraits = new long[1];

    internal DocumentTagAttributeTranslator()
    {
      this.arrayOfOrigAttrNames = DocumentTagAttributeTranslator.arrayOfOrigTagAttrNames;
      this.arrayOfNewAttrNames = DocumentTagAttributeTranslator.arrayOfNewTagAttrNames;
      this.arrayOfOrigAttrValues = DocumentTagAttributeTranslator.arrayOfOrigTagAttrValues;
      this.arrayOfNewAttrValues = DocumentTagAttributeTranslator.arrayOfNewTagAttrValues;
      this.arrayOfAttrTraits = DocumentTagAttributeTranslator.arrayOfTagAttrTraits;
      this.formatter = (AttributeFormatter) null;
    }

    protected override int SetIndex()
    {
      return this.GetIndexByValue();
    }
  }
}
