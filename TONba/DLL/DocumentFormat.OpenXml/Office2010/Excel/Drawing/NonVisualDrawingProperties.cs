// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.Drawing.NonVisualDrawingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HyperlinkOnHover))]
  [ChildElementInfo(typeof (NonVisualDrawingPropertiesExtensionList))]
  [ChildElementInfo(typeof (HyperlinkOnClick))]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class NonVisualDrawingProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "id",
      "name",
      "descr",
      "hidden",
      "title"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[3]
    {
      "hlinkClick",
      "hlinkHover",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cNvPr";
    private const byte tagNsId = 54;
    internal const int ElementTypeIdConst = 13077;

    public override string LocalName
    {
      get
      {
        return "cNvPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 54;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13077;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return NonVisualDrawingProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NonVisualDrawingProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "descr")]
    public StringValue Description
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

    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
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

    [SchemaAttr(0, "title")]
    public StringValue Title
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public NonVisualDrawingProperties()
    {
    }

    public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualDrawingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualDrawingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "hlinkClick" == name)
        return (OpenXmlElement) new HyperlinkOnClick();
      if (10 == (int) namespaceId && "hlinkHover" == name)
        return (OpenXmlElement) new HyperlinkOnHover();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new NonVisualDrawingPropertiesExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualDrawingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualDrawingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public HyperlinkOnClick HyperlinkOnClick
    {
      get
      {
        return this.GetElement<HyperlinkOnClick>(0);
      }
      set
      {
        this.SetElement<HyperlinkOnClick>(0, value);
      }
    }

    public HyperlinkOnHover HyperlinkOnHover
    {
      get
      {
        return this.GetElement<HyperlinkOnHover>(1);
      }
      set
      {
        this.SetElement<HyperlinkOnHover>(1, value);
      }
    }

    public NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
    {
      get
      {
        return this.GetElement<NonVisualDrawingPropertiesExtensionList>(2);
      }
      set
      {
        this.SetElement<NonVisualDrawingPropertiesExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "descr" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualDrawingProperties>(deep);
    }
  }
}
