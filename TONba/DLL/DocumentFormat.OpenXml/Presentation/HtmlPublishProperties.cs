// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.HtmlPublishProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (SlideAll))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CustomShowReference))]
  [ChildElementInfo(typeof (ExtensionList))]
  [OfficeAvailability(FileFormatVersions.Office2007)]
  [ChildElementInfo(typeof (SlideRange))]
  public class HtmlPublishProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "showSpeakerNotes",
      "pubBrowser",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 0,
      (byte) 0,
      (byte) 19
    };
    private const string tagName = "htmlPubPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12426;

    public override string LocalName
    {
      get
      {
        return "htmlPubPr";
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
        return 12426;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2007 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return HtmlPublishProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return HtmlPublishProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "showSpeakerNotes")]
    public BooleanValue ShowSpeakerNotes
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

    [SchemaAttr(0, "pubBrowser")]
    public EnumValue<HtmlPublishWebBrowserSupportValues> TargetBrowser
    {
      get
      {
        return (EnumValue<HtmlPublishWebBrowserSupportValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    public HtmlPublishProperties()
    {
    }

    public HtmlPublishProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HtmlPublishProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HtmlPublishProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "sldAll" == name)
        return (OpenXmlElement) new SlideAll();
      if (24 == (int) namespaceId && "sldRg" == name)
        return (OpenXmlElement) new SlideRange();
      if (24 == (int) namespaceId && "custShow" == name)
        return (OpenXmlElement) new CustomShowReference();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "showSpeakerNotes" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pubBrowser" == name)
        return (OpenXmlSimpleType) new EnumValue<HtmlPublishWebBrowserSupportValues>();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HtmlPublishProperties>(deep);
    }
  }
}
