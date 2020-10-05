// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class QuickAccessToolbarCustomizationsPart : CustomUIPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization";
    internal const string ContentTypeConstant = "application/xml";
    internal const string TargetPathConstant = "userCustomization";
    internal const string TargetNameConstant = "customUI";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (QuickAccessToolbarCustomizationsPart._partConstraint == null)
        QuickAccessToolbarCustomizationsPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) QuickAccessToolbarCustomizationsPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (QuickAccessToolbarCustomizationsPart._dataPartReferenceConstraint == null)
        QuickAccessToolbarCustomizationsPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) QuickAccessToolbarCustomizationsPart._dataPartReferenceConstraint;
    }

    protected internal QuickAccessToolbarCustomizationsPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "userCustomization";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "customUI";
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
