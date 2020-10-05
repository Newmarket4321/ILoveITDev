// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFColorScaleConverter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ClosedXML.Excel
{
  internal class XLCFColorScaleConverter : IXLCFConverter
  {
    public ConditionalFormattingRule Convert(IXLConditionalFormat cf, int priority, XLWorkbook.SaveContext context)
    {
      ConditionalFormattingRule conditionalFormattingRule = new ConditionalFormattingRule()
      {
        Type = (EnumValue<ConditionalFormatValues>) cf.ConditionalFormatType.ToOpenXml(),
        Priority = (Int32Value) priority
      };
      ColorScale colorScale = new ColorScale();
      for (int index = 1; index <= cf.Values.Count; ++index)
      {
        ConditionalFormatValueObject formatValueObject = new ConditionalFormatValueObject()
        {
          Type = (EnumValue<ConditionalFormatValueObjectValues>) cf.ContentTypes[index].ToOpenXml(),
          Val = (StringValue) cf.Values[index].Value
        };
        colorScale.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) formatValueObject
        });
        XLColor color1 = cf.Colors[index];
        Color color2;
        if (color1.ColorType == XLColorType.Color)
        {
          Color color3 = new Color();
          color3.Rgb = (HexBinaryValue) color1.Color.ToHex();
          color2 = color3;
        }
        else if (color1.ColorType == XLColorType.Indexed)
        {
          Color color3 = new Color();
          color3.Indexed = (UInt32Value) ((uint) color1.Indexed);
          color2 = color3;
        }
        else
        {
          Color color3 = new Color();
          color3.Theme = (UInt32Value) ((uint) color1.ThemeColor);
          color2 = color3;
          if (color1.ThemeTint != 0.0)
            color2.Tint = (DoubleValue) color1.ThemeTint;
        }
        colorScale.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) color2
        });
      }
      conditionalFormattingRule.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) colorScale
      });
      return conditionalFormattingRule;
    }
  }
}
