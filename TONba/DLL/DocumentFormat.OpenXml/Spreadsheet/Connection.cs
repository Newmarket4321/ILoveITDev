// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Connection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (DatabaseProperties))]
  [ChildElementInfo(typeof (TextProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (WebQueryProperties))]
  [ChildElementInfo(typeof (OlapProperties))]
  [ChildElementInfo(typeof (Parameters))]
  [ChildElementInfo(typeof (ConnectionExtensionList))]
  public class Connection : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[20]
    {
      "id",
      "sourceFile",
      "odcFile",
      "keepAlive",
      "interval",
      "name",
      "description",
      "type",
      "reconnectionMethod",
      "refreshedVersion",
      "minRefreshableVersion",
      "savePassword",
      "new",
      "deleted",
      "onlyUseConnectionFile",
      "background",
      "refreshOnLoad",
      "saveData",
      "credentials",
      "singleSignOnId"
    };
    private static byte[] attributeNamespaceIds = new byte[20];
    private static readonly string[] eleTagNames = new string[6]
    {
      "dbPr",
      "olapPr",
      "webPr",
      "textPr",
      "parameters",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "connection";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11127;

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
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11127;
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

    [SchemaAttr(0, "id")]
    public UInt32Value Id
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

    [SchemaAttr(0, "sourceFile")]
    public StringValue SourceFile
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

    [SchemaAttr(0, "odcFile")]
    public StringValue ConnectionFile
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "keepAlive")]
    public BooleanValue KeepAlive
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "interval")]
    public UInt32Value Interval
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "description")]
    public StringValue Description
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

    [SchemaAttr(0, "type")]
    public UInt32Value Type
    {
      get
      {
        return (UInt32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "reconnectionMethod")]
    public UInt32Value ReconnectionMethod
    {
      get
      {
        return (UInt32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refreshedVersion")]
    public ByteValue RefreshedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minRefreshableVersion")]
    public ByteValue MinRefreshableVersion
    {
      get
      {
        return (ByteValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "savePassword")]
    public BooleanValue SavePassword
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "new")]
    public BooleanValue New
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "deleted")]
    public BooleanValue Deleted
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "onlyUseConnectionFile")]
    public BooleanValue OnlyUseConnectionFile
    {
      get
      {
        return (BooleanValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "background")]
    public BooleanValue Background
    {
      get
      {
        return (BooleanValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refreshOnLoad")]
    public BooleanValue RefreshOnLoad
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "saveData")]
    public BooleanValue SaveData
    {
      get
      {
        return (BooleanValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "credentials")]
    public EnumValue<CredentialsMethodValues> Credentials
    {
      get
      {
        return (EnumValue<CredentialsMethodValues>) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "singleSignOnId")]
    public StringValue SingleSignOnId
    {
      get
      {
        return (StringValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
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
      if (22 == (int) namespaceId && "dbPr" == name)
        return (OpenXmlElement) new DatabaseProperties();
      if (22 == (int) namespaceId && "olapPr" == name)
        return (OpenXmlElement) new OlapProperties();
      if (22 == (int) namespaceId && "webPr" == name)
        return (OpenXmlElement) new WebQueryProperties();
      if (22 == (int) namespaceId && "textPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (22 == (int) namespaceId && "parameters" == name)
        return (OpenXmlElement) new Parameters();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ConnectionExtensionList();
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

    public DatabaseProperties DatabaseProperties
    {
      get
      {
        return this.GetElement<DatabaseProperties>(0);
      }
      set
      {
        this.SetElement<DatabaseProperties>(0, value);
      }
    }

    public OlapProperties OlapProperties
    {
      get
      {
        return this.GetElement<OlapProperties>(1);
      }
      set
      {
        this.SetElement<OlapProperties>(1, value);
      }
    }

    public WebQueryProperties WebQueryProperties
    {
      get
      {
        return this.GetElement<WebQueryProperties>(2);
      }
      set
      {
        this.SetElement<WebQueryProperties>(2, value);
      }
    }

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(3);
      }
      set
      {
        this.SetElement<TextProperties>(3, value);
      }
    }

    public Parameters Parameters
    {
      get
      {
        return this.GetElement<Parameters>(4);
      }
      set
      {
        this.SetElement<Parameters>(4, value);
      }
    }

    public ConnectionExtensionList ConnectionExtensionList
    {
      get
      {
        return this.GetElement<ConnectionExtensionList>(5);
      }
      set
      {
        this.SetElement<ConnectionExtensionList>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sourceFile" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "odcFile" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "keepAlive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "interval" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "reconnectionMethod" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "refreshedVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "minRefreshableVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "savePassword" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "new" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "deleted" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "onlyUseConnectionFile" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "background" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "refreshOnLoad" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "saveData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "credentials" == name)
        return (OpenXmlSimpleType) new EnumValue<CredentialsMethodValues>();
      if ((int) namespaceId == 0 && "singleSignOnId" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Connection>(deep);
    }
  }
}
