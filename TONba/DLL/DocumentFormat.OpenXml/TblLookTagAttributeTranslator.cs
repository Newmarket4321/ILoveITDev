// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.TblLookTagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class TblLookTagAttributeTranslator : TagAttributeTranslator
  {
    private static string[] arrayOfOrigTagAttrNames = new string[6]
    {
      "firstRow",
      "lastRow",
      "firstColumn",
      "lastColumn",
      "noHBand",
      "noVBand"
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
    private static long[] arrayOfTagAttrTraits = new long[6]
    {
      32L,
      64L,
      128L,
      256L,
      512L,
      1024L
    };

    internal TblLookTagAttributeTranslator()
    {
      this.arrayOfOrigAttrNames = TblLookTagAttributeTranslator.arrayOfOrigTagAttrNames;
      this.arrayOfNewAttrNames = TblLookTagAttributeTranslator.arrayOfNewTagAttrNames;
      this.arrayOfOrigAttrValues = (string[]) null;
      this.arrayOfNewAttrValues = (string[]) null;
      this.arrayOfAttrTraits = TblLookTagAttributeTranslator.arrayOfTagAttrTraits;
      this.formatter = (AttributeFormatter) new HexAttributeFormatter(TblLookTagAttributeTranslator.arrayOfTagAttrTraits.Length);
    }

    protected override int SetIndex()
    {
      return this.GetIndexByAttributeName();
    }

    internal override string Value
    {
      get
      {
        return this.strAttrValue;
      }
    }
  }
}
