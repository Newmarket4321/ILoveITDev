// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.ValidationErrorInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation
{
  [DebuggerDisplay("Description={Description}")]
  public class ValidationErrorInfo
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private OpenXmlElement _element;

    [Conditional("DEBUG")]
    public void SetDebugField(string attributeQualifiedName, string validationErrorCategory)
    {
    }

    public string Id { get; internal set; }

    public ValidationErrorType ErrorType { get; internal set; }

    public string Description { get; internal set; }

    public XmlPath Path { get; internal set; }

    public OpenXmlElement Node
    {
      get
      {
        return this._element;
      }
      internal set
      {
        this._element = value;
        this.Path = XmlPath.GetXPath(value);
        if (this.Part != null)
          return;
        this.Part = this._element.GetPart();
      }
    }

    public OpenXmlPart Part { get; internal set; }

    public OpenXmlElement RelatedNode { get; internal set; }

    public OpenXmlPart RelatedPart { get; internal set; }
  }
}
