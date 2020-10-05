// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.UserShapes
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (RelativeAnchorSize))]
  [ChildElementInfo(typeof (AbsoluteAnchorSize))]
  [GeneratedCode("DomGen", "2.0")]
  public class UserShapes : OpenXmlPartRootElement
  {
    private const string tagName = "userShapes";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10393;

    public override string LocalName
    {
      get
      {
        return "userShapes";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10393;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal UserShapes(ChartDrawingPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ChartDrawingPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ChartDrawingPart ChartDrawingPart
    {
      get
      {
        return this.OpenXmlPart as ChartDrawingPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public UserShapes(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public UserShapes(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public UserShapes(string outerXml)
      : base(outerXml)
    {
    }

    public UserShapes()
    {
    }

    public void Save(ChartDrawingPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (12 == (int) namespaceId && "relSizeAnchor" == name)
        return (OpenXmlElement) new RelativeAnchorSize();
      if (12 == (int) namespaceId && "absSizeAnchor" == name)
        return (OpenXmlElement) new AbsoluteAnchorSize();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<UserShapes>(deep);
    }
  }
}
