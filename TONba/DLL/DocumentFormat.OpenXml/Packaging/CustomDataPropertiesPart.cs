// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomDataPropertiesPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class CustomDataPropertiesPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/customDataProps";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.customDataProperties+xml";
    internal const string TargetPathConstant = "customData";
    internal const string TargetNameConstant = "customDataProps";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DatastoreItem _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (CustomDataPropertiesPart._partConstraint == null)
        CustomDataPropertiesPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.microsoft.com/office/2007/relationships/customData",
            new PartConstraintRule("CustomDataPart", "application/binary", false, false, FileFormatVersions.Office2010)
          }
        };
      return (IDictionary<string, PartConstraintRule>) CustomDataPropertiesPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (CustomDataPropertiesPart._dataPartReferenceConstraint == null)
        CustomDataPropertiesPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CustomDataPropertiesPart._dataPartReferenceConstraint;
    }

    protected internal CustomDataPropertiesPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2007/relationships/customData":
          return (OpenXmlPart) new CustomDataPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2007/relationships/customDataProps";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.customDataProperties+xml";
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
        return "customDataProps";
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public CustomDataPart CustomDataPart
    {
      get
      {
        return this.GetSubPartOfType<CustomDataPart>();
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

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as DatastoreItem;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.DatastoreItem;
      }
    }

    public DatastoreItem DatastoreItem
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<DatastoreItem>();
        return this._rootEle;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }
  }
}
