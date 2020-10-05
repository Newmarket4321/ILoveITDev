// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DataPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DataPart
  {
    private const string DefaultTargetPart = "data";
    private const string DefaultTargetName = "data";
    private const string DefaultTargetExt = ".bin";
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private OpenXmlPackage _openXmlPackage;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private PackagePart _metroPart;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Uri _uri;

    internal DataPart()
    {
    }

    public OpenXmlPackage OpenXmlPackage
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._openXmlPackage;
      }
    }

    public Uri Uri
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._uri;
      }
    }

    public IEnumerable<DataPartReferenceRelationship> GetDataPartReferenceRelationships()
    {
      this.ThrowIfObjectDisposed();
      foreach (DataPartReferenceRelationship referenceRelationship in this.OpenXmlPackage.DataPartReferenceRelationships)
      {
        if (referenceRelationship.DataPart == this)
          yield return referenceRelationship;
      }
      OpenXmlPackagePartIterator partIterator = new OpenXmlPackagePartIterator(this.OpenXmlPackage);
      foreach (OpenXmlPart openXmlPart in partIterator)
      {
        foreach (DataPartReferenceRelationship referenceRelationship in openXmlPart.DataPartReferenceRelationships)
        {
          if (referenceRelationship.DataPart == this)
            yield return referenceRelationship;
        }
      }
    }

    public Stream GetStream()
    {
      this.ThrowIfObjectDisposed();
      return this.PackagePart.GetStream();
    }

    public Stream GetStream(FileMode mode)
    {
      this.ThrowIfObjectDisposed();
      return this.PackagePart.GetStream(mode);
    }

    public Stream GetStream(FileMode mode, FileAccess access)
    {
      this.ThrowIfObjectDisposed();
      return this.PackagePart.GetStream(mode, access);
    }

    public void FeedData(Stream sourceStream)
    {
      this.ThrowIfObjectDisposed();
      if (sourceStream == null)
        throw new ArgumentNullException(nameof (sourceStream));
      using (Stream stream = this.GetStream(FileMode.Create))
        OpenXmlPart.CopyStream(sourceStream, stream);
    }

    public virtual string ContentType
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.PackagePart.ContentType;
      }
    }

    internal PackagePart PackagePart
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._metroPart;
      }
    }

    internal virtual string TargetPath
    {
      get
      {
        return "data";
      }
    }

    internal virtual string TargetName
    {
      get
      {
        return "data";
      }
    }

    internal virtual string TargetFileExtension
    {
      get
      {
        return ".bin";
      }
    }

    internal void Load(OpenXmlPackage openXmlPackage, PackagePart packagePart)
    {
      this._openXmlPackage = openXmlPackage;
      this._metroPart = packagePart;
      this._uri = packagePart.Uri;
      if (this._metroPart.GetRelationships().Any<PackageRelationship>())
        throw new OpenXmlPackageException(ExceptionMessages.MediaDataPartShouldNotReferenceOtherParts);
    }

    internal void CreateInternal(OpenXmlPackage openXmlPackage, string contentType, string extension)
    {
      this._openXmlPackage = openXmlPackage;
      this._uri = this.NewPartUri(openXmlPackage, contentType, extension);
      this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
    }

    internal void CreateInternal(OpenXmlPackage openXmlPackage, MediaDataPartType mediaDataPartType)
    {
      this._openXmlPackage = openXmlPackage;
      string contentType = mediaDataPartType.GetContentType();
      string targetExtension = mediaDataPartType.GetTargetExtension();
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      this._uri = this.NewPartUri(openXmlPackage, contentType, (string) null);
      this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
    }

    internal void CreateInternal2(OpenXmlPackage openXmlPackage, string contentType, Uri partUri)
    {
      if (openXmlPackage == null)
        throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
      if (this._metroPart != null)
        throw new InvalidOperationException();
      this._openXmlPackage = openXmlPackage;
      Uri parentUri = new Uri("/", UriKind.Relative);
      this._uri = this._openXmlPackage.GetUniquePartUri(contentType, parentUri, partUri);
      this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
    }

    internal Uri NewPartUri(OpenXmlPackage openXmlPackage, string contentType, string extension)
    {
      string targetExt;
      if (extension == null)
      {
        if (!this._openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out targetExt))
          targetExt = this.TargetFileExtension;
      }
      else
        targetExt = extension;
      return openXmlPackage.GetUniquePartUri(contentType, new Uri("/", UriKind.Relative), this.TargetPath, this.TargetName, targetExt);
    }

    internal void Destroy()
    {
      this.OpenXmlPackage.Package.DeletePart(this.Uri);
      this._openXmlPackage = (OpenXmlPackage) null;
    }

    protected void ThrowIfObjectDisposed()
    {
      if (this._openXmlPackage == null)
        throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
    }
  }
}
