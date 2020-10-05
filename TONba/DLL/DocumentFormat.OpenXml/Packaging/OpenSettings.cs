// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.OpenSettings
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Packaging
{
  public class OpenSettings
  {
    private bool? autoSave;
    private MarkupCompatibilityProcessSettings _mcSettings;

    public bool AutoSave
    {
      get
      {
        if (!this.autoSave.HasValue)
          return true;
        return this.autoSave.Value;
      }
      set
      {
        this.autoSave = new bool?(value);
      }
    }

    public MarkupCompatibilityProcessSettings MarkupCompatibilityProcessSettings
    {
      get
      {
        if (this._mcSettings == null)
          this._mcSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);
        return this._mcSettings;
      }
      set
      {
        this._mcSettings = value;
      }
    }

    public long MaxCharactersInPart { get; set; }
  }
}
