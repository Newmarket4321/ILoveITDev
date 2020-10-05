// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.DifferentialType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (Font))]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (Alignment))]
  [ChildElementInfo(typeof (Border))]
  [ChildElementInfo(typeof (Protection))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Fill))]
  public class DifferentialType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "font",
      "numFmt",
      "fill",
      "alignment",
      "border",
      "protection",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "dxf";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13028;

    public override string LocalName
    {
      get
      {
        return "dxf";
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
        return 13028;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DifferentialType()
    {
    }

    public DifferentialType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DifferentialType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DifferentialType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "font" == name)
        return (OpenXmlElement) new Font();
      if (22 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlElement) new NumberingFormat();
      if (22 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new Fill();
      if (22 == (int) namespaceId && "alignment" == name)
        return (OpenXmlElement) new Alignment();
      if (22 == (int) namespaceId && "border" == name)
        return (OpenXmlElement) new Border();
      if (22 == (int) namespaceId && "protection" == name)
        return (OpenXmlElement) new Protection();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DifferentialType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DifferentialType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Font Font
    {
      get
      {
        return this.GetElement<Font>(0);
      }
      set
      {
        this.SetElement<Font>(0, value);
      }
    }

    public NumberingFormat NumberingFormat
    {
      get
      {
        return this.GetElement<NumberingFormat>(1);
      }
      set
      {
        this.SetElement<NumberingFormat>(1, value);
      }
    }

    public Fill Fill
    {
      get
      {
        return this.GetElement<Fill>(2);
      }
      set
      {
        this.SetElement<Fill>(2, value);
      }
    }

    public Alignment Alignment
    {
      get
      {
        return this.GetElement<Alignment>(3);
      }
      set
      {
        this.SetElement<Alignment>(3, value);
      }
    }

    public Border Border
    {
      get
      {
        return this.GetElement<Border>(4);
      }
      set
      {
        this.SetElement<Border>(4, value);
      }
    }

    public Protection Protection
    {
      get
      {
        return this.GetElement<Protection>(5);
      }
      set
      {
        this.SetElement<Protection>(5, value);
      }
    }

    public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(6);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(6, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DifferentialType>(deep);
    }
  }
}
