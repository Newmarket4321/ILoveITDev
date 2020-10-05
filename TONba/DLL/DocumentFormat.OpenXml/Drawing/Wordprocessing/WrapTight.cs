// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [ChildElementInfo(typeof (WrapPolygon))]
  [GeneratedCode("DomGen", "2.0")]
  public class WrapTight : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "wrapText",
      "distL",
      "distR"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "wrapPolygon"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 16
    };
    private const string tagName = "wrapTight";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10762;

    public override string LocalName
    {
      get
      {
        return "wrapTight";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 16;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10762;
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
        return WrapTight.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WrapTight.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "wrapText")]
    public EnumValue<WrapTextValues> WrapText
    {
      get
      {
        return (EnumValue<WrapTextValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
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

    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public WrapTight()
    {
    }

    public WrapTight(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WrapTight(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WrapTight(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "wrapPolygon" == name)
        return (OpenXmlElement) new WrapPolygon();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WrapTight.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WrapTight.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public WrapPolygon WrapPolygon
    {
      get
      {
        return this.GetElement<WrapPolygon>(0);
      }
      set
      {
        this.SetElement<WrapPolygon>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "wrapText" == name)
        return (OpenXmlSimpleType) new EnumValue<WrapTextValues>();
      if ((int) namespaceId == 0 && "distL" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "distR" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WrapTight>(deep);
    }
  }
}
