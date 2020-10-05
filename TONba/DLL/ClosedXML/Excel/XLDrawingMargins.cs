// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingMargins
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingMargins : IXLDrawingMargins
  {
    private readonly IXLDrawingStyle _style;
    private double _left;
    private double _right;
    private double _top;
    private double _bottom;

    public XLDrawingMargins(IXLDrawingStyle style)
    {
      this._style = style;
    }

    public bool Automatic { get; set; }

    public IXLDrawingStyle SetAutomatic()
    {
      this.Automatic = true;
      return this._style;
    }

    public IXLDrawingStyle SetAutomatic(bool value)
    {
      this.Automatic = value;
      return this._style;
    }

    public double Left
    {
      get
      {
        return this._left;
      }
      set
      {
        this._left = value;
        this.Automatic = false;
      }
    }

    public IXLDrawingStyle SetLeft(double value)
    {
      this.Left = value;
      return this._style;
    }

    public double Right
    {
      get
      {
        return this._right;
      }
      set
      {
        this._right = value;
        this.Automatic = false;
      }
    }

    public IXLDrawingStyle SetRight(double value)
    {
      this.Right = value;
      return this._style;
    }

    public double Top
    {
      get
      {
        return this._top;
      }
      set
      {
        this._top = value;
        this.Automatic = false;
      }
    }

    public IXLDrawingStyle SetTop(double value)
    {
      this.Top = value;
      return this._style;
    }

    public double Bottom
    {
      get
      {
        return this._bottom;
      }
      set
      {
        this._bottom = value;
        this.Automatic = false;
      }
    }

    public IXLDrawingStyle SetBottom(double value)
    {
      this.Bottom = value;
      return this._style;
    }

    public double All
    {
      set
      {
        this._left = value;
        this._right = value;
        this._top = value;
        this._bottom = value;
        this.Automatic = false;
      }
    }

    public IXLDrawingStyle SetAll(double value)
    {
      this.All = value;
      return this._style;
    }
  }
}
