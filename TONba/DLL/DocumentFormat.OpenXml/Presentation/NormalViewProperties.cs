// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.NormalViewProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (RestoredLeft))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RestoredTop))]
  public class NormalViewProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "showOutlineIcons",
      "snapVertSplitter",
      "vertBarState",
      "horzBarState",
      "preferSingleView"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[3]
    {
      "restoredLeft",
      "restoredTop",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "normalViewPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12355;

    public override string LocalName
    {
      get
      {
        return "normalViewPr";
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
        return 12355;
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
        return NormalViewProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NormalViewProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "showOutlineIcons")]
    public BooleanValue ShowOutlineIcons
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

    [SchemaAttr(0, "snapVertSplitter")]
    public BooleanValue SnapVerticalSplitter
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

    [SchemaAttr(0, "vertBarState")]
    public EnumValue<SplitterBarStateValues> VerticalBarState
    {
      get
      {
        return (EnumValue<SplitterBarStateValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "horzBarState")]
    public EnumValue<SplitterBarStateValues> HorizontalBarState
    {
      get
      {
        return (EnumValue<SplitterBarStateValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "preferSingleView")]
    public BooleanValue PreferSingleView
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

    public NormalViewProperties()
    {
    }

    public NormalViewProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NormalViewProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NormalViewProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "restoredLeft" == name)
        return (OpenXmlElement) new RestoredLeft();
      if (24 == (int) namespaceId && "restoredTop" == name)
        return (OpenXmlElement) new RestoredTop();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NormalViewProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NormalViewProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RestoredLeft RestoredLeft
    {
      get
      {
        return this.GetElement<RestoredLeft>(0);
      }
      set
      {
        this.SetElement<RestoredLeft>(0, value);
      }
    }

    public RestoredTop RestoredTop
    {
      get
      {
        return this.GetElement<RestoredTop>(1);
      }
      set
      {
        this.SetElement<RestoredTop>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "showOutlineIcons" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "snapVertSplitter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "vertBarState" == name)
        return (OpenXmlSimpleType) new EnumValue<SplitterBarStateValues>();
      if ((int) namespaceId == 0 && "horzBarState" == name)
        return (OpenXmlSimpleType) new EnumValue<SplitterBarStateValues>();
      if ((int) namespaceId == 0 && "preferSingleView" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NormalViewProperties>(deep);
    }
  }
}
