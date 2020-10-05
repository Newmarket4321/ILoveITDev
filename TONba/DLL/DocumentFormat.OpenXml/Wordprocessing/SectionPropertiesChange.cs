﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (PreviousSectionProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public class SectionPropertiesChange : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "author",
      "date",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "sectPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "sectPrChange";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11811;

    public override string LocalName
    {
      get
      {
        return "sectPrChange";
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
        return 11811;
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
        return SectionPropertiesChange.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SectionPropertiesChange.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "author")]
    public StringValue Author
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

    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
      get
      {
        return (DateTimeValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
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

    public SectionPropertiesChange()
    {
    }

    public SectionPropertiesChange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SectionPropertiesChange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SectionPropertiesChange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "sectPr" == name)
        return (OpenXmlElement) new PreviousSectionProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SectionPropertiesChange.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SectionPropertiesChange.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PreviousSectionProperties PreviousSectionProperties
    {
      get
      {
        return this.GetElement<PreviousSectionProperties>(0);
      }
      set
      {
        this.SetElement<PreviousSectionProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SectionPropertiesChange>(deep);
    }
  }
}
