// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Control
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Picture))]
  [GeneratedCode("DomGen", "2.0")]
  public class Control : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "spid",
      "name",
      "showAsIcon",
      "id",
      "imgW",
      "imgH"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 19,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "extLst",
      "pic"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "control";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12310;

    public override string LocalName
    {
      get
      {
        return "control";
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
        return 12310;
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
        return Control.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Control.attributeNamespaceIds;
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

    public Control()
    {
    }

    public Control(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Control(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Control(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      if (24 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Control.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Control.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    public Picture Picture
    {
      get
      {
        return this.GetElement<Picture>(1);
      }
      set
      {
        this.SetElement<Picture>(1, value);
      }
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
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Control>(deep);
    }
  }
}
