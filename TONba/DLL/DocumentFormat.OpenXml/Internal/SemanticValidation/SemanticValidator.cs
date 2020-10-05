// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.SemanticValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class SemanticValidator : ICancelable
  {
    private SemanticConstraintRegistry _curReg;
    private bool _stopValidating;

    public FileFormatVersions FileFormat { get; private set; }

    public ApplicationType AppType { get; private set; }

    public SemanticValidator(FileFormatVersions format, ApplicationType app)
    {
      this.FileFormat = format;
      this.AppType = app;
      this._curReg = new SemanticConstraintRegistry(format, app);
    }

    public void Validate(ValidationContext validationContext)
    {
      this._stopValidating = false;
      ValidationTraverser.ValidatingTraverse(validationContext, new ValidationTraverser.ValidationAction(this.ValidateElement), new ValidationTraverser.ValidationAction(this.OnContextValidationFinished), new ValidationTraverser.GetStopSignal(this.StopSignal));
    }

    public void ClearConstraintState(SemanticValidationLevel level)
    {
      this._curReg.ClearConstraintState(level);
    }

    private void OnContextValidationFinished(ValidationContext context)
    {
      this._curReg.ActCallBack(context.Element.ElementTypeId);
    }

    private void ValidateElement(ValidationContext context)
    {
      if (this._curReg == null)
        return;
      foreach (ValidationErrorInfo checkConstraint in this._curReg.CheckConstraints(context))
        context.EmitError(checkConstraint);
    }

    private bool StopSignal(ValidationContext validationContext)
    {
      return this._stopValidating;
    }

    public void OnCancel(object sender, EventArgs eventArgs)
    {
      this._stopValidating = true;
    }
  }
}
