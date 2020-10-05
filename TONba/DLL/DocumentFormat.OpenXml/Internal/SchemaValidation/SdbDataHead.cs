// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbDataHead
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO;
using System.Text;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SdbDataHead : SdbData
  {
    public const int HeadSize = 128;
    public const int SignatureSize = 16;
    public const int LatestDataVersion = 65536;

    public static byte[] SignatureConst
    {
      get
      {
        return Encoding.ASCII.GetBytes("OPENXML SCHM    ");
      }
    }

    public byte[] Signature { get; set; }

    public int DataVersion { get; set; }

    public int DataByteCount { get; set; }

    public int StartClassId { get; set; }

    public int ClassIdsCount { get; set; }

    public int ClassIdsDataOffset { get; set; }

    public int SchemaTypeCount { get; set; }

    public int SchemaTypeDataOffset { get; set; }

    public int ParticleCount { get; set; }

    public int ParticleDataOffset { get; set; }

    public int ParticleChildrenIndexCount { get; set; }

    public int ParticleChildrenIndexDataOffset { get; set; }

    public int AttributeCount { get; set; }

    public int AttributeDataOffset { get; set; }

    public int SimpleTypeCount { get; set; }

    public int SimpleTypeDataOffset { get; set; }

    public override byte[] GetBytes()
    {
      byte[] numArray = new byte[128];
      this.GetBytes(this.Signature, this.DataVersion.Bytes(), this.DataByteCount.Bytes(), this.StartClassId.Bytes(), this.ClassIdsCount.Bytes(), this.ClassIdsDataOffset.Bytes(), this.SchemaTypeCount.Bytes(), this.SchemaTypeDataOffset.Bytes(), this.ParticleCount.Bytes(), this.ParticleDataOffset.Bytes(), this.ParticleChildrenIndexCount.Bytes(), this.ParticleChildrenIndexDataOffset.Bytes(), this.AttributeCount.Bytes(), this.AttributeDataOffset.Bytes(), this.SimpleTypeCount.Bytes(), this.SimpleTypeDataOffset.Bytes()).CopyTo((Array) numArray, 0);
      return numArray;
    }

    public override void LoadFromBytes(byte[] value, int startIndex)
    {
      this.Signature = new byte[16];
      Array.Copy((Array) value, startIndex, (Array) this.Signature, 0, 16);
      startIndex += 16;
      for (int index = 0; index < 16; ++index)
      {
        if ((int) this.Signature[index] != (int) SdbDataHead.SignatureConst[index])
          throw new InvalidDataException("Invalide schema constraint data.");
      }
      this.DataVersion = SdbData.LoadInt(value, ref startIndex);
      this.DataByteCount = SdbData.LoadInt(value, ref startIndex);
      if (this.DataVersion != 65536)
        throw new InvalidDataException("Invalide schema constraint data.");
      this.StartClassId = SdbData.LoadInt(value, ref startIndex);
      this.ClassIdsCount = SdbData.LoadInt(value, ref startIndex);
      this.ClassIdsDataOffset = SdbData.LoadInt(value, ref startIndex);
      this.SchemaTypeCount = SdbData.LoadInt(value, ref startIndex);
      this.SchemaTypeDataOffset = SdbData.LoadInt(value, ref startIndex);
      this.ParticleCount = SdbData.LoadInt(value, ref startIndex);
      this.ParticleDataOffset = SdbData.LoadInt(value, ref startIndex);
      this.ParticleChildrenIndexCount = SdbData.LoadInt(value, ref startIndex);
      this.ParticleChildrenIndexDataOffset = SdbData.LoadInt(value, ref startIndex);
      this.AttributeCount = SdbData.LoadInt(value, ref startIndex);
      this.AttributeDataOffset = SdbData.LoadInt(value, ref startIndex);
      this.SimpleTypeCount = SdbData.LoadInt(value, ref startIndex);
      this.SimpleTypeDataOffset = SdbData.LoadInt(value, ref startIndex);
    }

    public override int DataSize
    {
      get
      {
        return 128;
      }
    }
  }
}
