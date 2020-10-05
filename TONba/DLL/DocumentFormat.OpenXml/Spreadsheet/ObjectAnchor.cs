// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ObjectAnchor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ToMarker), FileFormatVersions.Office2010)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (FromMarker), FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class ObjectAnchor : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "moveWithCells",
      "sizeWithCells",
      "z-order"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[2]
    {
      "from",
      "to"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "anchor";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11366;

    public override string LocalName
    {
      get
      {
        return "anchor";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11366;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ObjectAnchor.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ObjectAnchor.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "moveWithCells")]
    public BooleanValue MoveWithCells
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

    [SchemaAttr(0, "sizeWithCells")]
    public BooleanValue SizeWithCells
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

    [SchemaAttr(0, "z-order")]
    public UInt32Value ZOrder
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public ObjectAnchor()
    {
    }

    public ObjectAnchor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ObjectAnchor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ObjectAnchor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "from" == name)
        return (OpenXmlElement) new FromMarker();
      if (22 == (int) namespaceId && "to" == name)
        return (OpenXmlElement) new ToMarker();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ObjectAnchor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ObjectAnchor.eleNamespaceIds;
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
      if ((int) namespaceId == 0 && "moveWithCells" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sizeWithCells" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "z-order" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ObjectAnchor>(deep);
    }
  }
}
