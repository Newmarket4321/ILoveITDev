// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WordprocessingPeoplePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/people";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.people+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "people";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private People _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WordprocessingPeoplePart._partConstraint == null)
        WordprocessingPeoplePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WordprocessingPeoplePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WordprocessingPeoplePart._dataPartReferenceConstraint == null)
        WordprocessingPeoplePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WordprocessingPeoplePart._dataPartReferenceConstraint;
    }

    protected internal WordprocessingPeoplePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2011/relationships/people";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.wordprocessingml.people+xml";
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
        return "people";
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return version == FileFormatVersions.Office2013;
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
        this._rootEle = value as People;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.People;
      }
    }

    public People People
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<People>();
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
