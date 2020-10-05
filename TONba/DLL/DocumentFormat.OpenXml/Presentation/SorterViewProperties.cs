// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SorterViewProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonViewProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class SorterViewProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "showFormatting"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "cViewPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "sorterViewPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12359;

    public override string LocalName
    {
      get
      {
        return "sorterViewPr";
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
        return 12359;
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
        return SorterViewProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SorterViewProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "showFormatting")]
    public BooleanValue ShowFormatting
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

    public SorterViewProperties()
    {
    }

    public SorterViewProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SorterViewProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SorterViewProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cViewPr" == name)
        return (OpenXmlElement) new CommonViewProperties();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SorterViewProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SorterViewProperties.eleNamespaceIds;
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

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "showFormatting" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SorterViewProperties>(deep);
    }
  }
}
