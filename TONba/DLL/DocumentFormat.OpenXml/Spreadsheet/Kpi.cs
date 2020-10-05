// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Kpi
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class Kpi : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[10]
    {
      "uniqueName",
      "caption",
      "displayFolder",
      "measureGroup",
      "parent",
      "value",
      "goal",
      "status",
      "trend",
      "weight"
    };
    private static byte[] attributeNamespaceIds = new byte[10];
    private const string tagName = "kpi";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11149;

    public override string LocalName
    {
      get
      {
        return "kpi";
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
        return 11149;
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
        return Kpi.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Kpi.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
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

    [SchemaAttr(0, "caption")]
    public StringValue Caption
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

    [SchemaAttr(0, "displayFolder")]
    public StringValue DisplayFolder
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

    [SchemaAttr(0, "measureGroup")]
    public StringValue MeasureGroup
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "parent")]
    public StringValue ParentKpi
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "value")]
    public StringValue Value
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

    [SchemaAttr(0, "goal")]
    public StringValue Goal
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

    [SchemaAttr(0, "status")]
    public StringValue Status
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "trend")]
    public StringValue Trend
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "weight")]
    public StringValue Weight
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "caption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "displayFolder" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "measureGroup" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "parent" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "value" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "goal" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "status" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "trend" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "weight" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Kpi>(deep);
    }
  }
}
