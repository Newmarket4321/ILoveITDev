// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ControlPropertiesPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class ControlPropertiesPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.controlproperties+xml";
    internal const string TargetPathConstant = "../ctrlProps";
    internal const string TargetNameConstant = "ctrlProp";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private FormControlProperties _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ControlPropertiesPart._partConstraint == null)
        ControlPropertiesPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ControlPropertiesPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ControlPropertiesPart._dataPartReferenceConstraint == null)
        ControlPropertiesPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ControlPropertiesPart._dataPartReferenceConstraint;
    }

    protected internal ControlPropertiesPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.controlproperties+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../ctrlProps";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "ctrlProp";
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return version == FileFormatVersions.Office2010;
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
        this._rootEle = value as FormControlProperties;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.FormControlProperties;
      }
    }

    public FormControlProperties FormControlProperties
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<FormControlProperties>();
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
