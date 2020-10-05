// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFIconSetConverter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ClosedXML.Excel
{
  internal class XLCFIconSetConverter : IXLCFConverter
  {
    public ConditionalFormattingRule Convert(IXLConditionalFormat cf, int priority, XLWorkbook.SaveContext context)
    {
      ConditionalFormattingRule conditionalFormattingRule = new ConditionalFormattingRule()
      {
        Type = (EnumValue<ConditionalFormatValues>) cf.ConditionalFormatType.ToOpenXml(),
        Priority = (Int32Value) priority
      };
      IconSet iconSet = new IconSet()
      {
        ShowValue = (BooleanValue) (!cf.ShowIconOnly),
        Reverse = (BooleanValue) cf.ReverseIconOrder,
        IconSetValue = (EnumValue<IconSetValues>) cf.IconSetStyle.ToOpenXml()
      };
      int count = cf.Values.Count;
      for (int index = 1; index <= count; ++index)
      {
        ConditionalFormatValueObject formatValueObject = new ConditionalFormatValueObject()
        {
          Type = (EnumValue<ConditionalFormatValueObjectValues>) cf.ContentTypes[index].ToOpenXml(),
          Val = (StringValue) cf.Values[index].Value,
          GreaterThanOrEqual = (BooleanValue) (cf.IconSetOperators[index] == XLCFIconSetOperator.EqualOrGreaterThan)
        };
        iconSet.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) formatValueObject
        });
      }
      conditionalFormattingRule.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) iconSet
      });
      return conditionalFormattingRule;
    }
  }
}
