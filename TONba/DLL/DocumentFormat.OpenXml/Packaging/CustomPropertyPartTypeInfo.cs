// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomPropertyPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class CustomPropertyPartTypeInfo
  {
    internal static string GetContentType(CustomPropertyPartType partType)
    {
      switch (partType)
      {
        case CustomPropertyPartType.Spreadsheet:
          return "application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty";
        case CustomPropertyPartType.Xml:
          return "application/xml";
        default:
          throw new ArgumentOutOfRangeException(nameof (partType));
      }
    }

    internal static string GetTargetExtension(CustomPropertyPartType partType)
    {
      switch (partType)
      {
        case CustomPropertyPartType.Spreadsheet:
          return ".xml";
        case CustomPropertyPartType.Xml:
          return ".xml";
        default:
          return ".xml";
      }
    }
  }
}
