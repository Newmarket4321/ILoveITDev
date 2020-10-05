// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingProtection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingProtection : IXLDrawingProtection
  {
    private readonly IXLDrawingStyle _style;

    public XLDrawingProtection(IXLDrawingStyle style)
    {
      this._style = style;
    }

    public bool Locked { get; set; }

    public IXLDrawingStyle SetLocked()
    {
      this.Locked = true;
      return this._style;
    }

    public IXLDrawingStyle SetLocked(bool value)
    {
      this.Locked = value;
      return this._style;
    }

    public bool LockText { get; set; }

    public IXLDrawingStyle SetLockText()
    {
      this.LockText = true;
      return this._style;
    }

    public IXLDrawingStyle SetLockText(bool value)
    {
      this.LockText = value;
      return this._style;
    }
  }
}
