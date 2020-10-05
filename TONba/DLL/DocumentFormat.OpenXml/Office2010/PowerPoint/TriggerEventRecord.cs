// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.TriggerEventRecord
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Presentation;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class TriggerEventRecord : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "type",
      "time",
      "objId"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "triggerEvt";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12880;

    public override string LocalName
    {
      get
      {
        return "triggerEvt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 49;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12880;
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
        return TriggerEventRecord.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TriggerEventRecord.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<TriggerEventValues> Type
    {
      get
      {
        return (EnumValue<TriggerEventValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "time")]
    public StringValue Time
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

    [SchemaAttr(0, "objId")]
    public UInt32Value ObjectId
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<TriggerEventValues>();
      if ((int) namespaceId == 0 && "time" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "objId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TriggerEventRecord>(deep);
    }
  }
}
