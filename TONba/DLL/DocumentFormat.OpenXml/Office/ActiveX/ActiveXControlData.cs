// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.ActiveX.ActiveXControlData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
  [ChildElementInfo(typeof (ActiveXObjectProperty))]
  [GeneratedCode("DomGen", "2.0")]
  public class ActiveXControlData : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "classid",
      "license",
      "id",
      "persistence"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 35,
      (byte) 35,
      (byte) 19,
      (byte) 35
    };
    private const string tagName = "ocx";
    private const byte tagNsId = 35;
    internal const int ElementTypeIdConst = 12688;

    public override string LocalName
    {
      get
      {
        return "ocx";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 35;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12688;
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
        return ActiveXControlData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ActiveXControlData.attributeNamespaceIds;
      }
    }

    [SchemaAttr(35, "classid")]
    public StringValue ActiveXControlClassId
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

    [SchemaAttr(35, "license")]
    public StringValue License
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

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    [SchemaAttr(35, "persistence")]
    public EnumValue<PersistenceValues> Persistence
    {
      get
      {
        return (EnumValue<PersistenceValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public ActiveXControlData()
    {
    }

    public ActiveXControlData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ActiveXControlData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ActiveXControlData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (35 == (int) namespaceId && "ocxPr" == name)
        return (OpenXmlElement) new ActiveXObjectProperty();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (35 == (int) namespaceId && "classid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (35 == (int) namespaceId && "license" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (35 == (int) namespaceId && "persistence" == name)
        return (OpenXmlSimpleType) new EnumValue<PersistenceValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ActiveXControlData>(deep);
    }
  }
}
