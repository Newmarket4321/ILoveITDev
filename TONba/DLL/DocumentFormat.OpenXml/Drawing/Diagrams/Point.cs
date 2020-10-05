// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.Point
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (PtExtensionList))]
  [ChildElementInfo(typeof (PropertySet))]
  [ChildElementInfo(typeof (TextBody))]
  [GeneratedCode("DomGen", "2.0")]
  public class Point : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "modelId",
      "type",
      "cxnId"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[4]
    {
      "prSet",
      "spPr",
      "t",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14
    };
    private const string tagName = "pt";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10705;

    public override string LocalName
    {
      get
      {
        return "pt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10705;
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
        return Point.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Point.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "modelId")]
    public StringValue ModelId
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

    [SchemaAttr(0, "type")]
    public EnumValue<PointValues> Type
    {
      get
      {
        return (EnumValue<PointValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cxnId")]
    public StringValue ConnectionId
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Point()
    {
    }

    public Point(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Point(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Point(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "prSet" == name)
        return (OpenXmlElement) new PropertySet();
      if (14 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (14 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new TextBody();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Point.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Point.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PropertySet PropertySet
    {
      get
      {
        return this.GetElement<PropertySet>(0);
      }
      set
      {
        this.SetElement<PropertySet>(0, value);
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(1);
      }
      set
      {
        this.SetElement<ShapeProperties>(1, value);
      }
    }

    public TextBody TextBody
    {
      get
      {
        return this.GetElement<TextBody>(2);
      }
      set
      {
        this.SetElement<TextBody>(2, value);
      }
    }

    public PtExtensionList PtExtensionList
    {
      get
      {
        return this.GetElement<PtExtensionList>(3);
      }
      set
      {
        this.SetElement<PtExtensionList>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "modelId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<PointValues>();
      if ((int) namespaceId == 0 && "cxnId" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Point>(deep);
    }
  }
}
