﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
  [GeneratedCode("DomGen", "2.0")]
  public class MultimediaClips : OpenXmlLeafTextElement
  {
    private const string tagName = "MMClips";
    private const byte tagNsId = 3;
    internal const int ElementTypeIdConst = 11078;

    public override string LocalName
    {
      get
      {
        return "MMClips";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 3;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11078;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MultimediaClips()
    {
    }

    public MultimediaClips(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      Int32Value int32Value = new Int32Value();
      int32Value.InnerText = text;
      return (OpenXmlSimpleType) int32Value;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MultimediaClips>(deep);
    }
  }
}
