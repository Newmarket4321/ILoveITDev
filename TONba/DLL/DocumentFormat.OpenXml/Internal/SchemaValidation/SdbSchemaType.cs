// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbSchemaType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SdbSchemaType : SdbData
  {
    public ushort ParticleIndex { get; set; }

    public ushort SimpleTypeIndex { get; set; }

    public ushort AttributesCount { get; set; }

    public ushort StartIndexOfAttributes { get; set; }

    public SdbSchemaType()
    {
    }

    public SdbSchemaType(ushort particleIndex, ushort simpleTypeIndex, ushort attributeCount, ushort startAttribute)
    {
      this.ParticleIndex = particleIndex;
      this.SimpleTypeIndex = simpleTypeIndex;
      this.AttributesCount = attributeCount;
      this.StartIndexOfAttributes = startAttribute;
    }

    public bool IsCompositeType
    {
      get
      {
        return (int) this.ParticleIndex != (int) ushort.MaxValue;
      }
    }

    public bool IsSimpleContent
    {
      get
      {
        return (int) this.SimpleTypeIndex != (int) ushort.MaxValue;
      }
    }

    public static int TypeSize
    {
      get
      {
        return 8;
      }
    }

    public override int DataSize
    {
      get
      {
        return SdbSchemaType.TypeSize;
      }
    }

    public override byte[] GetBytes()
    {
      return this.GetBytes(this.ParticleIndex.Bytes(), this.SimpleTypeIndex.Bytes(), this.AttributesCount.Bytes(), this.StartIndexOfAttributes.Bytes());
    }

    public override void LoadFromBytes(byte[] value, int startIndex)
    {
      this.ParticleIndex = SdbData.LoadSdbIndex(value, ref startIndex);
      this.SimpleTypeIndex = SdbData.LoadSdbIndex(value, ref startIndex);
      this.AttributesCount = SdbData.LoadSdbIndex(value, ref startIndex);
      this.StartIndexOfAttributes = SdbData.LoadSdbIndex(value, ref startIndex);
    }
  }
}
