// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (ShapeStyle))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualShapeProperties))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (TextBody))]
  public class Shape : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "macro",
      "textlink",
      "fLocksText",
      "fPublished"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[4]
    {
      "nvSpPr",
      "spPr",
      "style",
      "txBody"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18
    };
    private const string tagName = "sp";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10789;

    public override string LocalName
    {
      get
      {
        return "sp";
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
        return 10789;
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
        return Shape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Shape.attributeNamespaceIds;
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

    [SchemaAttr(0, "textlink")]
    public StringValue TextLink
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

    [SchemaAttr(0, "fLocksText")]
    public BooleanValue LockText
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
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

    public Shape()
    {
    }

    public Shape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Shape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Shape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "nvSpPr" == name)
        return (OpenXmlElement) new NonVisualShapeProperties();
      if (18 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (18 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new ShapeStyle();
      if (18 == (int) namespaceId && "txBody" == name)
        return (OpenXmlElement) new TextBody();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Shape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Shape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualShapeProperties NonVisualShapeProperties
    {
      get
      {
        return this.GetElement<NonVisualShapeProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualShapeProperties>(0, value);
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

    public TextBody TextBody
    {
      get
      {
        return this.GetElement<TextBody>(3);
      }
      set
      {
        this.SetElement<TextBody>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "macro" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "textlink" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fLocksText" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fPublished" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shape>(deep);
    }
  }
}
