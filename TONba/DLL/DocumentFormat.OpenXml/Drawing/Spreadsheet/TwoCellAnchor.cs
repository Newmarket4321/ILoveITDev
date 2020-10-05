// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.TwoCellAnchor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (FromMarker))]
  [ChildElementInfo(typeof (ToMarker))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (GroupShape))]
  [ChildElementInfo(typeof (GraphicFrame))]
  [ChildElementInfo(typeof (ConnectionShape))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ClientData))]
  [GeneratedCode("DomGen", "2.0")]
  public class TwoCellAnchor : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "editAs"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[9]
    {
      "from",
      "to",
      "sp",
      "grpSp",
      "graphicFrame",
      "cxnSp",
      "pic",
      "contentPart",
      "clientData"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18
    };
    private const string tagName = "twoCellAnchor";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10786;

    public override string LocalName
    {
      get
      {
        return "twoCellAnchor";
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
        return 10786;
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
        return TwoCellAnchor.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TwoCellAnchor.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "editAs")]
    public EnumValue<EditAsValues> EditAs
    {
      get
      {
        return (EnumValue<EditAsValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public TwoCellAnchor()
    {
    }

    public TwoCellAnchor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TwoCellAnchor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TwoCellAnchor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "from" == name)
        return (OpenXmlElement) new FromMarker();
      if (18 == (int) namespaceId && "to" == name)
        return (OpenXmlElement) new ToMarker();
      if (18 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (18 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (18 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (18 == (int) namespaceId && "cxnSp" == name)
        return (OpenXmlElement) new ConnectionShape();
      if (18 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (18 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      if (18 == (int) namespaceId && "clientData" == name)
        return (OpenXmlElement) new ClientData();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TwoCellAnchor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TwoCellAnchor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FromMarker FromMarker
    {
      get
      {
        return this.GetElement<FromMarker>(0);
      }
      set
      {
        this.SetElement<FromMarker>(0, value);
      }
    }

    public ToMarker ToMarker
    {
      get
      {
        return this.GetElement<ToMarker>(1);
      }
      set
      {
        this.SetElement<ToMarker>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "editAs" == name)
        return (OpenXmlSimpleType) new EnumValue<EditAsValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TwoCellAnchor>(deep);
    }
  }
}
