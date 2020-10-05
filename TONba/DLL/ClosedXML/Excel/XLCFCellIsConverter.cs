// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFCellIsConverter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ClosedXML.Excel
{
  internal class XLCFCellIsConverter : IXLCFConverter
  {
    public ConditionalFormattingRule Convert(IXLConditionalFormat cf, int priority, XLWorkbook.SaveContext context)
    {
      string quoted = this.GetQuoted(cf.Values[1]);
      ConditionalFormattingRule conditionalFormattingRule = new ConditionalFormattingRule()
      {
        FormatId = (UInt32Value) ((uint) context.DifferentialFormats[cf.Style]),
        Operator = (EnumValue<ConditionalFormattingOperatorValues>) cf.Operator.ToOpenXml(),
        Type = (EnumValue<ConditionalFormatValues>) cf.ConditionalFormatType.ToOpenXml(),
        Priority = (Int32Value) priority
      };
      Formula formula1 = new Formula();
      if (cf.Operator == XLCFOperator.Equal || cf.Operator == XLCFOperator.NotEqual)
        formula1.Text = quoted;
      else
        formula1.Text = quoted;
      conditionalFormattingRule.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) formula1
      });
      if (cf.Operator == XLCFOperator.Between || cf.Operator == XLCFOperator.NotBetween)
      {
        Formula formula2 = new Formula();
        formula2.Text = this.GetQuoted(cf.Values[2]);
        Formula formula3 = formula2;
        conditionalFormattingRule.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) formula3
        });
      }
      return conditionalFormattingRule;
    }

    private string GetQuoted(XLFormula formula)
    {
      string s = formula.Value;
      double result;
      if (!double.TryParse(s, out result) && !formula.IsFormula && ((int) s[0] != 34 && !s.EndsWith("\"")))
        return string.Format("\"{0}\"", (object) s.Replace("\"", "\"\""));
      return s;
    }
  }
}
