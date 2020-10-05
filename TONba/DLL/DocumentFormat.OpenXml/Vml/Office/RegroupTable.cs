// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.RegroupTable
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Entry))]
  public class RegroupTable : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ext"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 26
    };
    private const string tagName = "regrouptable";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12489;

    public override string LocalName
    {
      get
      {
        return "regrouptable";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12489;
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
        return RegroupTable.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RegroupTable.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public RegroupTable()
    {
    }

    public RegroupTable(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RegroupTable(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RegroupTable(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "entry" == name)
        return (OpenXmlElement) new Entry();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RegroupTable>(deep);
    }
  }
}
