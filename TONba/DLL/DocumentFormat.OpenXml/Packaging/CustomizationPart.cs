// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomizationPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class CustomizationPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations";
    internal const string ContentTypeConstant = "application/vnd.ms-word.keyMapCustomizations+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "customizations";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private TemplateCommandGroup _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (CustomizationPart._partConstraint == null)
        CustomizationPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars",
            new PartConstraintRule("WordAttachedToolbarsPart", "application/vnd.ms-word.attachedToolbars", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) CustomizationPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (CustomizationPart._dataPartReferenceConstraint == null)
        CustomizationPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) CustomizationPart._dataPartReferenceConstraint;
    }

    protected internal CustomizationPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars":
          return (OpenXmlPart) new WordAttachedToolbarsPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-word.keyMapCustomizations+xml";
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
        return "customizations";
      }
    }

    public WordAttachedToolbarsPart WordAttachedToolbarsPart
    {
      get
      {
        return this.GetSubPartOfType<WordAttachedToolbarsPart>();
      }
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
        this._rootEle = value as TemplateCommandGroup;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.TemplateCommandGroup;
      }
    }

    public TemplateCommandGroup TemplateCommandGroup
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<TemplateCommandGroup>();
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
