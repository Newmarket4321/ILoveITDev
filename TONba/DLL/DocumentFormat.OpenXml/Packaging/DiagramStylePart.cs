// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DiagramStylePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DiagramStylePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml";
    internal const string TargetPathConstant = "../graphics";
    internal const string TargetNameConstant = "quickStyle";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private StyleDefinition _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (DiagramStylePart._partConstraint == null)
        DiagramStylePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) DiagramStylePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (DiagramStylePart._dataPartReferenceConstraint == null)
        DiagramStylePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) DiagramStylePart._dataPartReferenceConstraint;
    }

    protected internal DiagramStylePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../graphics";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "quickStyle";
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
        this._rootEle = value as StyleDefinition;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.StyleDefinition;
      }
    }

    public StyleDefinition StyleDefinition
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<StyleDefinition>();
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
