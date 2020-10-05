// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDrawingAlignment
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDrawingAlignment
  {
    XLDrawingHorizontalAlignment Horizontal { get; set; }

    XLDrawingVerticalAlignment Vertical { get; set; }

    bool AutomaticSize { get; set; }

    XLDrawingTextDirection Direction { get; set; }

    XLDrawingTextOrientation Orientation { get; set; }

    IXLDrawingStyle SetHorizontal(XLDrawingHorizontalAlignment value);

    IXLDrawingStyle SetVertical(XLDrawingVerticalAlignment value);

    IXLDrawingStyle SetAutomaticSize();

    IXLDrawingStyle SetAutomaticSize(bool value);

    IXLDrawingStyle SetDirection(XLDrawingTextDirection value);

    IXLDrawingStyle SetOrientation(XLDrawingTextOrientation value);
  }
}
