// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomXmlPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class CustomXmlPart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml";
    internal const string TargetPathConstant = "../customXML";
    internal const string TargetNameConstant = "item";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (CustomXmlPart._partConstraint == null)
        CustomXmlPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps",
            new PartConstraintRule("CustomXmlPropertiesPart", "application/vnd.openxmlformats-officedocument.customXmlProperties+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) CustomXmlPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (CustomXmlPart._dataPartReferenceConstraint == null)
        CustomXmlPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CustomXmlPart._dataPartReferenceConstraint;
    }

    protected internal CustomXmlPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps":
          return (OpenXmlPart) new CustomXmlPropertiesPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../customXML";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "item";
      }
    }

    public CustomXmlPropertiesPart CustomXmlPropertiesPart
    {
      get
      {
        return this.GetSubPartOfType<CustomXmlPropertiesPart>();
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
