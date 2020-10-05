﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TablePartStyleType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TableCellTextStyle))]
  [ChildElementInfo(typeof (TableCellStyle))]
  public abstract class TablePartStyleType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "tcTxStyle",
      "tcStyle"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tcTxStyle" == name)
        return (OpenXmlElement) new TableCellTextStyle();
      if (10 == (int) namespaceId && "tcStyle" == name)
        return (OpenXmlElement) new TableCellStyle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TablePartStyleType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TablePartStyleType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableCellTextStyle TableCellTextStyle
    {
      get
      {
        return this.GetElement<TableCellTextStyle>(0);
      }
      set
      {
        this.SetElement<TableCellTextStyle>(0, value);
      }
    }

    public TableCellStyle TableCellStyle
    {
      get
      {
        return this.GetElement<TableCellStyle>(1);
      }
      set
      {
        this.SetElement<TableCellStyle>(1, value);
      }
    }

    protected TablePartStyleType()
    {
    }

    protected TablePartStyleType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TablePartStyleType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TablePartStyleType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
