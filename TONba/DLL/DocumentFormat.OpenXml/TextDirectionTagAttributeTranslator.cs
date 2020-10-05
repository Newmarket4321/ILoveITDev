// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.TextDirectionTagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class TextDirectionTagAttributeTranslator : TagAttributeTranslator
  {
    private static string[] arrayOfOrigTagAttrNames = new string[6]
    {
      "val",
      "val",
      "val",
      "val",
      "val",
      "val"
    };
    private static string[] arrayOfNewTagAttrNames = new string[6]
    {
      "val",
      "val",
      "val",
      "val",
      "val",
      "val"
    };
    private static string[] arrayOfOrigTagAttrValues = new string[6]
    {
      "lr",
      "tb",
      "tbV",
      "lrV",
      "rl",
      "rlV"
    };
    private static string[] arrayOfNewTagAttrValues = new string[6]
    {
      "btLr",
      "lrTb",
      "lrTbV",
      "tbLrV",
      "tbRl",
      "tbRlV"
    };
    private static long[] arrayOfTagAttrTraits = new long[6];

    internal TextDirectionTagAttributeTranslator()
    {
      this.arrayOfOrigAttrNames = TextDirectionTagAttributeTranslator.arrayOfOrigTagAttrNames;
      this.arrayOfNewAttrNames = TextDirectionTagAttributeTranslator.arrayOfNewTagAttrNames;
      this.arrayOfOrigAttrValues = TextDirectionTagAttributeTranslator.arrayOfOrigTagAttrValues;
      this.arrayOfNewAttrValues = TextDirectionTagAttributeTranslator.arrayOfNewTagAttrValues;
      this.arrayOfAttrTraits = TextDirectionTagAttributeTranslator.arrayOfTagAttrTraits;
      this.formatter = (AttributeFormatter) null;
    }

    protected override int SetIndex()
    {
      return this.GetIndexByValue();
    }
  }
}
