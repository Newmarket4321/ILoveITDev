// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SchemaValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SchemaValidator : ICancelable
  {
    private SdbSchemaDatas _sdbSchemaDatas;
    private SchemaTypeValidator _schemaTypeValidator;
    private bool _stopValidating;

    internal SchemaValidator()
      : this(FileFormatVersions.Office2007)
    {
    }

    internal SchemaValidator(FileFormatVersions fileFormat)
    {
      switch (fileFormat)
      {
        case FileFormatVersions.Office2007:
          this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();
          break;
        case FileFormatVersions.Office2010:
          this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2010SchemaDatas();
          break;
        case FileFormatVersions.Office2013:
          this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2013SchemaDatas();
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof (fileFormat), string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.FileFormatNotSupported, new object[1]
          {
            (object) fileFormat
          }));
      }
      this._schemaTypeValidator = new SchemaTypeValidator(this._sdbSchemaDatas);
    }

    internal void Validate(ValidationContext validationContext)
    {
      this._stopValidating = false;
      OpenXmlElement element = validationContext.Element;
      ValidationTraverser.ValidatingTraverse(validationContext, new ValidationTraverser.ValidationAction(this.ValidateElement), (ValidationTraverser.ValidationAction) null, new ValidationTraverser.GetStopSignal(this.StopSignal));
    }

    private void ValidateElement(ValidationContext validationContext)
    {
      this._schemaTypeValidator.Validate(validationContext);
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
