// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.UnionHelper
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class UnionHelper
  {
    internal static OpenXmlSimpleType[] CreatePossibleMembers(UnionValueRestriction unionValueRestriction, FileFormatVersions fileFormatVersion)
    {
      switch (fileFormatVersion)
      {
        case FileFormatVersions.Office2007:
          return O12UnionHelper.CreatePossibleMembers(unionValueRestriction);
        case FileFormatVersions.Office2010:
          return O14UnionHelper.CreatePossibleMembers(unionValueRestriction);
        case FileFormatVersions.Office2013:
          return O15UnionHelper.CreatePossibleMembers(unionValueRestriction);
        default:
          return (OpenXmlSimpleType[]) null;
      }
    }

    internal static OpenXmlSimpleType CreateTargetValueObject(RedirectedRestriction redirectedRestriction, FileFormatVersions fileFormatVersion)
    {
      switch (fileFormatVersion)
      {
        case FileFormatVersions.Office2007:
          return O12UnionHelper.CreateTargetValueObject(redirectedRestriction);
        case FileFormatVersions.Office2010:
          return O14UnionHelper.CreateTargetValueObject(redirectedRestriction);
        case FileFormatVersions.Office2013:
          return O15UnionHelper.CreateTargetValueObject(redirectedRestriction);
        default:
          return (OpenXmlSimpleType) null;
      }
    }
  }
}
