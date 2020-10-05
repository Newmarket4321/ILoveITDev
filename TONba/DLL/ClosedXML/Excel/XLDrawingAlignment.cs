// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingAlignment
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingAlignment : IXLDrawingAlignment
  {
    private readonly IXLDrawingStyle _style;

    public XLDrawingAlignment(IXLDrawingStyle style)
    {
      this._style = style;
    }

    public XLDrawingHorizontalAlignment Horizontal { get; set; }

    public IXLDrawingStyle SetHorizontal(XLDrawingHorizontalAlignment value)
    {
      this.Horizontal = value;
      return this._style;
    }

    public XLDrawingVerticalAlignment Vertical { get; set; }

    public IXLDrawingStyle SetVertical(XLDrawingVerticalAlignment value)
    {
      this.Vertical = value;
      return this._style;
    }

    public bool AutomaticSize { get; set; }

    public IXLDrawingStyle SetAutomaticSize()
    {
      this.AutomaticSize = true;
      return this._style;
    }

    public IXLDrawingStyle SetAutomaticSize(bool value)
    {
      this.AutomaticSize = value;
      return this._style;
    }

    public XLDrawingTextDirection Direction { get; set; }

    public IXLDrawingStyle SetDirection(XLDrawingTextDirection value)
    {
      this.Direction = value;
      return this._style;
    }

    public XLDrawingTextOrientation Orientation { get; set; }

    public IXLDrawingStyle SetOrientation(XLDrawingTextOrientation value)
    {
      this.Orientation = value;
      return this._style;
    }
  }
}
