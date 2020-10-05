// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DataConsolidate
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (DataReferences))]
  [GeneratedCode("DomGen", "2.0")]
  public class DataConsolidate : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "function",
      "leftLabels",
      "startLabels",
      "topLabels",
      "link"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[1]
    {
      "dataRefs"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "dataConsolidate";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11414;

    public override string LocalName
    {
      get
      {
        return "dataConsolidate";
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
        return 11414;
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
        return DataConsolidate.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataConsolidate.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "function")]
    public EnumValue<DataConsolidateFunctionValues> Function
    {
      get
      {
        return (EnumValue<DataConsolidateFunctionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "leftLabels")]
    public BooleanValue LeftLabels
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

    [SchemaAttr(0, "startLabels")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public BooleanValue StartLabels
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

    [SchemaAttr(0, "topLabels")]
    public BooleanValue TopLabels
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

    [SchemaAttr(0, "link")]
    public BooleanValue Link
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

    public DataConsolidate()
    {
    }

    public DataConsolidate(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataConsolidate(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataConsolidate(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "dataRefs" == name)
        return (OpenXmlElement) new DataReferences();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataConsolidate.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataConsolidate.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DataReferences DataReferences
    {
      get
      {
        return this.GetElement<DataReferences>(0);
      }
      set
      {
        this.SetElement<DataReferences>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "function" == name)
        return (OpenXmlSimpleType) new EnumValue<DataConsolidateFunctionValues>();
      if ((int) namespaceId == 0 && "leftLabels" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "startLabels" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "topLabels" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "link" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataConsolidate>(deep);
    }
  }
}
