// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.ValidationContext
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Validation
{
  internal class ValidationContext
  {
    internal event EventHandler<ValidationErrorEventArgs> ValidationErrorEventHandler;

    internal ValidationContext()
    {
      this.McContext = new MCContext(false);
      this.FileFormat = FileFormatVersions.Office2007;
    }

    internal FileFormatVersions FileFormat { get; set; }

    internal OpenXmlPackage Package { get; set; }

    internal OpenXmlPart Part { get; set; }

    internal OpenXmlElement Element { get; set; }

    internal MCContext McContext { get; set; }

    internal bool CollectExpectedChildren { get; set; }

    internal void EmitError(ValidationErrorInfo error)
    {
      this.OnValidationError(new ValidationErrorEventArgs(error));
    }

    protected virtual void OnValidationError(ValidationErrorEventArgs errorEventArgs)
    {
      EventHandler<ValidationErrorEventArgs> errorEventHandler = this.ValidationErrorEventHandler;
      if (errorEventHandler == null)
        return;
      errorEventHandler((object) this, errorEventArgs);
    }

    internal OpenXmlElement GetFirstChildMc()
    {
      return this.Element.GetFirstChildMc(this.McContext, this.FileFormat);
    }

    internal OpenXmlElement GetNextChildMc(OpenXmlElement child)
    {
      return this.Element.GetNextChildMc(child, this.McContext, this.FileFormat);
    }
  }
}
