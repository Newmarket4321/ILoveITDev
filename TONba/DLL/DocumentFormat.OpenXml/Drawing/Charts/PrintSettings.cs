// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PrintSettings
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (PageSetup))]
  [ChildElementInfo(typeof (PageMargins))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (LegacyDrawingHeaderFooter))]
  [GeneratedCode("DomGen", "2.0")]
  public class PrintSettings : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "headerFooter",
      "pageMargins",
      "pageSetup",
      "legacyDrawingHF"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "printSettings";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10648;

    public override string LocalName
    {
      get
      {
        return "printSettings";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10648;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PrintSettings()
    {
    }

    public PrintSettings(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PrintSettings(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PrintSettings(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "headerFooter" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (11 == (int) namespaceId && "pageMargins" == name)
        return (OpenXmlElement) new PageMargins();
      if (11 == (int) namespaceId && "pageSetup" == name)
        return (OpenXmlElement) new PageSetup();
      if (11 == (int) namespaceId && "legacyDrawingHF" == name)
        return (OpenXmlElement) new LegacyDrawingHeaderFooter();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PrintSettings.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PrintSettings.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(0);
      }
      set
      {
        this.SetElement<HeaderFooter>(0, value);
      }
    }

    public PageMargins PageMargins
    {
      get
      {
        return this.GetElement<PageMargins>(1);
      }
      set
      {
        this.SetElement<PageMargins>(1, value);
      }
    }

    public PageSetup PageSetup
    {
      get
      {
        return this.GetElement<PageSetup>(2);
      }
      set
      {
        this.SetElement<PageSetup>(2, value);
      }
    }

    public LegacyDrawingHeaderFooter LegacyDrawingHeaderFooter
    {
      get
      {
        return this.GetElement<LegacyDrawingHeaderFooter>(3);
      }
      set
      {
        this.SetElement<LegacyDrawingHeaderFooter>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PrintSettings>(deep);
    }
  }
}
