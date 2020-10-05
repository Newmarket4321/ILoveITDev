// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtContentDate
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (DateFormat))]
  [ChildElementInfo(typeof (SdtDateMappingType))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LanguageId))]
  [ChildElementInfo(typeof (Calendar))]
  public class SdtContentDate : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "fullDate"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[4]
    {
      "dateFormat",
      "lid",
      "storeMappedDataAs",
      "calendar"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "date";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12093;

    public override string LocalName
    {
      get
      {
        return "date";
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
        return 12093;
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
        return SdtContentDate.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SdtContentDate.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "fullDate")]
    public DateTimeValue FullDate
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

    public SdtContentDate()
    {
    }

    public SdtContentDate(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SdtContentDate(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SdtContentDate(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "dateFormat" == name)
        return (OpenXmlElement) new DateFormat();
      if (23 == (int) namespaceId && "lid" == name)
        return (OpenXmlElement) new LanguageId();
      if (23 == (int) namespaceId && "storeMappedDataAs" == name)
        return (OpenXmlElement) new SdtDateMappingType();
      if (23 == (int) namespaceId && "calendar" == name)
        return (OpenXmlElement) new Calendar();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SdtContentDate.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SdtContentDate.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DateFormat DateFormat
    {
      get
      {
        return this.GetElement<DateFormat>(0);
      }
      set
      {
        this.SetElement<DateFormat>(0, value);
      }
    }

    public LanguageId LanguageId
    {
      get
      {
        return this.GetElement<LanguageId>(1);
      }
      set
      {
        this.SetElement<LanguageId>(1, value);
      }
    }

    public SdtDateMappingType SdtDateMappingType
    {
      get
      {
        return this.GetElement<SdtDateMappingType>(2);
      }
      set
      {
        this.SetElement<SdtDateMappingType>(2, value);
      }
    }

    public Calendar Calendar
    {
      get
      {
        return this.GetElement<Calendar>(3);
      }
      set
      {
        this.SetElement<Calendar>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "fullDate" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SdtContentDate>(deep);
    }
  }
}
