// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLHeaderFooter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLHeaderFooter : IXLHeaderFooter
  {
    private Dictionary<XLHFOccurrence, string> innerTexts = new Dictionary<XLHFOccurrence, string>();
    private Dictionary<XLHFOccurrence, string> _initialTexts;
    private bool _changed;

    public XLHeaderFooter(XLWorksheet worksheet)
    {
      this.Left = (IXLHFItem) new XLHFItem(worksheet);
      this.Right = (IXLHFItem) new XLHFItem(worksheet);
      this.Center = (IXLHFItem) new XLHFItem(worksheet);
      this.SetAsInitial();
    }

    public XLHeaderFooter(XLHeaderFooter defaultHF, XLWorksheet worksheet)
    {
      defaultHF.innerTexts.ForEach<KeyValuePair<XLHFOccurrence, string>>((Action<KeyValuePair<XLHFOccurrence, string>>) (kp => this.innerTexts.Add(kp.Key, kp.Value)));
      this.Left = (IXLHFItem) new XLHFItem(defaultHF.Left as XLHFItem, worksheet);
      this.Center = (IXLHFItem) new XLHFItem(defaultHF.Center as XLHFItem, worksheet);
      this.Right = (IXLHFItem) new XLHFItem(defaultHF.Right as XLHFItem, worksheet);
      this.SetAsInitial();
    }

    public IXLHFItem Left { get; private set; }

    public IXLHFItem Center { get; private set; }

    public IXLHFItem Right { get; private set; }

    public string GetText(XLHFOccurrence occurrence)
    {
      if (this.innerTexts.ContainsKey(occurrence))
        return this.innerTexts[occurrence];
      string empty = string.Empty;
      string text1 = this.Left.GetText(occurrence);
      string text2 = this.Center.GetText(occurrence);
      string text3 = this.Right.GetText(occurrence);
      string str = empty + (text1.Length > 0 ? "&L" + text1 : string.Empty) + (text2.Length > 0 ? "&C" + text2 : string.Empty) + (text3.Length > 0 ? "&R" + text3 : string.Empty);
      if (str.Length > (int) byte.MaxValue)
        throw new ArgumentOutOfRangeException("Headers and Footers cannot be longer than 255 characters (including style markups)");
      return str;
    }

    internal string SetInnerText(XLHFOccurrence occurrence, string text)
    {
      if (this.innerTexts.ContainsKey(occurrence))
        this.innerTexts[occurrence] = text;
      else
        this.innerTexts.Add(occurrence, text);
      return this.innerTexts[occurrence];
    }

    internal bool Changed
    {
      get
      {
        if (!this._changed)
          return this._initialTexts.Any<KeyValuePair<XLHFOccurrence, string>>((Func<KeyValuePair<XLHFOccurrence, string>, bool>) (it => this.GetText(it.Key) != it.Value));
        return true;
      }
      set
      {
        this._changed = value;
      }
    }

    internal void SetAsInitial()
    {
      this._initialTexts = new Dictionary<XLHFOccurrence, string>();
      foreach (XLHFOccurrence xlhfOccurrence in Enum.GetValues(typeof (XLHFOccurrence)).Cast<XLHFOccurrence>())
        this._initialTexts.Add(xlhfOccurrence, this.GetText(xlhfOccurrence));
    }

    public IXLHeaderFooter Clear(XLHFOccurrence occurrence = XLHFOccurrence.AllPages)
    {
      this.Left.Clear(occurrence);
      this.Right.Clear(occurrence);
      this.Center.Clear(occurrence);
      return (IXLHeaderFooter) this;
    }
  }
}
