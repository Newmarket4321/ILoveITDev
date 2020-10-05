// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class LegacyDiagramTextPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText";
    internal const string ContentTypeConstant = "application/vnd.ms-office.legacyDiagramText";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "legacyDiagramText";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (LegacyDiagramTextPart._partConstraint == null)
        LegacyDiagramTextPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) LegacyDiagramTextPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (LegacyDiagramTextPart._dataPartReferenceConstraint == null)
        LegacyDiagramTextPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) LegacyDiagramTextPart._dataPartReferenceConstraint;
    }

    protected internal LegacyDiagramTextPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-office.legacyDiagramText";
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
        return "legacyDiagramText";
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
