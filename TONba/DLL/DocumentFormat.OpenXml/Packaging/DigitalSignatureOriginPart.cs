// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DigitalSignatureOriginPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-package.digital-signature-origin";
    internal const string TargetPathConstant = "_xmlsignatures";
    internal const string TargetNameConstant = "origin";
    internal const string TargetFileExtensionConstant = ".sigs";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (DigitalSignatureOriginPart._partConstraint == null)
        DigitalSignatureOriginPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature",
            new PartConstraintRule("XmlSignaturePart", "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) DigitalSignatureOriginPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (DigitalSignatureOriginPart._dataPartReferenceConstraint == null)
        DigitalSignatureOriginPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) DigitalSignatureOriginPart._dataPartReferenceConstraint;
    }

    protected internal DigitalSignatureOriginPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature":
          return (OpenXmlPart) new XmlSignaturePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-package.digital-signature-origin";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "_xmlsignatures";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "origin";
      }
    }

    internal override sealed string TargetFileExtension
    {
      get
      {
        return ".sigs";
      }
    }

    public IEnumerable<XmlSignaturePart> XmlSignatureParts
    {
      get
      {
        return this.GetPartsOfType<XmlSignaturePart>();
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
