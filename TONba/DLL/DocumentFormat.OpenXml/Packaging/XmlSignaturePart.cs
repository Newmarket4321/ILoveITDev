// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.XmlSignaturePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class XmlSignaturePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml";
    internal const string TargetPathConstant = "_xmlsignatures";
    internal const string TargetNameConstant = "sig";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (XmlSignaturePart._partConstraint == null)
        XmlSignaturePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) XmlSignaturePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (XmlSignaturePart._dataPartReferenceConstraint == null)
        XmlSignaturePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) XmlSignaturePart._dataPartReferenceConstraint;
    }

    protected internal XmlSignaturePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml";
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
        return "sig";
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
