// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.DocumentTypeDetector
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal static class DocumentTypeDetector
  {
    private const string _mainPartRelationshipType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    private static Dictionary<string, OpenXmlDocumentType> _mainPartContentTypes;

    internal static Dictionary<string, OpenXmlDocumentType> MainPartContentTypes
    {
      get
      {
        if (DocumentTypeDetector._mainPartContentTypes == null)
          DocumentTypeDetector._mainPartContentTypes = new Dictionary<string, OpenXmlDocumentType>()
          {
            {
              "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
              OpenXmlDocumentType.Wordprocessing
            },
            {
              "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml",
              OpenXmlDocumentType.Wordprocessing
            },
            {
              "application/vnd.ms-word.document.macroEnabled.main+xml",
              OpenXmlDocumentType.Wordprocessing
            },
            {
              "application/vnd.ms-word.template.macroEnabledTemplate.main+xml",
              OpenXmlDocumentType.Wordprocessing
            },
            {
              "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
              OpenXmlDocumentType.Spreadsheet
            },
            {
              "application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml",
              OpenXmlDocumentType.Spreadsheet
            },
            {
              "application/vnd.ms-excel.sheet.macroEnabled.main+xml",
              OpenXmlDocumentType.Spreadsheet
            },
            {
              "application/vnd.ms-excel.template.macroEnabled.main+xml",
              OpenXmlDocumentType.Spreadsheet
            },
            {
              "application/vnd.ms-excel.addin.macroEnabled.main+xml",
              OpenXmlDocumentType.Spreadsheet
            },
            {
              "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml",
              OpenXmlDocumentType.Presentation
            },
            {
              "application/vnd.openxmlformats-officedocument.presentationml.template.main+xml",
              OpenXmlDocumentType.Presentation
            },
            {
              "application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml",
              OpenXmlDocumentType.Presentation
            },
            {
              "application/vnd.ms-powerpoint.presentation.macroEnabled.main+xml",
              OpenXmlDocumentType.Presentation
            },
            {
              "application/vnd.ms-powerpoint.template.macroEnabled.main+xml",
              OpenXmlDocumentType.Presentation
            },
            {
              "application/vnd.ms-powerpoint.slideshow.macroEnabled.main+xml",
              OpenXmlDocumentType.Presentation
            },
            {
              "application/vnd.ms-powerpoint.addin.macroEnabled.main+xml",
              OpenXmlDocumentType.Presentation
            }
          };
        return DocumentTypeDetector._mainPartContentTypes;
      }
    }

    internal static OpenXmlDocumentType GetDocumentType(OpenXmlPackage openXmlPackage)
    {
      if (openXmlPackage is WordprocessingDocument)
        return OpenXmlDocumentType.Wordprocessing;
      if (openXmlPackage is SpreadsheetDocument)
        return OpenXmlDocumentType.Spreadsheet;
      return openXmlPackage is PresentationDocument ? OpenXmlDocumentType.Presentation : OpenXmlDocumentType.Invalid;
    }
  }
}
