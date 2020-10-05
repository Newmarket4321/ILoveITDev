// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.VbaDataPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class VbaDataPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/wordVbaData";
    internal const string ContentTypeConstant = "application/vnd.ms-word.vbaData+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "vbaData";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private VbaSuppData _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (VbaDataPart._partConstraint == null)
        VbaDataPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) VbaDataPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (VbaDataPart._dataPartReferenceConstraint == null)
        VbaDataPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) VbaDataPart._dataPartReferenceConstraint;
    }

    protected internal VbaDataPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/wordVbaData";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-word.vbaData+xml";
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
        return "vbaData";
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
        this._rootEle = value as VbaSuppData;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.VbaSuppData;
      }
    }

    public VbaSuppData VbaSuppData
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<VbaSuppData>();
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
