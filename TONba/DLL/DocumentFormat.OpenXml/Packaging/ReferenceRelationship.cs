// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ReferenceRelationship
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
  public abstract class ReferenceRelationship
  {
    internal ReferenceRelationship()
    {
    }

    protected internal ReferenceRelationship(PackageRelationship packageRelationship)
    {
      this.RelationshipType = packageRelationship.RelationshipType;
      this.Uri = packageRelationship.TargetUri;
      this.IsExternal = packageRelationship.TargetMode == TargetMode.External;
      this.Id = packageRelationship.Id;
    }

    protected internal ReferenceRelationship(Uri targetUri, bool isExternal, string relationshipType, string id)
    {
      this.RelationshipType = relationshipType;
      this.Uri = targetUri;
      this.Id = id;
      this.IsExternal = isExternal;
    }

    public OpenXmlPartContainer Container { get; internal set; }

    public virtual string RelationshipType { get; private set; }

    public virtual bool IsExternal { get; private set; }

    public virtual string Id { get; private set; }

    public virtual Uri Uri { get; private set; }

    internal void Initialize(Uri targetUri, bool isExternal, string relationshipType, string id)
    {
      this.RelationshipType = relationshipType;
      this.Uri = targetUri;
      this.Id = id;
      this.IsExternal = isExternal;
    }
  }
}
