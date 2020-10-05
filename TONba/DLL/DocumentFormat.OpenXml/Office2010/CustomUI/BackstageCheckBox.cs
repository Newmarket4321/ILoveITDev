// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class BackstageCheckBox : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[20]
    {
      "expand",
      "description",
      "getDescription",
      "screentip",
      "getScreentip",
      "supertip",
      "getSupertip",
      "id",
      "idQ",
      "tag",
      "onAction",
      "getPressed",
      "enabled",
      "getEnabled",
      "label",
      "getLabel",
      "visible",
      "getVisible",
      "keytip",
      "getKeytip"
    };
    private static byte[] attributeNamespaceIds = new byte[20];
    private const string tagName = "checkBox";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13129;

    public override string LocalName
    {
      get
      {
        return "checkBox";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13129;
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
        return BackstageCheckBox.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BackstageCheckBox.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "expand")]
    public EnumValue<ExpandValues> Expand
    {
      get
      {
        return (EnumValue<ExpandValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "description")]
    public StringValue Description
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

    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
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

    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
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

    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
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

    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
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

    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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

    [SchemaAttr(0, "tag")]
    public StringValue Tag
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

    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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

    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
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

    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "label")]
    public StringValue Label
    {
      get
      {
        return (StringValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
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

    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "expand" == name)
        return (OpenXmlSimpleType) new EnumValue<ExpandValues>();
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getDescription" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "screentip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getScreentip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "supertip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getSupertip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "idQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tag" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "onAction" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getPressed" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "enabled" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "getEnabled" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "label" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getLabel" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "visible" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "getVisible" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "keytip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getKeytip" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BackstageCheckBox>(deep);
    }
  }
}
