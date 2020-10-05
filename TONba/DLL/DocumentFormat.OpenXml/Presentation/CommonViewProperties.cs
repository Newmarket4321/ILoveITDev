// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommonViewProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (ScaleFactor))]
  [ChildElementInfo(typeof (Origin))]
  [GeneratedCode("DomGen", "2.0")]
  public class CommonViewProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "varScale"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "scale",
      "origin"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cViewPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12349;

    public override string LocalName
    {
      get
      {
        return "cViewPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12349;
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
        return CommonViewProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommonViewProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "varScale")]
    public BooleanValue VariableScale
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public CommonViewProperties()
    {
    }

    public CommonViewProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommonViewProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommonViewProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "scale" == name)
        return (OpenXmlElement) new ScaleFactor();
      if (24 == (int) namespaceId && "origin" == name)
        return (OpenXmlElement) new Origin();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CommonViewProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CommonViewProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ScaleFactor ScaleFactor
    {
      get
      {
        return this.GetElement<ScaleFactor>(0);
      }
      set
      {
        this.SetElement<ScaleFactor>(0, value);
      }
    }

    public Origin Origin
    {
      get
      {
        return this.GetElement<Origin>(1);
      }
      set
      {
        this.SetElement<Origin>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "varScale" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommonViewProperties>(deep);
    }
  }
}
