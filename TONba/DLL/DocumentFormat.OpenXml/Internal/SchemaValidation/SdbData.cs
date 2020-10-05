// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal abstract class SdbData
  {
    public const ushort InvalidId = 65535;
    public const int MaxSdbIndex = 65535;

    public abstract int DataSize { get; }

    public abstract byte[] GetBytes();

    public abstract void LoadFromBytes(byte[] value, int startIndex);

    protected byte[] GetBytes(params byte[][] fieldvalues)
    {
      byte[] numArray = new byte[this.DataSize];
      int index = 0;
      foreach (byte[] fieldvalue in fieldvalues)
      {
        fieldvalue.CopyTo((Array) numArray, index);
        index += fieldvalue.Length;
      }
      return numArray;
    }

    public static int LoadInt(byte[] bytes, ref int startIndex)
    {
      int int32 = BitConverter.ToInt32(bytes, startIndex);
      startIndex += 4;
      return int32;
    }

    public static ushort LoadSdbIndex(byte[] bytes, ref int startIndex)
    {
      ushort uint16 = BitConverter.ToUInt16(bytes, startIndex);
      startIndex += 2;
      return uint16;
    }

    public static ushort LoadUInt16(byte[] bytes, ref int startIndex)
    {
      ushort uint16 = BitConverter.ToUInt16(bytes, startIndex);
      startIndex += 2;
      return uint16;
    }

    public static byte LoadByte(byte[] bytes, ref int startIndex)
    {
      ++startIndex;
      return bytes[startIndex - 1];
    }
  }
}
