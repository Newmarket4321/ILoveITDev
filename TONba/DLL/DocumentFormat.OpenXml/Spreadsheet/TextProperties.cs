// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TextProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TextFields))]
  public class TextProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[16]
    {
      "prompt",
      "fileType",
      "codePage",
      "characterSet",
      "firstRow",
      "sourceFile",
      "delimited",
      "decimal",
      "thousands",
      "tab",
      "space",
      "comma",
      "semicolon",
      "consecutive",
      "qualifier",
      "delimiter"
    };
    private static byte[] attributeNamespaceIds = new byte[16];
    private static readonly string[] eleTagNames = new string[1]
    {
      "textFields"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "textPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11443;

    public override string LocalName
    {
      get
      {
        return "textPr";
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
        return 11443;
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
        return TextProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prompt")]
    public BooleanValue Prompt
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

    [SchemaAttr(0, "fileType")]
    public EnumValue<FileTypeValues> FileType
    {
      get
      {
        return (EnumValue<FileTypeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "codePage")]
    public UInt32Value CodePage
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

    [SchemaAttr(0, "characterSet")]
    public StringValue TextCharacterSet
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

    [SchemaAttr(0, "firstRow")]
    public UInt32Value FirstRow
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

    [SchemaAttr(0, "sourceFile")]
    public StringValue SourceFile
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

    [SchemaAttr(0, "delimited")]
    public BooleanValue Delimited
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

    [SchemaAttr(0, "decimal")]
    public StringValue Decimal
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

    [SchemaAttr(0, "thousands")]
    public StringValue Thousands
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

    [SchemaAttr(0, "tab")]
    public BooleanValue TabAsDelimiter
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

    [SchemaAttr(0, "space")]
    public BooleanValue Space
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "comma")]
    public BooleanValue Comma
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

    [SchemaAttr(0, "semicolon")]
    public BooleanValue Semicolon
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

    [SchemaAttr(0, "consecutive")]
    public BooleanValue Consecutive
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

    [SchemaAttr(0, "qualifier")]
    public EnumValue<QualifierValues> Qualifier
    {
      get
      {
        return (EnumValue<QualifierValues>) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "delimiter")]
    public StringValue Delimiter
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

    public TextProperties()
    {
    }

    public TextProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "textFields" == name)
        return (OpenXmlElement) new TextFields();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TextFields TextFields
    {
      get
      {
        return this.GetElement<TextFields>(0);
      }
      set
      {
        this.SetElement<TextFields>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prompt" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fileType" == name)
        return (OpenXmlSimpleType) new EnumValue<FileTypeValues>();
      if ((int) namespaceId == 0 && "codePage" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "characterSet" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "firstRow" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sourceFile" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "delimited" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "decimal" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "thousands" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tab" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "space" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "comma" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "semicolon" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "consecutive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "qualifier" == name)
        return (OpenXmlSimpleType) new EnumValue<QualifierValues>();
      if ((int) namespaceId == 0 && "delimiter" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextProperties>(deep);
    }
  }
}
