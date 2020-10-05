// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLProtection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLProtection : IXLProtection, IEquatable<IXLProtection>
  {
    private readonly IXLStylized _container;
    private bool _hidden;
    private bool _locked;

    public bool Locked
    {
      get
      {
        return this._locked;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Protection.Locked = value));
        else
          this._locked = value;
      }
    }

    public bool Hidden
    {
      get
      {
        return this._hidden;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Protection.Hidden = value));
        else
          this._hidden = value;
      }
    }

    public bool Equals(IXLProtection other)
    {
      XLProtection xlProtection = other as XLProtection;
      if (xlProtection == null || this._locked != xlProtection._locked)
        return false;
      return this._hidden == xlProtection._hidden;
    }

    public IXLStyle SetLocked()
    {
      this.Locked = true;
      return this._container.Style;
    }

    public IXLStyle SetLocked(bool value)
    {
      this.Locked = value;
      return this._container.Style;
    }

    public IXLStyle SetHidden()
    {
      this.Hidden = true;
      return this._container.Style;
    }

    public IXLStyle SetHidden(bool value)
    {
      this.Hidden = value;
      return this._container.Style;
    }

    public XLProtection()
      : this((IXLStylized) null, XLWorkbook.DefaultStyle.Protection)
    {
    }

    public XLProtection(IXLStylized container, IXLProtection defaultProtection = null)
    {
      this._container = container;
      if (defaultProtection == null)
        return;
      this._locked = defaultProtection.Locked;
      this._hidden = defaultProtection.Hidden;
    }

    private void SetStyleChanged()
    {
      if (this._container == null)
        return;
      this._container.StyleChanged = true;
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLProtection) obj);
    }

    public override int GetHashCode()
    {
      if (this.Locked)
        return !this.Hidden ? 10 : 11;
      return !this.Hidden ? 0 : 1;
    }

    public override string ToString()
    {
      if (this.Locked)
        return !this.Hidden ? "Locked" : "Locked-Hidden";
      return !this.Hidden ? "None" : "Hidden";
    }
  }
}
