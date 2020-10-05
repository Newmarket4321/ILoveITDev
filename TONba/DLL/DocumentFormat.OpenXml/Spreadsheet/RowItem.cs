// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RowItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (MemberPropertyIndex))]
  [GeneratedCode("DomGen", "2.0")]
  public class RowItem : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "t",
      "r",
      "i"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "i";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11171;

    public override string LocalName
    {
      get
      {
        return "i";
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
        return 11171;
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
        return RowItem.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RowItem.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "t")]
    public EnumValue<ItemValues> ItemType
    {
      get
      {
        return (EnumValue<ItemValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "r")]
    public UInt32Value RepeatedItemCount
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "i")]
    public UInt32Value Index
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

    public RowItem()
    {
    }

    public RowItem(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RowItem(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RowItem(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "x" == name)
        return (OpenXmlElement) new MemberPropertyIndex();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new EnumValue<ItemValues>();
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "i" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RowItem>(deep);
    }
  }
}
