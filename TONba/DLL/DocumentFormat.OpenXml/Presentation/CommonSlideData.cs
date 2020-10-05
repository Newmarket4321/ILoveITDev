// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommonSlideData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Background))]
  [ChildElementInfo(typeof (ControlList))]
  [ChildElementInfo(typeof (ShapeTree))]
  [ChildElementInfo(typeof (CustomerDataList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonSlideDataExtensionList))]
  public class CommonSlideData : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[5]
    {
      "bg",
      "spTree",
      "custDataLst",
      "controls",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cSld";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12343;

    public override string LocalName
    {
      get
      {
        return "cSld";
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
        return 12343;
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
        return CommonSlideData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommonSlideData.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    public CommonSlideData()
    {
    }

    public CommonSlideData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommonSlideData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommonSlideData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "bg" == name)
        return (OpenXmlElement) new Background();
      if (24 == (int) namespaceId && "spTree" == name)
        return (OpenXmlElement) new ShapeTree();
      if (24 == (int) namespaceId && "custDataLst" == name)
        return (OpenXmlElement) new CustomerDataList();
      if (24 == (int) namespaceId && "controls" == name)
        return (OpenXmlElement) new ControlList();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new CommonSlideDataExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CommonSlideData.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CommonSlideData.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Background Background
    {
      get
      {
        return this.GetElement<Background>(0);
      }
      set
      {
        this.SetElement<Background>(0, value);
      }
    }

    public ShapeTree ShapeTree
    {
      get
      {
        return this.GetElement<ShapeTree>(1);
      }
      set
      {
        this.SetElement<ShapeTree>(1, value);
      }
    }

    public CustomerDataList CustomerDataList
    {
      get
      {
        return this.GetElement<CustomerDataList>(2);
      }
      set
      {
        this.SetElement<CustomerDataList>(2, value);
      }
    }

    public ControlList ControlList
    {
      get
      {
        return this.GetElement<ControlList>(3);
      }
      set
      {
        this.SetElement<ControlList>(3, value);
      }
    }

    public CommonSlideDataExtensionList CommonSlideDataExtensionList
    {
      get
      {
        return this.GetElement<CommonSlideDataExtensionList>(4);
      }
      set
      {
        this.SetElement<CommonSlideDataExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommonSlideData>(deep);
    }
  }
}
