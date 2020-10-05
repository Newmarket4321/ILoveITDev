// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SectionTitle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DoNotAllowInsertDeleteSection), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SdtRepeatedSection : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "sectionTitle",
      "doNotAllowInsertDeleteSection"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 69,
      (byte) 69
    };
    private const string tagName = "repeatingSection";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13340;

    public override string LocalName
    {
      get
      {
        return "repeatingSection";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13340;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public SdtRepeatedSection()
    {
    }

    public SdtRepeatedSection(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SdtRepeatedSection(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SdtRepeatedSection(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "sectionTitle" == name)
        return (OpenXmlElement) new SectionTitle();
      if (69 == (int) namespaceId && "doNotAllowInsertDeleteSection" == name)
        return (OpenXmlElement) new DoNotAllowInsertDeleteSection();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SdtRepeatedSection.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SdtRepeatedSection.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SectionTitle SectionTitle
    {
      get
      {
        return this.GetElement<SectionTitle>(0);
      }
      set
      {
        this.SetElement<SectionTitle>(0, value);
      }
    }

    public DoNotAllowInsertDeleteSection DoNotAllowInsertDeleteSection
    {
      get
      {
        return this.GetElement<DoNotAllowInsertDeleteSection>(1);
      }
      set
      {
        this.SetElement<DoNotAllowInsertDeleteSection>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SdtRepeatedSection>(deep);
    }
  }
}
