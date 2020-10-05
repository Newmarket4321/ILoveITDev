// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.MediaDataPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class MediaDataPartTypeInfo
  {
    internal static string GetContentType(this MediaDataPartType mediaDataPartType)
    {
      switch (mediaDataPartType)
      {
        case MediaDataPartType.Aiff:
          return "audio/aiff";
        case MediaDataPartType.Midi:
          return "audio/midi";
        case MediaDataPartType.Mp3:
          return "audio/mp3";
        case MediaDataPartType.MpegUrl:
          return "audio/mpegurl";
        case MediaDataPartType.Wav:
          return "audio/wav";
        case MediaDataPartType.Wma:
          return "audio/x-ms-wma";
        case MediaDataPartType.MpegAudio:
          return "audio/mpeg";
        case MediaDataPartType.OggAudio:
          return "audio/ogg";
        case MediaDataPartType.Asx:
          return "video/x-ms-asf-plugin";
        case MediaDataPartType.Avi:
          return "video/avi";
        case MediaDataPartType.Mpg:
          return "video/mpg";
        case MediaDataPartType.MpegVideo:
          return "video/mpeg";
        case MediaDataPartType.Wmv:
          return "video/x-ms-wmv";
        case MediaDataPartType.Wmx:
          return "video/x-ms-wmx";
        case MediaDataPartType.Wvx:
          return "video/x-ms-wvx";
        case MediaDataPartType.Quicktime:
          return "video/quicktime";
        case MediaDataPartType.OggVideo:
          return "video/ogg";
        case MediaDataPartType.VC1:
          return "video/vc1";
        default:
          throw new ArgumentOutOfRangeException(nameof (mediaDataPartType));
      }
    }

    internal static string GetTargetExtension(this MediaDataPartType mediaDataPartType)
    {
      switch (mediaDataPartType)
      {
        case MediaDataPartType.Aiff:
          return ".aiff";
        case MediaDataPartType.Midi:
          return ".midi";
        case MediaDataPartType.Mp3:
          return ".mp3";
        case MediaDataPartType.MpegUrl:
          return ".m3u";
        case MediaDataPartType.Wav:
          return ".wav";
        case MediaDataPartType.Wma:
          return ".wma";
        case MediaDataPartType.MpegAudio:
          return ".mpeg";
        case MediaDataPartType.OggAudio:
          return ".ogg";
        case MediaDataPartType.Asx:
          return ".asx";
        case MediaDataPartType.Avi:
          return ".avi";
        case MediaDataPartType.Mpg:
          return ".mpg";
        case MediaDataPartType.MpegVideo:
          return ".mpeg";
        case MediaDataPartType.Wmv:
          return ".wmv";
        case MediaDataPartType.Wmx:
          return ".wmx";
        case MediaDataPartType.Wvx:
          return ".wvx";
        case MediaDataPartType.Quicktime:
          return ".mov";
        case MediaDataPartType.OggVideo:
          return ".ogg";
        case MediaDataPartType.VC1:
          return ".wmv";
        default:
          return ".media";
      }
    }
  }
}
