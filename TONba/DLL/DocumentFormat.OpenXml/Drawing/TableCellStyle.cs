// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableCellStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TableCellBorders))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FillProperties))]
  [ChildElementInfo(typeof (FillReference))]
  [ChildElementInfo(typeof (Cell3DProperties))]
  public class TableCellStyle : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "tcBdr",
      "fill",
      "fillRef",
      "cell3D"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "tcStyle";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10273;

    public override string LocalName
    {
      get
      {
        return "tcStyle";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10273;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableCellStyle()
    {
    }

    public TableCellStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCellStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCellStyle(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tcBdr" == name)
        return (OpenXmlElement) new TableCellBorders();
      if (10 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new FillProperties();
      if (10 == (int) namespaceId && "fillRef" == name)
        return (OpenXmlElement) new FillReference();
      if (10 == (int) namespaceId && "cell3D" == name)
        return (OpenXmlElement) new Cell3DProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableCellStyle.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableCellStyle.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableCellBorders TableCellBorders
    {
      get
      {
        return this.GetElement<TableCellBorders>(0);
      }
      set
      {
        this.SetElement<TableCellBorders>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCellStyle>(deep);
    }
  }
}
