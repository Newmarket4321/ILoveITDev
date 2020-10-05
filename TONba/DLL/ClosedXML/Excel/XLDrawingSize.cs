// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingSize
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingSize : IXLDrawingSize
  {
    private readonly IXLDrawingStyle _style;

    public XLDrawingSize(IXLDrawingStyle style)
    {
      this._style = style;
    }

    public bool AutomaticSize
    {
      get
      {
        return this._style.Alignment.AutomaticSize;
      }
      set
      {
        this._style.Alignment.AutomaticSize = value;
      }
    }

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

    public double Height { get; set; }

    public IXLDrawingStyle SetHeight(double value)
    {
      this.Height = value;
      return this._style;
    }

    public double Width { get; set; }

    public IXLDrawingStyle SetWidth(double value)
    {
      this.Width = value;
      return this._style;
    }
  }
}
