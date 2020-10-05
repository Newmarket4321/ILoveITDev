// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DbCommand), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DbTables), FileFormatVersions.Office2013)]
  public class OleDbPrpoperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "connection"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "dbTables",
      "dbCommand"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "oledbPr";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13401;

    public override string LocalName
    {
      get
      {
        return "oledbPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13401;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return OleDbPrpoperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OleDbPrpoperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "connection")]
    public StringValue Connection
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

    public OleDbPrpoperties()
    {
    }

    public OleDbPrpoperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OleDbPrpoperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OleDbPrpoperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "dbTables" == name)
        return (OpenXmlElement) new DbTables();
      if (71 == (int) namespaceId && "dbCommand" == name)
        return (OpenXmlElement) new DbCommand();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OleDbPrpoperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OleDbPrpoperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public DbTables DbTables
    {
      get
      {
        return this.GetElement<DbTables>(0);
      }
      set
      {
        this.SetElement<DbTables>(0, value);
      }
    }

    public DbCommand DbCommand
    {
      get
      {
        return this.GetElement<DbCommand>(1);
      }
      set
      {
        this.SetElement<DbCommand>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "connection" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OleDbPrpoperties>(deep);
    }
  }
}
