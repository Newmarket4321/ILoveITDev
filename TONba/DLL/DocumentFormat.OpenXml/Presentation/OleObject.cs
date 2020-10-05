// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.OleObject
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (OleObjectLink))]
  [ChildElementInfo(typeof (Picture))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OleObjectEmbed))]
  public class OleObject : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "spid",
      "name",
      "showAsIcon",
      "id",
      "imgW",
      "imgH",
      "progId"
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 19,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "oleObj";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12235;

    public override string LocalName
    {
      get
      {
        return "oleObj";
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
        return 12235;
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
        return OleObject.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OleObject.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
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

    [SchemaAttr(0, "showAsIcon")]
    public BooleanValue ShowAsIcon
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

    [SchemaAttr(19, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "imgW")]
    public Int32Value ImageWidth
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "imgH")]
    public Int32Value ImageHeight
    {
      get
      {
        return (Int32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "progId")]
    public StringValue ProgId
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    public OleObject()
    {
    }

    public OleObject(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OleObject(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OleObject(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "embed" == name)
        return (OpenXmlElement) new OleObjectEmbed();
      if (24 == (int) namespaceId && "link" == name)
        return (OpenXmlElement) new OleObjectLink();
      if (24 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "spid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "showAsIcon" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "imgW" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "imgH" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "progId" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OleObject>(deep);
    }
  }
}
