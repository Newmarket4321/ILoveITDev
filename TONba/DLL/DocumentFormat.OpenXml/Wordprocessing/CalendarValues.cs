// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.CalendarValues
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public enum CalendarValues
  {
    [EnumString("gregorian")] Gregorian,
    [EnumString("hijri")] Hijri,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("umalqura")] Umalqura,
    [EnumString("hebrew")] Hebrew,
    [EnumString("taiwan")] Taiwan,
    [EnumString("japan")] Japan,
    [EnumString("thai")] Thai,
    [EnumString("korea")] Korea,
    [EnumString("saka")] Saka,
    [EnumString("gregorianXlitEnglish")] GregorianTransliteratedEnglish,
    [EnumString("gregorianXlitFrench")] GregorianTransliteratedFrench,
    [EnumString("gregorianUs"), OfficeAvailability(FileFormatVersions.Office2010)] GregorianUs,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("gregorianMeFrench")] GregorianMeFrench,
    [EnumString("gregorianArabic"), OfficeAvailability(FileFormatVersions.Office2010)] GregorianArabic,
    [EnumString("none"), OfficeAvailability(FileFormatVersions.Office2010)] None,
  }
}
