// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.FieldChar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (FormFieldData))]
  [ChildElementInfo(typeof (NumberingChange))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FieldData))]
  public class FieldChar : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "fldCharType",
      "fldLock",
      "dirty"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[3]
    {
      "fldData",
      "ffData",
      "numberingChange"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "fldChar";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11614;

    public override string LocalName
    {
      get
      {
        return "fldChar";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11614;
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
        return FieldChar.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FieldChar.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "fldCharType")]
    public EnumValue<FieldCharValues> FieldCharType
    {
      get
      {
        return (EnumValue<FieldCharValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "fldLock")]
    public OnOffValue FieldLock
    {
      get
      {
        return (OnOffValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "dirty")]
    public OnOffValue Dirty
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public FieldChar()
    {
    }

    public FieldChar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FieldChar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FieldChar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "fldData" == name)
        return (OpenXmlElement) new FieldData();
      if (23 == (int) namespaceId && "ffData" == name)
        return (OpenXmlElement) new FormFieldData();
      if (23 == (int) namespaceId && "numberingChange" == name)
        return (OpenXmlElement) new NumberingChange();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FieldChar.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FieldChar.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public FieldData FieldData
    {
      get
      {
        return this.GetElement<FieldData>(0);
      }
      set
      {
        this.SetElement<FieldData>(0, value);
      }
    }

    public FormFieldData FormFieldData
    {
      get
      {
        return this.GetElement<FormFieldData>(1);
      }
      set
      {
        this.SetElement<FormFieldData>(1, value);
      }
    }

    public NumberingChange NumberingChange
    {
      get
      {
        return this.GetElement<NumberingChange>(2);
      }
      set
      {
        this.SetElement<NumberingChange>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "fldCharType" == name)
        return (OpenXmlSimpleType) new EnumValue<FieldCharValues>();
      if (23 == (int) namespaceId && "fldLock" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "dirty" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FieldChar>(deep);
    }
  }
}
