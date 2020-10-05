// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DdeLink
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DdeItems))]
  public class DdeLink : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "ddeService",
      "ddeTopic"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[1]
    {
      "ddeItems"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "ddeLink";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11343;

    public override string LocalName
    {
      get
      {
        return "ddeLink";
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
        return 11343;
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
        return DdeLink.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DdeLink.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ddeService")]
    public StringValue DdeService
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

    [SchemaAttr(0, "ddeTopic")]
    public StringValue DdeTopic
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

    public DdeLink()
    {
    }

    public DdeLink(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DdeLink(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DdeLink(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "ddeItems" == name)
        return (OpenXmlElement) new DdeItems();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DdeLink.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DdeLink.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DdeItems DdeItems
    {
      get
      {
        return this.GetElement<DdeItems>(0);
      }
      set
      {
        this.SetElement<DdeItems>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ddeService" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "ddeTopic" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DdeLink>(deep);
    }
  }
}
