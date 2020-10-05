// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DocumentSettingsPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DocumentSettingsPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "settings";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Settings _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (DocumentSettingsPart._partConstraint == null)
        DocumentSettingsPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData",
            new PartConstraintRule("MailMergeRecipientDataPart", (string) null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
            new PartConstraintRule("ImagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) DocumentSettingsPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (DocumentSettingsPart._dataPartReferenceConstraint == null)
        DocumentSettingsPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) DocumentSettingsPart._dataPartReferenceConstraint;
    }

    protected internal DocumentSettingsPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData":
          return (OpenXmlPart) new MailMergeRecipientDataPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType)
    {
      MailMergeRecipientDataPart newPart = new MailMergeRecipientDataPart();
      this.InitPart<MailMergeRecipientDataPart>(newPart, contentType);
      return newPart;
    }

    public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType)
    {
      string contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
      string targetExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddMailMergeRecipientDataPart(contentType);
    }

    public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType, string id)
    {
      MailMergeRecipientDataPart newPart = new MailMergeRecipientDataPart();
      this.InitPart<MailMergeRecipientDataPart>(newPart, contentType, id);
      return newPart;
    }

    public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType, string id)
    {
      string contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
      string targetExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddMailMergeRecipientDataPart(contentType, id);
    }

    public ImagePart AddImagePart(string contentType)
    {
      ImagePart newPart = new ImagePart();
      this.InitPart<ImagePart>(newPart, contentType);
      return newPart;
    }

    public ImagePart AddImagePart(ImagePartType partType)
    {
      string contentType = ImagePartTypeInfo.GetContentType(partType);
      string targetExtension = ImagePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddImagePart(contentType);
    }

    public ImagePart AddImagePart(string contentType, string id)
    {
      ImagePart newPart = new ImagePart();
      this.InitPart<ImagePart>(newPart, contentType, id);
      return newPart;
    }

    public ImagePart AddImagePart(ImagePartType partType, string id)
    {
      string contentType = ImagePartTypeInfo.GetContentType(partType);
      string targetExtension = ImagePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddImagePart(contentType, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml";
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
        return "settings";
      }
    }

    public MailMergeRecipientDataPart MailMergeRecipientDataPart
    {
      get
      {
        return this.GetSubPartOfType<MailMergeRecipientDataPart>();
      }
    }

    public IEnumerable<ImagePart> ImageParts
    {
      get
      {
        return this.GetPartsOfType<ImagePart>();
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
        this._rootEle = value as Settings;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Settings;
      }
    }

    public Settings Settings
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Settings>();
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
