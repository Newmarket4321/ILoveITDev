// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomXmlPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class CustomXmlPartTypeInfo
  {
    internal static string GetContentType(CustomXmlPartType partType)
    {
      switch (partType)
      {
        case CustomXmlPartType.AdditionalCharacteristics:
          return "application/xml";
        case CustomXmlPartType.Bibliography:
          return "application/xml";
        case CustomXmlPartType.CustomXml:
          return "application/xml";
        case CustomXmlPartType.InkContent:
          return "application/inkml+xml";
        default:
          throw new ArgumentOutOfRangeException(nameof (partType));
      }
    }

    internal static string GetTargetExtension(CustomXmlPartType partType)
    {
      switch (partType)
      {
        case CustomXmlPartType.AdditionalCharacteristics:
          return ".xml";
        case CustomXmlPartType.Bibliography:
          return ".xml";
        case CustomXmlPartType.CustomXml:
          return ".xml";
        case CustomXmlPartType.InkContent:
          return ".xml";
        default:
          return ".xml";
      }
    }
  }
}
