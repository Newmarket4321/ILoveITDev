// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.VbaProjectPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class VbaProjectPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/vbaProject";
    internal const string ContentTypeConstant = "application/vnd.ms-office.vbaProject";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "vbaProject";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (VbaProjectPart._partConstraint == null)
        VbaProjectPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.microsoft.com/office/2006/relationships/wordVbaData",
            new PartConstraintRule("VbaDataPart", "application/vnd.ms-word.vbaData+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) VbaProjectPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (VbaProjectPart._dataPartReferenceConstraint == null)
        VbaProjectPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) VbaProjectPart._dataPartReferenceConstraint;
    }

    protected internal VbaProjectPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2006/relationships/wordVbaData":
          return (OpenXmlPart) new VbaDataPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/vbaProject";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-office.vbaProject";
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
        return "vbaProject";
      }
    }

    public VbaDataPart VbaDataPart
    {
      get
      {
        return this.GetSubPartOfType<VbaDataPart>();
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
