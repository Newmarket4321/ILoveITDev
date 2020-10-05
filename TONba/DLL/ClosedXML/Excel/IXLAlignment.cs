// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLAlignment
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLAlignment : IEquatable<IXLAlignment>
  {
    XLAlignmentHorizontalValues Horizontal { get; set; }

    XLAlignmentVerticalValues Vertical { get; set; }

    int Indent { get; set; }

    bool JustifyLastLine { get; set; }

    XLAlignmentReadingOrderValues ReadingOrder { get; set; }

    int RelativeIndent { get; set; }

    bool ShrinkToFit { get; set; }

    int TextRotation { get; set; }

    bool WrapText { get; set; }

    bool TopToBottom { get; set; }

    IXLStyle SetHorizontal(XLAlignmentHorizontalValues value);

    IXLStyle SetVertical(XLAlignmentVerticalValues value);

    IXLStyle SetIndent(int value);

    IXLStyle SetJustifyLastLine();

    IXLStyle SetJustifyLastLine(bool value);

    IXLStyle SetReadingOrder(XLAlignmentReadingOrderValues value);

    IXLStyle SetRelativeIndent(int value);

    IXLStyle SetShrinkToFit();

    IXLStyle SetShrinkToFit(bool value);

    IXLStyle SetTextRotation(int value);

    IXLStyle SetWrapText();

    IXLStyle SetWrapText(bool value);

    IXLStyle SetTopToBottom();

    IXLStyle SetTopToBottom(bool value);
  }
}
