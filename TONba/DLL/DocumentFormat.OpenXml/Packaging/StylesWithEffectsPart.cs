// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class StylesWithEffectsPart : StylesPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects";
    internal const string ContentTypeConstant = "application/vnd.ms-word.stylesWithEffects+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "stylesWithEffects";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (StylesWithEffectsPart._partConstraint == null)
        StylesWithEffectsPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) StylesWithEffectsPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (StylesWithEffectsPart._dataPartReferenceConstraint == null)
        StylesWithEffectsPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) StylesWithEffectsPart._dataPartReferenceConstraint;
    }

    protected internal StylesWithEffectsPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-word.stylesWithEffects+xml";
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
        return "stylesWithEffects";
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
  }
}
