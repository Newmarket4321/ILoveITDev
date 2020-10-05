// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.MarkerType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (RowId))]
  [ChildElementInfo(typeof (RowOffset))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ColumnId))]
  [ChildElementInfo(typeof (ColumnOffset))]
  public abstract class MarkerType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "col",
      "colOff",
      "row",
      "rowOff"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "col" == name)
        return (OpenXmlElement) new ColumnId();
      if (18 == (int) namespaceId && "colOff" == name)
        return (OpenXmlElement) new ColumnOffset();
      if (18 == (int) namespaceId && "row" == name)
        return (OpenXmlElement) new RowId();
      if (18 == (int) namespaceId && "rowOff" == name)
        return (OpenXmlElement) new RowOffset();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MarkerType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MarkerType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ColumnId ColumnId
    {
      get
      {
        return this.GetElement<ColumnId>(0);
      }
      set
      {
        this.SetElement<ColumnId>(0, value);
      }
    }

    public ColumnOffset ColumnOffset
    {
      get
      {
        return this.GetElement<ColumnOffset>(1);
      }
      set
      {
        this.SetElement<ColumnOffset>(1, value);
      }
    }

    public RowId RowId
    {
      get
      {
        return this.GetElement<RowId>(2);
      }
      set
      {
        this.SetElement<RowId>(2, value);
      }
    }

    public RowOffset RowOffset
    {
      get
      {
        return this.GetElement<RowOffset>(3);
      }
      set
      {
        this.SetElement<RowOffset>(3, value);
      }
    }

    protected MarkerType()
    {
    }

    protected MarkerType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected MarkerType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected MarkerType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
