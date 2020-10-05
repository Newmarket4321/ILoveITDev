// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace DocumentFormat.OpenXml.Packaging
{
  public class MailMergeRecipientDataPart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "recipients";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private OpenXmlPartRootElement _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (MailMergeRecipientDataPart._partConstraint == null)
        MailMergeRecipientDataPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) MailMergeRecipientDataPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (MailMergeRecipientDataPart._dataPartReferenceConstraint == null)
        MailMergeRecipientDataPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) MailMergeRecipientDataPart._dataPartReferenceConstraint;
    }

    protected internal MailMergeRecipientDataPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData";
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
        return "recipients";
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return false;
      }
    }

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return this._rootEle;
      }
      set
      {
        this._rootEle = value;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        if (this.Recipients != null)
          return (OpenXmlPartRootElement) this.Recipients;
        return (OpenXmlPartRootElement) this.MailMergeRecipients;
      }
    }

    public Recipients Recipients
    {
      get
      {
        this.TryLoadRootElement();
        return this._rootEle as Recipients;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        if (this.MailMergeRecipients != null)
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, ExceptionMessages.PropertyMutualExclusive, new object[2]
          {
            (object) nameof (Recipients),
            (object) "MailMergeRecipients"
          }));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }

    public MailMergeRecipients MailMergeRecipients
    {
      get
      {
        this.TryLoadRootElement();
        return this._rootEle as MailMergeRecipients;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        if (this.Recipients != null)
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, ExceptionMessages.PropertyMutualExclusive, new object[2]
          {
            (object) nameof (MailMergeRecipients),
            (object) "Recipients"
          }));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }

    private void TryLoadRootElement()
    {
      if (this._rootEle != null)
        return;
      try
      {
        this.LoadDomTree<Recipients>();
      }
      catch (InvalidDataException ex)
      {
      }
      if (this._rootEle != null)
        return;
      this.LoadDomTree<MailMergeRecipients>();
    }
  }
}
