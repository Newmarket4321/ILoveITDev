// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ExtendedPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class ExtendedPart : OpenXmlPart
  {
    private static Dictionary<string, PartConstraintRule> _partConstraints = new Dictionary<string, PartConstraintRule>();
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
    private const string DefaultTargetExt = ".dat";
    private string _relationshipType;

    protected ExtendedPart()
    {
    }

    protected internal ExtendedPart(string relationshipType)
    {
      this._relationshipType = relationshipType;
    }

    public override string RelationshipType
    {
      get
      {
        return this._relationshipType;
      }
    }

    internal override string TargetFileExtension
    {
      get
      {
        return ".dat";
      }
    }

    internal override string TargetPath
    {
      get
      {
        return "udata";
      }
    }

    internal override string TargetName
    {
      get
      {
        return "data";
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return false;
      }
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      this.ThrowIfObjectDisposed();
      return (IDictionary<string, PartConstraintRule>) ExtendedPart._partConstraints;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      this.ThrowIfObjectDisposed();
      return (IDictionary<string, PartConstraintRule>) ExtendedPart._dataPartReferenceConstraint;
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return false;
    }

    internal override OpenXmlPart AddPartFrom(OpenXmlPart subPart, string rId)
    {
      this.ThrowIfObjectDisposed();
      if (subPart == null)
        throw new ArgumentNullException(nameof (subPart));
      if (subPart.OpenXmlPackage != this.InternalOpenXmlPackage || !this.IsChildPart(subPart))
        return this.AddSubPart(subPart, rId);
      if (rId != null && rId != this.GetIdOfPart(subPart))
        throw new InvalidOperationException(ExceptionMessages.PartExistsWithDifferentRelationshipId);
      return subPart;
    }

    internal override void InitPart<T>(T newPart, string contentType, string id)
    {
      this.ThrowIfObjectDisposed();
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (contentType == string.Empty)
        throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof (contentType));
      newPart.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, (string) null);
      this.ChildrenParts.Add(this.AttachChild((OpenXmlPart) newPart, id), (OpenXmlPart) newPart);
    }
  }
}
