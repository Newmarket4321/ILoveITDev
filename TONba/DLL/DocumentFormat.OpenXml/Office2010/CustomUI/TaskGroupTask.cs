// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class TaskGroupTask : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[23]
    {
      "id",
      "idQ",
      "tag",
      "idMso",
      "insertAfterMso",
      "insertBeforeMso",
      "insertAfterQ",
      "insertBeforeQ",
      "onAction",
      "isDefinitive",
      "image",
      "imageMso",
      "getImage",
      "enabled",
      "getEnabled",
      "label",
      "getLabel",
      "visible",
      "getVisible",
      "description",
      "getDescription",
      "keytip",
      "getKeytip"
    };
    private static byte[] attributeNamespaceIds = new byte[23];
    private const string tagName = "task";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13168;

    public override string LocalName
    {
      get
      {
        return "task";
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
        return 13168;
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
        return TaskGroupTask.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TaskGroupTask.attributeNamespaceIds;
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

    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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

    [SchemaAttr(0, "tag")]
    public StringValue Tag
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

    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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

    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
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

    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
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

    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
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

    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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

    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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

    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "image")]
    public StringValue Image
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

    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
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

    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
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

    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
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

    [SchemaAttr(0, "label")]
    public StringValue Label
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

    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
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

    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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

    [SchemaAttr(0, "description")]
    public StringValue Description
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

    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
      get
      {
        return (StringValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
      get
      {
        return (StringValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
      get
      {
        return (StringValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "idQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tag" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "idMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertAfterMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertBeforeMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertAfterQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertBeforeQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "onAction" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "isDefinitive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "image" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "imageMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getImage" == name)
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
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getDescription" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "keytip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getKeytip" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TaskGroupTask>(deep);
    }
  }
}
