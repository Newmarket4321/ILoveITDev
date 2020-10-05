// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TableCellVerticalAlignment))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (NoWrap))]
  [ChildElementInfo(typeof (TableCellMargin))]
  public class StyleTableCellProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "shd",
      "noWrap",
      "tcMar",
      "vAlign"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tcPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11957;

    public override string LocalName
    {
      get
      {
        return "tcPr";
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
        return 11957;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public StyleTableCellProperties()
    {
    }

    public StyleTableCellProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StyleTableCellProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StyleTableCellProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "noWrap" == name)
        return (OpenXmlElement) new NoWrap();
      if (23 == (int) namespaceId && "tcMar" == name)
        return (OpenXmlElement) new TableCellMargin();
      if (23 == (int) namespaceId && "vAlign" == name)
        return (OpenXmlElement) new TableCellVerticalAlignment();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StyleTableCellProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StyleTableCellProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(0);
      }
      set
      {
        this.SetElement<Shading>(0, value);
      }
    }

    public NoWrap NoWrap
    {
      get
      {
        return this.GetElement<NoWrap>(1);
      }
      set
      {
        this.SetElement<NoWrap>(1, value);
      }
    }

    public TableCellMargin TableCellMargin
    {
      get
      {
        return this.GetElement<TableCellMargin>(2);
      }
      set
      {
        this.SetElement<TableCellMargin>(2, value);
      }
    }

    public TableCellVerticalAlignment TableCellVerticalAlignment
    {
      get
      {
        return this.GetElement<TableCellVerticalAlignment>(3);
      }
      set
      {
        this.SetElement<TableCellVerticalAlignment>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StyleTableCellProperties>(deep);
    }
  }
}
