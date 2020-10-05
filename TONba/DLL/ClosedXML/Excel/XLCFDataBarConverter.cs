// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFDataBarConverter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ClosedXML.Excel
{
  internal class XLCFDataBarConverter : IXLCFConverter
  {
    public ConditionalFormattingRule Convert(IXLConditionalFormat cf, int priority, XLWorkbook.SaveContext context)
    {
      ConditionalFormattingRule conditionalFormattingRule = new ConditionalFormattingRule()
      {
        Type = (EnumValue<ConditionalFormatValues>) cf.ConditionalFormatType.ToOpenXml(),
        Priority = (Int32Value) priority
      };
      DataBar dataBar = new DataBar()
      {
        ShowValue = (BooleanValue) (!cf.ShowBarOnly)
      };
      ConditionalFormatValueObject formatValueObject1 = new ConditionalFormatValueObject()
      {
        Type = (EnumValue<ConditionalFormatValueObjectValues>) cf.ContentTypes[1].ToOpenXml()
      };
      if (cf.Values.Count >= 1)
        formatValueObject1.Val = (StringValue) cf.Values[1].Value;
      ConditionalFormatValueObject formatValueObject2 = new ConditionalFormatValueObject()
      {
        Type = (EnumValue<ConditionalFormatValueObjectValues>) cf.ContentTypes[2].ToOpenXml()
      };
      if (cf.Values.Count >= 2)
        formatValueObject2.Val = (StringValue) cf.Values[2].Value;
      Color color1 = new Color();
      color1.Rgb = (HexBinaryValue) cf.Colors[1].Color.ToHex();
      Color color2 = color1;
      dataBar.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) formatValueObject1
      });
      dataBar.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) formatValueObject2
      });
      dataBar.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) color2
      });
      conditionalFormattingRule.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) dataBar
      });
      return conditionalFormattingRule;
    }
  }
}
