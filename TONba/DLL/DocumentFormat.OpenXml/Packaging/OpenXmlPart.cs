// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.OpenXmlPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Packaging;
using System.Xml;
using System.Xml.Schema;

namespace DocumentFormat.OpenXml.Packaging
{
  public abstract class OpenXmlPart : OpenXmlPartContainer
  {
    private string documentClassNameOfWord = "DocumentFormat.OpenXml.Packaging.WordprocessingDocument";
    private string documentClassNameOfExcel = "DocumentFormat.OpenXml.Packaging.SpreadsheetDocument";
    private string documentClassNameOfPPT = "DocumentFormat.OpenXml.Packaging.PresentationDocument";
    private const string DefaultTargetExt = ".xml";
    private OpenXmlPackage _openXmlPackage;
    private PackagePart _metroPart;
    private Uri _uri;
    internal MarkupCompatibilityProcessSettings MCSettings;

    protected internal OpenXmlPart()
    {
    }

    internal void Load(OpenXmlPackage openXmlPackage, OpenXmlPart parent, Uri uriTarget, string id, Dictionary<Uri, OpenXmlPart> loadedParts)
    {
      if (uriTarget == (Uri) null)
        throw new ArgumentNullException(nameof (uriTarget));
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      if (openXmlPackage == null && parent == null)
        throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
      if (parent != null && openXmlPackage != null && parent.OpenXmlPackage != openXmlPackage)
        throw new ArgumentOutOfRangeException(nameof (parent));
      if (parent != null && openXmlPackage == null)
        openXmlPackage = parent.OpenXmlPackage;
      this._openXmlPackage = openXmlPackage;
      this._uri = uriTarget;
      PackagePart part = this.OpenXmlPackage.Package.GetPart(uriTarget);
      if (this.IsContentTypeFixed && part.ContentType != this.ContentType)
        throw new OpenXmlPackageException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.InvalidPartContentType, (object) part.Uri.OriginalString, (object) part.ContentType, (object) this.ContentType));
      this._metroPart = part;
      this.OpenXmlPackage.ReserveUri(this.ContentType, this.Uri);
      RelationshipCollection relationshipCollection = (RelationshipCollection) new PackagePartRelationshipPropertyCollection(this.PackagePart);
      this.LoadReferencedPartsAndRelationships(openXmlPackage, this, relationshipCollection, loadedParts);
    }

    internal override sealed OpenXmlPart NewPart(string relationshipType, string contentType)
    {
      this.ThrowIfObjectDisposed();
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      PartConstraintRule partConstraintRule;
      if (!this.GetPartConstraint().TryGetValue(relationshipType, out partConstraintRule))
        throw new ArgumentOutOfRangeException(nameof (relationshipType));
      if (!partConstraintRule.MaxOccursGreatThanOne && this.GetSubPart(relationshipType) != null)
        throw new InvalidOperationException(ExceptionMessages.OnlyOnePartAllowed);
      OpenXmlPart openXmlPart = this.CreateOpenXmlPart(relationshipType);
      openXmlPart.CreateInternal(this.OpenXmlPackage, this, contentType, (string) null);
      this.ChildrenParts.Add(this.AttachChild(openXmlPart), openXmlPart);
      return openXmlPart;
    }

    internal string GetTargetPath(string defaultPath)
    {
      string str1 = (string) null;
      if (this.TargetPathOfWord != null || this.TargetPathOfExcel != null || this.TargetPathOfPPT != null)
      {
        string str2 = this._openXmlPackage.GetType().ToString();
        if (this.TargetPathOfWord != null && str2 == this.documentClassNameOfWord)
          str1 = this.TargetPathOfWord;
        else if (this.TargetPathOfExcel != null && str2 == this.documentClassNameOfExcel)
          str1 = this.TargetPathOfExcel;
        else if (this.TargetPathOfPPT != null && str2 == this.documentClassNameOfPPT)
          str1 = this.TargetPathOfPPT;
      }
      return str1 ?? defaultPath;
    }

    internal void CreateInternal(OpenXmlPackage openXmlPackage, OpenXmlPart parent, string contentType, string targetExt)
    {
      if (openXmlPackage == null && parent == null)
        throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
      if (parent != null && openXmlPackage != null && parent.OpenXmlPackage != openXmlPackage)
        throw new ArgumentOutOfRangeException(nameof (parent));
      if (parent != null && openXmlPackage == null)
        openXmlPackage = parent.OpenXmlPackage;
      if (this._metroPart != null)
        throw new InvalidOperationException();
      this._openXmlPackage = openXmlPackage;
      Uri parentUri = parent == null ? new Uri("/", UriKind.Relative) : parent.Uri;
      string targetPath = this.GetTargetPath(this.TargetPath) ?? ".";
      string targetExt1 = targetExt;
      if (!this.IsContentTypeFixed && !this._openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out targetExt1))
        targetExt1 = targetExt;
      if (targetExt1 == null)
        targetExt1 = this.TargetFileExtension;
      this._uri = this._openXmlPackage.GetUniquePartUri(contentType, parentUri, targetPath, this.TargetName, targetExt1);
      this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
    }

    internal void CreateInternal2(OpenXmlPackage openXmlPackage, OpenXmlPart parent, string contentType, Uri partUri)
    {
      if (openXmlPackage == null && parent == null)
        throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
      if (parent != null && openXmlPackage != null && parent.OpenXmlPackage != openXmlPackage)
        throw new ArgumentOutOfRangeException(nameof (parent));
      if (parent != null && openXmlPackage == null)
        openXmlPackage = parent.OpenXmlPackage;
      if (this._metroPart != null)
        throw new InvalidOperationException();
      this._openXmlPackage = openXmlPackage;
      Uri parentUri = parent == null ? new Uri("/", UriKind.Relative) : parent.Uri;
      this._uri = this._openXmlPackage.GetUniquePartUri(contentType, parentUri, partUri);
      this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
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

    public IEnumerable<OpenXmlPart> GetParentParts()
    {
      this.ThrowIfObjectDisposed();
      Dictionary<OpenXmlPart, bool> liveParts = new Dictionary<OpenXmlPart, bool>();
      this.OpenXmlPackage.FindAllReachableParts((IDictionary<OpenXmlPart, bool>) liveParts);
      foreach (OpenXmlPart key in liveParts.Keys)
      {
        if (key.IsChildPart(this))
          yield return key;
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

    public abstract string RelationshipType { get; }

    [Obsolete("This functionality is obsolete and will be removed from future version release. Please see OpenXmlValidator class for supported validation functionality.", false)]
    public void ValidateXml(XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
    {
      this.ThrowIfObjectDisposed();
      if (schemas == null)
        throw new ArgumentNullException(nameof (schemas));
      XmlReaderSettings settings = new XmlReaderSettings();
      settings.DtdProcessing = DtdProcessing.Prohibit;
      settings.MaxCharactersInDocument = this.MaxCharactersInPart;
      using (Stream stream = this.GetStream())
      {
        settings.Schemas = schemas;
        settings.ValidationType = ValidationType.Schema;
        if (validationEventHandler != null)
          settings.ValidationEventHandler += validationEventHandler;
        XmlReader xmlReader;
        using (xmlReader = XmlConvertingReaderFactory.Create(stream, settings))
        {
          do
            ;
          while (xmlReader.Read());
        }
      }
    }

    [Obsolete("This functionality is obsolete and will be removed from future version release. Please see OpenXmlValidator class for supported validation functionality.", false)]
    public void ValidateXml(string schemaFile, ValidationEventHandler validationEventHandler)
    {
      this.ThrowIfObjectDisposed();
      if (schemaFile == null)
        throw new ArgumentNullException(nameof (schemaFile));
      XmlSchemaSet schemas = new XmlSchemaSet();
      schemas.Add((string) null, schemaFile);
      this.ValidateXml(schemas, validationEventHandler);
    }

    public OpenXmlPartRootElement RootElement
    {
      get
      {
        return this.PartRootElement;
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

    internal long MaxCharactersInPart
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.OpenXmlPackage.MaxCharactersInPart;
      }
    }

    internal virtual bool IsContentTypeFixed
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return false;
      }
    }

    internal override sealed void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
    {
      this.ThrowIfObjectDisposed();
      if (reachableParts == null)
        throw new ArgumentNullException(nameof (reachableParts));
      reachableParts.Add(this, false);
      foreach (OpenXmlPart key in (IEnumerable<OpenXmlPart>) this.ChildrenParts.Values)
      {
        if (!reachableParts.ContainsKey(key))
          key.FindAllReachableParts(reachableParts);
      }
    }

    internal virtual string TargetPath
    {
      get
      {
        return (string) null;
      }
    }

    internal virtual string TargetPathOfWord
    {
      get
      {
        return (string) null;
      }
    }

    internal virtual string TargetPathOfExcel
    {
      get
      {
        return (string) null;
      }
    }

    internal virtual string TargetPathOfPPT
    {
      get
      {
        return (string) null;
      }
    }

    internal abstract string TargetName { get; }

    internal virtual string TargetFileExtension
    {
      get
      {
        return ".xml";
      }
    }

    internal virtual OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) null;
      }
      set
      {
        throw new InvalidOperationException();
      }
    }

    internal virtual OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) null;
      }
    }

    internal virtual bool IsInVersion(FileFormatVersions version)
    {
      return true;
    }

    internal bool IsRootElementLoaded
    {
      get
      {
        return this._rootElement != null;
      }
    }

    internal OpenXmlPartRootElement SetPartRootElementToNull()
    {
      OpenXmlPartRootElement rootElement = this._rootElement;
      if (this._rootElement != null)
        this._rootElement = (OpenXmlPartRootElement) null;
      return rootElement;
    }

    internal void LoadDomTree<T>() where T : OpenXmlPartRootElement, new()
    {
      bool flag = true;
      using (Stream stream = this.GetStream(FileMode.OpenOrCreate, FileAccess.Read))
      {
        if (stream.Length > 0L)
          flag = false;
        if (flag)
          return;
        T instance = Activator.CreateInstance<T>();
        try
        {
          if (!instance.LoadFromPart(this, stream))
            return;
          instance.OpenXmlPart = this;
          this._rootElement = (OpenXmlPartRootElement) instance;
        }
        catch (InvalidDataException ex)
        {
          throw new InvalidDataException(ExceptionMessages.CannotLoadRootElement, (Exception) ex);
        }
      }
    }

    internal void SetDomTree(OpenXmlPartRootElement partRootElement)
    {
      if (partRootElement.OpenXmlPart != null)
        throw new ArgumentException(ExceptionMessages.PartRootAlreadyHasAssociation, nameof (partRootElement));
      partRootElement.OpenXmlPart = this;
      if (this._rootElement != null)
        this._rootElement.OpenXmlPart = (OpenXmlPart) null;
      this._rootElement = partRootElement;
    }

    internal void Destroy()
    {
      this.OpenXmlPackage.Package.DeletePart(this.Uri);
      this.PartDictionary = (Dictionary<string, OpenXmlPart>) null;
      this.ReferenceRelationshipList.Clear();
      this._openXmlPackage = (OpenXmlPackage) null;
      this._metroPart = (PackagePart) null;
      this._uri = (Uri) null;
      if (this._rootElement == null)
        return;
      this._rootElement.OpenXmlPart = (OpenXmlPart) null;
      this._rootElement = (OpenXmlPartRootElement) null;
    }

    protected override sealed void ThrowIfObjectDisposed()
    {
      if (this._openXmlPackage == null)
        throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
    }

    internal override sealed OpenXmlPackage InternalOpenXmlPackage
    {
      get
      {
        return this._openXmlPackage;
      }
    }

    internal override sealed OpenXmlPart ThisOpenXmlPart
    {
      get
      {
        return this;
      }
    }

    internal override sealed void DeleteRelationship(string id)
    {
      this.ThrowIfObjectDisposed();
      this.PackagePart.DeleteRelationship(id);
    }

    internal override sealed PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      return this._metroPart.CreateRelationship(targetUri, targetMode, relationshipType);
    }

    internal override sealed PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id)
    {
      this.ThrowIfObjectDisposed();
      return this._metroPart.CreateRelationship(targetUri, targetMode, relationshipType, id);
    }

    internal static void CopyStream(Stream sourceStream, Stream targetStream)
    {
      if (sourceStream == null)
        throw new ArgumentNullException(nameof (sourceStream));
      using (BinaryReader binaryReader = new BinaryReader(sourceStream))
      {
        byte[] buffer = new byte[4096];
        int count;
        do
        {
          count = binaryReader.Read(buffer, 0, 4096);
          if (count > 0)
            targetStream.Write(buffer, 0, count);
        }
        while (count > 0);
      }
    }
  }
}
