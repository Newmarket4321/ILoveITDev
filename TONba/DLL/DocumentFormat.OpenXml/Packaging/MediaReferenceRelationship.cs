// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.MediaReferenceRelationship
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Packaging
{
  public class MediaReferenceRelationship : DataPartReferenceRelationship
  {
    internal const string RelationshipTypeConst = "http://schemas.microsoft.com/office/2007/relationships/media";

    public static string MediaReferenceRelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2007/relationships/media";
      }
    }

    internal MediaReferenceRelationship()
    {
    }

    protected internal MediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
      : base((DataPart) mediaDataPart, "http://schemas.microsoft.com/office/2007/relationships/media", id)
    {
    }

    public override string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2007/relationships/media";
      }
    }
  }
}
