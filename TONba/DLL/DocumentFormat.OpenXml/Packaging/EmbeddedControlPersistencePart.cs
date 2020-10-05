// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class EmbeddedControlPersistencePart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control";
    internal const string TargetPathConstant = "embeddings";
    internal const string TargetNameConstant = "control";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (EmbeddedControlPersistencePart._partConstraint == null)
        EmbeddedControlPersistencePart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary",
            new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) EmbeddedControlPersistencePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (EmbeddedControlPersistencePart._dataPartReferenceConstraint == null)
        EmbeddedControlPersistencePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) EmbeddedControlPersistencePart._dataPartReferenceConstraint;
    }

    protected internal EmbeddedControlPersistencePart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary":
          return (OpenXmlPart) new EmbeddedControlPersistenceBinaryDataPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
      EmbeddedControlPersistenceBinaryDataPart newPart = new EmbeddedControlPersistenceBinaryDataPart();
      this.InitPart<EmbeddedControlPersistenceBinaryDataPart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
      string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
      EmbeddedControlPersistenceBinaryDataPart newPart = new EmbeddedControlPersistenceBinaryDataPart();
      this.InitPart<EmbeddedControlPersistenceBinaryDataPart>(newPart, contentType, id);
      return newPart;
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
      string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control";
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
        return "control";
      }
    }

    internal override sealed string TargetFileExtension
    {
      get
      {
        return ".bin";
      }
    }

    public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
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
