// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class CoreFilePropertiesPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-package.core-properties+xml";
    internal const string TargetPathConstant = "docProps";
    internal const string TargetNameConstant = "core";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (CoreFilePropertiesPart._partConstraint == null)
        CoreFilePropertiesPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CoreFilePropertiesPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (CoreFilePropertiesPart._dataPartReferenceConstraint == null)
        CoreFilePropertiesPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CoreFilePropertiesPart._dataPartReferenceConstraint;
    }

    protected internal CoreFilePropertiesPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-package.core-properties+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "docProps";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "core";
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
