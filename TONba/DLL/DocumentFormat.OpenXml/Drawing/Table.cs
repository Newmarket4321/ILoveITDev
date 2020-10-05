// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Table
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TableGrid))]
  [ChildElementInfo(typeof (TableRow))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TableProperties))]
  public class Table : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "tblPr",
      "tblGrid",
      "tr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "tbl";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10125;

    public override string LocalName
    {
      get
      {
        return "tbl";
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
        return 10125;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Table()
    {
    }

    public Table(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Table(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Table(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tblPr" == name)
        return (OpenXmlElement) new TableProperties();
      if (10 == (int) namespaceId && "tblGrid" == name)
        return (OpenXmlElement) new TableGrid();
      if (10 == (int) namespaceId && "tr" == name)
        return (OpenXmlElement) new TableRow();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Table.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Table.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableProperties TableProperties
    {
      get
      {
        return this.GetElement<TableProperties>(0);
      }
      set
      {
        this.SetElement<TableProperties>(0, value);
      }
    }

    public TableGrid TableGrid
    {
      get
      {
        return this.GetElement<TableGrid>(1);
      }
      set
      {
        this.SetElement<TableGrid>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Table>(deep);
    }
  }
}
