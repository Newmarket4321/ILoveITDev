// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.Connection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (RangeProperties), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ModelTextProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataFeedProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OleDbPrpoperties), FileFormatVersions.Office2013)]
  public class Connection : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "id",
      "model",
      "excludeFromRefreshAll",
      "autoDelete",
      "usedByAddin"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[5]
    {
      "textPr",
      "modelTextPr",
      "rangePr",
      "oledbPr",
      "dataFeedPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 71,
      (byte) 71,
      (byte) 71,
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "connection";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13368;

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
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13368;
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
    public StringValue Id
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

    [SchemaAttr(0, "model")]
    public BooleanValue Model
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

    [SchemaAttr(0, "excludeFromRefreshAll")]
    public BooleanValue ExcludeFromRefreshAll
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

    [SchemaAttr(0, "autoDelete")]
    public BooleanValue AutoDelete
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

    [SchemaAttr(0, "usedByAddin")]
    public BooleanValue UsedByAddin
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
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
      if (71 == (int) namespaceId && "textPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (71 == (int) namespaceId && "modelTextPr" == name)
        return (OpenXmlElement) new ModelTextProperties();
      if (71 == (int) namespaceId && "rangePr" == name)
        return (OpenXmlElement) new RangeProperties();
      if (71 == (int) namespaceId && "oledbPr" == name)
        return (OpenXmlElement) new OleDbPrpoperties();
      if (71 == (int) namespaceId && "dataFeedPr" == name)
        return (OpenXmlElement) new DataFeedProperties();
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

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(0);
      }
      set
      {
        this.SetElement<TextProperties>(0, value);
      }
    }

    public ModelTextProperties ModelTextProperties
    {
      get
      {
        return this.GetElement<ModelTextProperties>(1);
      }
      set
      {
        this.SetElement<ModelTextProperties>(1, value);
      }
    }

    public RangeProperties RangeProperties
    {
      get
      {
        return this.GetElement<RangeProperties>(2);
      }
      set
      {
        this.SetElement<RangeProperties>(2, value);
      }
    }

    public OleDbPrpoperties OleDbPrpoperties
    {
      get
      {
        return this.GetElement<OleDbPrpoperties>(3);
      }
      set
      {
        this.SetElement<OleDbPrpoperties>(3, value);
      }
    }

    public DataFeedProperties DataFeedProperties
    {
      get
      {
        return this.GetElement<DataFeedProperties>(4);
      }
      set
      {
        this.SetElement<DataFeedProperties>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "model" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "excludeFromRefreshAll" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoDelete" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "usedByAddin" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Connection>(deep);
    }
  }
}
