// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLAlignment
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLAlignment : IXLAlignment, IEquatable<IXLAlignment>
  {
    private readonly IXLStylized _container;
    private XLAlignmentHorizontalValues _horizontal;
    private int _indent;
    private bool _justifyLastLine;
    private XLAlignmentReadingOrderValues _readingOrder;
    private int _relativeIndent;
    private bool _shrinkToFit;
    private int _textRotation;
    private XLAlignmentVerticalValues _vertical;
    private bool _wrapText;

    public XLAlignment()
      : this((IXLStylized) null, XLWorkbook.DefaultStyle.Alignment)
    {
    }

    public XLAlignment(IXLStylized container, IXLAlignment d = null)
    {
      this._container = container;
      if (d == null)
        return;
      this._horizontal = d.Horizontal;
      this._vertical = d.Vertical;
      this._indent = d.Indent;
      this._justifyLastLine = d.JustifyLastLine;
      this._readingOrder = d.ReadingOrder;
      this._relativeIndent = d.RelativeIndent;
      this._shrinkToFit = d.ShrinkToFit;
      this._textRotation = d.TextRotation;
      this._wrapText = d.WrapText;
    }

    public XLAlignmentHorizontalValues Horizontal
    {
      get
      {
        return this._horizontal;
      }
      set
      {
        this.SetStyleChanged();
        bool updateIndent = value != XLAlignmentHorizontalValues.Left && value != XLAlignmentHorizontalValues.Right && value != XLAlignmentHorizontalValues.Distributed;
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s =>
          {
            s.Alignment.Horizontal = value;
            if (!updateIndent)
              return;
            s.Alignment.Indent = 0;
          }));
        }
        else
        {
          this._horizontal = value;
          if (!updateIndent)
            return;
          this._indent = 0;
        }
      }
    }

    public XLAlignmentVerticalValues Vertical
    {
      get
      {
        return this._vertical;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.Vertical = value));
        else
          this._vertical = value;
      }
    }

    public int Indent
    {
      get
      {
        return this._indent;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.Indent = value));
        }
        else
        {
          if (this._indent == value)
            return;
          if (this._horizontal == XLAlignmentHorizontalValues.General)
            this._horizontal = XLAlignmentHorizontalValues.Left;
          if (value > 0 && this._horizontal != XLAlignmentHorizontalValues.Left && (this._horizontal != XLAlignmentHorizontalValues.Right && this._horizontal != XLAlignmentHorizontalValues.Distributed))
            throw new ArgumentException("For indents, only left, right, and distributed horizontal alignments are supported.");
          this._indent = value;
        }
      }
    }

    public bool JustifyLastLine
    {
      get
      {
        return this._justifyLastLine;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.JustifyLastLine = value));
        else
          this._justifyLastLine = value;
      }
    }

    public XLAlignmentReadingOrderValues ReadingOrder
    {
      get
      {
        return this._readingOrder;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.ReadingOrder = value));
        else
          this._readingOrder = value;
      }
    }

    public int RelativeIndent
    {
      get
      {
        return this._relativeIndent;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.RelativeIndent = value));
        else
          this._relativeIndent = value;
      }
    }

    public bool ShrinkToFit
    {
      get
      {
        return this._shrinkToFit;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.ShrinkToFit = value));
        else
          this._shrinkToFit = value;
      }
    }

    public int TextRotation
    {
      get
      {
        return this._textRotation;
      }
      set
      {
        this.SetStyleChanged();
        int rotation = value;
        if (rotation != (int) byte.MaxValue && (rotation < -90 || rotation > 180))
          throw new ArgumentException("TextRotation must be between -90 and 180 degrees, or 255.");
        if (rotation < 0)
          rotation = 90 + rotation * -1;
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.TextRotation = rotation));
        else
          this._textRotation = rotation;
      }
    }

    public bool WrapText
    {
      get
      {
        return this._wrapText;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.WrapText = value));
        else
          this._wrapText = value;
      }
    }

    public bool TopToBottom
    {
      get
      {
        return this._textRotation == (int) byte.MaxValue;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Alignment.TextRotation = value ? (int) byte.MaxValue : 0));
        else
          this._textRotation = value ? (int) byte.MaxValue : 0;
      }
    }

    public bool Equals(IXLAlignment other)
    {
      if (other == null)
        return false;
      XLAlignment xlAlignment = other as XLAlignment;
      if (xlAlignment == null || this._horizontal != xlAlignment._horizontal || (this._vertical != xlAlignment._vertical || this._indent != xlAlignment._indent) || (this._justifyLastLine != xlAlignment._justifyLastLine || this._readingOrder != xlAlignment._readingOrder || (this._relativeIndent != xlAlignment._relativeIndent || this._shrinkToFit != xlAlignment._shrinkToFit)) || this._textRotation != xlAlignment._textRotation)
        return false;
      return this._wrapText == xlAlignment._wrapText;
    }

    public IXLStyle SetHorizontal(XLAlignmentHorizontalValues value)
    {
      this.Horizontal = value;
      return this._container.Style;
    }

    public IXLStyle SetVertical(XLAlignmentVerticalValues value)
    {
      this.Vertical = value;
      return this._container.Style;
    }

    public IXLStyle SetIndent(int value)
    {
      this.Indent = value;
      return this._container.Style;
    }

    public IXLStyle SetJustifyLastLine()
    {
      this.JustifyLastLine = true;
      return this._container.Style;
    }

    public IXLStyle SetJustifyLastLine(bool value)
    {
      this.JustifyLastLine = value;
      return this._container.Style;
    }

    public IXLStyle SetReadingOrder(XLAlignmentReadingOrderValues value)
    {
      this.ReadingOrder = value;
      return this._container.Style;
    }

    public IXLStyle SetRelativeIndent(int value)
    {
      this.RelativeIndent = value;
      return this._container.Style;
    }

    public IXLStyle SetShrinkToFit()
    {
      this.ShrinkToFit = true;
      return this._container.Style;
    }

    public IXLStyle SetShrinkToFit(bool value)
    {
      this.ShrinkToFit = value;
      return this._container.Style;
    }

    public IXLStyle SetTextRotation(int value)
    {
      this.TextRotation = value;
      return this._container.Style;
    }

    public IXLStyle SetWrapText()
    {
      this.WrapText = true;
      return this._container.Style;
    }

    public IXLStyle SetWrapText(bool value)
    {
      this.WrapText = value;
      return this._container.Style;
    }

    public IXLStyle SetTopToBottom()
    {
      this.TopToBottom = true;
      return this._container.Style;
    }

    public IXLStyle SetTopToBottom(bool value)
    {
      this.TopToBottom = value;
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
      stringBuilder.Append((object) this.Horizontal);
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.Vertical);
      stringBuilder.Append("-");
      stringBuilder.Append(this.Indent);
      stringBuilder.Append("-");
      stringBuilder.Append(this.JustifyLastLine);
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.ReadingOrder);
      stringBuilder.Append("-");
      stringBuilder.Append(this.RelativeIndent);
      stringBuilder.Append("-");
      stringBuilder.Append(this.ShrinkToFit);
      stringBuilder.Append("-");
      stringBuilder.Append(this.TextRotation);
      stringBuilder.Append("-");
      stringBuilder.Append(this.WrapText);
      stringBuilder.Append("-");
      return stringBuilder.ToString();
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLAlignment) obj);
    }

    public override int GetHashCode()
    {
      return (int) ((XLAlignmentReadingOrderValues) (this.Horizontal ^ (XLAlignmentHorizontalValues) this.Vertical ^ (XLAlignmentHorizontalValues) this.Indent ^ (XLAlignmentHorizontalValues) this.JustifyLastLine.GetHashCode()) ^ this.ReadingOrder ^ (XLAlignmentReadingOrderValues) this.RelativeIndent ^ (XLAlignmentReadingOrderValues) this.ShrinkToFit.GetHashCode() ^ (XLAlignmentReadingOrderValues) this.TextRotation ^ (XLAlignmentReadingOrderValues) this.WrapText.GetHashCode());
    }
  }
}
