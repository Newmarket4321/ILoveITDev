// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.StylePaneSortMethodTagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class StylePaneSortMethodTagAttributeTranslator : TagAttributeTranslator
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
      "name",
      "priority",
      "default",
      "font",
      "basedOn",
      "type"
    };
    private static string[] arrayOfNewTagAttrValues = new string[6]
    {
      "0000",
      "0001",
      "0002",
      "0003",
      "0004",
      "0005"
    };
    private static long[] arrayOfTagAttrTraits = new long[6];

    internal StylePaneSortMethodTagAttributeTranslator()
    {
      this.arrayOfOrigAttrNames = StylePaneSortMethodTagAttributeTranslator.arrayOfOrigTagAttrNames;
      this.arrayOfNewAttrNames = StylePaneSortMethodTagAttributeTranslator.arrayOfNewTagAttrNames;
      this.arrayOfOrigAttrValues = StylePaneSortMethodTagAttributeTranslator.arrayOfOrigTagAttrValues;
      this.arrayOfNewAttrValues = StylePaneSortMethodTagAttributeTranslator.arrayOfNewTagAttrValues;
      this.arrayOfAttrTraits = StylePaneSortMethodTagAttributeTranslator.arrayOfTagAttrTraits;
      this.formatter = (AttributeFormatter) null;
    }

    protected override int SetIndex()
    {
      return this.GetIndexByValue();
    }
  }
}
