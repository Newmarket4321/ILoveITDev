// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.ValidationResult
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
  internal class ValidationResult
  {
    internal ValidationResult()
    {
      this.Valid = true;
      this.Errors = new List<ValidationErrorInfo>();
    }

    internal bool Canceled { get; set; }

    internal bool Valid { get; set; }

    internal List<ValidationErrorInfo> Errors { get; private set; }

    internal int MaxNumberOfErrors { get; set; }

    internal void Clear()
    {
      this.Valid = true;
      this.Canceled = false;
      this.Errors.Clear();
    }

    internal void AddError(ValidationErrorInfo error)
    {
      this.Valid = false;
      this.Errors.Add(error);
    }

    internal void OnValidationError(object sender, ValidationErrorEventArgs errorEventArgs)
    {
      if (errorEventArgs.ValidationErrorInfo == null)
        return;
      if (this.MaxNumberOfErrors > 0 && this.Errors.Count >= this.MaxNumberOfErrors)
      {
        EventHandler<EventArgs> errorsEventHandler = this.MaxNumberOfErrorsEventHandler;
        if (errorsEventHandler == null)
          return;
        errorsEventHandler((object) this, (EventArgs) null);
      }
      else
      {
        this.Valid = false;
        this.Errors.Add(errorEventArgs.ValidationErrorInfo);
      }
    }

    internal event EventHandler<EventArgs> MaxNumberOfErrorsEventHandler;
  }
}
