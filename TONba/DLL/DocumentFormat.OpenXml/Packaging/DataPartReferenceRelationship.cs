// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DataPartReferenceRelationship : ReferenceRelationship
  {
    internal DataPartReferenceRelationship()
    {
    }

    protected internal DataPartReferenceRelationship(DataPart dataPart, string relationshipType, string id)
      : base(dataPart.Uri, false, relationshipType, id)
    {
      this.DataPart = dataPart;
    }

    public virtual DataPart DataPart { get; private set; }

    internal void Initialize(OpenXmlPartContainer containter, DataPart dataPart, string relationshipType, string id)
    {
      this.Initialize(dataPart.Uri, false, relationshipType, id);
      this.Container = containter;
      this.DataPart = dataPart;
    }

    internal static bool IsDataPartReferenceRelationship(string relationshipType)
    {
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2007/relationships/media":
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio":
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video":
          return true;
        default:
          return false;
      }
    }

    internal static DataPartReferenceRelationship CreateDataPartReferenceRelationship(OpenXmlPartContainer containter, DataPart dataPart, string relationshipType, string id)
    {
      DataPartReferenceRelationship referenceRelationship;
      switch (relationshipType)
      {
        case "http://schemas.microsoft.com/office/2007/relationships/media":
          referenceRelationship = (DataPartReferenceRelationship) new MediaReferenceRelationship((MediaDataPart) dataPart, id);
          break;
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio":
          referenceRelationship = (DataPartReferenceRelationship) new AudioReferenceRelationship((MediaDataPart) dataPart, id);
          break;
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video":
          referenceRelationship = (DataPartReferenceRelationship) new VideoReferenceRelationship((MediaDataPart) dataPart, id);
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
      referenceRelationship.Container = containter;
      return referenceRelationship;
    }
  }
}
