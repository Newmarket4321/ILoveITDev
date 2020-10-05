// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Profiler
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal static class Profiler
  {
    internal static void CommentMarkAtProfile(long timestamp, Profiler.MarkId markId)
    {
    }

    internal static void CommentMarkProfile(Profiler.MarkId markId)
    {
    }

    internal enum MarkId
    {
      OpenXmlPackage_Load_In = 100, // 0x00000064
      OpenXmlPackage_Load_Out = 101, // 0x00000065
      OpenXmlPartRootElement_LoadFromPart_In = 200, // 0x000000C8
      OpenXmlPartRootElement_LoadFromPart_Out = 201, // 0x000000C9
    }
  }
}
