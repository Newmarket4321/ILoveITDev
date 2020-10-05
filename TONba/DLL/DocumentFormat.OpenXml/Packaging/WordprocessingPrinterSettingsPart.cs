// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class WordprocessingPrinterSettingsPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings";
    internal const string TargetPathConstant = "../printerSettings";
    internal const string TargetNameConstant = "printerSettings";
    internal const string TargetFileExtensionConstant = ".bin";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WordprocessingPrinterSettingsPart._partConstraint == null)
        WordprocessingPrinterSettingsPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WordprocessingPrinterSettingsPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WordprocessingPrinterSettingsPart._dataPartReferenceConstraint == null)
        WordprocessingPrinterSettingsPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WordprocessingPrinterSettingsPart._dataPartReferenceConstraint;
    }

    protected internal WordprocessingPrinterSettingsPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../printerSettings";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "printerSettings";
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
