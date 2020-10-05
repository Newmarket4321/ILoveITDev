// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ImagePartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class ImagePartTypeInfo
  {
    internal static string GetContentType(ImagePartType imageType)
    {
      switch (imageType)
      {
        case ImagePartType.Bmp:
          return "image/bmp";
        case ImagePartType.Gif:
          return "image/gif";
        case ImagePartType.Png:
          return "image/png";
        case ImagePartType.Tiff:
          return "image/tiff";
        case ImagePartType.Icon:
          return "image/x-icon";
        case ImagePartType.Pcx:
          return "image/x-pcx";
        case ImagePartType.Jpeg:
          return "image/jpeg";
        case ImagePartType.Emf:
          return "image/x-emf";
        case ImagePartType.Wmf:
          return "image/x-wmf";
        default:
          throw new ArgumentOutOfRangeException(nameof (imageType));
      }
    }

    internal static string GetTargetExtension(ImagePartType imageType)
    {
      switch (imageType)
      {
        case ImagePartType.Bmp:
          return ".bmp";
        case ImagePartType.Gif:
          return ".gif";
        case ImagePartType.Png:
          return ".png";
        case ImagePartType.Tiff:
          return ".tiff";
        case ImagePartType.Icon:
          return ".ico";
        case ImagePartType.Pcx:
          return ".pcx";
        case ImagePartType.Jpeg:
          return ".jpg";
        case ImagePartType.Emf:
          return ".emf";
        case ImagePartType.Wmf:
          return ".wmf";
        default:
          return ".image";
      }
    }
  }
}
