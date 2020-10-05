// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class EmbeddedPackagePart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package";
    internal const string TargetPathConstant = "embeddings";
    internal const string TargetNameConstant = "package";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (EmbeddedPackagePart._partConstraint == null)
        EmbeddedPackagePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) EmbeddedPackagePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (EmbeddedPackagePart._dataPartReferenceConstraint == null)
        EmbeddedPackagePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) EmbeddedPackagePart._dataPartReferenceConstraint;
    }

    protected internal EmbeddedPackagePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "embeddings";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "package";
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
