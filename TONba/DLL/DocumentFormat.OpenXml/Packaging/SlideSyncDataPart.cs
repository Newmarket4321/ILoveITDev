// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.SlideSyncDataPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class SlideSyncDataPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml";
    internal const string TargetPathConstant = "slideUpdateInfo";
    internal const string TargetNameConstant = "slideUpdateInfo";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SlideSyncProperties _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (SlideSyncDataPart._partConstraint == null)
        SlideSyncDataPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SlideSyncDataPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (SlideSyncDataPart._dataPartReferenceConstraint == null)
        SlideSyncDataPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SlideSyncDataPart._dataPartReferenceConstraint;
    }

    protected internal SlideSyncDataPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "slideUpdateInfo";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "slideUpdateInfo";
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
        this._rootEle = value as SlideSyncProperties;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.SlideSyncProperties;
      }
    }

    public SlideSyncProperties SlideSyncProperties
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<SlideSyncProperties>();
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
