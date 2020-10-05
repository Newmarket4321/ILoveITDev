// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Shape))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RoundRectangle))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (ImageFile))]
  [ChildElementInfo(typeof (Line))]
  [ChildElementInfo(typeof (Oval))]
  [ChildElementInfo(typeof (PolyLine))]
  [ChildElementInfo(typeof (Rectangle))]
  [ChildElementInfo(typeof (OleObject))]
  [ChildElementInfo(typeof (ObjectLink))]
  [ChildElementInfo(typeof (Arc))]
  [ChildElementInfo(typeof (Curve))]
  [ChildElementInfo(typeof (Shapetype))]
  [ChildElementInfo(typeof (Drawing))]
  [ChildElementInfo(typeof (Control))]
  [ChildElementInfo(typeof (ObjectEmbed))]
  public class EmbeddedObject : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "dxaOrig",
      "dyaOrig",
      "anchorId"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 52
    };
    private const string tagName = "object";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11612;

    public override string LocalName
    {
      get
      {
        return "object";
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
        return 11612;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return EmbeddedObject.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EmbeddedObject.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "dxaOrig")]
    public StringValue DxaOriginal
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "dyaOrig")]
    public StringValue DyaOriginal
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "anchorId")]
    public HexBinaryValue AnchorId
    {
      get
      {
        return (HexBinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public EmbeddedObject()
    {
    }

    public EmbeddedObject(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EmbeddedObject(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EmbeddedObject(string outerXml)
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
      if (26 == (int) namespaceId && "arc" == name)
        return (OpenXmlElement) new Arc();
      if (26 == (int) namespaceId && "curve" == name)
        return (OpenXmlElement) new Curve();
      if (27 == (int) namespaceId && "OLEObject" == name)
        return (OpenXmlElement) new OleObject();
      if (23 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new Drawing();
      if (23 == (int) namespaceId && "control" == name)
        return (OpenXmlElement) new Control();
      if (23 == (int) namespaceId && "objectEmbed" == name)
        return (OpenXmlElement) new ObjectEmbed();
      if (23 == (int) namespaceId && "objectLink" == name)
        return (OpenXmlElement) new ObjectLink();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "dxaOrig" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "dyaOrig" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (52 == (int) namespaceId && "anchorId" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EmbeddedObject>(deep);
    }
  }
}
