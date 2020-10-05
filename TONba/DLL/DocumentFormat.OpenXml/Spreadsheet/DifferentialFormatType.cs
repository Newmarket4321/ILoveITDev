// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DifferentialFormatType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Border))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Font))]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (Fill))]
  [ChildElementInfo(typeof (Alignment))]
  [ChildElementInfo(typeof (Protection))]
  public abstract class DifferentialFormatType : OpenXmlCompositeElement
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
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DifferentialFormatType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DifferentialFormatType.eleNamespaceIds;
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

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(6);
      }
      set
      {
        this.SetElement<ExtensionList>(6, value);
      }
    }

    protected DifferentialFormatType()
    {
    }

    protected DifferentialFormatType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected DifferentialFormatType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected DifferentialFormatType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
