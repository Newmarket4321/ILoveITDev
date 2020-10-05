// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.OpenXmlPackage
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
  public abstract class OpenXmlPackage : OpenXmlPartContainer, IDisposable
  {
    private OpenXmlPackage.PartUriHelper _partUriHelper = new OpenXmlPackage.PartUriHelper();
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private PartExtensionProvider _partExtensionProvider = new PartExtensionProvider();
    private LinkedList<DataPart> _dataPartList = new LinkedList<DataPart>();
    private bool _disposed;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Package _metroPackage;
    private FileAccess _accessMode;
    private string _mainPartContentType;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private CompressionOption _compressionOption;
    private bool _strictTranslation;

    internal OpenSettings OpenSettings { get; set; }

    internal bool StrictTranslation
    {
      get
      {
        return this._strictTranslation;
      }
      set
      {
        this._strictTranslation = value;
      }
    }

    internal void OpenCore(Package package)
    {
      if (package == null)
        throw new ArgumentNullException(nameof (package));
      if (package.FileOpenAccess == FileAccess.Write)
        throw new IOException(ExceptionMessages.PackageMustCanBeRead);
      this._accessMode = package.FileOpenAccess;
      this._metroPackage = package;
      this.Load();
    }

    internal void CreateCore(Package package)
    {
      if (package == null)
        throw new ArgumentNullException(nameof (package));
      this._accessMode = package.FileOpenAccess;
      this._metroPackage = package;
    }

    internal void OpenCore(Stream stream, bool readWriteMode)
    {
      if (stream == null)
        throw new ArgumentNullException(nameof (stream));
      this._accessMode = !readWriteMode ? FileAccess.Read : FileAccess.ReadWrite;
      this._metroPackage = Package.Open(stream, this._accessMode == FileAccess.Read ? FileMode.Open : FileMode.OpenOrCreate, this._accessMode);
      this.Load();
    }

    internal void CreateCore(Stream stream)
    {
      if (stream == null)
        throw new ArgumentNullException(nameof (stream));
      if (!stream.CanWrite)
        throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
      this._accessMode = FileAccess.ReadWrite;
      this._metroPackage = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite);
    }

    internal void OpenCore(string path, bool readWriteMode)
    {
      if (path == null)
        throw new ArgumentNullException(nameof (path));
      this._accessMode = !readWriteMode ? FileAccess.Read : FileAccess.ReadWrite;
      this._metroPackage = Package.Open(path, this._accessMode == FileAccess.Read ? FileMode.Open : FileMode.OpenOrCreate, this._accessMode, this._accessMode == FileAccess.Read ? FileShare.Read : FileShare.None);
      this.Load();
    }

    internal void CreateCore(string path)
    {
      if (path == null)
        throw new ArgumentNullException(nameof (path));
      this._accessMode = FileAccess.ReadWrite;
      this._metroPackage = Package.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
    }

    private void Load()
    {
      Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPackage_Load_In);
      try
      {
        Dictionary<Uri, OpenXmlPart> loadedParts = new Dictionary<Uri, OpenXmlPart>();
        bool flag = false;
        RelationshipCollection relationshipCollection = (RelationshipCollection) new PackageRelationshipPropertyCollection(this._metroPackage);
        this.StrictTranslation = relationshipCollection.StrictTranslation;
        foreach (RelationshipProperty relationshipProperty in (CollectionBase) relationshipCollection)
        {
          if (relationshipProperty.RelationshipType == this.MainPartRelationshipType)
          {
            flag = true;
            PackagePart part = this.Package.GetPart(PackUriHelper.ResolvePartUri(new Uri("/", UriKind.Relative), relationshipProperty.TargetUri));
            if (!this.IsValidMainPartContentType(part.ContentType))
              throw new OpenXmlPackageException(ExceptionMessages.InvalidPackageType);
            this.MainPartContentType = part.ContentType;
            break;
          }
        }
        if (!flag)
          throw new OpenXmlPackageException(ExceptionMessages.NoMainPart);
        this.LoadReferencedPartsAndRelationships(this, (OpenXmlPart) null, relationshipCollection, loadedParts);
      }
      catch (OpenXmlPackageException ex)
      {
        this.Close();
        throw;
      }
      catch (UriFormatException ex)
      {
        OpenXmlPackageException packageException = new OpenXmlPackageException(ExceptionMessages.InvalidUriFormat);
        this.Close();
        throw packageException;
      }
      catch (Exception ex)
      {
        this.Close();
        throw;
      }
      Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPackage_Load_Out);
    }

    public Package Package
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._metroPackage;
      }
    }

    public FileAccess FileOpenAccess
    {
      get
      {
        return this._metroPackage.FileOpenAccess;
      }
    }

    public CompressionOption CompressionOption
    {
      get
      {
        return this._compressionOption;
      }
      set
      {
        this._compressionOption = value;
      }
    }

    public PackageProperties PackageProperties
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.Package.PackageProperties;
      }
    }

    public PartExtensionProvider PartExtensionProvider
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._partExtensionProvider;
      }
    }

    public long MaxCharactersInPart { get; internal set; }

    public IEnumerable<DataPart> DataParts
    {
      get
      {
        return (IEnumerable<DataPart>) this._dataPartList;
      }
    }

    public override T AddPart<T>(T part)
    {
      this.ThrowIfObjectDisposed();
      if ((object) part == null)
        throw new ArgumentNullException(nameof (part));
      if (part.RelationshipType == this.MainPartRelationshipType && part.ContentType != this.MainPartContentType)
        throw new ArgumentOutOfRangeException(ExceptionMessages.MainPartIsDifferent);
      return (T) this.AddPartFrom((OpenXmlPart) part, (string) null);
    }

    public void DeletePartsRecursivelyOfType<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      this.DeletePartsRecursivelyOfTypeBase<T>();
    }

    public void Close()
    {
      this.ThrowIfObjectDisposed();
      this.Dispose();
    }

    public MediaDataPart CreateMediaDataPart(string contentType)
    {
      this.ThrowIfObjectDisposed();
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      MediaDataPart mediaDataPart = new MediaDataPart();
      mediaDataPart.CreateInternal(this.InternalOpenXmlPackage, contentType, (string) null);
      this._dataPartList.AddLast((DataPart) mediaDataPart);
      return mediaDataPart;
    }

    public MediaDataPart CreateMediaDataPart(string contentType, string extension)
    {
      this.ThrowIfObjectDisposed();
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (extension == null)
        throw new ArgumentNullException(nameof (extension));
      MediaDataPart mediaDataPart = new MediaDataPart();
      mediaDataPart.CreateInternal(this.InternalOpenXmlPackage, contentType, extension);
      this._dataPartList.AddLast((DataPart) mediaDataPart);
      return mediaDataPart;
    }

    public MediaDataPart CreateMediaDataPart(MediaDataPartType mediaDataPartType)
    {
      this.ThrowIfObjectDisposed();
      MediaDataPart mediaDataPart = new MediaDataPart();
      mediaDataPart.CreateInternal(this.InternalOpenXmlPackage, mediaDataPartType);
      this._dataPartList.AddLast((DataPart) mediaDataPart);
      return mediaDataPart;
    }

    public bool DeletePart(DataPart dataPart)
    {
      this.ThrowIfObjectDisposed();
      if (dataPart == null)
        throw new ArgumentNullException(nameof (dataPart));
      if (dataPart.OpenXmlPackage != this)
        throw new InvalidOperationException(ExceptionMessages.ForeignDataPart);
      if (!OpenXmlPackage.IsOrphanDataPart(dataPart))
        throw new InvalidOperationException(ExceptionMessages.DataPartIsInUse);
      dataPart.Destroy();
      return this._dataPartList.Remove(dataPart);
    }

    [Obsolete("This functionality is obsolete and will be removed from future version release. Please see OpenXmlValidator class for supported validation functionality.", false)]
    public void Validate(OpenXmlPackageValidationSettings validationSettings)
    {
      this.ThrowIfObjectDisposed();
      OpenXmlPackageValidationSettings validationSettings1;
      if (validationSettings != null && validationSettings.GetEventHandler() != null)
      {
        validationSettings1 = validationSettings;
      }
      else
      {
        validationSettings1 = new OpenXmlPackageValidationSettings();
        validationSettings1.EventHandler += new EventHandler<OpenXmlPackageValidationEventArgs>(OpenXmlPackage.DefaultValidationEventHandler);
      }
      validationSettings1.FileFormat = FileFormatVersions.Office2007;
      Dictionary<OpenXmlPart, bool> processedParts = new Dictionary<OpenXmlPart, bool>();
      this.ValidateInternal(validationSettings1, processedParts);
    }

    internal void Validate(OpenXmlPackageValidationSettings validationSettings, FileFormatVersions fileFormatVersion)
    {
      this.ThrowIfObjectDisposed();
      validationSettings.FileFormat = fileFormatVersion;
      Dictionary<OpenXmlPart, bool> processedParts = new Dictionary<OpenXmlPart, bool>();
      this.ValidateInternal(validationSettings, processedParts);
    }

    internal void ReserveUri(string contentType, Uri partUri)
    {
      this.ThrowIfObjectDisposed();
      this._partUriHelper.ReserveUri(contentType, partUri);
    }

    internal Uri GetUniquePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt)
    {
      this.ThrowIfObjectDisposed();
      Uri uniquePartUri;
      do
      {
        uniquePartUri = this._partUriHelper.GetUniquePartUri(contentType, parentUri, targetPath, targetName, targetExt);
      }
      while (this._metroPackage.PartExists(uniquePartUri));
      return uniquePartUri;
    }

    internal Uri GetUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
    {
      this.ThrowIfObjectDisposed();
      Uri uniquePartUri;
      do
      {
        uniquePartUri = this._partUriHelper.GetUniquePartUri(contentType, parentUri, targetUri);
      }
      while (this._metroPackage.PartExists(uniquePartUri));
      return uniquePartUri;
    }

    protected override void ThrowIfObjectDisposed()
    {
      if (this._disposed)
        throw new ObjectDisposedException(this.GetType().Name);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this._disposed)
        return;
      if (disposing)
      {
        this.SavePartContents();
        this.DeleteUnusedDataPartOnClose();
        this._metroPackage.Close();
        this._metroPackage = (Package) null;
        this.PartDictionary = (Dictionary<string, OpenXmlPart>) null;
        this.ReferenceRelationshipList.Clear();
        this._partUriHelper = (OpenXmlPackage.PartUriHelper) null;
      }
      this._disposed = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public MarkupCompatibilityProcessSettings MarkupCompatibilityProcessSettings
    {
      get
      {
        if (this.OpenSettings.MarkupCompatibilityProcessSettings == null)
          return new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);
        return this.OpenSettings.MarkupCompatibilityProcessSettings;
      }
    }

    public bool AutoSave
    {
      get
      {
        return this.OpenSettings.AutoSave;
      }
    }

    private void SavePartContents()
    {
      if (this.FileOpenAccess == FileAccess.Read || !this.AutoSave && !this.StrictTranslation)
        return;
      OpenXmlPackagePartIterator packagePartIterator = new OpenXmlPackagePartIterator(this);
      bool flag = false;
      foreach (OpenXmlPart openXmlPart in packagePartIterator)
      {
        if (openXmlPart.IsRootElementLoaded)
        {
          flag = true;
          break;
        }
      }
      if (!flag)
        return;
      foreach (OpenXmlPart part in packagePartIterator)
        OpenXmlPackage.TrySavePartContent(part);
      if (!this.StrictTranslation)
        return;
      new PackageRelationshipPropertyCollection(this._metroPackage).UpdateRelationshipTypesInPackage();
    }

    private static void TrySavePartContent(OpenXmlPart part)
    {
      if (part.OpenXmlPackage.StrictTranslation)
      {
        new PackagePartRelationshipPropertyCollection(part.PackagePart).UpdateRelationshipTypesInPackage();
        if (part.PartRootElement == null)
          return;
        OpenXmlPackage.SavePartContent(part);
      }
      else
      {
        if (!OpenXmlPackage.IsPartContentChanged(part))
          return;
        OpenXmlPackage.SavePartContent(part);
      }
    }

    private static bool IsPartContentChanged(OpenXmlPart part)
    {
      if (!part.IsRootElementLoaded && part.OpenXmlPackage.MarkupCompatibilityProcessSettings.ProcessMode == MarkupCompatibilityProcessMode.ProcessAllParts && part.PartRootElement != null)
        return true;
      return part.IsRootElementLoaded;
    }

    private static void SavePartContent(OpenXmlPart part)
    {
      part.PartRootElement.Save();
    }

    internal abstract string MainPartRelationshipType { get; }

    internal string MainPartContentType
    {
      get
      {
        return this._mainPartContentType;
      }
      set
      {
        if (!this.IsValidMainPartContentType(value))
          throw new ArgumentOutOfRangeException(ExceptionMessages.InvalidMainPartContentType);
        this._mainPartContentType = value;
      }
    }

    internal abstract ICollection<string> ValidMainPartContentTypes { get; }

    internal bool IsValidMainPartContentType(string contentType)
    {
      return this.ValidMainPartContentTypes.Contains(contentType);
    }

    internal void ChangeDocumentTypeInternal<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      T subPartOfType = this.GetSubPartOfType<T>();
      MemoryStream memoryStream = (MemoryStream) null;
      Dictionary<string, OpenXmlPart> dictionary = new Dictionary<string, OpenXmlPart>();
      ExtendedPart extendedPart;
      ReferenceRelationship[] array;
      try
      {
        using (Stream stream = subPartOfType.GetStream())
        {
          if (stream.Length > (long) int.MaxValue)
            throw new OpenXmlPackageException(ExceptionMessages.DocumentTooBig);
          memoryStream = new MemoryStream(Convert.ToInt32(stream.Length));
          OpenXmlPart.CopyStream(stream, (Stream) memoryStream);
        }
        extendedPart = this.AddExtendedPart("http://temp", this.MainPartContentType, ".xml");
        foreach (KeyValuePair<string, OpenXmlPart> childrenPart in (IEnumerable<KeyValuePair<string, OpenXmlPart>>) subPartOfType.ChildrenParts)
          dictionary.Add(childrenPart.Key, childrenPart.Value);
        array = subPartOfType.ReferenceRelationshipList.ToArray<ReferenceRelationship>();
      }
      catch (OpenXmlPackageException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, (Exception) ex);
      }
      catch (SystemException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, (Exception) ex);
      }
      try
      {
        Uri uri = subPartOfType.Uri;
        string idOfPart1 = this.GetIdOfPart((OpenXmlPart) subPartOfType);
        this.ChildrenParts.Remove(idOfPart1);
        this.DeleteRelationship(idOfPart1);
        subPartOfType.Destroy();
        T instance = (T) Activator.CreateInstance(typeof (T), true);
        instance.CreateInternal2(this, (OpenXmlPart) null, this.MainPartContentType, uri);
        this.ChildrenParts.Add(this.AttachChild((OpenXmlPart) instance, idOfPart1), (OpenXmlPart) instance);
        memoryStream.Position = 0L;
        instance.FeedData((Stream) memoryStream);
        foreach (KeyValuePair<string, OpenXmlPart> keyValuePair in dictionary)
        {
          instance.AttachChild(keyValuePair.Value, keyValuePair.Key);
          instance.ChildrenParts.Add(keyValuePair);
        }
        foreach (ExternalRelationship externalRelationship in array.OfType<ExternalRelationship>())
          instance.AddExternalRelationship(externalRelationship.RelationshipType, externalRelationship.Uri, externalRelationship.Id);
        foreach (HyperlinkRelationship hyperlinkRelationship in array.OfType<HyperlinkRelationship>())
          instance.AddHyperlinkRelationship(hyperlinkRelationship.Uri, hyperlinkRelationship.IsExternal, hyperlinkRelationship.Id);
        foreach (DataPartReferenceRelationship dataPartReferenceRelationship in array.OfType<DataPartReferenceRelationship>())
          instance.AddDataPartReferenceRelationship(dataPartReferenceRelationship);
        string idOfPart2 = this.GetIdOfPart((OpenXmlPart) extendedPart);
        this.ChildrenParts.Remove(idOfPart2);
        this.DeleteRelationship(idOfPart2);
        extendedPart.Destroy();
      }
      catch (OpenXmlPackageException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, (Exception) ex);
      }
      catch (SystemException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentTypeSerious, (Exception) ex);
      }
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
        throw new InvalidOperationException();
      OpenXmlPart openXmlPart = this.CreateOpenXmlPart(relationshipType);
      openXmlPart.CreateInternal(this, (OpenXmlPart) null, contentType, (string) null);
      this.ChildrenParts.Add(this.AttachChild(openXmlPart), openXmlPart);
      return openXmlPart;
    }

    internal override sealed OpenXmlPackage InternalOpenXmlPackage
    {
      get
      {
        return this;
      }
    }

    internal override sealed OpenXmlPart ThisOpenXmlPart
    {
      get
      {
        return (OpenXmlPart) null;
      }
    }

    internal override sealed void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
    {
      this.ThrowIfObjectDisposed();
      if (reachableParts == null)
        throw new ArgumentNullException(nameof (reachableParts));
      foreach (OpenXmlPart key in (IEnumerable<OpenXmlPart>) this.ChildrenParts.Values)
      {
        if (!reachableParts.ContainsKey(key))
          key.FindAllReachableParts(reachableParts);
      }
    }

    internal override sealed void DeleteRelationship(string id)
    {
      this.ThrowIfObjectDisposed();
      this.Package.DeleteRelationship(id);
    }

    internal override sealed PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      return this.Package.CreateRelationship(targetUri, targetMode, relationshipType);
    }

    internal override sealed PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id)
    {
      this.ThrowIfObjectDisposed();
      return this.Package.CreateRelationship(targetUri, targetMode, relationshipType, id);
    }

    internal PackagePart CreateMetroPart(Uri partUri, string contentType)
    {
      return this.Package.CreatePart(partUri, contentType, this.CompressionOption);
    }

    private static void DefaultValidationEventHandler(object sender, OpenXmlPackageValidationEventArgs e)
    {
      OpenXmlPackageException packageException = new OpenXmlPackageException(ExceptionMessages.ValidationException);
      packageException.Data.Add((object) "OpenXmlPackageValidationEventArgs", (object) e);
      throw packageException;
    }

    private static bool IsOrphanDataPart(DataPart dataPart)
    {
      return !dataPart.GetDataPartReferenceRelationships().Any<DataPartReferenceRelationship>();
    }

    private void DeleteUnusedDataPartOnClose()
    {
      if (this._dataPartList.Count <= 0)
        return;
      HashSet<DataPart> dataPartSet = new HashSet<DataPart>();
      foreach (DataPart dataPart in this.DataParts)
        dataPartSet.Add(dataPart);
      foreach (DataPartReferenceRelationship referenceRelationship in this.DataPartReferenceRelationships)
      {
        dataPartSet.Remove(referenceRelationship.DataPart);
        if (dataPartSet.Count == 0)
          return;
      }
      foreach (OpenXmlPartContainer xmlPartContainer in new OpenXmlPackagePartIterator(this))
      {
        foreach (DataPartReferenceRelationship referenceRelationship in xmlPartContainer.DataPartReferenceRelationships)
        {
          dataPartSet.Remove(referenceRelationship.DataPart);
          if (dataPartSet.Count == 0)
            return;
        }
      }
      foreach (DataPart dataPart in dataPartSet)
      {
        dataPart.Destroy();
        this._dataPartList.Remove(dataPart);
      }
    }

    internal DataPart FindDataPart(Uri partUri)
    {
      foreach (DataPart dataPart in this.DataParts)
      {
        if (dataPart.Uri == partUri)
          return dataPart;
      }
      return (DataPart) null;
    }

    internal DataPart AddDataPartToList(DataPart dataPart)
    {
      this._dataPartList.AddLast(dataPart);
      return dataPart;
    }

    internal class PartUriHelper
    {
      private Dictionary<string, int> _sequenceNumbers = new Dictionary<string, int>(20);
      private Dictionary<string, int> _reservedUri = new Dictionary<string, int>();

      private bool IsReservedUri(Uri uri)
      {
        return this._reservedUri.ContainsKey(uri.OriginalString.ToUpperInvariant());
      }

      internal void AddToReserveUri(Uri partUri)
      {
        this._reservedUri.Add(partUri.OriginalString.ToUpperInvariant(), 0);
      }

      internal void ReserveUri(string contentType, Uri partUri)
      {
        this.GetNextSequenceNumber(contentType);
        this.AddToReserveUri(PackUriHelper.GetNormalizedPartUri(partUri));
      }

      internal Uri GetUniquePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt)
      {
        Uri uri;
        do
        {
          string nextSequenceNumber = this.GetNextSequenceNumber(contentType);
          Uri targetUri = new Uri(Path.Combine(targetPath, targetName + nextSequenceNumber + targetExt), UriKind.RelativeOrAbsolute);
          uri = PackUriHelper.ResolvePartUri(parentUri, targetUri);
        }
        while (this.IsReservedUri(uri));
        this.AddToReserveUri(uri);
        return uri;
      }

      internal Uri GetUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
      {
        Uri uri = PackUriHelper.ResolvePartUri(parentUri, targetUri);
        if (this.IsReservedUri(uri))
        {
          string targetPath = ".";
          string withoutExtension = Path.GetFileNameWithoutExtension(targetUri.OriginalString);
          string extension = Path.GetExtension(targetUri.OriginalString);
          uri = this.GetUniquePartUri(contentType, uri, targetPath, withoutExtension, extension);
        }
        else
          this.AddToReserveUri(uri);
        return uri;
      }

      private string GetNextSequenceNumber(string contentType)
      {
        if (this._sequenceNumbers.ContainsKey(contentType))
        {
          Dictionary<string, int> sequenceNumbers;
          string index;
          (sequenceNumbers = this._sequenceNumbers)[index = contentType] = sequenceNumbers[index] + 1;
          return Convert.ToString(this._sequenceNumbers[contentType], 16);
        }
        this._sequenceNumbers.Add(contentType, 1);
        return "";
      }
    }
  }
}
