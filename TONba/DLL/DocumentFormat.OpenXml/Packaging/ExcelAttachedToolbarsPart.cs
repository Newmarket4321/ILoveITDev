// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ExcelAttachedToolbarsPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class ExcelAttachedToolbarsPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.attachedToolbars";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "attachedToolbars";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ExcelAttachedToolbarsPart._partConstraint == null)
        ExcelAttachedToolbarsPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ExcelAttachedToolbarsPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ExcelAttachedToolbarsPart._dataPartReferenceConstraint == null)
        ExcelAttachedToolbarsPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ExcelAttachedToolbarsPart._dataPartReferenceConstraint;
    }

    protected internal ExcelAttachedToolbarsPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.attachedToolbars";
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
        return "attachedToolbars";
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
