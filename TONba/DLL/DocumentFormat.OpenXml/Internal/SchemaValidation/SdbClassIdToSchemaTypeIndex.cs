// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbClassIdToSchemaTypeIndex
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("ClassId={ClassId}")]
  internal class SdbClassIdToSchemaTypeIndex : SdbData
  {
    public const ushort StartClassId = 10001;
    public const ushort InvalidSchemaTypeIndex = 65535;

    public ushort ClassId { get; set; }

    public ushort SchemaTypeIndex { get; set; }

    public SdbClassIdToSchemaTypeIndex()
    {
    }

    public SdbClassIdToSchemaTypeIndex(ushort classId, ushort schemaTypeIndex)
    {
      this.ClassId = classId;
      this.SchemaTypeIndex = schemaTypeIndex;
    }

    public static ushort ArrayIndexFromClassId(ushort classId)
    {
      return (ushort) ((uint) classId - 10001U);
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
        return SdbClassIdToSchemaTypeIndex.TypeSize;
      }
    }

    public override byte[] GetBytes()
    {
      return this.GetBytes(this.ClassId.Bytes(), this.SchemaTypeIndex.Bytes());
    }

    public override void LoadFromBytes(byte[] value, int startIndex)
    {
      this.ClassId = SdbData.LoadSdbIndex(value, ref startIndex);
      this.SchemaTypeIndex = SdbData.LoadSdbIndex(value, ref startIndex);
    }
  }
}
