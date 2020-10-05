// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.XLCalcEngine
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel.CalcEngine
{
  internal class XLCalcEngine : ClosedXML.Excel.CalcEngine.CalcEngine
  {
    private readonly IXLWorksheet _ws;
    private readonly XLWorkbook _wb;

    public XLCalcEngine()
    {
    }

    public XLCalcEngine(XLWorkbook wb)
    {
      this._wb = wb;
      this.IdentifierChars = "$:!";
    }

    public XLCalcEngine(IXLWorksheet ws)
      : this(ws.Workbook)
    {
      this._ws = ws;
    }

    public override object GetExternalObject(string identifier)
    {
      if (identifier.Contains("!") && this._wb != null)
        return (object) new CellRangeReference(this._wb.Worksheet(identifier.Substring(0, identifier.IndexOf("!"))).Range(identifier.Substring(identifier.IndexOf("!") + 1)), this);
      if (this._ws != null)
        return (object) new CellRangeReference(this._ws.Range(identifier), this);
      return (object) identifier;
    }
  }
}
