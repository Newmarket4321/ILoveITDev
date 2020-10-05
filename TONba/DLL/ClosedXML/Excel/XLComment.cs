// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLComment
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLComment : XLFormattedText<IXLComment>, IXLComment, IXLFormattedText<IXLComment>, IEnumerable<IXLRichString>, IEnumerable, IEquatable<IXLFormattedText<IXLComment>>, IXLWithRichString, IXLDrawing<IXLComment>
  {
    private XLCell _cell;
    private bool _visible;

    public XLComment(XLCell cell, IXLFontBase defaultFont)
      : base(defaultFont)
    {
      this.Initialize(cell);
    }

    public XLComment(XLCell cell, XLFormattedText<IXLComment> defaultComment, IXLFontBase defaultFont)
      : base((IXLFormattedText<IXLComment>) defaultComment, defaultFont)
    {
      this.Initialize(cell);
    }

    public XLComment(XLCell cell, string text, IXLFontBase defaultFont)
      : base(text, defaultFont)
    {
      this.Initialize(cell);
    }

    public string Author { get; set; }

    public IXLComment SetAuthor(string value)
    {
      this.Author = value;
      return (IXLComment) this;
    }

    public IXLRichString AddSignature()
    {
      this.AddText(this.Author + ":").SetBold();
      return this.AddText(Environment.NewLine);
    }

    public void Delete()
    {
      this._cell.DeleteComment();
    }

    public string Name { get; set; }

    public string Description { get; set; }

    public XLDrawingAnchor Anchor { get; set; }

    public bool HorizontalFlip { get; set; }

    public bool VerticalFlip { get; set; }

    public int Rotation { get; set; }

    public int ExtentLength { get; set; }

    public int ExtentWidth { get; set; }

    public int ShapeId { get; internal set; }

    public bool Visible
    {
      get
      {
        return this._visible;
      }
      set
      {
        this._visible = value;
      }
    }

    public IXLComment SetVisible()
    {
      this.Visible = true;
      return this.Container;
    }

    public IXLComment SetVisible(bool hidden)
    {
      this.Visible = hidden;
      return this.Container;
    }

    public IXLDrawingPosition Position { get; private set; }

    public int ZOrder { get; set; }

    public IXLComment SetZOrder(int zOrder)
    {
      this.ZOrder = zOrder;
      return this.Container;
    }

    public IXLDrawingStyle Style { get; private set; }

    public IXLComment SetName(string name)
    {
      this.Name = name;
      return this.Container;
    }

    public IXLComment SetDescription(string description)
    {
      this.Description = description;
      return this.Container;
    }

    public IXLComment SetHorizontalFlip()
    {
      this.HorizontalFlip = true;
      return this.Container;
    }

    public IXLComment SetHorizontalFlip(bool horizontalFlip)
    {
      this.HorizontalFlip = horizontalFlip;
      return this.Container;
    }

    public IXLComment SetVerticalFlip()
    {
      this.VerticalFlip = true;
      return this.Container;
    }

    public IXLComment SetVerticalFlip(bool verticalFlip)
    {
      this.VerticalFlip = verticalFlip;
      return this.Container;
    }

    public IXLComment SetRotation(int rotation)
    {
      this.Rotation = rotation;
      return this.Container;
    }

    public IXLComment SetExtentLength(int extentLength)
    {
      this.ExtentLength = extentLength;
      return this.Container;
    }

    public IXLComment SetExtentWidth(int extentWidth)
    {
      this.ExtentWidth = extentWidth;
      return this.Container;
    }

    private void Initialize(XLCell cell)
    {
      this.Author = cell.Worksheet.Author;
      this.Container = (IXLComment) this;
      this.Anchor = XLDrawingAnchor.MoveAndSizeWithCells;
      this.Style = (IXLDrawingStyle) new XLDrawingStyle();
      int rowNumber = cell.Address.RowNumber;
      double num = 0.0;
      if (rowNumber > 1)
      {
        --rowNumber;
        double height = cell.CellAbove().WorksheetRow().Height;
        if (height > 7.0)
          num = height - 7.0;
      }
      this.Position = (IXLDrawingPosition) new XLDrawingPosition()
      {
        Column = (cell.Address.ColumnNumber + 1),
        ColumnOffset = 2.0,
        Row = rowNumber,
        RowOffset = num
      };
      this.ZOrder = cell.Worksheet.ZOrder++;
      this.Style.Margins.SetLeft(0.1).Margins.SetRight(0.1).Margins.SetTop(0.05).Margins.SetBottom(0.05).Margins.SetAutomatic().Size.SetHeight(59.25).Size.SetWidth(19.2).ColorsAndLines.SetLineColor(XLColor.Black).ColorsAndLines.SetFillColor(XLColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 225)).ColorsAndLines.SetLineDash(XLDashStyle.Solid).ColorsAndLines.SetLineStyle(XLLineStyle.Single).ColorsAndLines.SetLineWeight(0.75).ColorsAndLines.SetFillTransparency(1.0).ColorsAndLines.SetLineTransparency(1.0).Alignment.SetHorizontal(XLDrawingHorizontalAlignment.Left).Alignment.SetVertical(XLDrawingVerticalAlignment.Top).Alignment.SetDirection(XLDrawingTextDirection.Context).Alignment.SetOrientation(XLDrawingTextOrientation.LeftToRight).Properties.SetPositioning(XLDrawingAnchor.Absolute).Protection.SetLocked().Protection.SetLockText();
      this._cell = cell;
      this.ShapeId = cell.Worksheet.Workbook.ShapeIdManager.GetNext();
    }
  }
}
