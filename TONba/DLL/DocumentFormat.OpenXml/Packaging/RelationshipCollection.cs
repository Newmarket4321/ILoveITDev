// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.RelationshipCollection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
  internal abstract class RelationshipCollection : CollectionBase
  {
    private bool _strictTranslation;

    protected PackageRelationshipCollection BasePackageRelationshipCollection { get; set; }

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

    public RelationshipProperty this[int index]
    {
      get
      {
        return (RelationshipProperty) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
      }
    }

    public int Add(RelationshipProperty value)
    {
      return this.List.Add((object) value);
    }

    public int IndexOf(RelationshipProperty value)
    {
      return this.List.IndexOf((object) value);
    }

    public void Insert(int index, RelationshipProperty value)
    {
      this.List.Insert(index, (object) value);
    }

    public void Remove(RelationshipProperty value)
    {
      this.List.Remove((object) value);
    }

    public bool Contains(RelationshipProperty value)
    {
      return this.List.Contains((object) value);
    }

    protected void Build()
    {
      foreach (PackageRelationship packageRelationship in this.BasePackageRelationshipCollection)
      {
        RelationshipProperty relationshipProperty;
        relationshipProperty.TargetUri = packageRelationship.TargetUri;
        relationshipProperty.TargetMode = packageRelationship.TargetMode;
        relationshipProperty.Id = packageRelationship.Id;
        relationshipProperty.RelationshipType = packageRelationship.RelationshipType;
        string transitionalRelationship;
        if (NamespaceIdMap.TryGetTransitionalRelationship(relationshipProperty.RelationshipType, out transitionalRelationship))
        {
          relationshipProperty.RelationshipType = transitionalRelationship;
          this.StrictTranslation = true;
        }
        this.Add(relationshipProperty);
      }
    }

    internal void UpdateRelationshipTypesInPackage()
    {
      if (this.GetPackage().FileOpenAccess == FileAccess.Read)
        return;
      for (int index = 0; index < this.Count; ++index)
      {
        RelationshipProperty relationshipProperty = this[index];
        this.ReplaceRelationship(relationshipProperty.TargetUri, relationshipProperty.TargetMode, relationshipProperty.RelationshipType, relationshipProperty.Id);
      }
    }

    internal abstract void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId);

    internal abstract Package GetPackage();
  }
}
