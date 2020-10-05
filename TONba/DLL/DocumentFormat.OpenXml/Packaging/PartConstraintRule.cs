// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PartConstraintRule
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Packaging
{
  internal class PartConstraintRule
  {
    internal string PartClassName;
    internal string PartContentType;
    internal bool MinOccursIsNonZero;
    internal bool MaxOccursGreatThanOne;
    internal FileFormatVersions FileFormat;

    internal PartConstraintRule(string partClassName, string partContentType, bool minOccursIsNonZero, bool maxOccursGreatThanOne, FileFormatVersions fileFormat)
    {
      this.PartClassName = partClassName;
      this.PartContentType = partContentType;
      this.MinOccursIsNonZero = minOccursIsNonZero;
      this.MaxOccursGreatThanOne = maxOccursGreatThanOne;
      this.FileFormat = fileFormat;
    }
  }
}
