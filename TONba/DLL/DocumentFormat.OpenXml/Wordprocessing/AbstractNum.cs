// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.AbstractNum
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Nsid))]
  [ChildElementInfo(typeof (StyleLink))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MultiLevelType))]
  [ChildElementInfo(typeof (TemplateCode))]
  [ChildElementInfo(typeof (AbstractNumDefinitionName))]
  [ChildElementInfo(typeof (NumberingStyleLink))]
  [ChildElementInfo(typeof (Level))]
  public class AbstractNum : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "abstractNumId"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[7]
    {
      "nsid",
      "multiLevelType",
      "tmpl",
      "name",
      "styleLink",
      "numStyleLink",
      "lvl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "abstractNum";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11933;

    public override string LocalName
    {
      get
      {
        return "abstractNum";
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
        return 11933;
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
        return AbstractNum.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AbstractNum.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "abstractNumId")]
    public Int32Value AbstractNumberId
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

    public AbstractNum()
    {
    }

    public AbstractNum(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AbstractNum(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AbstractNum(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "nsid" == name)
        return (OpenXmlElement) new Nsid();
      if (23 == (int) namespaceId && "multiLevelType" == name)
        return (OpenXmlElement) new MultiLevelType();
      if (23 == (int) namespaceId && "tmpl" == name)
        return (OpenXmlElement) new TemplateCode();
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new AbstractNumDefinitionName();
      if (23 == (int) namespaceId && "styleLink" == name)
        return (OpenXmlElement) new StyleLink();
      if (23 == (int) namespaceId && "numStyleLink" == name)
        return (OpenXmlElement) new NumberingStyleLink();
      if (23 == (int) namespaceId && "lvl" == name)
        return (OpenXmlElement) new Level();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AbstractNum.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AbstractNum.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Nsid Nsid
    {
      get
      {
        return this.GetElement<Nsid>(0);
      }
      set
      {
        this.SetElement<Nsid>(0, value);
      }
    }

    public MultiLevelType MultiLevelType
    {
      get
      {
        return this.GetElement<MultiLevelType>(1);
      }
      set
      {
        this.SetElement<MultiLevelType>(1, value);
      }
    }

    public TemplateCode TemplateCode
    {
      get
      {
        return this.GetElement<TemplateCode>(2);
      }
      set
      {
        this.SetElement<TemplateCode>(2, value);
      }
    }

    public AbstractNumDefinitionName AbstractNumDefinitionName
    {
      get
      {
        return this.GetElement<AbstractNumDefinitionName>(3);
      }
      set
      {
        this.SetElement<AbstractNumDefinitionName>(3, value);
      }
    }

    public StyleLink StyleLink
    {
      get
      {
        return this.GetElement<StyleLink>(4);
      }
      set
      {
        this.SetElement<StyleLink>(4, value);
      }
    }

    public NumberingStyleLink NumberingStyleLink
    {
      get
      {
        return this.GetElement<NumberingStyleLink>(5);
      }
      set
      {
        this.SetElement<NumberingStyleLink>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "abstractNumId" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AbstractNum>(deep);
    }
  }
}
