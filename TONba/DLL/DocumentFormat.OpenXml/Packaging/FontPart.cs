// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.FontPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class FontPart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font";
    internal const string TargetPathConstant = "fonts";
    internal const string TargetNameConstant = "font";
    internal const string TargetFileExtensionConstant = ".dat";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (FontPart._partConstraint == null)
        FontPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) FontPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (FontPart._dataPartReferenceConstraint == null)
        FontPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) FontPart._dataPartReferenceConstraint;
    }

    protected internal FontPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "fonts";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "font";
      }
    }

    internal override sealed string TargetFileExtension
    {
      get
      {
        return ".dat";
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
