// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualConnectionShapeProperties))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (ShapeStyle))]
  public class ConnectionShape : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "macro",
      "fPublished"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "nvCxnSpPr",
      "spPr",
      "style"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 18,
      (byte) 18,
      (byte) 18
    };
    private const string tagName = "cxnSp";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10792;

    public override string LocalName
    {
      get
      {
        return "cxnSp";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10792;
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
        return ConnectionShape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ConnectionShape.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "macro")]
    public StringValue Macro
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

    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public ConnectionShape()
    {
    }

    public ConnectionShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ConnectionShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ConnectionShape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "nvCxnSpPr" == name)
        return (OpenXmlElement) new NonVisualConnectionShapeProperties();
      if (18 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (18 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new ShapeStyle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ConnectionShape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ConnectionShape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualConnectionShapeProperties NonVisualConnectionShapeProperties
    {
      get
      {
        return this.GetElement<NonVisualConnectionShapeProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualConnectionShapeProperties>(0, value);
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

    public ShapeStyle ShapeStyle
    {
      get
      {
        return this.GetElement<ShapeStyle>(2);
      }
      set
      {
        this.SetElement<ShapeStyle>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "macro" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fPublished" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConnectionShape>(deep);
    }
  }
}
