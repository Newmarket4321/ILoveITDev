﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class InSketchMode : BooleanFalseType
  {
    private const string tagName = "inSketchMode";
    private const byte tagNsId = 46;
    internal const int ElementTypeIdConst = 12772;

    public override string LocalName
    {
      get
      {
        return "inSketchMode";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 46;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12772;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<InSketchMode>(deep);
    }
  }
}
