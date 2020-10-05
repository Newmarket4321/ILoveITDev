// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Xml;

namespace DocumentFormat.OpenXml.Packaging
{
  public abstract class OpenXmlPartContainer
  {
    private Dictionary<string, OpenXmlPart> _childrenPartsDictionary = new Dictionary<string, OpenXmlPart>();
    private LinkedList<ReferenceRelationship> _referenceRelationships = new LinkedList<ReferenceRelationship>();
    private object _annotations;

    internal IDictionary<string, OpenXmlPart> ChildrenParts
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return (IDictionary<string, OpenXmlPart>) this.PartDictionary;
      }
    }

    internal Dictionary<string, OpenXmlPart> PartDictionary
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._childrenPartsDictionary;
      }
      set
      {
        this.ThrowIfObjectDisposed();
        this._childrenPartsDictionary = value;
      }
    }

    internal LinkedList<ReferenceRelationship> ReferenceRelationshipList
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._referenceRelationships;
      }
    }

    public void DeleteReferenceRelationship(ReferenceRelationship referenceRelationship)
    {
      this.ThrowIfObjectDisposed();
      if (referenceRelationship == null)
        throw new ArgumentNullException(nameof (referenceRelationship));
      if (referenceRelationship.Id == null || referenceRelationship.Container != this)
        throw new InvalidOperationException(ExceptionMessages.ReferenceRelationshipIsNotReferenced);
      if (!this.ReferenceRelationshipList.Contains(referenceRelationship))
        throw new InvalidOperationException(ExceptionMessages.ReferenceRelationshipIsNotReferenced);
      this.ReferenceRelationshipList.Remove(referenceRelationship);
      this.DeleteRelationship(referenceRelationship.Id);
      referenceRelationship.Container = (OpenXmlPartContainer) null;
    }

    public void DeleteReferenceRelationship(string id)
    {
      this.ThrowIfObjectDisposed();
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      foreach (ReferenceRelationship referenceRelationship in this.ReferenceRelationshipList)
      {
        if (referenceRelationship.Id == id)
        {
          this.ReferenceRelationshipList.Remove(referenceRelationship);
          this.DeleteRelationship(referenceRelationship.Id);
          referenceRelationship.Container = (OpenXmlPartContainer) null;
          return;
        }
      }
      throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedReferenceRelationship);
    }

    public ReferenceRelationship GetReferenceRelationship(string id)
    {
      this.ThrowIfObjectDisposed();
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      foreach (ReferenceRelationship referenceRelationship in this.ReferenceRelationshipList)
      {
        if (referenceRelationship.Id == id)
          return referenceRelationship;
      }
      throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedReferenceRelationship);
    }

    public IEnumerable<ExternalRelationship> ExternalRelationships
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.ReferenceRelationshipList.OfType<ExternalRelationship>();
      }
    }

    public ExternalRelationship AddExternalRelationship(string relationshipType, Uri externalUri)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      if (externalUri == (Uri) null)
        throw new ArgumentNullException(nameof (externalUri));
      if (relationshipType == "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink")
        throw new InvalidOperationException(ExceptionMessages.UseAddHyperlinkRelationship);
      PackageRelationship relationship = this.CreateRelationship(externalUri, TargetMode.External, relationshipType);
      ExternalRelationship externalRelationship = new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id);
      externalRelationship.Container = this;
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) externalRelationship);
      return externalRelationship;
    }

    public ExternalRelationship AddExternalRelationship(string relationshipType, Uri externalUri, string id)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      if (externalUri == (Uri) null)
        throw new ArgumentNullException(nameof (externalUri));
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      if (relationshipType == "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink")
        throw new InvalidOperationException(ExceptionMessages.UseAddHyperlinkRelationship);
      PackageRelationship relationship = this.CreateRelationship(externalUri, TargetMode.External, relationshipType, id);
      ExternalRelationship externalRelationship = new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id);
      externalRelationship.Container = this;
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) externalRelationship);
      return externalRelationship;
    }

    public void DeleteExternalRelationship(ExternalRelationship externalRelationship)
    {
      this.ThrowIfObjectDisposed();
      if (externalRelationship == null)
        throw new ArgumentNullException(nameof (externalRelationship));
      if (externalRelationship.Id == null || externalRelationship.Container != this)
        throw new InvalidOperationException(ExceptionMessages.ExternalRelationshipIsNotReferenced);
      if (!this.ReferenceRelationshipList.Contains((ReferenceRelationship) externalRelationship))
        throw new InvalidOperationException(ExceptionMessages.ExternalRelationshipIsNotReferenced);
      this.ReferenceRelationshipList.Remove((ReferenceRelationship) externalRelationship);
      this.DeleteRelationship(externalRelationship.Id);
      externalRelationship.Container = (OpenXmlPartContainer) null;
    }

    public void DeleteExternalRelationship(string id)
    {
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      foreach (ExternalRelationship externalRelationship in this.ReferenceRelationshipList.OfType<ExternalRelationship>())
      {
        if (externalRelationship.Id == id)
        {
          this.ReferenceRelationshipList.Remove((ReferenceRelationship) externalRelationship);
          this.DeleteRelationship(externalRelationship.Id);
          externalRelationship.Container = (OpenXmlPartContainer) null;
          return;
        }
      }
      throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedExternalRelationship);
    }

    public ExternalRelationship GetExternalRelationship(string id)
    {
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      foreach (ExternalRelationship externalRelationship in this.ReferenceRelationshipList.OfType<ExternalRelationship>())
      {
        if (externalRelationship.Id == id)
          return externalRelationship;
      }
      throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedExternalRelationship);
    }

    public IEnumerable<HyperlinkRelationship> HyperlinkRelationships
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.ReferenceRelationshipList.OfType<HyperlinkRelationship>();
      }
    }

    public HyperlinkRelationship AddHyperlinkRelationship(Uri hyperlinkUri, bool isExternal)
    {
      this.ThrowIfObjectDisposed();
      if (hyperlinkUri == (Uri) null)
        throw new ArgumentNullException(nameof (hyperlinkUri));
      TargetMode targetMode = isExternal ? TargetMode.External : TargetMode.Internal;
      PackageRelationship relationship = this.CreateRelationship(hyperlinkUri, targetMode, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink");
      HyperlinkRelationship hyperlinkRelationship = new HyperlinkRelationship(relationship.TargetUri, isExternal, relationship.Id);
      hyperlinkRelationship.Container = this;
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) hyperlinkRelationship);
      return hyperlinkRelationship;
    }

    public HyperlinkRelationship AddHyperlinkRelationship(Uri hyperlinkUri, bool isExternal, string id)
    {
      this.ThrowIfObjectDisposed();
      if (hyperlinkUri == (Uri) null)
        throw new ArgumentNullException(nameof (hyperlinkUri));
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      PackageRelationship relationship = this.CreateRelationship(hyperlinkUri, TargetMode.External, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink", id);
      HyperlinkRelationship hyperlinkRelationship = new HyperlinkRelationship(relationship.TargetUri, isExternal, relationship.Id);
      hyperlinkRelationship.Container = this;
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) hyperlinkRelationship);
      return hyperlinkRelationship;
    }

    public IEnumerable<DataPartReferenceRelationship> DataPartReferenceRelationships
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.ReferenceRelationshipList.OfType<DataPartReferenceRelationship>();
      }
    }

    internal T AddDataPartReferenceRelationship<T>(MediaDataPart mediaDataPart) where T : DataPartReferenceRelationship
    {
      this.ThrowIfObjectDisposed();
      if (mediaDataPart == null)
        throw new ArgumentNullException(nameof (mediaDataPart));
      if (mediaDataPart.OpenXmlPackage != this.InternalOpenXmlPackage)
        throw new InvalidOperationException(ExceptionMessages.ForeignMediaDataPart);
      T instance = (T) Activator.CreateInstance(typeof (T), true);
      PackageRelationship relationship = this.CreateRelationship(mediaDataPart.Uri, TargetMode.Internal, instance.RelationshipType);
      instance.Initialize(this, (DataPart) mediaDataPart, instance.RelationshipType, relationship.Id);
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) instance);
      return instance;
    }

    internal T AddDataPartReferenceRelationship<T>(MediaDataPart mediaDataPart, string id) where T : DataPartReferenceRelationship
    {
      this.ThrowIfObjectDisposed();
      if (mediaDataPart == null)
        throw new ArgumentNullException(nameof (mediaDataPart));
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      if (mediaDataPart.OpenXmlPackage != this.InternalOpenXmlPackage)
        throw new InvalidOperationException(ExceptionMessages.ForeignMediaDataPart);
      T instance = (T) Activator.CreateInstance(typeof (T), true);
      PackageRelationship relationship = this.CreateRelationship(mediaDataPart.Uri, TargetMode.Internal, instance.RelationshipType, id);
      instance.Initialize(this, (DataPart) mediaDataPart, instance.RelationshipType, relationship.Id);
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) instance);
      return instance;
    }

    internal DataPartReferenceRelationship AddDataPartReferenceRelationship(DataPartReferenceRelationship dataPartReferenceRelationship)
    {
      if (dataPartReferenceRelationship == null)
        throw new ArgumentNullException(nameof (dataPartReferenceRelationship));
      this.CreateRelationship(dataPartReferenceRelationship.DataPart.Uri, TargetMode.Internal, dataPartReferenceRelationship.RelationshipType, dataPartReferenceRelationship.Id);
      this.ReferenceRelationshipList.AddLast((ReferenceRelationship) dataPartReferenceRelationship);
      return dataPartReferenceRelationship;
    }

    public IEnumerable<IdPartPair> Parts
    {
      get
      {
        this.ThrowIfObjectDisposed();
        foreach (KeyValuePair<string, OpenXmlPart> part in this.PartDictionary)
          yield return new IdPartPair(part.Key, part.Value);
      }
    }

    public OpenXmlPart GetPartById(string id)
    {
      this.ThrowIfObjectDisposed();
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      OpenXmlPart openXmlPart = (OpenXmlPart) null;
      if (this.PartDictionary.TryGetValue(id, out openXmlPart))
        return openXmlPart;
      throw new ArgumentOutOfRangeException(nameof (id));
    }

    public string GetIdOfPart(OpenXmlPart part)
    {
      this.ThrowIfObjectDisposed();
      if (part == null)
        throw new ArgumentNullException(nameof (part));
      if (this.PartDictionary.ContainsValue(part))
      {
        foreach (KeyValuePair<string, OpenXmlPart> part1 in this.PartDictionary)
        {
          if (part == part1.Value)
            return part1.Key;
        }
      }
      throw new ArgumentOutOfRangeException(nameof (part));
    }

    public string ChangeIdOfPart(OpenXmlPart part, string newRelationshipId)
    {
      this.ThrowIfObjectDisposed();
      if (part == null)
        throw new ArgumentNullException(nameof (part));
      if (newRelationshipId == null)
        throw new ArgumentNullException(nameof (newRelationshipId));
      string str = (string) null;
      foreach (KeyValuePair<string, OpenXmlPart> childrenPart in (IEnumerable<KeyValuePair<string, OpenXmlPart>>) this.ChildrenParts)
      {
        if (childrenPart.Key == newRelationshipId)
          throw new ArgumentException(ExceptionMessages.RelationshipIdConflict, nameof (newRelationshipId));
        if (childrenPart.Value == part)
        {
          if (str != null)
            throw new InvalidOperationException(ExceptionMessages.MultipleRelationshipsToSamePart);
          str = childrenPart.Key;
        }
      }
      if (str == null)
        throw new ArgumentOutOfRangeException(nameof (part));
      this.CreateRelationship(part.Uri, TargetMode.Internal, part.RelationshipType, newRelationshipId);
      this.ChildrenParts.Add(newRelationshipId, part);
      this.DeleteRelationship(str);
      this.ChildrenParts.Remove(str);
      return str;
    }

    public virtual T AddPart<T>(T part) where T : OpenXmlPart
    {
      return (T) this.AddPartFrom((OpenXmlPart) part, (string) null);
    }

    public virtual T AddPart<T>(T part, string id) where T : OpenXmlPart
    {
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      return (T) this.AddPartFrom((OpenXmlPart) part, id);
    }

    public string CreateRelationshipToPart(OpenXmlPart targetPart)
    {
      if (targetPart == null)
        throw new ArgumentNullException(nameof (targetPart));
      if (!this.IsInSamePackage(targetPart))
        throw new InvalidOperationException(ExceptionMessages.PartNotInSamePackage);
      return this.GetIdOfPart(this.AddPart<OpenXmlPart>(targetPart));
    }

    public string CreateRelationshipToPart(OpenXmlPart targetPart, string id)
    {
      if (targetPart == null)
        throw new ArgumentNullException(nameof (targetPart));
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      if (!this.IsInSamePackage(targetPart))
        throw new InvalidOperationException(ExceptionMessages.PartNotInSamePackage);
      this.AddPart<OpenXmlPart>(targetPart, id);
      return id;
    }

    public T AddNewPart<T>() where T : OpenXmlPart, IFixedContentTypePart
    {
      return this.AddNewPartInternal<T>();
    }

    public T AddNewPart<T>(string id) where T : OpenXmlPart, IFixedContentTypePart
    {
      return this.AddNewPartInternal<T>((string) null, id);
    }

    public virtual T AddNewPart<T>(string contentType, string id) where T : OpenXmlPart
    {
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      return this.AddNewPartInternal<T>(contentType, id);
    }

    public ExtendedPart AddExtendedPart(string relationshipType, string contentType, string targetExt)
    {
      return this.AddExtendedPart(relationshipType, contentType, targetExt, (string) null);
    }

    public ExtendedPart AddExtendedPart(string relationshipType, string contentType, string targetExt, string rId)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (targetExt == null)
        throw new ArgumentNullException(nameof (targetExt));
      ExtendedPart extendedPart = new ExtendedPart(relationshipType);
      extendedPart.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, targetExt);
      this.ChildrenParts.Add(this.AttachChild((OpenXmlPart) extendedPart, rId), (OpenXmlPart) extendedPart);
      return extendedPart;
    }

    public bool DeletePart(string id)
    {
      this.ThrowIfObjectDisposed();
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      return this.DeletePartCore(id);
    }

    public bool DeletePart(OpenXmlPart part)
    {
      this.ThrowIfObjectDisposed();
      if (part == null)
        return false;
      if (part.OpenXmlPackage != this.InternalOpenXmlPackage || !this.PartDictionary.ContainsValue(part))
        throw new InvalidOperationException(ExceptionMessages.ForeignOpenXmlPart);
      return this.DeletePart(this.GetIdOfPart(part));
    }

    public void DeleteParts<T>(IEnumerable<T> partsToBeDeleted) where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      if (partsToBeDeleted == null)
        throw new ArgumentNullException(nameof (partsToBeDeleted));
      StringCollection stringCollection = new StringCollection();
      foreach (T obj in partsToBeDeleted)
      {
        string idOfPart = this.GetIdOfPart((OpenXmlPart) obj);
        stringCollection.Add(idOfPart);
      }
      foreach (string id in stringCollection)
        this.DeletePart(id);
    }

    public int GetPartsCountOfType<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      int num = 0;
      foreach (KeyValuePair<string, OpenXmlPart> childrenPart in (IEnumerable<KeyValuePair<string, OpenXmlPart>>) this.ChildrenParts)
      {
        if (childrenPart.Value is T)
          ++num;
      }
      return num;
    }

    public void AddAnnotation(object annotation)
    {
      if (annotation == null)
        throw new ArgumentNullException(nameof (annotation));
      if (this._annotations == null)
      {
        object obj;
        if (!(annotation is object[]))
          obj = annotation;
        else
          obj = (object) new object[1]{ annotation };
        this._annotations = obj;
      }
      else
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          this._annotations = (object) new object[2]
          {
            this._annotations,
            annotation
          };
        }
        else
        {
          int index = 0;
          while (index < annotations.Length && annotations[index] != null)
            ++index;
          if (index == annotations.Length)
          {
            Array.Resize<object>(ref annotations, index * 2);
            this._annotations = (object) annotations;
          }
          annotations[index] = annotation;
        }
      }
    }

    public T Annotation<T>() where T : class
    {
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
          return this._annotations as T;
        for (int index = 0; index < annotations.Length; ++index)
        {
          object obj1 = annotations[index];
          if (obj1 != null)
          {
            T obj2 = obj1 as T;
            if ((object) obj2 != null)
              return obj2;
          }
          else
            break;
        }
      }
      return default (T);
    }

    public object Annotation(Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          if (type.IsInstanceOfType(this._annotations))
            return this._annotations;
        }
        else
        {
          for (int index = 0; index < annotations.Length; ++index)
          {
            object o = annotations[index];
            if (o != null)
            {
              if (type.IsInstanceOfType(o))
                return o;
            }
            else
              break;
          }
        }
      }
      return (object) null;
    }

    public IEnumerable<T> Annotations<T>() where T : class
    {
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          if (this._annotations is T)
            yield return (T) this._annotations;
        }
        else
        {
          for (int i = 0; i < annotations.Length; ++i)
          {
            object obj = annotations[i];
            if (obj == null)
              break;
            if (obj is T)
              yield return (T) obj;
          }
        }
      }
    }

    public IEnumerable<object> Annotations(Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          if (type.IsInstanceOfType(this._annotations))
            yield return this._annotations;
        }
        else
        {
          for (int i = 0; i < annotations.Length; ++i)
          {
            object obj = annotations[i];
            if (obj == null)
              break;
            if (type.IsInstanceOfType(obj))
              yield return obj;
          }
        }
      }
    }

    public void RemoveAnnotations<T>() where T : class
    {
      if (this._annotations == null)
        return;
      object[] annotations = this._annotations as object[];
      if (annotations == null)
      {
        if (!(this._annotations is T))
          return;
        this._annotations = (object) null;
      }
      else
      {
        int index = 0;
        int num = 0;
        for (; index < annotations.Length; ++index)
        {
          object obj = annotations[index];
          if (obj != null)
          {
            if (!(obj is T))
              annotations[num++] = obj;
          }
          else
            break;
        }
        if (num != 0)
        {
          while (num < index)
            annotations[num++] = (object) null;
        }
        else
          this._annotations = (object) null;
      }
    }

    public void RemoveAnnotations(Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (this._annotations == null)
        return;
      object[] annotations = this._annotations as object[];
      if (annotations == null)
      {
        if (!type.IsInstanceOfType(this._annotations))
          return;
        this._annotations = (object) null;
      }
      else
      {
        int index = 0;
        int num = 0;
        for (; index < annotations.Length; ++index)
        {
          object o = annotations[index];
          if (o != null)
          {
            if (!type.IsInstanceOfType(o))
              annotations[num++] = o;
          }
          else
            break;
        }
        if (num != 0)
        {
          while (num < index)
            annotations[num++] = (object) null;
        }
        else
          this._annotations = (object) null;
      }
    }

    public IEnumerable<T> GetPartsOfType<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      foreach (OpenXmlPart openXmlPart in this.PartDictionary.Values)
      {
        if (openXmlPart is T)
          yield return (T) openXmlPart;
      }
    }

    public void GetPartsOfType<T>(ICollection<T> partCollection) where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      if (partCollection == null)
        throw new ArgumentNullException(nameof (partCollection));
      partCollection.Clear();
      foreach (T obj in this.GetPartsOfType<T>())
        partCollection.Add(obj);
    }

    internal T AddNewPartInternal<T>() where T : OpenXmlPart, IFixedContentTypePart
    {
      this.ThrowIfObjectDisposed();
      T instance = (T) Activator.CreateInstance(typeof (T), true);
      try
      {
        this.InitPart<T>(instance, instance.ContentType);
      }
      catch (ArgumentOutOfRangeException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed);
      }
      catch (InvalidOperationException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
      }
      return instance;
    }

    internal T AddNewPartInternal<T>(string contentType, string id) where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      if (id != null)
      {
        if (id == string.Empty)
          throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof (id));
        try
        {
          XmlConvert.VerifyNCName(id);
        }
        catch (XmlException ex)
        {
          throw new ArgumentException(ExceptionMessages.InvalidXmlIDStringException, nameof (id));
        }
        if (this.ChildrenParts.ContainsKey(id))
          throw new ArgumentException(ExceptionMessages.RelationshipIdConflict, nameof (id));
      }
      if (contentType == string.Empty)
        throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof (contentType));
      T instance = (T) Activator.CreateInstance(typeof (T), true);
      if ((object) instance is ExtendedPart)
        throw new ArgumentOutOfRangeException(nameof (T), ExceptionMessages.ExtendedPartNotAllowed);
      if (contentType != null && instance.IsContentTypeFixed && instance.ContentType != contentType)
        throw new ArgumentOutOfRangeException(nameof (contentType), ExceptionMessages.ErrorContentType);
      if (contentType == null)
        contentType = instance.ContentType;
      try
      {
        this.InitPart<T>(instance, contentType, id);
      }
      catch (ArgumentOutOfRangeException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed);
      }
      catch (InvalidOperationException ex)
      {
        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
      }
      return instance;
    }

    internal void InitPart<T>(T newPart, string contentType) where T : OpenXmlPart
    {
      this.InitPart<T>(newPart, contentType, (string) null);
    }

    internal virtual void InitPart<T>(T newPart, string contentType, string id) where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (contentType == string.Empty)
        throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException);
      PartConstraintRule partConstraintRule;
      if (!this.GetPartConstraint().TryGetValue(newPart.RelationshipType, out partConstraintRule))
        throw new ArgumentOutOfRangeException(nameof (newPart));
      if (!partConstraintRule.MaxOccursGreatThanOne && (object) this.GetSubPartOfType<T>() != null)
        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
      if (partConstraintRule.PartContentType != null && contentType != partConstraintRule.PartContentType)
        throw new ArgumentOutOfRangeException(nameof (newPart));
      newPart.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, (string) null);
      this.ChildrenParts.Add(this.AttachChild((OpenXmlPart) newPart, id), (OpenXmlPart) newPart);
    }

    internal virtual OpenXmlPart AddPartFrom(OpenXmlPart subPart, string rId)
    {
      this.ThrowIfObjectDisposed();
      if (subPart == null)
        throw new ArgumentNullException(nameof (subPart));
      if (subPart.OpenXmlPackage == this.InternalOpenXmlPackage && this.IsChildPart(subPart))
      {
        if (rId != null && rId != this.GetIdOfPart(subPart))
          throw new InvalidOperationException(ExceptionMessages.PartExistsWithDifferentRelationshipId);
        return subPart;
      }
      PartConstraintRule partConstraintRule;
      if (!this.GetPartConstraint().TryGetValue(subPart.RelationshipType, out partConstraintRule))
      {
        if (subPart is ExtendedPart)
          return this.AddSubPart(subPart, rId);
        throw new InvalidOperationException(ExceptionMessages.AddedPartIsNotAllowed);
      }
      if (partConstraintRule.PartContentType != null && subPart.ContentType != partConstraintRule.PartContentType)
        throw new InvalidOperationException(ExceptionMessages.AddedPartIsNotAllowed);
      if (partConstraintRule.MaxOccursGreatThanOne)
        return this.AddSubPart(subPart, rId);
      if (this.GetSubPart(subPart.RelationshipType) != null)
        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
      return this.SetSubPart(subPart, rId);
    }

    internal OpenXmlPart SetSubPart(OpenXmlPart part, string rId)
    {
      if (part == null)
        throw new ArgumentNullException(nameof (part));
      return this.AddSubPart(part, rId);
    }

    internal OpenXmlPart AddSubPart(OpenXmlPart part, string rId)
    {
      if (part == null)
        throw new ArgumentNullException(nameof (part));
      if (part.OpenXmlPackage != this.InternalOpenXmlPackage)
        return this.AddSubPartFromOtherPackage(part, false, rId);
      this.ChildrenParts.Add(this.AttachChild(part, rId), part);
      return part;
    }

    internal OpenXmlPart AddSubPartFromOtherPackage(OpenXmlPart part, bool keepIdAndUri, string rId)
    {
      Dictionary<OpenXmlPart, OpenXmlPart> dictionary1 = new Dictionary<OpenXmlPart, OpenXmlPart>();
      Dictionary<DataPart, DataPart> dictionary2 = new Dictionary<DataPart, DataPart>();
      return this.AddSubPartFromOtherPackage(part, (IDictionary<OpenXmlPart, OpenXmlPart>) dictionary1, (IDictionary<DataPart, DataPart>) dictionary2, keepIdAndUri, rId);
    }

    private OpenXmlPart AddSubPartFromOtherPackage(OpenXmlPart part, IDictionary<OpenXmlPart, OpenXmlPart> partDictionary, IDictionary<DataPart, DataPart> dataPartsDictionary, bool keepIdAndUri, string rId)
    {
      if (keepIdAndUri && rId == null)
        throw new ArgumentNullException(nameof (rId));
      OpenXmlPart part1;
      if (partDictionary.TryGetValue(part, out part1))
      {
        this.ChildrenParts.Add(this.AttachChild(part1, rId), part1);
        return part1;
      }
      OpenXmlPart openXmlPart = this.CreateOpenXmlPart(part.RelationshipType);
      openXmlPart.CreateInternal2(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, part.ContentType, part.Uri);
      using (Stream stream = part.GetStream())
        openXmlPart.FeedData(stream);
      this.ChildrenParts.Add(this.AttachChild(openXmlPart, rId), openXmlPart);
      partDictionary.Add(part, openXmlPart);
      foreach (IdPartPair part2 in part.Parts)
        openXmlPart.AddSubPartFromOtherPackage(part2.OpenXmlPart, partDictionary, dataPartsDictionary, true, part2.RelationshipId);
      foreach (ExternalRelationship externalRelationship in part.ExternalRelationships)
        openXmlPart.AddExternalRelationship(externalRelationship.RelationshipType, externalRelationship.Uri, externalRelationship.Id);
      foreach (HyperlinkRelationship hyperlinkRelationship in part.HyperlinkRelationships)
        openXmlPart.AddHyperlinkRelationship(hyperlinkRelationship.Uri, hyperlinkRelationship.IsExternal, hyperlinkRelationship.Id);
      foreach (DataPartReferenceRelationship referenceRelationship in part.DataPartReferenceRelationships)
      {
        if (!dataPartsDictionary.ContainsKey(referenceRelationship.DataPart))
          dataPartsDictionary.Add(referenceRelationship.DataPart, (DataPart) null);
      }
      foreach (KeyValuePair<DataPart, DataPart> dataParts in (IEnumerable<KeyValuePair<DataPart, DataPart>>) dataPartsDictionary)
      {
        if (dataParts.Value == null)
        {
          DataPart key = dataParts.Key;
          MediaDataPart mediaDataPart = new MediaDataPart();
          mediaDataPart.CreateInternal2(this.InternalOpenXmlPackage, key.ContentType, key.Uri);
          using (Stream stream = key.GetStream())
            mediaDataPart.FeedData(stream);
          this.InternalOpenXmlPackage.AddDataPartToList((DataPart) mediaDataPart);
          dataPartsDictionary[key] = (DataPart) mediaDataPart;
        }
      }
      foreach (DataPartReferenceRelationship referenceRelationship in part.DataPartReferenceRelationships)
        this.ReferenceRelationshipList.AddLast((ReferenceRelationship) DataPartReferenceRelationship.CreateDataPartReferenceRelationship(this, dataPartsDictionary[referenceRelationship.DataPart], referenceRelationship.RelationshipType, referenceRelationship.Id));
      return openXmlPart;
    }

    internal string AttachChild(OpenXmlPart part)
    {
      return this.AttachChild(part, (string) null);
    }

    internal string AttachChild(OpenXmlPart part, string rId)
    {
      if (rId == null)
        return this.CreateRelationship(part.Uri, TargetMode.Internal, part.RelationshipType).Id;
      return this.CreateRelationship(part.Uri, TargetMode.Internal, part.RelationshipType, rId).Id;
    }

    internal bool DeletePartCore(string id)
    {
      Dictionary<OpenXmlPart, bool> dictionary = new Dictionary<OpenXmlPart, bool>();
      Dictionary<OpenXmlPart, bool> processedParts = new Dictionary<OpenXmlPart, bool>();
      OpenXmlPart partById = this.GetPartById(id);
      if (partById == null)
        return false;
      partById.FindAllReachableParts((IDictionary<OpenXmlPart, bool>) processedParts);
      this.ChildrenParts.Remove(id);
      this.InternalOpenXmlPackage.FindAllReachableParts((IDictionary<OpenXmlPart, bool>) dictionary);
      Dictionary<OpenXmlPart, bool> toBeDeletedParts = new Dictionary<OpenXmlPart, bool>();
      foreach (OpenXmlPart key in processedParts.Keys)
      {
        if (!dictionary.ContainsKey(key))
          toBeDeletedParts.Add(key, false);
      }
      processedParts[partById] = true;
      if (toBeDeletedParts.Count == 0)
      {
        this.DeleteRelationship(id);
      }
      else
      {
        partById.DeleteAllParts(processedParts, toBeDeletedParts);
        this.DeleteRelationship(id);
        bool flag;
        if (toBeDeletedParts.TryGetValue(partById, out flag) && !flag)
        {
          partById.Destroy();
          toBeDeletedParts[partById] = true;
        }
      }
      return true;
    }

    internal void DeletePartsOfType<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      StringCollection stringCollection = new StringCollection();
      foreach (KeyValuePair<string, OpenXmlPart> childrenPart in (IEnumerable<KeyValuePair<string, OpenXmlPart>>) this.ChildrenParts)
      {
        if (childrenPart.Value is T)
          stringCollection.Add(childrenPart.Key);
      }
      foreach (string id in stringCollection)
        this.DeletePart(id);
    }

    internal void DeletePartsRecursivelyOfTypeBase<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      this.DeletePartsOfType<T>();
      foreach (OpenXmlPartContainer xmlPartContainer in (IEnumerable<OpenXmlPart>) this.ChildrenParts.Values)
        xmlPartContainer.DeletePartsRecursivelyOfTypeBase<T>();
    }

    internal void DeleteAllParts(Dictionary<OpenXmlPart, bool> processedParts, Dictionary<OpenXmlPart, bool> toBeDeletedParts)
    {
      this.ThrowIfObjectDisposed();
      if (this.PartDictionary.Count <= 0)
        return;
      Collection<OpenXmlPart> collection = new Collection<OpenXmlPart>();
      foreach (KeyValuePair<string, OpenXmlPart> childrenPart in (IEnumerable<KeyValuePair<string, OpenXmlPart>>) this.ChildrenParts)
      {
        if (!processedParts[childrenPart.Value])
        {
          processedParts[childrenPart.Value] = true;
          bool flag;
          if (toBeDeletedParts.TryGetValue(childrenPart.Value, out flag) && !flag)
          {
            childrenPart.Value.DeleteAllParts(processedParts, toBeDeletedParts);
            collection.Add(childrenPart.Value);
          }
        }
        this.DeleteRelationship(childrenPart.Key);
      }
      this.ChildrenParts.Clear();
      foreach (OpenXmlPart index in collection)
      {
        index.Destroy();
        toBeDeletedParts[index] = true;
      }
    }

    internal OpenXmlPart GetSubPart(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      foreach (OpenXmlPart openXmlPart in this.PartDictionary.Values)
      {
        if (openXmlPart.RelationshipType == relationshipType)
          return openXmlPart;
      }
      return (OpenXmlPart) null;
    }

    internal T GetSubPartOfType<T>() where T : OpenXmlPart
    {
      this.ThrowIfObjectDisposed();
      using (IEnumerator<T> enumerator = this.GetPartsOfType<T>().GetEnumerator())
      {
        if (enumerator.MoveNext())
          return enumerator.Current;
      }
      return default (T);
    }

    internal bool IsChildPart(OpenXmlPart part)
    {
      this.ThrowIfObjectDisposed();
      if (part == null)
        throw new ArgumentNullException(nameof (part));
      if (part.OpenXmlPackage != this.InternalOpenXmlPackage)
        throw new ArgumentOutOfRangeException(nameof (part));
      return this.PartDictionary.ContainsValue(part);
    }

    internal OpenXmlPart CreateOpenXmlPart(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      return !this.GetPartConstraint().ContainsKey(relationshipType) ? GlobalPartFactory.CreateOpenXmlPart(this.InternalOpenXmlPackage, relationshipType) : this.CreatePartCore(relationshipType);
    }

    internal void LoadReferencedPartsAndRelationships(OpenXmlPackage openXmlPackage, OpenXmlPart sourcePart, RelationshipCollection relationshipCollection, Dictionary<Uri, OpenXmlPart> loadedParts)
    {
      foreach (RelationshipProperty relationship in (CollectionBase) relationshipCollection)
      {
        if (relationship.RelationshipType == "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink")
        {
          LinkedList<ReferenceRelationship> relationshipList = this.ReferenceRelationshipList;
          HyperlinkRelationship hyperlinkRelationship1 = new HyperlinkRelationship(relationship.TargetUri, relationship.TargetMode == TargetMode.External, relationship.Id);
          hyperlinkRelationship1.Container = this;
          HyperlinkRelationship hyperlinkRelationship2 = hyperlinkRelationship1;
          relationshipList.AddLast((ReferenceRelationship) hyperlinkRelationship2);
        }
        else if (relationship.TargetMode == TargetMode.Internal)
        {
          if (!relationship.TargetUri.ToString().Equals("NULL", StringComparison.OrdinalIgnoreCase))
          {
            Uri uri = PackUriHelper.ResolvePartUri(sourcePart == null ? new Uri("/", UriKind.Relative) : sourcePart.Uri, relationship.TargetUri);
            OpenXmlPart openXmlPart;
            if (loadedParts.TryGetValue(uri, out openXmlPart))
            {
              if (openXmlPart.RelationshipType != relationship.RelationshipType)
                throw new OpenXmlPackageException(ExceptionMessages.SamePartWithDifferentRelationshipType);
              this.ChildrenParts.Add(relationship.Id, openXmlPart);
            }
            else if (DataPartReferenceRelationship.IsDataPartReferenceRelationship(relationship.RelationshipType))
            {
              DataPart dataPart;
              if ((dataPart = openXmlPackage.FindDataPart(uri)) == null)
              {
                dataPart = (DataPart) new MediaDataPart();
                PackagePart part = openXmlPackage.Package.GetPart(uri);
                dataPart.Load(openXmlPackage, part);
                openXmlPackage.AddDataPartToList(dataPart);
              }
              this.ReferenceRelationshipList.AddLast((ReferenceRelationship) DataPartReferenceRelationship.CreateDataPartReferenceRelationship(this, dataPart, relationship.RelationshipType, relationship.Id));
            }
            else
            {
              openXmlPart = this.CreateOpenXmlPart(relationship.RelationshipType);
              openXmlPart.MCSettings = openXmlPackage.MarkupCompatibilityProcessSettings;
              loadedParts.Add(uri, openXmlPart);
              openXmlPart.Load(openXmlPackage, sourcePart, uri, relationship.Id, loadedParts);
              this.ChildrenParts.Add(relationship.Id, openXmlPart);
            }
          }
        }
        else
        {
          LinkedList<ReferenceRelationship> relationshipList = this.ReferenceRelationshipList;
          ExternalRelationship externalRelationship1 = new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id);
          externalRelationship1.Container = this;
          ExternalRelationship externalRelationship2 = externalRelationship1;
          relationshipList.AddLast((ReferenceRelationship) externalRelationship2);
        }
      }
    }

    internal void ValidateInternal(OpenXmlPackageValidationSettings validationSettings, Dictionary<OpenXmlPart, bool> processedParts)
    {
      EventHandler<OpenXmlPackageValidationEventArgs> eventHandler = validationSettings.GetEventHandler();
      this.ValidateDataPartReferenceRelationships(validationSettings);
      Dictionary<string, int> dictionary = new Dictionary<string, int>();
      foreach (OpenXmlPart openXmlPart in (IEnumerable<OpenXmlPart>) this.ChildrenParts.Values)
      {
        int num = 0;
        dictionary.TryGetValue(openXmlPart.RelationshipType, out num);
        dictionary[openXmlPart.RelationshipType] = num + 1;
        if (!(this is ExtendedPart) && !this.GetPartConstraint().Keys.Contains(openXmlPart.RelationshipType) && openXmlPart.IsInVersion(validationSettings.FileFormat))
          eventHandler((object) this, new OpenXmlPackageValidationEventArgs()
          {
            MessageId = "PartIsNotAllowed",
            PartClassName = openXmlPart.RelationshipType,
            Part = this.ThisOpenXmlPart,
            SubPart = openXmlPart
          });
      }
      foreach (KeyValuePair<string, PartConstraintRule> keyValuePair in (IEnumerable<KeyValuePair<string, PartConstraintRule>>) this.GetPartConstraint())
      {
        string key = keyValuePair.Key;
        PartConstraintRule partConstraintRule = keyValuePair.Value;
        if (partConstraintRule.MinOccursIsNonZero && partConstraintRule.FileFormat.Includes(validationSettings.FileFormat) && this.GetSubPart(key) == null)
          eventHandler((object) this, new OpenXmlPackageValidationEventArgs()
          {
            MessageId = "RequiredPartDoNotExist",
            PartClassName = partConstraintRule.PartClassName,
            Part = this.ThisOpenXmlPart
          });
        if (!partConstraintRule.MaxOccursGreatThanOne && partConstraintRule.FileFormat.Includes(validationSettings.FileFormat))
        {
          int num = 0;
          if (dictionary.TryGetValue(key, out num) && num > 1)
            eventHandler((object) this, new OpenXmlPackageValidationEventArgs()
            {
              MessageId = "OnlyOnePartAllowed",
              PartClassName = partConstraintRule.PartClassName,
              Part = this.ThisOpenXmlPart
            });
        }
      }
      foreach (OpenXmlPart key in (IEnumerable<OpenXmlPart>) this.ChildrenParts.Values)
      {
        if (!processedParts.ContainsKey(key))
        {
          if (!(key is ExtendedPart))
          {
            PartConstraintRule partConstraintRule = (PartConstraintRule) null;
            if (this.GetPartConstraint().TryGetValue(key.RelationshipType, out partConstraintRule) && partConstraintRule.FileFormat.Includes(validationSettings.FileFormat) && (partConstraintRule.PartContentType != null && key.ContentType != partConstraintRule.PartContentType))
              eventHandler((object) this, new OpenXmlPackageValidationEventArgs()
              {
                Message = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.InvalidContentTypePart, new object[1]
                {
                  (object) partConstraintRule.PartContentType
                }),
                MessageId = "InvalidContentTypePart",
                SubPart = key,
                Part = this.ThisOpenXmlPart
              });
          }
          processedParts.Add(key, true);
          key.ValidateInternal(validationSettings, processedParts);
        }
      }
    }

    internal void ValidateDataPartReferenceRelationships(OpenXmlPackageValidationSettings validationSettings)
    {
      EventHandler<OpenXmlPackageValidationEventArgs> eventHandler = validationSettings.GetEventHandler();
      foreach (DataPartReferenceRelationship referenceRelationship in this.DataPartReferenceRelationships)
      {
        PartConstraintRule partConstraintRule;
        if (!this.GetDataPartReferenceConstraint().TryGetValue(referenceRelationship.RelationshipType, out partConstraintRule))
          eventHandler((object) this, new OpenXmlPackageValidationEventArgs()
          {
            MessageId = "DataPartReferenceIsNotAllowed",
            PartClassName = referenceRelationship.RelationshipType,
            Part = this.ThisOpenXmlPart,
            SubPart = (OpenXmlPart) null,
            DataPartReferenceRelationship = referenceRelationship
          });
      }
    }

    internal abstract OpenXmlPackage InternalOpenXmlPackage { get; }

    internal abstract OpenXmlPart ThisOpenXmlPart { get; }

    internal abstract IDictionary<string, PartConstraintRule> GetPartConstraint();

    internal abstract IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint();

    protected abstract void ThrowIfObjectDisposed();

    internal virtual OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      return (OpenXmlPart) new ExtendedPart(relationshipType);
    }

    internal abstract OpenXmlPart NewPart(string relationshipType, string contentType);

    internal abstract void DeleteRelationship(string id);

    internal abstract PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType);

    internal abstract PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id);

    internal abstract void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts);

    private bool IsInSamePackage(OpenXmlPart targetPart)
    {
      if (this.InternalOpenXmlPackage != null && targetPart.OpenXmlPackage != null)
        return targetPart.OpenXmlPackage == this.InternalOpenXmlPackage;
      return false;
    }
  }
}
