// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ImageFile))]
  [ChildElementInfo(typeof (Oval))]
  [ChildElementInfo(typeof (PolyLine))]
  [ChildElementInfo(typeof (Rectangle))]
  [ChildElementInfo(typeof (Shapetype))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (Line))]
  [ChildElementInfo(typeof (RoundRectangle))]
  public class PictureBulletBase : OpenXmlCompositeElement
  {
    private const string tagName = "pict";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12209;

    public override string LocalName
    {
      get
      {
        return "pict";
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
        return 12209;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PictureBulletBase()
    {
    }

    public PictureBulletBase(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PictureBulletBase(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PictureBulletBase(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new Group();
      if (26 == (int) namespaceId && "image" == name)
        return (OpenXmlElement) new ImageFile();
      if (26 == (int) namespaceId && "line" == name)
        return (OpenXmlElement) new Line();
      if (26 == (int) namespaceId && "oval" == name)
        return (OpenXmlElement) new Oval();
      if (26 == (int) namespaceId && "polyline" == name)
        return (OpenXmlElement) new PolyLine();
      if (26 == (int) namespaceId && "rect" == name)
        return (OpenXmlElement) new Rectangle();
      if (26 == (int) namespaceId && "roundrect" == name)
        return (OpenXmlElement) new RoundRectangle();
      if (26 == (int) namespaceId && "shape" == name)
        return (OpenXmlElement) new Shape();
      if (26 == (int) namespaceId && "shapetype" == name)
        return (OpenXmlElement) new Shapetype();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PictureBulletBase>(deep);
    }
  }
}
