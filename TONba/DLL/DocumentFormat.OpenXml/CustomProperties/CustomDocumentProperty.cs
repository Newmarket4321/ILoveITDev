// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.VariantTypes;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.CustomProperties
{
  [ChildElementInfo(typeof (VTByte))]
  [ChildElementInfo(typeof (VTVector))]
  [ChildElementInfo(typeof (VTArray))]
  [ChildElementInfo(typeof (VTBlob))]
  [ChildElementInfo(typeof (VTOBlob))]
  [ChildElementInfo(typeof (VTEmpty))]
  [ChildElementInfo(typeof (VTNull))]
  [ChildElementInfo(typeof (VTShort))]
  [ChildElementInfo(typeof (VTInt32))]
  [ChildElementInfo(typeof (VTInt64))]
  [ChildElementInfo(typeof (VTInteger))]
  [ChildElementInfo(typeof (VTUnsignedByte))]
  [ChildElementInfo(typeof (VTUnsignedShort))]
  [ChildElementInfo(typeof (VTUnsignedInt32))]
  [ChildElementInfo(typeof (VTUnsignedInt64))]
  [ChildElementInfo(typeof (VTUnsignedInteger))]
  [ChildElementInfo(typeof (VTFloat))]
  [ChildElementInfo(typeof (VTDouble))]
  [ChildElementInfo(typeof (VTDecimal))]
  [ChildElementInfo(typeof (VTLPSTR))]
  [ChildElementInfo(typeof (VTLPWSTR))]
  [ChildElementInfo(typeof (VTBString))]
  [ChildElementInfo(typeof (VTDate))]
  [ChildElementInfo(typeof (VTFileTime))]
  [ChildElementInfo(typeof (VTBool))]
  [ChildElementInfo(typeof (VTCurrency))]
  [ChildElementInfo(typeof (VTError))]
  [ChildElementInfo(typeof (VTStreamData))]
  [ChildElementInfo(typeof (VTOStreamData))]
  [ChildElementInfo(typeof (VTStorage))]
  [ChildElementInfo(typeof (VTOStorage))]
  [ChildElementInfo(typeof (VTVStreamData))]
  [ChildElementInfo(typeof (VTClassId))]
  [ChildElementInfo(typeof (VTClipboardData))]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomDocumentProperty : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "fmtid",
      "pid",
      "name",
      "linkTarget"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[34]
    {
      "vector",
      "array",
      "blob",
      "oblob",
      "empty",
      "null",
      "i1",
      "i2",
      "i4",
      "i8",
      "int",
      "ui1",
      "ui2",
      "ui4",
      "ui8",
      "uint",
      "r4",
      "r8",
      "decimal",
      "lpstr",
      "lpwstr",
      "bstr",
      "date",
      "filetime",
      "bool",
      "cy",
      "error",
      "stream",
      "ostream",
      "storage",
      "ostorage",
      "vstream",
      "clsid",
      "cf"
    };
    private static readonly byte[] eleNamespaceIds = new byte[34]
    {
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5,
      (byte) 5
    };
    private const string tagName = "property";
    private const byte tagNsId = 4;
    internal const int ElementTypeIdConst = 10904;

    public override string LocalName
    {
      get
      {
        return "property";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 4;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10904;
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
        return CustomDocumentProperty.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CustomDocumentProperty.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "fmtid")]
    public StringValue FormatId
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pid")]
    public Int32Value PropertyId
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

    [SchemaAttr(0, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "linkTarget")]
    public StringValue LinkTarget
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public CustomDocumentProperty()
    {
    }

    public CustomDocumentProperty(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomDocumentProperty(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomDocumentProperty(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (5 == (int) namespaceId && "vector" == name)
        return (OpenXmlElement) new VTVector();
      if (5 == (int) namespaceId && "array" == name)
        return (OpenXmlElement) new VTArray();
      if (5 == (int) namespaceId && "blob" == name)
        return (OpenXmlElement) new VTBlob();
      if (5 == (int) namespaceId && "oblob" == name)
        return (OpenXmlElement) new VTOBlob();
      if (5 == (int) namespaceId && "empty" == name)
        return (OpenXmlElement) new VTEmpty();
      if (5 == (int) namespaceId && "null" == name)
        return (OpenXmlElement) new VTNull();
      if (5 == (int) namespaceId && "i1" == name)
        return (OpenXmlElement) new VTByte();
      if (5 == (int) namespaceId && "i2" == name)
        return (OpenXmlElement) new VTShort();
      if (5 == (int) namespaceId && "i4" == name)
        return (OpenXmlElement) new VTInt32();
      if (5 == (int) namespaceId && "i8" == name)
        return (OpenXmlElement) new VTInt64();
      if (5 == (int) namespaceId && "int" == name)
        return (OpenXmlElement) new VTInteger();
      if (5 == (int) namespaceId && "ui1" == name)
        return (OpenXmlElement) new VTUnsignedByte();
      if (5 == (int) namespaceId && "ui2" == name)
        return (OpenXmlElement) new VTUnsignedShort();
      if (5 == (int) namespaceId && "ui4" == name)
        return (OpenXmlElement) new VTUnsignedInt32();
      if (5 == (int) namespaceId && "ui8" == name)
        return (OpenXmlElement) new VTUnsignedInt64();
      if (5 == (int) namespaceId && "uint" == name)
        return (OpenXmlElement) new VTUnsignedInteger();
      if (5 == (int) namespaceId && "r4" == name)
        return (OpenXmlElement) new VTFloat();
      if (5 == (int) namespaceId && "r8" == name)
        return (OpenXmlElement) new VTDouble();
      if (5 == (int) namespaceId && "decimal" == name)
        return (OpenXmlElement) new VTDecimal();
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
      if (5 == (int) namespaceId && "stream" == name)
        return (OpenXmlElement) new VTStreamData();
      if (5 == (int) namespaceId && "ostream" == name)
        return (OpenXmlElement) new VTOStreamData();
      if (5 == (int) namespaceId && "storage" == name)
        return (OpenXmlElement) new VTStorage();
      if (5 == (int) namespaceId && "ostorage" == name)
        return (OpenXmlElement) new VTOStorage();
      if (5 == (int) namespaceId && "vstream" == name)
        return (OpenXmlElement) new VTVStreamData();
      if (5 == (int) namespaceId && "clsid" == name)
        return (OpenXmlElement) new VTClassId();
      if (5 == (int) namespaceId && "cf" == name)
        return (OpenXmlElement) new VTClipboardData();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomDocumentProperty.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomDocumentProperty.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public VTVector VTVector
    {
      get
      {
        return this.GetElement<VTVector>(0);
      }
      set
      {
        this.SetElement<VTVector>(0, value);
      }
    }

    public VTArray VTArray
    {
      get
      {
        return this.GetElement<VTArray>(1);
      }
      set
      {
        this.SetElement<VTArray>(1, value);
      }
    }

    public VTBlob VTBlob
    {
      get
      {
        return this.GetElement<VTBlob>(2);
      }
      set
      {
        this.SetElement<VTBlob>(2, value);
      }
    }

    public VTOBlob VTOBlob
    {
      get
      {
        return this.GetElement<VTOBlob>(3);
      }
      set
      {
        this.SetElement<VTOBlob>(3, value);
      }
    }

    public VTEmpty VTEmpty
    {
      get
      {
        return this.GetElement<VTEmpty>(4);
      }
      set
      {
        this.SetElement<VTEmpty>(4, value);
      }
    }

    public VTNull VTNull
    {
      get
      {
        return this.GetElement<VTNull>(5);
      }
      set
      {
        this.SetElement<VTNull>(5, value);
      }
    }

    public VTByte VTByte
    {
      get
      {
        return this.GetElement<VTByte>(6);
      }
      set
      {
        this.SetElement<VTByte>(6, value);
      }
    }

    public VTShort VTShort
    {
      get
      {
        return this.GetElement<VTShort>(7);
      }
      set
      {
        this.SetElement<VTShort>(7, value);
      }
    }

    public VTInt32 VTInt32
    {
      get
      {
        return this.GetElement<VTInt32>(8);
      }
      set
      {
        this.SetElement<VTInt32>(8, value);
      }
    }

    public VTInt64 VTInt64
    {
      get
      {
        return this.GetElement<VTInt64>(9);
      }
      set
      {
        this.SetElement<VTInt64>(9, value);
      }
    }

    public VTInteger VTInteger
    {
      get
      {
        return this.GetElement<VTInteger>(10);
      }
      set
      {
        this.SetElement<VTInteger>(10, value);
      }
    }

    public VTUnsignedByte VTUnsignedByte
    {
      get
      {
        return this.GetElement<VTUnsignedByte>(11);
      }
      set
      {
        this.SetElement<VTUnsignedByte>(11, value);
      }
    }

    public VTUnsignedShort VTUnsignedShort
    {
      get
      {
        return this.GetElement<VTUnsignedShort>(12);
      }
      set
      {
        this.SetElement<VTUnsignedShort>(12, value);
      }
    }

    public VTUnsignedInt32 VTUnsignedInt32
    {
      get
      {
        return this.GetElement<VTUnsignedInt32>(13);
      }
      set
      {
        this.SetElement<VTUnsignedInt32>(13, value);
      }
    }

    public VTUnsignedInt64 VTUnsignedInt64
    {
      get
      {
        return this.GetElement<VTUnsignedInt64>(14);
      }
      set
      {
        this.SetElement<VTUnsignedInt64>(14, value);
      }
    }

    public VTUnsignedInteger VTUnsignedInteger
    {
      get
      {
        return this.GetElement<VTUnsignedInteger>(15);
      }
      set
      {
        this.SetElement<VTUnsignedInteger>(15, value);
      }
    }

    public VTFloat VTFloat
    {
      get
      {
        return this.GetElement<VTFloat>(16);
      }
      set
      {
        this.SetElement<VTFloat>(16, value);
      }
    }

    public VTDouble VTDouble
    {
      get
      {
        return this.GetElement<VTDouble>(17);
      }
      set
      {
        this.SetElement<VTDouble>(17, value);
      }
    }

    public VTDecimal VTDecimal
    {
      get
      {
        return this.GetElement<VTDecimal>(18);
      }
      set
      {
        this.SetElement<VTDecimal>(18, value);
      }
    }

    public VTLPSTR VTLPSTR
    {
      get
      {
        return this.GetElement<VTLPSTR>(19);
      }
      set
      {
        this.SetElement<VTLPSTR>(19, value);
      }
    }

    public VTLPWSTR VTLPWSTR
    {
      get
      {
        return this.GetElement<VTLPWSTR>(20);
      }
      set
      {
        this.SetElement<VTLPWSTR>(20, value);
      }
    }

    public VTBString VTBString
    {
      get
      {
        return this.GetElement<VTBString>(21);
      }
      set
      {
        this.SetElement<VTBString>(21, value);
      }
    }

    public VTDate VTDate
    {
      get
      {
        return this.GetElement<VTDate>(22);
      }
      set
      {
        this.SetElement<VTDate>(22, value);
      }
    }

    public VTFileTime VTFileTime
    {
      get
      {
        return this.GetElement<VTFileTime>(23);
      }
      set
      {
        this.SetElement<VTFileTime>(23, value);
      }
    }

    public VTBool VTBool
    {
      get
      {
        return this.GetElement<VTBool>(24);
      }
      set
      {
        this.SetElement<VTBool>(24, value);
      }
    }

    public VTCurrency VTCurrency
    {
      get
      {
        return this.GetElement<VTCurrency>(25);
      }
      set
      {
        this.SetElement<VTCurrency>(25, value);
      }
    }

    public VTError VTError
    {
      get
      {
        return this.GetElement<VTError>(26);
      }
      set
      {
        this.SetElement<VTError>(26, value);
      }
    }

    public VTStreamData VTStreamData
    {
      get
      {
        return this.GetElement<VTStreamData>(27);
      }
      set
      {
        this.SetElement<VTStreamData>(27, value);
      }
    }

    public VTOStreamData VTOStreamData
    {
      get
      {
        return this.GetElement<VTOStreamData>(28);
      }
      set
      {
        this.SetElement<VTOStreamData>(28, value);
      }
    }

    public VTStorage VTStorage
    {
      get
      {
        return this.GetElement<VTStorage>(29);
      }
      set
      {
        this.SetElement<VTStorage>(29, value);
      }
    }

    public VTOStorage VTOStorage
    {
      get
      {
        return this.GetElement<VTOStorage>(30);
      }
      set
      {
        this.SetElement<VTOStorage>(30, value);
      }
    }

    public VTVStreamData VTVStreamData
    {
      get
      {
        return this.GetElement<VTVStreamData>(31);
      }
      set
      {
        this.SetElement<VTVStreamData>(31, value);
      }
    }

    public VTClassId VTClassId
    {
      get
      {
        return this.GetElement<VTClassId>(32);
      }
      set
      {
        this.SetElement<VTClassId>(32, value);
      }
    }

    public VTClipboardData VTClipboardData
    {
      get
      {
        return this.GetElement<VTClipboardData>(33);
      }
      set
      {
        this.SetElement<VTClipboardData>(33, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "fmtid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "pid" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "linkTarget" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomDocumentProperty>(deep);
    }
  }
}
