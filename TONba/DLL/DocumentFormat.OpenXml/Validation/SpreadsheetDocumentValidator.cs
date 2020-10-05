// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.SpreadsheetDocumentValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Internal.SemanticValidation;
using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
  internal class SpreadsheetDocumentValidator : DocumentValidator
  {
    private SpreadsheetDocument _spreadsheetDocument;

    internal SpreadsheetDocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
      : base(settings, schemaValidator, semanticValidator)
    {
    }

    protected override OpenXmlPackage TargetDocument
    {
      get
      {
        return (OpenXmlPackage) this._spreadsheetDocument;
      }
      set
      {
        this._spreadsheetDocument = (SpreadsheetDocument) value;
      }
    }

    protected override IEnumerable<OpenXmlPart> PartsToBeValidated
    {
      get
      {
        WorkbookPart workbookPart = this._spreadsheetDocument.WorkbookPart;
        if (workbookPart != null)
        {
          Dictionary<OpenXmlPart, bool> parts = new Dictionary<OpenXmlPart, bool>();
          this._spreadsheetDocument.FindAllReachableParts((IDictionary<OpenXmlPart, bool>) parts);
          foreach (OpenXmlPart key in parts.Keys)
          {
            if (key.IsInVersion(this.ValidationSettings.FileFormat))
              yield return key;
          }
        }
      }
    }
  }
}
