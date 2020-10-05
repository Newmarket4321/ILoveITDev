// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ChartColorStylePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class ChartColorStylePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle";
    internal const string ContentTypeConstant = "application/vnd.ms-office.chartcolorstyle+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "colors";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ColorStyle _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ChartColorStylePart._partConstraint == null)
        ChartColorStylePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ChartColorStylePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ChartColorStylePart._dataPartReferenceConstraint == null)
        ChartColorStylePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ChartColorStylePart._dataPartReferenceConstraint;
    }

    protected internal ChartColorStylePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-office.chartcolorstyle+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return ".";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "colors";
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
        this._rootEle = value as ColorStyle;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.ColorStyle;
      }
    }

    public ColorStyle ColorStyle
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<ColorStyle>();
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
