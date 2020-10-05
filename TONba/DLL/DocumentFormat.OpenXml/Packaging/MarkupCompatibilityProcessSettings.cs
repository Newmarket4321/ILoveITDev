// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Packaging
{
  public class MarkupCompatibilityProcessSettings
  {
    public MarkupCompatibilityProcessMode ProcessMode { get; internal set; }

    public FileFormatVersions TargetFileFormatVersions { get; internal set; }

    public MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode processMode, FileFormatVersions targetFileFormatVersions)
    {
      this.ProcessMode = processMode;
      this.TargetFileFormatVersions = targetFileFormatVersions;
    }

    private MarkupCompatibilityProcessSettings()
    {
      this.ProcessMode = MarkupCompatibilityProcessMode.NoProcess;
      this.TargetFileFormatVersions = FileFormatVersions.Office2007;
    }
  }
}
