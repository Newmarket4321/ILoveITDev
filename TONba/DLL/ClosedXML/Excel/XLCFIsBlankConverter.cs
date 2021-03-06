﻿// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFIsBlankConverter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ClosedXML.Excel
{
  internal class XLCFIsBlankConverter : IXLCFConverter
  {
    public ConditionalFormattingRule Convert(IXLConditionalFormat cf, int priority, XLWorkbook.SaveContext context)
    {
      ConditionalFormattingRule conditionalFormattingRule = new ConditionalFormattingRule()
      {
        FormatId = (UInt32Value) ((uint) context.DifferentialFormats[cf.Style]),
        Type = (EnumValue<ConditionalFormatValues>) cf.ConditionalFormatType.ToOpenXml(),
        Priority = (Int32Value) priority
      };
      Formula formula1 = new Formula();
      formula1.Text = "LEN(TRIM(" + cf.Range.RangeAddress.FirstAddress.ToStringRelative(false) + "))=0";
      Formula formula2 = formula1;
      conditionalFormattingRule.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) formula2
      });
      return conditionalFormattingRule;
    }
  }
}
