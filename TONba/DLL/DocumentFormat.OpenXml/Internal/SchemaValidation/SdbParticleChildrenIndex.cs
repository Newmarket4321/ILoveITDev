// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbParticleChildrenIndex
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("ParticleIndex={ParticleIndex}")]
  internal class SdbParticleChildrenIndex : SdbData
  {
    public ushort ParticleIndex { get; set; }

    public SdbParticleChildrenIndex()
    {
      this.ParticleIndex = ushort.MaxValue;
    }

    public SdbParticleChildrenIndex(ushort index)
    {
      this.ParticleIndex = index;
    }

    public SdbParticleChildrenIndex(int index)
    {
      if (index >= (int) ushort.MaxValue)
        throw new ArgumentOutOfRangeException(nameof (index));
      this.ParticleIndex = (ushort) index;
    }

    public static int TypeSize
    {
      get
      {
        return 2;
      }
    }

    public override int DataSize
    {
      get
      {
        return SdbParticleChildrenIndex.TypeSize;
      }
    }

    public override byte[] GetBytes()
    {
      return this.ParticleIndex.Bytes();
    }

    public override void LoadFromBytes(byte[] value, int startIndex)
    {
      this.ParticleIndex = SdbData.LoadSdbIndex(value, ref startIndex);
    }
  }
}
