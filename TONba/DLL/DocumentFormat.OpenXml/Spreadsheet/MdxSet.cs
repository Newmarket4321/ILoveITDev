// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.MdxSet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (NameIndex))]
  [GeneratedCode("DomGen", "2.0")]
  public class MdxSet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "ns",
      "c",
      "o"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "ms";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11302;

    public override string LocalName
    {
      get
      {
        return "ms";
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
        return 11302;
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
        return MdxSet.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MdxSet.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ns")]
    public UInt32Value SetDefinitionIndex
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "c")]
    public UInt32Value MemberIndexCount
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

    [SchemaAttr(0, "o")]
    public EnumValue<MdxSetOrderValues> SortingOrder
    {
      get
      {
        return (EnumValue<MdxSetOrderValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public MdxSet()
    {
    }

    public MdxSet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MdxSet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MdxSet(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "n" == name)
        return (OpenXmlElement) new NameIndex();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ns" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "c" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "o" == name)
        return (OpenXmlSimpleType) new EnumValue<MdxSetOrderValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MdxSet>(deep);
    }
  }
}
