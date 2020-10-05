// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PageBorders
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TopBorder))]
  [ChildElementInfo(typeof (LeftBorder))]
  [ChildElementInfo(typeof (BottomBorder))]
  [ChildElementInfo(typeof (RightBorder))]
  public class PageBorders : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "zOrder",
      "display",
      "offsetFrom"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[4]
    {
      "top",
      "left",
      "bottom",
      "right"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "pgBorders";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11742;

    public override string LocalName
    {
      get
      {
        return "pgBorders";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11742;
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
        return PageBorders.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PageBorders.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "zOrder")]
    public EnumValue<PageBorderZOrderValues> ZOrder
    {
      get
      {
        return (EnumValue<PageBorderZOrderValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "display")]
    public EnumValue<PageBorderDisplayValues> Display
    {
      get
      {
        return (EnumValue<PageBorderDisplayValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "offsetFrom")]
    public EnumValue<PageBorderOffsetValues> OffsetFrom
    {
      get
      {
        return (EnumValue<PageBorderOffsetValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public PageBorders()
    {
    }

    public PageBorders(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PageBorders(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PageBorders(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopBorder();
      if (23 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftBorder();
      if (23 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomBorder();
      if (23 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightBorder();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PageBorders.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PageBorders.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TopBorder TopBorder
    {
      get
      {
        return this.GetElement<TopBorder>(0);
      }
      set
      {
        this.SetElement<TopBorder>(0, value);
      }
    }

    public LeftBorder LeftBorder
    {
      get
      {
        return this.GetElement<LeftBorder>(1);
      }
      set
      {
        this.SetElement<LeftBorder>(1, value);
      }
    }

    public BottomBorder BottomBorder
    {
      get
      {
        return this.GetElement<BottomBorder>(2);
      }
      set
      {
        this.SetElement<BottomBorder>(2, value);
      }
    }

    public RightBorder RightBorder
    {
      get
      {
        return this.GetElement<RightBorder>(3);
      }
      set
      {
        this.SetElement<RightBorder>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "zOrder" == name)
        return (OpenXmlSimpleType) new EnumValue<PageBorderZOrderValues>();
      if (23 == (int) namespaceId && "display" == name)
        return (OpenXmlSimpleType) new EnumValue<PageBorderDisplayValues>();
      if (23 == (int) namespaceId && "offsetFrom" == name)
        return (OpenXmlSimpleType) new EnumValue<PageBorderOffsetValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PageBorders>(deep);
    }
  }
}
