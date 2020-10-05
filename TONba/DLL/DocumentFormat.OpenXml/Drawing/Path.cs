// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Path
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (CloseShapePath))]
  [ChildElementInfo(typeof (QuadraticBezierCurveTo))]
  [ChildElementInfo(typeof (LineTo))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CubicBezierCurveTo))]
  [ChildElementInfo(typeof (ArcTo))]
  [ChildElementInfo(typeof (MoveTo))]
  public class Path : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "w",
      "h",
      "fill",
      "stroke",
      "extrusionOk"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private const string tagName = "path";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10225;

    public override string LocalName
    {
      get
      {
        return "path";
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
        return 10225;
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
        return Path.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Path.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "w")]
    public Int64Value Width
    {
      get
      {
        return (Int64Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "h")]
    public Int64Value Height
    {
      get
      {
        return (Int64Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fill")]
    public EnumValue<PathFillModeValues> Fill
    {
      get
      {
        return (EnumValue<PathFillModeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stroke")]
    public BooleanValue Stroke
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "extrusionOk")]
    public BooleanValue ExtrusionOk
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public Path()
    {
    }

    public Path(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Path(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Path(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "close" == name)
        return (OpenXmlElement) new CloseShapePath();
      if (10 == (int) namespaceId && "moveTo" == name)
        return (OpenXmlElement) new MoveTo();
      if (10 == (int) namespaceId && "lnTo" == name)
        return (OpenXmlElement) new LineTo();
      if (10 == (int) namespaceId && "arcTo" == name)
        return (OpenXmlElement) new ArcTo();
      if (10 == (int) namespaceId && "quadBezTo" == name)
        return (OpenXmlElement) new QuadraticBezierCurveTo();
      if (10 == (int) namespaceId && "cubicBezTo" == name)
        return (OpenXmlElement) new CubicBezierCurveTo();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "w" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "h" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "fill" == name)
        return (OpenXmlSimpleType) new EnumValue<PathFillModeValues>();
      if ((int) namespaceId == 0 && "stroke" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "extrusionOk" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Path>(deep);
    }
  }
}
