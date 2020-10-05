// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ValidationSettings
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal class ValidationSettings
  {
    private const int _defaultMaxNumberOfErrorsReturned = 1000;

    internal ValidationSettings()
    {
      this.FileFormat = FileFormatVersions.Office2007;
      this.MaxNumberOfErrors = 1000;
    }

    internal ValidationSettings(FileFormatVersions fileFormat)
    {
      fileFormat.ThrowExceptionIfFileFormatNotSupported(nameof (fileFormat));
      this.FileFormat = fileFormat;
      this.MaxNumberOfErrors = 1000;
    }

    internal FileFormatVersions FileFormat { get; set; }

    internal int MaxNumberOfErrors { get; set; }
  }
}
