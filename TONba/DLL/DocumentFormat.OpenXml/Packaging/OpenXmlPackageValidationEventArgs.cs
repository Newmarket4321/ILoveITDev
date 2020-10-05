// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.OpenXmlPackageValidationEventArgs
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  [Obsolete("This functionality is obsolete and will be removed from future version release. Please see OpenXmlValidator class for supported validation functionality.", false)]
  [Serializable]
  public sealed class OpenXmlPackageValidationEventArgs : EventArgs
  {
    private string _message;
    private string _partClassName;
    [NonSerialized]
    private OpenXmlPart _childPart;
    [NonSerialized]
    private OpenXmlPart _parentPart;

    internal OpenXmlPackageValidationEventArgs()
    {
    }

    public string Message
    {
      get
      {
        if (this._message == null && this.MessageId != null)
          return ExceptionMessages.ResourceManager.GetString(this.MessageId);
        return this._message;
      }
      set
      {
        this._message = value;
      }
    }

    public string PartClassName
    {
      get
      {
        return this._partClassName;
      }
      internal set
      {
        this._partClassName = value;
      }
    }

    public OpenXmlPart SubPart
    {
      get
      {
        return this._childPart;
      }
      internal set
      {
        this._childPart = value;
      }
    }

    public OpenXmlPart Part
    {
      get
      {
        return this._parentPart;
      }
      internal set
      {
        this._parentPart = value;
      }
    }

    internal string MessageId { get; set; }

    internal DataPartReferenceRelationship DataPartReferenceRelationship { get; set; }
  }
}
