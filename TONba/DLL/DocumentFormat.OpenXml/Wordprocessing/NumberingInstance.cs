// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.NumberingInstance
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AbstractNumId))]
  [ChildElementInfo(typeof (LevelOverride))]
  public class NumberingInstance : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "numId"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "abstractNumId",
      "lvlOverride"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "num";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11934;

    public override string LocalName
    {
      get
      {
        return "num";
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
        return 11934;
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
        return NumberingInstance.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NumberingInstance.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "numId")]
    public Int32Value NumberID
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

    public NumberingInstance()
    {
    }

    public NumberingInstance(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NumberingInstance(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NumberingInstance(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "abstractNumId" == name)
        return (OpenXmlElement) new AbstractNumId();
      if (23 == (int) namespaceId && "lvlOverride" == name)
        return (OpenXmlElement) new LevelOverride();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberingInstance.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberingInstance.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AbstractNumId AbstractNumId
    {
      get
      {
        return this.GetElement<AbstractNumId>(0);
      }
      set
      {
        this.SetElement<AbstractNumId>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "numId" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberingInstance>(deep);
    }
  }
}
