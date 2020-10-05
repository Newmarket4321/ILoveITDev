// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.RestrictionField
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Flags]
  internal enum RestrictionField : byte
  {
    None = 0,
    Length = 1,
    MinLength = 2,
    MaxLength = 4,
    MinInclusive = 8,
    MaxInclusive = 16, // 0x10
    MinExclusive = 32, // 0x20
    MaxExclusive = 64, // 0x40
    Pattern = 128, // 0x80
    MinMaxInclusive = MaxInclusive | MinInclusive, // 0x18
    MinMaxExclusive = MaxExclusive | MinExclusive, // 0x60
    MinMaxRestriction = MinMaxExclusive | MinMaxInclusive, // 0x78
    LengthRestriction = MaxLength | MinLength | Length, // 0x07
  }
}
