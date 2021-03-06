﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CnfStyleTagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class CnfStyleTagAttributeTranslator : TagAttributeTranslator
  {
    private static string[] arrayOfOrigTagAttrNames = new string[12]
    {
      "firstRow",
      "lastRow",
      "firstColumn",
      "lastColumn",
      "oddVBand",
      "evenVBand",
      "oddHBand",
      "evenHBand",
      "firstRowLastColumn",
      "firstRowFirstColumn",
      "lastRowFirstColumn",
      "lastRowLastColumn"
    };
    private static string[] arrayOfNewTagAttrNames = new string[12]
    {
      "val",
      "val",
      "val",
      "val",
      "val",
      "val",
      "val",
      "val",
      "val",
      "val",
      "val",
      "val"
    };
    private static long[] arrayOfTagAttrTraits = new long[12]
    {
      2048L,
      1024L,
      512L,
      256L,
      128L,
      64L,
      32L,
      16L,
      8L,
      4L,
      2L,
      1L
    };

    internal CnfStyleTagAttributeTranslator()
    {
      this.arrayOfNewAttrNames = CnfStyleTagAttributeTranslator.arrayOfNewTagAttrNames;
      this.arrayOfOrigAttrNames = CnfStyleTagAttributeTranslator.arrayOfOrigTagAttrNames;
      this.arrayOfOrigAttrValues = (string[]) null;
      this.arrayOfNewAttrValues = (string[]) null;
      this.arrayOfAttrTraits = CnfStyleTagAttributeTranslator.arrayOfTagAttrTraits;
      this.formatter = (AttributeFormatter) new BinAttributeFormatter(CnfStyleTagAttributeTranslator.arrayOfTagAttrTraits.Length);
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
