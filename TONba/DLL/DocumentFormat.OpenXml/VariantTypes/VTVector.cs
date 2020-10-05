// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.VariantTypes.VTVector
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.VariantTypes
{
  [ChildElementInfo(typeof (VTClassId))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Variant))]
  [ChildElementInfo(typeof (VTByte))]
  [ChildElementInfo(typeof (VTShort))]
  [ChildElementInfo(typeof (VTInt32))]
  [ChildElementInfo(typeof (VTInt64))]
  [ChildElementInfo(typeof (VTUnsignedByte))]
  [ChildElementInfo(typeof (VTUnsignedShort))]
  [ChildElementInfo(typeof (VTUnsignedInt32))]
  [ChildElementInfo(typeof (VTUnsignedInt64))]
  [ChildElementInfo(typeof (VTFloat))]
  [ChildElementInfo(typeof (VTDouble))]
  [ChildElementInfo(typeof (VTLPSTR))]
  [ChildElementInfo(typeof (VTLPWSTR))]
  [ChildElementInfo(typeof (VTBString))]
  [ChildElementInfo(typeof (VTDate))]
  [ChildElementInfo(typeof (VTFileTime))]
  [ChildElementInfo(typeof (VTBool))]
  [ChildElementInfo(typeof (VTCurrency))]
  [ChildElementInfo(typeof (VTError))]
  [ChildElementInfo(typeof (VTClipboardData))]
  public class VTVector : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "baseType",
      "size"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "vector";
    private const byte tagNsId = 5;
    internal const int ElementTypeIdConst = 11030;

    public override string LocalName
    {
      get
      {
        return "vector";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 5;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11030;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return VTVector.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return VTVector.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "baseType")]
    public EnumValue<VectorBaseValues> BaseType
    {
      get
      {
        return (EnumValue<VectorBaseValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "size")]
    public UInt32Value Size
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public VTVector()
    {
    }

    public VTVector(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VTVector(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VTVector(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (5 == (int) namespaceId && "variant" == name)
        return (OpenXmlElement) new Variant();
      if (5 == (int) namespaceId && "i1" == name)
        return (OpenXmlElement) new VTByte();
      if (5 == (int) namespaceId && "i2" == name)
        return (OpenXmlElement) new VTShort();
      if (5 == (int) namespaceId && "i4" == name)
        return (OpenXmlElement) new VTInt32();
      if (5 == (int) namespaceId && "i8" == name)
        return (OpenXmlElement) new VTInt64();
      if (5 == (int) namespaceId && "ui1" == name)
        return (OpenXmlElement) new VTUnsignedByte();
      if (5 == (int) namespaceId && "ui2" == name)
        return (OpenXmlElement) new VTUnsignedShort();
      if (5 == (int) namespaceId && "ui4" == name)
        return (OpenXmlElement) new VTUnsignedInt32();
      if (5 == (int) namespaceId && "ui8" == name)
        return (OpenXmlElement) new VTUnsignedInt64();
      if (5 == (int) namespaceId && "r4" == name)
        return (OpenXmlElement) new VTFloat();
      if (5 == (int) namespaceId && "r8" == name)
        return (OpenXmlElement) new VTDouble();
      if (5 == (int) namespaceId && "lpstr" == name)
        return (OpenXmlElement) new VTLPSTR();
      if (5 == (int) namespaceId && "lpwstr" == name)
        return (OpenXmlElement) new VTLPWSTR();
      if (5 == (int) namespaceId && "bstr" == name)
        return (OpenXmlElement) new VTBString();
      if (5 == (int) namespaceId && "date" == name)
        return (OpenXmlElement) new VTDate();
      if (5 == (int) namespaceId && "filetime" == name)
        return (OpenXmlElement) new VTFileTime();
      if (5 == (int) namespaceId && "bool" == name)
        return (OpenXmlElement) new VTBool();
      if (5 == (int) namespaceId && "cy" == name)
        return (OpenXmlElement) new VTCurrency();
      if (5 == (int) namespaceId && "error" == name)
        return (OpenXmlElement) new VTError();
      if (5 == (int) namespaceId && "clsid" == name)
        return (OpenXmlElement) new VTClassId();
      if (5 == (int) namespaceId && "cf" == name)
        return (OpenXmlElement) new VTClipboardData();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "baseType" == name)
        return (OpenXmlSimpleType) new EnumValue<VectorBaseValues>();
      if ((int) namespaceId == 0 && "size" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VTVector>(deep);
    }
  }
}
