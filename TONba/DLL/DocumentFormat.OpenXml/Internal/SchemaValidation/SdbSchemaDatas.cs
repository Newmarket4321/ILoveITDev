// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbSchemaDatas
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SdbSchemaDatas
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ParticleConstraint[] EmptyChildrenParticles = new ParticleConstraint[0];
    private Dictionary<ushort, SchemaTypeData> _schemaTypeDatas;
    private bool _loaded;
    private FileFormatVersions _fileFormat;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SdbDataArray<SdbClassIdToSchemaTypeIndex> SdbClassIdMap { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SdbDataArray<SdbSchemaType> SdbSchemaTypes { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SdbDataArray<SdbParticleConstraint> SdbParticles { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SdbDataArray<SdbParticleChildrenIndex> SdbParticleIndexs { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SdbDataArray<SdbAttributeConstraint> SdbAttributes { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SimpleTypeRestrictions SimpleTypeRestrictions { get; set; }

    public SdbDataHead SdbDataHead { get; private set; }

    private SdbSchemaDatas(FileFormatVersions fileFormat)
    {
      this.SdbDataHead = new SdbDataHead();
      this._fileFormat = fileFormat;
    }

    public static SdbSchemaDatas GetOffice2007SchemaDatas()
    {
      SdbSchemaDatas sdbSchemaDatas = new SdbSchemaDatas(FileFormatVersions.Office2007);
      sdbSchemaDatas.InitOnDemand();
      return sdbSchemaDatas;
    }

    public static SdbSchemaDatas GetOffice2010SchemaDatas()
    {
      SdbSchemaDatas sdbSchemaDatas = new SdbSchemaDatas(FileFormatVersions.Office2010);
      sdbSchemaDatas.InitOnDemand();
      return sdbSchemaDatas;
    }

    public static SdbSchemaDatas GetOffice2013SchemaDatas()
    {
      SdbSchemaDatas sdbSchemaDatas = new SdbSchemaDatas(FileFormatVersions.Office2013);
      sdbSchemaDatas.InitOnDemand();
      return sdbSchemaDatas;
    }

    internal SchemaTypeData GetSchemaTypeData(OpenXmlElement openxmlElement)
    {
      return this.GetSchemaTypeData(openxmlElement.ElementTypeId);
    }

    internal SchemaTypeData GetSchemaTypeData(int openxmlTypeId)
    {
      this.InitOnDemand();
      ushort num = (ushort) openxmlTypeId;
      SchemaTypeData schemaTypeData1;
      if (this._schemaTypeDatas.TryGetValue(num, out schemaTypeData1))
        return schemaTypeData1;
      SchemaTypeData schemaTypeData2 = this.LoadSchemaTypeData(num);
      this._schemaTypeDatas.Add(num, schemaTypeData2);
      return schemaTypeData2;
    }

    private void InitOnDemand()
    {
      if (this._loaded)
        return;
      this.Init();
    }

    private void Init()
    {
      this._schemaTypeDatas = new Dictionary<ushort, SchemaTypeData>();
      byte[] schemaConstraintDatas;
      switch (this._fileFormat)
      {
        case FileFormatVersions.Office2007:
          schemaConstraintDatas = ValidationResources.O12SchemaConstraintDatas;
          break;
        case FileFormatVersions.Office2010:
          schemaConstraintDatas = ValidationResources.O14SchemaConstraintDatas;
          break;
        case FileFormatVersions.Office2013:
          schemaConstraintDatas = ValidationResources.O15SchemaConstraintDatas;
          break;
        default:
          schemaConstraintDatas = ValidationResources.O12SchemaConstraintDatas;
          break;
      }
      using (MemoryStream memoryStream = new MemoryStream(schemaConstraintDatas, false))
        this.Load((Stream) memoryStream);
    }

    private SchemaTypeData LoadSchemaTypeData(ushort openxmlTypeId)
    {
      SdbSchemaType sdbSchemaType = this.SdbSchemaTypes[(int) this.SdbClassIdMap[(int) (ushort) ((uint) openxmlTypeId - (uint) this.SdbDataHead.StartClassId)].SchemaTypeIndex];
      AttributeConstraint[] attributeConstraints = this.BuildAttributeConstraint(sdbSchemaType);
      ParticleConstraint particleConstraint = this.BuildParticleConstraint(sdbSchemaType);
      if (particleConstraint != null)
        return new SchemaTypeData((int) openxmlTypeId, attributeConstraints, particleConstraint);
      if (!sdbSchemaType.IsSimpleContent)
        return new SchemaTypeData((int) openxmlTypeId, attributeConstraints);
      SimpleTypeRestriction simpleTypeRestriction = this.SimpleTypeRestrictions[(int) sdbSchemaType.SimpleTypeIndex];
      return new SchemaTypeData((int) openxmlTypeId, attributeConstraints, simpleTypeRestriction);
    }

    private ParticleConstraint BuildParticleConstraint(SdbSchemaType sdbSchemaTpye)
    {
      if (sdbSchemaTpye.IsCompositeType)
        return this.BuildParticleConstraint(sdbSchemaTpye.ParticleIndex);
      return (ParticleConstraint) null;
    }

    private ParticleConstraint BuildParticleConstraint(ushort particleIndex)
    {
      SdbParticleConstraint sdbParticle = this.SdbParticles[(int) particleIndex];
      ParticleConstraint particleConstraint = ParticleConstraint.CreateParticleConstraint(sdbParticle.ParticleType);
      particleConstraint.ParticleType = sdbParticle.ParticleType;
      particleConstraint.MaxOccurs = sdbParticle.MaxOccurs;
      particleConstraint.MinOccurs = (int) sdbParticle.MinOccurs;
      particleConstraint.ElementId = (int) sdbParticle.ElementTypeId;
      if ((int) sdbParticle.ChildrenCount > 0)
      {
        particleConstraint.ChildrenParticles = new ParticleConstraint[(int) sdbParticle.ChildrenCount];
        for (ushort index = 0; (int) index < (int) sdbParticle.ChildrenCount; ++index)
        {
          ushort particleIndex1 = this.SdbParticleIndexs[(int) (ushort) ((uint) sdbParticle.ChildrenStartIndex + (uint) index)].ParticleIndex;
          particleConstraint.ChildrenParticles[(int) index] = this.BuildParticleConstraint(particleIndex1);
        }
      }
      else if (sdbParticle.ParticleType == ParticleType.All || sdbParticle.ParticleType == ParticleType.Choice || (sdbParticle.ParticleType == ParticleType.Group || sdbParticle.ParticleType == ParticleType.Sequence))
        particleConstraint.ChildrenParticles = this.EmptyChildrenParticles;
      return particleConstraint;
    }

    private AttributeConstraint[] BuildAttributeConstraint(SdbSchemaType sdbSchemaTpye)
    {
      if ((int) sdbSchemaTpye.AttributesCount <= 0)
        return (AttributeConstraint[]) null;
      int attributesCount = (int) sdbSchemaTpye.AttributesCount;
      AttributeConstraint[] attributeConstraintArray = new AttributeConstraint[attributesCount];
      ushort indexOfAttributes = sdbSchemaTpye.StartIndexOfAttributes;
      for (int index = 0; index < attributesCount; ++index)
      {
        SdbAttributeConstraint sdbAttribute = this.SdbAttributes[(int) indexOfAttributes + index];
        SimpleTypeRestriction simpleTypeRestriction = this.SimpleTypeRestrictions[(int) sdbAttribute.SimpleTypeIndex];
        attributeConstraintArray[index] = new AttributeConstraint(sdbAttribute.AttributeUse, simpleTypeRestriction, (FileFormatVersions) sdbAttribute.FileFormatVersion);
      }
      return attributeConstraintArray;
    }

    internal void Load(Stream dataStream)
    {
      byte[] buffer = new byte[128];
      dataStream.Read(buffer, 0, 128);
      this.SdbDataHead.LoadFromBytes(buffer, 0);
      this.CheckDataHead((int) dataStream.Length);
      int count1 = this.SdbDataHead.ClassIdsCount * SdbClassIdToSchemaTypeIndex.TypeSize;
      byte[] numArray1 = new byte[count1];
      dataStream.Read(numArray1, 0, count1);
      this.SdbClassIdMap = new SdbDataArray<SdbClassIdToSchemaTypeIndex>(numArray1);
      int count2 = this.SdbDataHead.SchemaTypeCount * SdbSchemaType.TypeSize;
      byte[] numArray2 = new byte[count2];
      dataStream.Read(numArray2, 0, count2);
      this.SdbSchemaTypes = new SdbDataArray<SdbSchemaType>(numArray2);
      int count3 = this.SdbDataHead.ParticleCount * SdbParticleConstraint.TypeSize;
      byte[] numArray3 = new byte[count3];
      dataStream.Read(numArray3, 0, count3);
      this.SdbParticles = new SdbDataArray<SdbParticleConstraint>(numArray3);
      int count4 = this.SdbDataHead.ParticleChildrenIndexCount * SdbParticleChildrenIndex.TypeSize;
      byte[] numArray4 = new byte[count4];
      dataStream.Read(numArray4, 0, count4);
      this.SdbParticleIndexs = new SdbDataArray<SdbParticleChildrenIndex>(numArray4);
      int count5 = this.SdbDataHead.AttributeCount * SdbAttributeConstraint.TypeSize;
      byte[] numArray5 = new byte[count5];
      dataStream.Read(numArray5, 0, count5);
      this.SdbAttributes = new SdbDataArray<SdbAttributeConstraint>(numArray5);
      dataStream.Seek((long) this.SdbDataHead.SimpleTypeDataOffset, SeekOrigin.Begin);
      this.SimpleTypeRestrictions = SimpleTypeRestrictions.Deserialize(dataStream, this._fileFormat);
      SdbSchemaDatas.Assert(this.SdbDataHead.SimpleTypeCount == this.SimpleTypeRestrictions.SimpleTypeCount);
      this.CheckData();
      this._loaded = true;
    }

    private SdbClassIdToSchemaTypeIndex GetClassIdData(ushort classId)
    {
      return this.SdbClassIdMap[(int) SdbClassIdToSchemaTypeIndex.ArrayIndexFromClassId(classId)];
    }

    private void CheckDataHead(int streamLength)
    {
      SdbDataHead sdbDataHead = this.SdbDataHead;
      SdbSchemaDatas.Assert(sdbDataHead.StartClassId == 10001);
      SdbSchemaDatas.Assert(sdbDataHead.DataByteCount + 256 == streamLength);
      SdbSchemaDatas.Assert(sdbDataHead.ClassIdsCount > 0);
      SdbSchemaDatas.Assert(sdbDataHead.SchemaTypeCount > 0);
      SdbSchemaDatas.Assert(sdbDataHead.SchemaTypeDataOffset == sdbDataHead.ClassIdsDataOffset + sdbDataHead.ClassIdsCount * SdbClassIdToSchemaTypeIndex.TypeSize);
      SdbSchemaDatas.Assert(sdbDataHead.ParticleCount > 0);
      SdbSchemaDatas.Assert(sdbDataHead.ParticleDataOffset == sdbDataHead.SchemaTypeDataOffset + sdbDataHead.SchemaTypeCount * SdbSchemaType.TypeSize);
      SdbSchemaDatas.Assert(sdbDataHead.ParticleChildrenIndexCount > 0);
      SdbSchemaDatas.Assert(sdbDataHead.ParticleChildrenIndexDataOffset == sdbDataHead.ParticleDataOffset + sdbDataHead.ParticleCount * SdbParticleConstraint.TypeSize);
      SdbSchemaDatas.Assert(sdbDataHead.AttributeCount > 0);
      SdbSchemaDatas.Assert(sdbDataHead.AttributeDataOffset == sdbDataHead.ParticleChildrenIndexDataOffset + sdbDataHead.ParticleChildrenIndexCount * SdbParticleChildrenIndex.TypeSize);
      SdbSchemaDatas.Assert(sdbDataHead.SimpleTypeCount > 0);
      SdbSchemaDatas.Assert(sdbDataHead.SimpleTypeDataOffset == sdbDataHead.AttributeDataOffset + sdbDataHead.AttributeCount * SdbAttributeConstraint.TypeSize);
      SdbSchemaDatas.Assert(sdbDataHead.SimpleTypeDataOffset < streamLength);
    }

    private static void Assert(bool value)
    {
      if (!value)
        throw new InvalidDataException("Invalid schema constraint binary data.");
    }

    private void CheckData()
    {
    }
  }
}
