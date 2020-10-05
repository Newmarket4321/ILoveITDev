// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ExternalWorkbookPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class ExternalWorkbookPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml";
    internal const string TargetPathConstant = "externalReferences";
    internal const string TargetNameConstant = "externalReference";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ExternalLink _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ExternalWorkbookPart._partConstraint == null)
        ExternalWorkbookPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ExternalWorkbookPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ExternalWorkbookPart._dataPartReferenceConstraint == null)
        ExternalWorkbookPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ExternalWorkbookPart._dataPartReferenceConstraint;
    }

    protected internal ExternalWorkbookPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "externalReferences";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "externalReference";
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return true;
      }
    }

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as ExternalLink;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.ExternalLink;
      }
    }

    public ExternalLink ExternalLink
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<ExternalLink>();
        return this._rootEle;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }
  }
}
