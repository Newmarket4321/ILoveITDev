// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ShowProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (PresenterSlideMode))]
  [ChildElementInfo(typeof (PenColor))]
  [ChildElementInfo(typeof (ShowPropertiesExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BrowseSlideMode))]
  [ChildElementInfo(typeof (KioskSlideMode))]
  [ChildElementInfo(typeof (SlideAll))]
  [ChildElementInfo(typeof (SlideRange))]
  [ChildElementInfo(typeof (CustomShowReference))]
  public class ShowProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "loop",
      "showNarration",
      "showAnimation",
      "useTimings"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "showPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12429;

    public override string LocalName
    {
      get
      {
        return "showPr";
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
        return 12429;
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
        return ShowProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ShowProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "loop")]
    public BooleanValue Loop
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

    [SchemaAttr(0, "showNarration")]
    public BooleanValue ShowNarration
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

    [SchemaAttr(0, "showAnimation")]
    public BooleanValue ShowAnimation
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

    [SchemaAttr(0, "useTimings")]
    public BooleanValue UseTimings
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

    public ShowProperties()
    {
    }

    public ShowProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShowProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShowProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "present" == name)
        return (OpenXmlElement) new PresenterSlideMode();
      if (24 == (int) namespaceId && "browse" == name)
        return (OpenXmlElement) new BrowseSlideMode();
      if (24 == (int) namespaceId && "kiosk" == name)
        return (OpenXmlElement) new KioskSlideMode();
      if (24 == (int) namespaceId && "sldAll" == name)
        return (OpenXmlElement) new SlideAll();
      if (24 == (int) namespaceId && "sldRg" == name)
        return (OpenXmlElement) new SlideRange();
      if (24 == (int) namespaceId && "custShow" == name)
        return (OpenXmlElement) new CustomShowReference();
      if (24 == (int) namespaceId && "penClr" == name)
        return (OpenXmlElement) new PenColor();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ShowPropertiesExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "loop" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showNarration" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showAnimation" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "useTimings" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShowProperties>(deep);
    }
  }
}
