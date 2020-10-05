// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Colors
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (MruColors))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (IndexedColors))]
  public class Colors : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "indexedColors",
      "mruColors"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "colors";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11516;

    public override string LocalName
    {
      get
      {
        return "colors";
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
        return 11516;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Colors()
    {
    }

    public Colors(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Colors(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Colors(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "indexedColors" == name)
        return (OpenXmlElement) new IndexedColors();
      if (22 == (int) namespaceId && "mruColors" == name)
        return (OpenXmlElement) new MruColors();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Colors.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Colors.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public IndexedColors IndexedColors
    {
      get
      {
        return this.GetElement<IndexedColors>(0);
      }
      set
      {
        this.SetElement<IndexedColors>(0, value);
      }
    }

    public MruColors MruColors
    {
      get
      {
        return this.GetElement<MruColors>(1);
      }
      set
      {
        this.SetElement<MruColors>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Colors>(deep);
    }
  }
}
