// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLHFItem
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLHFItem : IXLHFItem, IXLWithRichString
  {
    private readonly Dictionary<XLHFOccurrence, List<XLHFText>> texts = new Dictionary<XLHFOccurrence, List<XLHFText>>();
    private readonly XLWorksheet _worksheet;

    public XLHFItem(XLWorksheet worksheet)
    {
      this._worksheet = worksheet;
    }

    public XLHFItem(XLHFItem defaultHFItem, XLWorksheet worksheet)
      : this(worksheet)
    {
      defaultHFItem.texts.ForEach<KeyValuePair<XLHFOccurrence, List<XLHFText>>>((Action<KeyValuePair<XLHFOccurrence, List<XLHFText>>>) (kp => this.texts.Add(kp.Key, kp.Value)));
    }

    public string GetText(XLHFOccurrence occurrence)
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (this.texts.ContainsKey(occurrence))
      {
        foreach (XLHFText xlhfText in this.texts[occurrence])
          stringBuilder.Append(xlhfText.GetHFText(stringBuilder.ToString()));
      }
      return stringBuilder.ToString();
    }

    public IXLRichString AddText(string text)
    {
      return this.AddText(text, XLHFOccurrence.AllPages);
    }

    public IXLRichString AddText(XLHFPredefinedText predefinedText)
    {
      return this.AddText(predefinedText, XLHFOccurrence.AllPages);
    }

    public IXLRichString AddText(string text, XLHFOccurrence occurrence)
    {
      XLRichString richText = new XLRichString(text, (IXLFontBase) XLWorkbook.DefaultStyle.Font, (IXLWithRichString) this);
      XLHFText hfText = new XLHFText(richText, this._worksheet);
      if (occurrence == XLHFOccurrence.AllPages)
      {
        this.AddTextToOccurrence(hfText, XLHFOccurrence.EvenPages);
        this.AddTextToOccurrence(hfText, XLHFOccurrence.FirstPage);
        this.AddTextToOccurrence(hfText, XLHFOccurrence.OddPages);
      }
      else
        this.AddTextToOccurrence(hfText, occurrence);
      return (IXLRichString) richText;
    }

    public IXLRichString AddNewLine()
    {
      return this.AddText(Environment.NewLine);
    }

    public IXLRichString AddImage(string imagePath, XLHFOccurrence occurrence = XLHFOccurrence.AllPages)
    {
      throw new NotImplementedException();
    }

    private void AddTextToOccurrence(XLHFText hfText, XLHFOccurrence occurrence)
    {
      if (this.texts.ContainsKey(occurrence))
        this.texts[occurrence].Add(hfText);
      else
        this.texts.Add(occurrence, new List<XLHFText>()
        {
          hfText
        });
    }

    public IXLRichString AddText(XLHFPredefinedText predefinedText, XLHFOccurrence occurrence)
    {
      string text;
      switch (predefinedText)
      {
        case XLHFPredefinedText.PageNumber:
          text = "&P";
          break;
        case XLHFPredefinedText.NumberOfPages:
          text = "&N";
          break;
        case XLHFPredefinedText.Date:
          text = "&D";
          break;
        case XLHFPredefinedText.Time:
          text = "&T";
          break;
        case XLHFPredefinedText.FullPath:
          text = "&Z&F";
          break;
        case XLHFPredefinedText.Path:
          text = "&Z";
          break;
        case XLHFPredefinedText.File:
          text = "&F";
          break;
        case XLHFPredefinedText.SheetName:
          text = "&A";
          break;
        default:
          throw new NotImplementedException();
      }
      return this.AddText(text, occurrence);
    }

    public void Clear(XLHFOccurrence occurrence = XLHFOccurrence.AllPages)
    {
      if (occurrence == XLHFOccurrence.AllPages)
      {
        this.ClearOccurrence(XLHFOccurrence.EvenPages);
        this.ClearOccurrence(XLHFOccurrence.FirstPage);
        this.ClearOccurrence(XLHFOccurrence.OddPages);
      }
      else
        this.ClearOccurrence(occurrence);
    }

    private void ClearOccurrence(XLHFOccurrence occurrence)
    {
      if (!this.texts.ContainsKey(occurrence))
        return;
      this.texts.Remove(occurrence);
    }
  }
}
