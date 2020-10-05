// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.PivotTableUISettings
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FieldListActiveTabTopLevelEntity), FileFormatVersions.Office2013)]
  public class PivotTableUISettings : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "sourceDataName",
      "relNeededHidden"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "pivotTableUISettings";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13370;

    public override string LocalName
    {
      get
      {
        return "pivotTableUISettings";
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
        return 13370;
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
        return PivotTableUISettings.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotTableUISettings.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "sourceDataName")]
    public StringValue SourceDataName
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

    [SchemaAttr(0, "relNeededHidden")]
    public BooleanValue RelNeededHidden
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

    public PivotTableUISettings()
    {
    }

    public PivotTableUISettings(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotTableUISettings(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotTableUISettings(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "activeTabTopLevelEntity" == name)
        return (OpenXmlElement) new FieldListActiveTabTopLevelEntity();
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "sourceDataName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "relNeededHidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotTableUISettings>(deep);
    }
  }
}
