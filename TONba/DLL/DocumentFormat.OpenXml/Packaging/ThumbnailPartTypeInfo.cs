// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ThumbnailPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class ThumbnailPartTypeInfo
  {
    internal static string GetContentType(ThumbnailPartType imageType)
    {
      switch (imageType)
      {
        case ThumbnailPartType.Jpeg:
          return "image/jpeg";
        case ThumbnailPartType.Emf:
          return "image/x-emf";
        case ThumbnailPartType.Wmf:
          return "image/x-wmf";
        default:
          throw new ArgumentOutOfRangeException(nameof (imageType));
      }
    }

    internal static string GetTargetExtension(ThumbnailPartType imageType)
    {
      switch (imageType)
      {
        case ThumbnailPartType.Jpeg:
          return ".jpg";
        case ThumbnailPartType.Emf:
          return ".emf";
        case ThumbnailPartType.Wmf:
          return ".wmf";
        default:
          return ".image";
      }
    }
  }
}
