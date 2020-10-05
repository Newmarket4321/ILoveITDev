// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.FontPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class FontPartTypeInfo
  {
    internal static string GetContentType(FontPartType fontType)
    {
      switch (fontType)
      {
        case FontPartType.FontData:
          return "application/x-fontdata";
        case FontPartType.FontTtf:
          return "application/x-font-ttf";
        case FontPartType.FontOdttf:
          return "application/vnd.openxmlformats-officedocument.obfuscatedFont";
        default:
          throw new ArgumentOutOfRangeException(nameof (fontType));
      }
    }

    internal static string GetTargetExtension(FontPartType fontType)
    {
      switch (fontType)
      {
        case FontPartType.FontData:
          return ".fntdata";
        case FontPartType.FontTtf:
          return ".ttf";
        case FontPartType.FontOdttf:
          return ".odttf";
        default:
          return ".font";
      }
    }
  }
}
