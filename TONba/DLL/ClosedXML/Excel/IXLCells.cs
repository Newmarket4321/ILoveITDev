// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLCells
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLCells : IEnumerable<IXLCell>, IEnumerable
  {
    object Value { set; }

    XLCellValues DataType { set; }

    IXLCells SetDataType(XLCellValues dataType);

    IXLCells Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void DeleteComments();

    string FormulaA1 { set; }

    string FormulaR1C1 { set; }

    IXLStyle Style { get; set; }

    void Select();
  }
}
