// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.WorkbookProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class WorkbookProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[19]
    {
      "date1904",
      "dateCompatibility",
      "showObjects",
      "showBorderUnselectedTables",
      "filterPrivacy",
      "promptedSolutions",
      "showInkAnnotation",
      "backupFile",
      "saveExternalLinkValues",
      "updateLinks",
      "codeName",
      "hidePivotFieldList",
      "showPivotChartFilter",
      "allowRefreshQuery",
      "publishItems",
      "checkCompatibility",
      "autoCompressPictures",
      "refreshAllConnections",
      "defaultThemeVersion"
    };
    private static byte[] attributeNamespaceIds = new byte[19];
    private const string tagName = "workbookPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11521;

    public override string LocalName
    {
      get
      {
        return "workbookPr";
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
        return 11521;
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
        return WorkbookProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WorkbookProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "date1904")]
    public BooleanValue Date1904
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

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(0, "dateCompatibility")]
    public BooleanValue DateCompatibility
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

    [SchemaAttr(0, "showObjects")]
    public EnumValue<ObjectDisplayValues> ShowObjects
    {
      get
      {
        return (EnumValue<ObjectDisplayValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showBorderUnselectedTables")]
    public BooleanValue ShowBorderUnselectedTables
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

    [SchemaAttr(0, "filterPrivacy")]
    public BooleanValue FilterPrivacy
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

    [SchemaAttr(0, "promptedSolutions")]
    public BooleanValue PromptedSolutions
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showInkAnnotation")]
    public BooleanValue ShowInkAnnotation
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "backupFile")]
    public BooleanValue BackupFile
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "saveExternalLinkValues")]
    public BooleanValue SaveExternalLinkValues
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "updateLinks")]
    public EnumValue<UpdateLinksBehaviorValues> UpdateLinks
    {
      get
      {
        return (EnumValue<UpdateLinksBehaviorValues>) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "codeName")]
    public StringValue CodeName
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hidePivotFieldList")]
    public BooleanValue HidePivotFieldList
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

    [SchemaAttr(0, "showPivotChartFilter")]
    public BooleanValue ShowPivotChartFilter
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

    [SchemaAttr(0, "allowRefreshQuery")]
    public BooleanValue AllowRefreshQuery
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

    [SchemaAttr(0, "publishItems")]
    public BooleanValue PublishItems
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

    [SchemaAttr(0, "checkCompatibility")]
    public BooleanValue CheckCompatibility
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

    [SchemaAttr(0, "autoCompressPictures")]
    public BooleanValue AutoCompressPictures
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

    [SchemaAttr(0, "refreshAllConnections")]
    public BooleanValue RefreshAllConnections
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

    [SchemaAttr(0, "defaultThemeVersion")]
    public UInt32Value DefaultThemeVersion
    {
      get
      {
        return (UInt32Value) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "date1904" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dateCompatibility" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showObjects" == name)
        return (OpenXmlSimpleType) new EnumValue<ObjectDisplayValues>();
      if ((int) namespaceId == 0 && "showBorderUnselectedTables" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "filterPrivacy" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "promptedSolutions" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showInkAnnotation" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "backupFile" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "saveExternalLinkValues" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "updateLinks" == name)
        return (OpenXmlSimpleType) new EnumValue<UpdateLinksBehaviorValues>();
      if ((int) namespaceId == 0 && "codeName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hidePivotFieldList" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showPivotChartFilter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "allowRefreshQuery" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "publishItems" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "checkCompatibility" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoCompressPictures" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "refreshAllConnections" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "defaultThemeVersion" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WorkbookProperties>(deep);
    }
  }
}
