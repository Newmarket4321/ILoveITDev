// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFConverters
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLCFConverters
  {
    private static readonly Dictionary<XLConditionalFormatType, IXLCFConverter> Converters = new Dictionary<XLConditionalFormatType, IXLCFConverter>();

    static XLCFConverters()
    {
      XLCFConverters.Converters.Add(XLConditionalFormatType.ColorScale, (IXLCFConverter) new XLCFColorScaleConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.StartsWith, (IXLCFConverter) new XLCFStartsWithConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.EndsWith, (IXLCFConverter) new XLCFEndsWithConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.IsBlank, (IXLCFConverter) new XLCFIsBlankConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.NotBlank, (IXLCFConverter) new XLCFNotBlankConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.IsError, (IXLCFConverter) new XLCFIsErrorConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.NotError, (IXLCFConverter) new XLCFNotErrorConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.ContainsText, (IXLCFConverter) new XLCFContainsConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.NotContainsText, (IXLCFConverter) new XLCFNotContainsConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.CellIs, (IXLCFConverter) new XLCFCellIsConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.IsUnique, (IXLCFConverter) new XLCFUniqueConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.IsDuplicate, (IXLCFConverter) new XLCFUniqueConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.Expression, (IXLCFConverter) new XLCFCellIsConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.Top10, (IXLCFConverter) new XLCFTopConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.DataBar, (IXLCFConverter) new XLCFDataBarConverter());
      XLCFConverters.Converters.Add(XLConditionalFormatType.IconSet, (IXLCFConverter) new XLCFIconSetConverter());
    }

    public static ConditionalFormattingRule Convert(IXLConditionalFormat conditionalFormat, int priority, XLWorkbook.SaveContext context)
    {
      return XLCFConverters.Converters[conditionalFormat.ConditionalFormatType].Convert(conditionalFormat, priority, context);
    }
  }
}
