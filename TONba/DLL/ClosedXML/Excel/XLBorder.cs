// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLBorder
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLBorder : IXLBorder, IEquatable<IXLBorder>
  {
    private readonly IXLStylized _container;
    private XLBorderStyleValues _bottomBorder;
    private XLColor _bottomBorderColor;
    private XLBorderStyleValues _diagonalBorder;
    private XLColor _diagonalBorderColor;
    private bool _diagonalDown;
    private bool _diagonalUp;
    private XLBorderStyleValues _leftBorder;
    private XLColor _leftBorderColor;
    private XLBorderStyleValues _rightBorder;
    private XLColor _rightBorderColor;
    private XLBorderStyleValues _topBorder;
    private XLColor _topBorderColor;
    public bool LeftBorderModified;
    public bool LeftBorderColorModified;
    public bool RightBorderModified;
    public bool RightBorderColorModified;
    public bool TopBorderModified;
    public bool TopBorderColorModified;
    public bool BottomBorderModified;
    public bool BottomBorderColorModified;
    public bool DiagonalBorderModified;
    public bool DiagonalBorderColorModified;
    public bool DiagonalUpModified;
    public bool DiagonalDownModified;

    public XLBorder()
      : this((IXLStylized) null, XLWorkbook.DefaultStyle.Border, true)
    {
    }

    public XLBorder(IXLStylized container, IXLBorder defaultBorder, bool useDefaultModify = true)
    {
      this._container = container;
      if (defaultBorder == null)
        return;
      this._leftBorder = defaultBorder.LeftBorder;
      this._leftBorderColor = defaultBorder.LeftBorderColor;
      this._rightBorder = defaultBorder.RightBorder;
      this._rightBorderColor = defaultBorder.RightBorderColor;
      this._topBorder = defaultBorder.TopBorder;
      this._topBorderColor = defaultBorder.TopBorderColor;
      this._bottomBorder = defaultBorder.BottomBorder;
      this._bottomBorderColor = defaultBorder.BottomBorderColor;
      this._diagonalBorder = defaultBorder.DiagonalBorder;
      this._diagonalBorderColor = defaultBorder.DiagonalBorderColor;
      this._diagonalUp = defaultBorder.DiagonalUp;
      this._diagonalDown = defaultBorder.DiagonalDown;
      if (!useDefaultModify)
        return;
      XLBorder xlBorder = defaultBorder as XLBorder;
      this.BottomBorderColorModified = xlBorder.BottomBorderColorModified;
      this.BottomBorderModified = xlBorder.BottomBorderModified;
      this.DiagonalBorderColorModified = xlBorder.DiagonalBorderColorModified;
      this.DiagonalBorderModified = xlBorder.DiagonalBorderModified;
      this.DiagonalDownModified = xlBorder.DiagonalDownModified;
      this.DiagonalUpModified = xlBorder.DiagonalUpModified;
      this.LeftBorderColorModified = xlBorder.LeftBorderColorModified;
      this.LeftBorderModified = xlBorder.LeftBorderModified;
      this.RightBorderColorModified = xlBorder.RightBorderColorModified;
      this.RightBorderModified = xlBorder.RightBorderModified;
      this.TopBorderColorModified = xlBorder.TopBorderColorModified;
      this.TopBorderModified = xlBorder.TopBorderModified;
    }

    public XLBorderStyleValues OutsideBorder
    {
      set
      {
        if (this._container == null || this._container.UpdatingStyle)
          return;
        if (this._container is XLWorksheet || this._container is XLConditionalFormat)
        {
          this._container.Style.Border.SetTopBorder(value);
          this._container.Style.Border.SetBottomBorder(value);
          this._container.Style.Border.SetLeftBorder(value);
          this._container.Style.Border.SetRightBorder(value);
        }
        else
        {
          foreach (IXLRange xlRange in (IEnumerable<IXLRange>) this._container.RangesUsed)
          {
            xlRange.FirstColumn((Func<IXLRangeColumn, bool>) null).Style.Border.LeftBorder = value;
            xlRange.LastColumn((Func<IXLRangeColumn, bool>) null).Style.Border.RightBorder = value;
            xlRange.FirstRow((Func<IXLRangeRow, bool>) null).Style.Border.TopBorder = value;
            xlRange.LastRow((Func<IXLRangeRow, bool>) null).Style.Border.BottomBorder = value;
          }
        }
      }
    }

    public XLColor OutsideBorderColor
    {
      set
      {
        if (this._container == null || this._container.UpdatingStyle)
          return;
        if (this._container is XLWorksheet || this._container is XLConditionalFormat)
        {
          this._container.Style.Border.SetTopBorderColor(value);
          this._container.Style.Border.SetBottomBorderColor(value);
          this._container.Style.Border.SetLeftBorderColor(value);
          this._container.Style.Border.SetRightBorderColor(value);
        }
        else
        {
          foreach (IXLRange xlRange in (IEnumerable<IXLRange>) this._container.RangesUsed)
          {
            xlRange.FirstColumn((Func<IXLRangeColumn, bool>) null).Style.Border.LeftBorderColor = value;
            xlRange.LastColumn((Func<IXLRangeColumn, bool>) null).Style.Border.RightBorderColor = value;
            xlRange.FirstRow((Func<IXLRangeRow, bool>) null).Style.Border.TopBorderColor = value;
            xlRange.LastRow((Func<IXLRangeRow, bool>) null).Style.Border.BottomBorderColor = value;
          }
        }
      }
    }

    public XLBorderStyleValues InsideBorder
    {
      set
      {
        if (this._container == null || this._container.UpdatingStyle)
          return;
        XLWorksheet container = this._container as XLWorksheet;
        if (container != null)
        {
          container.Style.Border.SetTopBorder(value);
          container.Style.Border.SetBottomBorder(value);
          container.Style.Border.SetLeftBorder(value);
          container.Style.Border.SetRightBorder(value);
        }
        else
        {
          foreach (IXLRange xlRange in (IEnumerable<IXLRange>) this._container.RangesUsed)
          {
            IXLRange r = xlRange;
            Dictionary<int, XLBorderStyleValues> topBorders = new Dictionary<int, XLBorderStyleValues>();
            r.FirstRow((Func<IXLRangeRow, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => topBorders.Add(c.Address.ColumnNumber - r.RangeAddress.FirstAddress.ColumnNumber + 1, c.Style.Border.TopBorder)));
            Dictionary<int, XLBorderStyleValues> bottomBorders = new Dictionary<int, XLBorderStyleValues>();
            r.LastRow((Func<IXLRangeRow, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => bottomBorders.Add(c.Address.ColumnNumber - r.RangeAddress.FirstAddress.ColumnNumber + 1, c.Style.Border.BottomBorder)));
            Dictionary<int, XLBorderStyleValues> leftBorders = new Dictionary<int, XLBorderStyleValues>();
            r.FirstColumn((Func<IXLRangeColumn, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => leftBorders.Add(c.Address.RowNumber - r.RangeAddress.FirstAddress.RowNumber + 1, c.Style.Border.LeftBorder)));
            Dictionary<int, XLBorderStyleValues> rightBorders = new Dictionary<int, XLBorderStyleValues>();
            r.LastColumn((Func<IXLRangeColumn, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => rightBorders.Add(c.Address.RowNumber - r.RangeAddress.FirstAddress.RowNumber + 1, c.Style.Border.RightBorder)));
            r.Cells().Style.Border.OutsideBorder = value;
            topBorders.ForEach<KeyValuePair<int, XLBorderStyleValues>>((Action<KeyValuePair<int, XLBorderStyleValues>>) (kp => r.FirstRow((Func<IXLRangeRow, bool>) null).Cell(kp.Key).Style.Border.TopBorder = kp.Value));
            bottomBorders.ForEach<KeyValuePair<int, XLBorderStyleValues>>((Action<KeyValuePair<int, XLBorderStyleValues>>) (kp => r.LastRow((Func<IXLRangeRow, bool>) null).Cell(kp.Key).Style.Border.BottomBorder = kp.Value));
            leftBorders.ForEach<KeyValuePair<int, XLBorderStyleValues>>((Action<KeyValuePair<int, XLBorderStyleValues>>) (kp => r.FirstColumn((Func<IXLRangeColumn, bool>) null).Cell(kp.Key).Style.Border.LeftBorder = kp.Value));
            rightBorders.ForEach<KeyValuePair<int, XLBorderStyleValues>>((Action<KeyValuePair<int, XLBorderStyleValues>>) (kp => r.LastColumn((Func<IXLRangeColumn, bool>) null).Cell(kp.Key).Style.Border.RightBorder = kp.Value));
          }
        }
      }
    }

    public XLColor InsideBorderColor
    {
      set
      {
        if (this._container == null || this._container.UpdatingStyle)
          return;
        XLWorksheet container = this._container as XLWorksheet;
        if (container != null)
        {
          container.Style.Border.SetTopBorderColor(value);
          container.Style.Border.SetBottomBorderColor(value);
          container.Style.Border.SetLeftBorderColor(value);
          container.Style.Border.SetRightBorderColor(value);
        }
        else
        {
          foreach (IXLRange xlRange in (IEnumerable<IXLRange>) this._container.RangesUsed)
          {
            IXLRange r = xlRange;
            Dictionary<int, XLColor> topBorders = new Dictionary<int, XLColor>();
            r.FirstRow((Func<IXLRangeRow, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => topBorders.Add(c.Address.ColumnNumber - r.RangeAddress.FirstAddress.ColumnNumber + 1, c.Style.Border.TopBorderColor)));
            Dictionary<int, XLColor> bottomBorders = new Dictionary<int, XLColor>();
            r.LastRow((Func<IXLRangeRow, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => bottomBorders.Add(c.Address.ColumnNumber - r.RangeAddress.FirstAddress.ColumnNumber + 1, c.Style.Border.BottomBorderColor)));
            Dictionary<int, XLColor> leftBorders = new Dictionary<int, XLColor>();
            r.FirstColumn((Func<IXLRangeColumn, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => leftBorders.Add(c.Address.RowNumber - r.RangeAddress.FirstAddress.RowNumber + 1, c.Style.Border.LeftBorderColor)));
            Dictionary<int, XLColor> rightBorders = new Dictionary<int, XLColor>();
            r.LastColumn((Func<IXLRangeColumn, bool>) null).Cells().ForEach<IXLCell>((Action<IXLCell>) (c => rightBorders.Add(c.Address.RowNumber - r.RangeAddress.FirstAddress.RowNumber + 1, c.Style.Border.RightBorderColor)));
            r.Cells().Style.Border.OutsideBorderColor = value;
            topBorders.ForEach<KeyValuePair<int, XLColor>>((Action<KeyValuePair<int, XLColor>>) (kp => r.FirstRow((Func<IXLRangeRow, bool>) null).Cell(kp.Key).Style.Border.TopBorderColor = kp.Value));
            bottomBorders.ForEach<KeyValuePair<int, XLColor>>((Action<KeyValuePair<int, XLColor>>) (kp => r.LastRow((Func<IXLRangeRow, bool>) null).Cell(kp.Key).Style.Border.BottomBorderColor = kp.Value));
            leftBorders.ForEach<KeyValuePair<int, XLColor>>((Action<KeyValuePair<int, XLColor>>) (kp => r.FirstColumn((Func<IXLRangeColumn, bool>) null).Cell(kp.Key).Style.Border.LeftBorderColor = kp.Value));
            rightBorders.ForEach<KeyValuePair<int, XLColor>>((Action<KeyValuePair<int, XLColor>>) (kp => r.LastColumn((Func<IXLRangeColumn, bool>) null).Cell(kp.Key).Style.Border.RightBorderColor = kp.Value));
          }
        }
      }
    }

    public XLBorderStyleValues LeftBorder
    {
      get
      {
        return this._leftBorder;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.LeftBorder = value));
        }
        else
        {
          this._leftBorder = value;
          this.LeftBorderModified = true;
        }
      }
    }

    public XLColor LeftBorderColor
    {
      get
      {
        return this._leftBorderColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.LeftBorderColor = value));
        }
        else
        {
          this._leftBorderColor = value;
          this.LeftBorderColorModified = true;
        }
      }
    }

    public XLBorderStyleValues RightBorder
    {
      get
      {
        return this._rightBorder;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.RightBorder = value));
        }
        else
        {
          this._rightBorder = value;
          this.RightBorderModified = true;
        }
      }
    }

    public XLColor RightBorderColor
    {
      get
      {
        return this._rightBorderColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.RightBorderColor = value));
        }
        else
        {
          this._rightBorderColor = value;
          this.RightBorderColorModified = true;
        }
      }
    }

    public XLBorderStyleValues TopBorder
    {
      get
      {
        return this._topBorder;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.TopBorder = value));
        }
        else
        {
          this._topBorder = value;
          this.TopBorderModified = true;
        }
      }
    }

    public XLColor TopBorderColor
    {
      get
      {
        return this._topBorderColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.TopBorderColor = value));
        }
        else
        {
          this._topBorderColor = value;
          this.TopBorderColorModified = true;
        }
      }
    }

    public XLBorderStyleValues BottomBorder
    {
      get
      {
        return this._bottomBorder;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.BottomBorder = value));
        }
        else
        {
          this._bottomBorder = value;
          this.BottomBorderModified = true;
        }
      }
    }

    public XLColor BottomBorderColor
    {
      get
      {
        return this._bottomBorderColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.BottomBorderColor = value));
        }
        else
        {
          this._bottomBorderColor = value;
          this.BottomBorderColorModified = true;
        }
      }
    }

    public XLBorderStyleValues DiagonalBorder
    {
      get
      {
        return this._diagonalBorder;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.DiagonalBorder = value));
        }
        else
        {
          this._diagonalBorder = value;
          this.DiagonalBorderModified = true;
        }
      }
    }

    public XLColor DiagonalBorderColor
    {
      get
      {
        return this._diagonalBorderColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.DiagonalBorderColor = value));
        }
        else
        {
          this._diagonalBorderColor = value;
          this.DiagonalBorderColorModified = true;
        }
      }
    }

    public bool DiagonalUp
    {
      get
      {
        return this._diagonalUp;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.DiagonalUp = value));
        }
        else
        {
          this._diagonalUp = value;
          this.DiagonalUpModified = true;
        }
      }
    }

    public bool DiagonalDown
    {
      get
      {
        return this._diagonalDown;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Border.DiagonalDown = value));
        }
        else
        {
          this._diagonalDown = value;
          this.DiagonalDownModified = true;
        }
      }
    }

    public bool Equals(IXLBorder other)
    {
      XLBorder xlBorder = other as XLBorder;
      if (this._leftBorder == xlBorder._leftBorder && this._leftBorderColor.Equals(xlBorder._leftBorderColor) && (this._rightBorder == xlBorder._rightBorder && this._rightBorderColor.Equals(xlBorder._rightBorderColor)) && (this._topBorder == xlBorder._topBorder && this._topBorderColor.Equals(xlBorder._topBorderColor) && (this._bottomBorder == xlBorder._bottomBorder && this._bottomBorderColor.Equals(xlBorder._bottomBorderColor))) && (this._diagonalBorder == xlBorder._diagonalBorder && this._diagonalBorderColor.Equals(xlBorder._diagonalBorderColor) && this._diagonalUp == xlBorder._diagonalUp))
        return this._diagonalDown == xlBorder._diagonalDown;
      return false;
    }

    public IXLStyle SetOutsideBorder(XLBorderStyleValues value)
    {
      this.OutsideBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetOutsideBorderColor(XLColor value)
    {
      this.OutsideBorderColor = value;
      return this._container.Style;
    }

    public IXLStyle SetInsideBorder(XLBorderStyleValues value)
    {
      this.InsideBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetInsideBorderColor(XLColor value)
    {
      this.InsideBorderColor = value;
      return this._container.Style;
    }

    public IXLStyle SetLeftBorder(XLBorderStyleValues value)
    {
      this.LeftBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetLeftBorderColor(XLColor value)
    {
      this.LeftBorderColor = value;
      return this._container.Style;
    }

    public IXLStyle SetRightBorder(XLBorderStyleValues value)
    {
      this.RightBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetRightBorderColor(XLColor value)
    {
      this.RightBorderColor = value;
      return this._container.Style;
    }

    public IXLStyle SetTopBorder(XLBorderStyleValues value)
    {
      this.TopBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetTopBorderColor(XLColor value)
    {
      this.TopBorderColor = value;
      return this._container.Style;
    }

    public IXLStyle SetBottomBorder(XLBorderStyleValues value)
    {
      this.BottomBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetBottomBorderColor(XLColor value)
    {
      this.BottomBorderColor = value;
      return this._container.Style;
    }

    public IXLStyle SetDiagonalUp()
    {
      this.DiagonalUp = true;
      return this._container.Style;
    }

    public IXLStyle SetDiagonalUp(bool value)
    {
      this.DiagonalUp = value;
      return this._container.Style;
    }

    public IXLStyle SetDiagonalDown()
    {
      this.DiagonalDown = true;
      return this._container.Style;
    }

    public IXLStyle SetDiagonalDown(bool value)
    {
      this.DiagonalDown = value;
      return this._container.Style;
    }

    public IXLStyle SetDiagonalBorder(XLBorderStyleValues value)
    {
      this.DiagonalBorder = value;
      return this._container.Style;
    }

    public IXLStyle SetDiagonalBorderColor(XLColor value)
    {
      this.DiagonalBorderColor = value;
      return this._container.Style;
    }

    private void SetStyleChanged()
    {
      if (this._container == null)
        return;
      this._container.StyleChanged = true;
    }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.LeftBorder.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.LeftBorderColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.RightBorder.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.RightBorderColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.TopBorder.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.TopBorderColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.BottomBorder.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.BottomBorderColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.DiagonalBorder.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.DiagonalBorderColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.DiagonalUp.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.DiagonalDown.ToString());
      return stringBuilder.ToString();
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLBorder) obj);
    }

    public override int GetHashCode()
    {
      return (int) (this.LeftBorder ^ (XLBorderStyleValues) this.LeftBorderColor.GetHashCode() ^ this.RightBorder ^ (XLBorderStyleValues) this.RightBorderColor.GetHashCode() ^ this.TopBorder ^ (XLBorderStyleValues) this.TopBorderColor.GetHashCode() ^ this.BottomBorder ^ (XLBorderStyleValues) this.BottomBorderColor.GetHashCode() ^ this.DiagonalBorder ^ (XLBorderStyleValues) this.DiagonalBorderColor.GetHashCode() ^ (XLBorderStyleValues) this.DiagonalUp.GetHashCode() ^ (XLBorderStyleValues) this.DiagonalDown.GetHashCode());
    }
  }
}
