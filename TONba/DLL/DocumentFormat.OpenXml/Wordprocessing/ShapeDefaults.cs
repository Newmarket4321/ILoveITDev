// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class ShapeDefaults : ShapeDefaultsType
  {
    private const string tagName = "shapeDefaults";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12195;

    public override string LocalName
    {
      get
      {
        return "shapeDefaults";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12195;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ShapeDefaults()
    {
    }

    public ShapeDefaults(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShapeDefaults(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShapeDefaults(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapeDefaults>(deep);
    }
  }
}
