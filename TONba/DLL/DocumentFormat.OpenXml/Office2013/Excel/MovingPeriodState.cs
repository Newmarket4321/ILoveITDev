// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class MovingPeriodState : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "referenceDateBegin",
      "referencePeriod",
      "referenceMultiple",
      "movingPeriod",
      "movingMultiple"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private const string tagName = "movingPeriodState";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13380;

    public override string LocalName
    {
      get
      {
        return "movingPeriodState";
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
        return 13380;
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
        return MovingPeriodState.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MovingPeriodState.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "referenceDateBegin")]
    public DateTimeValue ReferenceDateBegin
    {
      get
      {
        return (DateTimeValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "referencePeriod")]
    public EnumValue<MovingPeriodStep> ReferencePeriod
    {
      get
      {
        return (EnumValue<MovingPeriodStep>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "referenceMultiple")]
    public UInt32Value ReferenceMultiple
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "movingPeriod")]
    public EnumValue<MovingPeriodStep> MovingPeriod
    {
      get
      {
        return (EnumValue<MovingPeriodStep>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "movingMultiple")]
    public UInt32Value MovingMultiple
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "referenceDateBegin" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "referencePeriod" == name)
        return (OpenXmlSimpleType) new EnumValue<MovingPeriodStep>();
      if ((int) namespaceId == 0 && "referenceMultiple" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "movingPeriod" == name)
        return (OpenXmlSimpleType) new EnumValue<MovingPeriodStep>();
      if ((int) namespaceId == 0 && "movingMultiple" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MovingPeriodState>(deep);
    }
  }
}
