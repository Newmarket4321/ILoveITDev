// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbAttributeConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SdbAttributeConstraint : SdbData
  {
    public XsdAttributeUse AttributeUse { get; set; }

    public ushort SimpleTypeIndex { get; set; }

    public byte FileFormatVersion { get; set; }

    public SdbAttributeConstraint()
    {
    }

    public SdbAttributeConstraint(XsdAttributeUse xsdAttributeUse, ushort simpleTypeIndex, byte fileFormatVersion)
    {
      this.AttributeUse = xsdAttributeUse;
      this.SimpleTypeIndex = simpleTypeIndex;
      this.FileFormatVersion = fileFormatVersion;
    }

    public static int TypeSize
    {
      get
      {
        return 4;
      }
    }

    public override int DataSize
    {
      get
      {
        return SdbAttributeConstraint.TypeSize;
      }
    }

    public override byte[] GetBytes()
    {
      return this.GetBytes(this.AttributeUse.Bytes(), this.SimpleTypeIndex.Bytes(), this.FileFormatVersion.Bytes());
    }

    public override void LoadFromBytes(byte[] value, int startIndex)
    {
      this.AttributeUse = (XsdAttributeUse) SdbData.LoadByte(value, ref startIndex);
      this.SimpleTypeIndex = SdbData.LoadSdbIndex(value, ref startIndex);
      this.FileFormatVersion = SdbData.LoadByte(value, ref startIndex);
    }
  }
}
