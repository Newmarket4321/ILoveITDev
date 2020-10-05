// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PackagePartRelationshipPropertyCollection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
  internal class PackagePartRelationshipPropertyCollection : RelationshipCollection
  {
    public PackagePart BasePackagePart { get; set; }

    public PackagePartRelationshipPropertyCollection(PackagePart packagePart)
    {
      this.BasePackagePart = packagePart;
      if (this.BasePackagePart == null)
        throw new ArgumentNullException(nameof (BasePackagePart));
      this.BasePackageRelationshipCollection = this.BasePackagePart.GetRelationships();
      this.Build();
    }

    internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
    {
      this.BasePackagePart.DeleteRelationship(strId);
      this.BasePackagePart.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
    }

    internal override Package GetPackage()
    {
      return this.BasePackagePart.Package;
    }
  }
}
