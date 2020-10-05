// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.SemanticValidationLevel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  [Flags]
  internal enum SemanticValidationLevel
  {
    PackageOnly = 1,
    PartOnly = 2,
    ElementOnly = 4,
    Package = PackageOnly, // 0x00000001
    Part = Package | PartOnly, // 0x00000003
    Element = Part | ElementOnly, // 0x00000007
  }
}
