// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLBorder
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLBorder : IEquatable<IXLBorder>
  {
    XLBorderStyleValues OutsideBorder { set; }

    XLColor OutsideBorderColor { set; }

    XLBorderStyleValues InsideBorder { set; }

    XLColor InsideBorderColor { set; }

    XLBorderStyleValues LeftBorder { get; set; }

    XLColor LeftBorderColor { get; set; }

    XLBorderStyleValues RightBorder { get; set; }

    XLColor RightBorderColor { get; set; }

    XLBorderStyleValues TopBorder { get; set; }

    XLColor TopBorderColor { get; set; }

    XLBorderStyleValues BottomBorder { get; set; }

    XLColor BottomBorderColor { get; set; }

    bool DiagonalUp { get; set; }

    bool DiagonalDown { get; set; }

    XLBorderStyleValues DiagonalBorder { get; set; }

    XLColor DiagonalBorderColor { get; set; }

    IXLStyle SetOutsideBorder(XLBorderStyleValues value);

    IXLStyle SetOutsideBorderColor(XLColor value);

    IXLStyle SetInsideBorder(XLBorderStyleValues value);

    IXLStyle SetInsideBorderColor(XLColor value);

    IXLStyle SetLeftBorder(XLBorderStyleValues value);

    IXLStyle SetLeftBorderColor(XLColor value);

    IXLStyle SetRightBorder(XLBorderStyleValues value);

    IXLStyle SetRightBorderColor(XLColor value);

    IXLStyle SetTopBorder(XLBorderStyleValues value);

    IXLStyle SetTopBorderColor(XLColor value);

    IXLStyle SetBottomBorder(XLBorderStyleValues value);

    IXLStyle SetBottomBorderColor(XLColor value);

    IXLStyle SetDiagonalUp();

    IXLStyle SetDiagonalUp(bool value);

    IXLStyle SetDiagonalDown();

    IXLStyle SetDiagonalDown(bool value);

    IXLStyle SetDiagonalBorder(XLBorderStyleValues value);

    IXLStyle SetDiagonalBorderColor(XLColor value);
  }
}
