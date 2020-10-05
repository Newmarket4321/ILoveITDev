// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.WebExtentionPane;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WebExTaskpanesPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes";
    internal const string ContentTypeConstant = "application/vnd.ms-office.webextensiontaskpanes+xml";
    internal const string TargetPathConstant = "../webextensions";
    internal const string TargetPathOfWordConstant = "word/webextensions";
    internal const string TargetPathOfExcelConstant = "xl/webextensions";
    internal const string TargetPathOfPPTConstant = "ppt/webextensions";
    internal const string TargetNameConstant = "taskpanes";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Taskpanes _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WebExTaskpanesPart._partConstraint == null)
        WebExTaskpanesPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.microsoft.com/office/2011/relationships/webextension",
            new PartConstraintRule("WebExtensionPart", "application/vnd.ms-office.webextension+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) WebExTaskpanesPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WebExTaskpanesPart._dataPartReferenceConstraint == null)
        WebExTaskpanesPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WebExTaskpanesPart._dataPartReferenceConstraint;
    }

    protected internal WebExTaskpanesPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2011/relationships/webextension":
          return (OpenXmlPart) new WebExtensionPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-office.webextensiontaskpanes+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../webextensions";
      }
    }

    internal override sealed string TargetPathOfWord
    {
      get
      {
        return "word/webextensions";
      }
    }

    internal override sealed string TargetPathOfExcel
    {
      get
      {
        return "xl/webextensions";
      }
    }

    internal override sealed string TargetPathOfPPT
    {
      get
      {
        return "ppt/webextensions";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "taskpanes";
      }
    }

    public IEnumerable<WebExtensionPart> WebExtensionParts
    {
      get
      {
        return this.GetPartsOfType<WebExtensionPart>();
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return version == FileFormatVersions.Office2013;
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
        this._rootEle = value as Taskpanes;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Taskpanes;
      }
    }

    public Taskpanes Taskpanes
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Taskpanes>();
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
