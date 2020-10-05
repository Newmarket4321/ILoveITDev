// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.FormControlProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ListItems), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class FormControlProperties : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[31]
    {
      "objectType",
      "checked",
      "colored",
      "dropLines",
      "dropStyle",
      "dx",
      "firstButton",
      "fmlaGroup",
      "fmlaLink",
      "fmlaRange",
      "fmlaTxbx",
      "horiz",
      "inc",
      "justLastX",
      "lockText",
      "max",
      "min",
      "multiSel",
      "noThreeD",
      "noThreeD2",
      "page",
      "sel",
      "seltype",
      "textHAlign",
      "textVAlign",
      "val",
      "widthMin",
      "editVal",
      "multiLine",
      "verticalBar",
      "passwordEdit"
    };
    private static byte[] attributeNamespaceIds = new byte[31];
    private static readonly string[] eleTagNames = new string[2]
    {
      "itemLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "formControlPr";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12992;

    public override string LocalName
    {
      get
      {
        return "formControlPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12992;
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
        return FormControlProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FormControlProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "objectType")]
    public EnumValue<ObjectTypeValues> ObjectType
    {
      get
      {
        return (EnumValue<ObjectTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "checked")]
    public EnumValue<CheckedValues> Checked
    {
      get
      {
        return (EnumValue<CheckedValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "colored")]
    public BooleanValue Colored
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

    [SchemaAttr(0, "dropLines")]
    public UInt32Value DropLines
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dropStyle")]
    public EnumValue<DropStyleValues> DropStyle
    {
      get
      {
        return (EnumValue<DropStyleValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dx")]
    public UInt32Value ScrollBarWidth
    {
      get
      {
        return (UInt32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "firstButton")]
    public BooleanValue FirstButton
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

    [SchemaAttr(0, "fmlaGroup")]
    public StringValue FmlaGroup
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

    [SchemaAttr(0, "fmlaLink")]
    public StringValue FmlaLink
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

    [SchemaAttr(0, "fmlaRange")]
    public StringValue FmlaRange
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

    [SchemaAttr(0, "fmlaTxbx")]
    public StringValue FmlaTextbox
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

    [SchemaAttr(0, "horiz")]
    public BooleanValue Horizontal
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

    [SchemaAttr(0, "inc")]
    public UInt32Value Incremental
    {
      get
      {
        return (UInt32Value) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "justLastX")]
    public BooleanValue JustLastX
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

    [SchemaAttr(0, "lockText")]
    public BooleanValue LockText
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

    [SchemaAttr(0, "max")]
    public UInt32Value Max
    {
      get
      {
        return (UInt32Value) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "min")]
    public UInt32Value Min
    {
      get
      {
        return (UInt32Value) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "multiSel")]
    public StringValue MultipleSelection
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

    [SchemaAttr(0, "noThreeD")]
    public BooleanValue NoThreeD
    {
      get
      {
        return (BooleanValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "noThreeD2")]
    public BooleanValue NoThreeD2
    {
      get
      {
        return (BooleanValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "page")]
    public UInt32Value Page
    {
      get
      {
        return (UInt32Value) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sel")]
    public UInt32Value Selected
    {
      get
      {
        return (UInt32Value) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "seltype")]
    public EnumValue<SelectionTypeValues> SelectionType
    {
      get
      {
        return (EnumValue<SelectionTypeValues>) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "textHAlign")]
    public EnumValue<TextHorizontalAlignmentValues> TextHorizontalAlign
    {
      get
      {
        return (EnumValue<TextHorizontalAlignmentValues>) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "textVAlign")]
    public EnumValue<TextVerticalAlignmentValues> TextVerticalAlign
    {
      get
      {
        return (EnumValue<TextVerticalAlignmentValues>) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
      get
      {
        return (UInt32Value) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "widthMin")]
    public UInt32Value MinimumWidth
    {
      get
      {
        return (UInt32Value) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "editVal")]
    public EnumValue<EditValidationValues> EditVal
    {
      get
      {
        return (EnumValue<EditValidationValues>) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "multiLine")]
    public BooleanValue MultipleLines
    {
      get
      {
        return (BooleanValue) this.Attributes[28];
      }
      set
      {
        this.Attributes[28] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "verticalBar")]
    public BooleanValue VerticalBar
    {
      get
      {
        return (BooleanValue) this.Attributes[29];
      }
      set
      {
        this.Attributes[29] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "passwordEdit")]
    public BooleanValue PasswordEdit
    {
      get
      {
        return (BooleanValue) this.Attributes[30];
      }
      set
      {
        this.Attributes[30] = (OpenXmlSimpleType) value;
      }
    }

    internal FormControlProperties(ControlPropertiesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ControlPropertiesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ControlPropertiesPart ControlPropertiesPart
    {
      get
      {
        return this.OpenXmlPart as ControlPropertiesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public FormControlProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FormControlProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FormControlProperties(string outerXml)
      : base(outerXml)
    {
    }

    public FormControlProperties()
    {
    }

    public void Save(ControlPropertiesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "itemLst" == name)
        return (OpenXmlElement) new ListItems();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FormControlProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FormControlProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ListItems ListItems
    {
      get
      {
        return this.GetElement<ListItems>(0);
      }
      set
      {
        this.SetElement<ListItems>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "objectType" == name)
        return (OpenXmlSimpleType) new EnumValue<ObjectTypeValues>();
      if ((int) namespaceId == 0 && "checked" == name)
        return (OpenXmlSimpleType) new EnumValue<CheckedValues>();
      if ((int) namespaceId == 0 && "colored" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dropLines" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "dropStyle" == name)
        return (OpenXmlSimpleType) new EnumValue<DropStyleValues>();
      if ((int) namespaceId == 0 && "dx" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "firstButton" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fmlaGroup" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fmlaLink" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fmlaRange" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fmlaTxbx" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "horiz" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "inc" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "justLastX" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "lockText" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "max" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "min" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "multiSel" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "noThreeD" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "noThreeD2" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "page" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sel" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "seltype" == name)
        return (OpenXmlSimpleType) new EnumValue<SelectionTypeValues>();
      if ((int) namespaceId == 0 && "textHAlign" == name)
        return (OpenXmlSimpleType) new EnumValue<TextHorizontalAlignmentValues>();
      if ((int) namespaceId == 0 && "textVAlign" == name)
        return (OpenXmlSimpleType) new EnumValue<TextVerticalAlignmentValues>();
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "widthMin" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "editVal" == name)
        return (OpenXmlSimpleType) new EnumValue<EditValidationValues>();
      if ((int) namespaceId == 0 && "multiLine" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "verticalBar" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "passwordEdit" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FormControlProperties>(deep);
    }
  }
}
