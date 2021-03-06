﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.LegacyDiagramTextInfoPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class LegacyDiagramTextInfoPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo";
    internal const string ContentTypeConstant = "application/vnd.ms-office.legacyDocTextInfo";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "legacyDocTextInfo";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (LegacyDiagramTextInfoPart._partConstraint == null)
        LegacyDiagramTextInfoPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) LegacyDiagramTextInfoPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (LegacyDiagramTextInfoPart._dataPartReferenceConstraint == null)
        LegacyDiagramTextInfoPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) LegacyDiagramTextInfoPart._dataPartReferenceConstraint;
    }

    protected internal LegacyDiagramTextInfoPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-office.legacyDocTextInfo";
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
        return "legacyDocTextInfo";
      }
    }

    internal override sealed string TargetFileExtension
    {
      get
      {
        return ".bin";
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return true;
      }
    }
  }
}
