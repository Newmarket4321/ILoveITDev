// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbParticleConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("ParticleType={ParticleType}")]
  internal class SdbParticleConstraint : SdbData
  {
    public const ushort UnboundedMaxOccurs = 0;

    public ParticleType ParticleType { get; set; }

    public ushort ElementTypeId { get; set; }

    public ushort MinOccurs { get; set; }

    public int MaxOccurs { get; set; }

    public ushort ChildrenCount { get; set; }

    public ushort ChildrenStartIndex { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public ushort XsdAnyNamespaceId
    {
      get
      {
        return this.ElementTypeId;
      }
    }

    public static int TypeSize
    {
      get
      {
        return 13;
      }
    }

    public override int DataSize
    {
      get
      {
        return SdbParticleConstraint.TypeSize;
      }
    }

    public override byte[] GetBytes()
    {
      return this.GetBytes(this.ParticleType.Bytes(), this.ElementTypeId.Bytes(), this.MinOccurs.Bytes(), this.MaxOccurs.Bytes(), this.ChildrenCount.Bytes(), this.ChildrenStartIndex.Bytes());
    }

    public override void LoadFromBytes(byte[] value, int startIndex)
    {
      this.ParticleType = (ParticleType) SdbData.LoadByte(value, ref startIndex);
      this.ElementTypeId = SdbData.LoadSdbIndex(value, ref startIndex);
      this.MinOccurs = SdbData.LoadUInt16(value, ref startIndex);
      this.MaxOccurs = SdbData.LoadInt(value, ref startIndex);
      this.ChildrenCount = SdbData.LoadSdbIndex(value, ref startIndex);
      this.ChildrenStartIndex = SdbData.LoadSdbIndex(value, ref startIndex);
    }
  }
}
