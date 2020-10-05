// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.ShapeLayout
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [ChildElementInfo(typeof (RegroupTable))]
  [ChildElementInfo(typeof (ShapeIdMap))]
  [ChildElementInfo(typeof (Rules))]
  [GeneratedCode("DomGen", "2.0")]
  public class ShapeLayout : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ext"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 26
    };
    private static readonly string[] eleTagNames = new string[3]
    {
      "idmap",
      "regrouptable",
      "rules"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "shapelayout";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12471;

    public override string LocalName
    {
      get
      {
        return "shapelayout";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12471;
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
        return ShapeLayout.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ShapeLayout.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public ShapeLayout()
    {
    }

    public ShapeLayout(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShapeLayout(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShapeLayout(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "idmap" == name)
        return (OpenXmlElement) new ShapeIdMap();
      if (27 == (int) namespaceId && "regrouptable" == name)
        return (OpenXmlElement) new RegroupTable();
      if (27 == (int) namespaceId && "rules" == name)
        return (OpenXmlElement) new Rules();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ShapeLayout.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ShapeLayout.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public ShapeIdMap ShapeIdMap
    {
      get
      {
        return this.GetElement<ShapeIdMap>(0);
      }
      set
      {
        this.SetElement<ShapeIdMap>(0, value);
      }
    }

    public RegroupTable RegroupTable
    {
      get
      {
        return this.GetElement<RegroupTable>(1);
      }
      set
      {
        this.SetElement<RegroupTable>(1, value);
      }
    }

    public Rules Rules
    {
      get
      {
        return this.GetElement<Rules>(2);
      }
      set
      {
        this.SetElement<Rules>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapeLayout>(deep);
    }
  }
}
