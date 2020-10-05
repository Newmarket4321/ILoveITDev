// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.FileFormatExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml
{
  internal static class FileFormatExtension
  {
    internal static bool Includes(this FileFormatVersions source, FileFormatVersions target)
    {
      return (source & target) == target;
    }

    internal static void ThrowExceptionIfFileFormatNotSupported(this FileFormatVersions fileFormat, string parameterName)
    {
      if (fileFormat != FileFormatVersions.Office2007 && fileFormat != FileFormatVersions.Office2010 && fileFormat != FileFormatVersions.Office2013)
      {
        string message = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.FileFormatNotSupported, new object[1]
        {
          (object) fileFormat
        });
        throw new ArgumentOutOfRangeException(parameterName, message);
      }
    }
  }
}
