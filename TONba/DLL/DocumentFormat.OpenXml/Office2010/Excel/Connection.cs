// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.Connection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CalculatedMembers), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class Connection : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "culture",
      "embeddedDataId"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[1]
    {
      "calculatedMembers"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 53
    };
    private const string tagName = "connection";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12978;

    public override string LocalName
    {
      get
      {
        return "connection";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12978;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Connection.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Connection.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "culture")]
    public StringValue Culture
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

    [SchemaAttr(0, "embeddedDataId")]
    public StringValue EmbeddedDataId
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

    public Connection()
    {
    }

    public Connection(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Connection(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Connection(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "calculatedMembers" == name)
        return (OpenXmlElement) new CalculatedMembers();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Connection.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Connection.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CalculatedMembers CalculatedMembers
    {
      get
      {
        return this.GetElement<CalculatedMembers>(0);
      }
      set
      {
        this.SetElement<CalculatedMembers>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "culture" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "embeddedDataId" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Connection>(deep);
    }
  }
}
