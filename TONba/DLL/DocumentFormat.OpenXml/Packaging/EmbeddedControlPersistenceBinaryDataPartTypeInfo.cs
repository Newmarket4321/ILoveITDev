// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class EmbeddedControlPersistenceBinaryDataPartTypeInfo
  {
    internal static string GetContentType(EmbeddedControlPersistenceBinaryDataPartType controlType)
    {
      if (controlType == EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin)
        return "application/vnd.ms-office.activeX";
      throw new ArgumentOutOfRangeException(nameof (controlType));
    }

    internal static string GetTargetExtension(EmbeddedControlPersistenceBinaryDataPartType controlType)
    {
      return controlType == EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin ? ".bin" : ".bin";
    }
  }
}
