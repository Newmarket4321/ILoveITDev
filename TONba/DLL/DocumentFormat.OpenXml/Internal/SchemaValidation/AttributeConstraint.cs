// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.AttributeConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class AttributeConstraint
  {
    internal AttributeConstraint(XsdAttributeUse xsdAttributeUse, SimpleTypeRestriction simpleTypeConstraint)
    {
      this.XsdAttributeUse = xsdAttributeUse;
      this.SimpleTypeConstraint = simpleTypeConstraint;
    }

    internal AttributeConstraint(XsdAttributeUse xsdAttributeUse, SimpleTypeRestriction simpleTypeConstraint, FileFormatVersions supportedVersion)
    {
      this.XsdAttributeUse = xsdAttributeUse;
      this.SimpleTypeConstraint = simpleTypeConstraint;
      this.SupportedVersion = supportedVersion;
    }

    internal XsdAttributeUse XsdAttributeUse { get; private set; }

    internal SimpleTypeRestriction SimpleTypeConstraint { get; private set; }

    internal FileFormatVersions SupportedVersion { get; private set; }
  }
}
