// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Transform2D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExcelNonVisualContentPartShapeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ApplicationNonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class ContentPart : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "bwMode"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 19,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[4]
    {
      "nvContentPartPr",
      "nvPr",
      "xfrm",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 54,
      (byte) 54,
      (byte) 54,
      (byte) 54
    };
    private const string tagName = "contentPart";
    private const byte tagNsId = 54;
    internal const int ElementTypeIdConst = 13076;

    public override string LocalName
    {
      get
      {
        return "contentPart";
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
        return 13076;
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
        return ContentPart.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContentPart.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
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

    [SchemaAttr(0, "bwMode")]
    public EnumValue<BlackWhiteModeValues> BlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public ContentPart()
    {
    }

    public ContentPart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ContentPart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ContentPart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (54 == (int) namespaceId && "nvContentPartPr" == name)
        return (OpenXmlElement) new ExcelNonVisualContentPartShapeProperties();
      if (54 == (int) namespaceId && "nvPr" == name)
        return (OpenXmlElement) new ApplicationNonVisualDrawingProperties();
      if (54 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new Transform2D();
      if (54 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ContentPart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ContentPart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExcelNonVisualContentPartShapeProperties ExcelNonVisualContentPartShapeProperties
    {
      get
      {
        return this.GetElement<ExcelNonVisualContentPartShapeProperties>(0);
      }
      set
      {
        this.SetElement<ExcelNonVisualContentPartShapeProperties>(0, value);
      }
    }

    public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
    {
      get
      {
        return this.GetElement<ApplicationNonVisualDrawingProperties>(1);
      }
      set
      {
        this.SetElement<ApplicationNonVisualDrawingProperties>(1, value);
      }
    }

    public Transform2D Transform2D
    {
      get
      {
        return this.GetElement<Transform2D>(2);
      }
      set
      {
        this.SetElement<Transform2D>(2, value);
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(3);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "bwMode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ContentPart>(deep);
    }
  }
}
