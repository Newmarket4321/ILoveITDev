// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PackageRelationshipPropertyCollection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
  internal class PackageRelationshipPropertyCollection : RelationshipCollection
  {
    public Package BasePackage { get; set; }

    public PackageRelationshipPropertyCollection(Package package)
    {
      this.BasePackage = package;
      if (this.BasePackage == null)
        throw new ArgumentNullException(nameof (BasePackage));
      this.BasePackageRelationshipCollection = this.BasePackage.GetRelationships();
      this.Build();
    }

    internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
    {
      this.BasePackage.DeleteRelationship(strId);
      this.BasePackage.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
    }

    internal override Package GetPackage()
    {
      return this.BasePackage;
    }
  }
}
