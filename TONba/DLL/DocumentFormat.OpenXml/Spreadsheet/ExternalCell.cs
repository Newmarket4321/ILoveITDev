// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ExternalCell
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Xstring))]
  public class ExternalCell : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "r",
      "t",
      "vm"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "v"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "cell";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11336;

    public override string LocalName
    {
      get
      {
        return "cell";
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
        return 11336;
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
        return ExternalCell.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ExternalCell.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "r")]
    public StringValue CellReference
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

    [SchemaAttr(0, "t")]
    public EnumValue<CellValues> DataType
    {
      get
      {
        return (EnumValue<CellValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "vm")]
    public UInt32Value ValueMetaIndex
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

    public ExternalCell()
    {
    }

    public ExternalCell(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ExternalCell(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ExternalCell(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "v" == name)
        return (OpenXmlElement) new Xstring();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ExternalCell.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ExternalCell.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Xstring Xstring
    {
      get
      {
        return this.GetElement<Xstring>(0);
      }
      set
      {
        this.SetElement<Xstring>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new EnumValue<CellValues>();
      if ((int) namespaceId == 0 && "vm" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ExternalCell>(deep);
    }
  }
}
