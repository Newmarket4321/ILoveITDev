﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Spreadsheet.DropStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class DropStyle : OpenXmlLeafTextElement
  {
    private const string tagName = "DropStyle";
    private const byte tagNsId = 29;
    internal const int ElementTypeIdConst = 12547;

    public override string LocalName
    {
      get
      {
        return nameof (DropStyle);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 29;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12547;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DropStyle()
    {
    }

    public DropStyle(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DropStyle>(deep);
    }
  }
}