// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.FontTablePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class FontTablePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "fontTable";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Fonts _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (FontTablePart._partConstraint == null)
        FontTablePart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",
            new PartConstraintRule("FontPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) FontTablePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (FontTablePart._dataPartReferenceConstraint == null)
        FontTablePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) FontTablePart._dataPartReferenceConstraint;
    }

    protected internal FontTablePart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font":
          return (OpenXmlPart) new FontPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public FontPart AddFontPart(string contentType)
    {
      FontPart newPart = new FontPart();
      this.InitPart<FontPart>(newPart, contentType);
      return newPart;
    }

    public FontPart AddFontPart(FontPartType partType)
    {
      string contentType = FontPartTypeInfo.GetContentType(partType);
      string targetExtension = FontPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddFontPart(contentType);
    }

    public FontPart AddFontPart(string contentType, string id)
    {
      FontPart newPart = new FontPart();
      this.InitPart<FontPart>(newPart, contentType, id);
      return newPart;
    }

    public FontPart AddFontPart(FontPartType partType, string id)
    {
      string contentType = FontPartTypeInfo.GetContentType(partType);
      string targetExtension = FontPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddFontPart(contentType, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml";
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
        return "fontTable";
      }
    }

    public IEnumerable<FontPart> FontParts
    {
      get
      {
        return this.GetPartsOfType<FontPart>();
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
        this._rootEle = value as Fonts;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Fonts;
      }
    }

    public Fonts Fonts
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Fonts>();
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
