// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.SpaceAfter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class SpaceAfter : TextSpacingType
  {
    private const string tagName = "spcAft";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10308;

    public override string LocalName
    {
      get
      {
        return "spcAft";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10308;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SpaceAfter()
    {
    }

    public SpaceAfter(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SpaceAfter(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SpaceAfter(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SpaceAfter>(deep);
    }
  }
}
