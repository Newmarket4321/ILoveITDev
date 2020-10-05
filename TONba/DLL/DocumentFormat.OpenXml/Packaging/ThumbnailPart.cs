// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ThumbnailPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class ThumbnailPart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail";
    internal const string TargetPathConstant = "docProps";
    internal const string TargetNameConstant = "thumbnail";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ThumbnailPart._partConstraint == null)
        ThumbnailPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ThumbnailPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ThumbnailPart._dataPartReferenceConstraint == null)
        ThumbnailPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ThumbnailPart._dataPartReferenceConstraint;
    }

    protected internal ThumbnailPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail";
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
        return "thumbnail";
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
        return false;
      }
    }
  }
}
