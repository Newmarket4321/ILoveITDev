// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.VariantTypes.VTArray
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.VariantTypes
{
  [ChildElementInfo(typeof (VTCurrency))]
  [ChildElementInfo(typeof (VTUnsignedShort))]
  [ChildElementInfo(typeof (VTUnsignedInt32))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Variant))]
  [ChildElementInfo(typeof (VTByte))]
  [ChildElementInfo(typeof (VTShort))]
  [ChildElementInfo(typeof (VTInt32))]
  [ChildElementInfo(typeof (VTInteger))]
  [ChildElementInfo(typeof (VTUnsignedByte))]
  [ChildElementInfo(typeof (VTUnsignedInteger))]
  [ChildElementInfo(typeof (VTFloat))]
  [ChildElementInfo(typeof (VTDouble))]
  [ChildElementInfo(typeof (VTDecimal))]
  [ChildElementInfo(typeof (VTBString))]
  [ChildElementInfo(typeof (VTDate))]
  [ChildElementInfo(typeof (VTBool))]
  [ChildElementInfo(typeof (VTError))]
  public class VTArray : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "lBound",
      "uBound",
      "baseType"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "array";
    private const byte tagNsId = 5;
    internal const int ElementTypeIdConst = 11031;

    public override string LocalName
    {
      get
      {
        return "array";
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
        return 11031;
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
        return VTArray.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return VTArray.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "lBound")]
    public Int32Value LowerBounds
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "uBound")]
    public Int32Value UpperBounds
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "baseType")]
    public EnumValue<ArrayBaseValues> BaseType
    {
      get
      {
        return (EnumValue<ArrayBaseValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public VTArray()
    {
    }

    public VTArray(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VTArray(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VTArray(string outerXml)
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
      if (5 == (int) namespaceId && "int" == name)
        return (OpenXmlElement) new VTInteger();
      if (5 == (int) namespaceId && "ui1" == name)
        return (OpenXmlElement) new VTUnsignedByte();
      if (5 == (int) namespaceId && "ui2" == name)
        return (OpenXmlElement) new VTUnsignedShort();
      if (5 == (int) namespaceId && "ui4" == name)
        return (OpenXmlElement) new VTUnsignedInt32();
      if (5 == (int) namespaceId && "uint" == name)
        return (OpenXmlElement) new VTUnsignedInteger();
      if (5 == (int) namespaceId && "r4" == name)
        return (OpenXmlElement) new VTFloat();
      if (5 == (int) namespaceId && "r8" == name)
        return (OpenXmlElement) new VTDouble();
      if (5 == (int) namespaceId && "decimal" == name)
        return (OpenXmlElement) new VTDecimal();
      if (5 == (int) namespaceId && "bstr" == name)
        return (OpenXmlElement) new VTBString();
      if (5 == (int) namespaceId && "date" == name)
        return (OpenXmlElement) new VTDate();
      if (5 == (int) namespaceId && "bool" == name)
        return (OpenXmlElement) new VTBool();
      if (5 == (int) namespaceId && "error" == name)
        return (OpenXmlElement) new VTError();
      if (5 == (int) namespaceId && "cy" == name)
        return (OpenXmlElement) new VTCurrency();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "lBound" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "uBound" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "baseType" == name)
        return (OpenXmlSimpleType) new EnumValue<ArrayBaseValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VTArray>(deep);
    }
  }
}
