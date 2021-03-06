﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PermStart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class PermStart : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "edGrp",
      "ed",
      "colFirst",
      "colLast",
      "id",
      "displacedByCustomXml"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "permStart";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11671;

    public override string LocalName
    {
      get
      {
        return "permStart";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11671;
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
        return PermStart.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PermStart.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "edGrp")]
    public EnumValue<RangePermissionEditingGroupValues> EditorGroup
    {
      get
      {
        return (EnumValue<RangePermissionEditingGroupValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "ed")]
    public StringValue Ed
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "colFirst")]
    public Int32Value ColumnFirst
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "colLast")]
    public Int32Value ColumnLast
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
    public Int32Value Id
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "displacedByCustomXml")]
    public EnumValue<DisplacedByCustomXmlValues> DisplacedByCustomXml
    {
      get
      {
        return (EnumValue<DisplacedByCustomXmlValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "edGrp" == name)
        return (OpenXmlSimpleType) new EnumValue<RangePermissionEditingGroupValues>();
      if (23 == (int) namespaceId && "ed" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "colFirst" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "colLast" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "displacedByCustomXml" == name)
        return (OpenXmlSimpleType) new EnumValue<DisplacedByCustomXmlValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PermStart>(deep);
    }
  }
}
