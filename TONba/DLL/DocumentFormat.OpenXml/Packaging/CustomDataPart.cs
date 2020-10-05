// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomDataPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class CustomDataPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/customData";
    internal const string ContentTypeConstant = "application/binary";
    internal const string TargetPathConstant = "customData";
    internal const string TargetNameConstant = "customData";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (CustomDataPart._partConstraint == null)
        CustomDataPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CustomDataPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (CustomDataPart._dataPartReferenceConstraint == null)
        CustomDataPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CustomDataPart._dataPartReferenceConstraint;
    }

    protected internal CustomDataPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2007/relationships/customData";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/binary";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "customData";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "customData";
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
