// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommonSlideViewProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonViewProperties))]
  [ChildElementInfo(typeof (GuideList))]
  [GeneratedCode("DomGen", "2.0")]
  public class CommonSlideViewProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "snapToGrid",
      "snapToObjects",
      "showGuides"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[2]
    {
      "cViewPr",
      "guideLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cSldViewPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12354;

    public override string LocalName
    {
      get
      {
        return "cSldViewPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12354;
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
        return CommonSlideViewProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommonSlideViewProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "snapToGrid")]
    public BooleanValue SnapToGrid
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "snapToObjects")]
    public BooleanValue SnapToObjects
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

    [SchemaAttr(0, "showGuides")]
    public BooleanValue ShowGuides
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

    public CommonSlideViewProperties()
    {
    }

    public CommonSlideViewProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommonSlideViewProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommonSlideViewProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cViewPr" == name)
        return (OpenXmlElement) new CommonViewProperties();
      if (24 == (int) namespaceId && "guideLst" == name)
        return (OpenXmlElement) new GuideList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CommonSlideViewProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CommonSlideViewProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonViewProperties CommonViewProperties
    {
      get
      {
        return this.GetElement<CommonViewProperties>(0);
      }
      set
      {
        this.SetElement<CommonViewProperties>(0, value);
      }
    }

    public GuideList GuideList
    {
      get
      {
        return this.GetElement<GuideList>(1);
      }
      set
      {
        this.SetElement<GuideList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "snapToGrid" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "snapToObjects" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showGuides" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommonSlideViewProperties>(deep);
    }
  }
}
