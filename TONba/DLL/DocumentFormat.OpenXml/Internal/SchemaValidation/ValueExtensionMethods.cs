// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ValueExtensionMethods
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class ValueExtensionMethods
  {
    public static byte[] Bytes(this int value)
    {
      return BitConverter.GetBytes(value);
    }

    public static byte[] Bytes(this ushort value)
    {
      return BitConverter.GetBytes(value);
    }

    public static byte[] Bytes(this ParticleType value)
    {
      return new byte[1]{ (byte) value };
    }

    public static byte[] Bytes(this XsdAttributeUse value)
    {
      return new byte[1]{ (byte) value };
    }

    public static byte[] Bytes(this byte value)
    {
      return new byte[1]{ value };
    }
  }
}
