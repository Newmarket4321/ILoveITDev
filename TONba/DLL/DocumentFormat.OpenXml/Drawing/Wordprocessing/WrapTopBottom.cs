// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EffectExtent))]
  public class WrapTopBottom : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "distT",
      "distB"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[1]
    {
      "effectExtent"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 16
    };
    private const string tagName = "wrapTopAndBottom";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10764;

    public override string LocalName
    {
      get
      {
        return "wrapTopAndBottom";
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
        return 10764;
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
        return WrapTopBottom.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WrapTopBottom.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "distT")]
    public UInt32Value DistanceFromTop
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "distB")]
    public UInt32Value DistanceFromBottom
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

    public WrapTopBottom()
    {
    }

    public WrapTopBottom(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WrapTopBottom(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WrapTopBottom(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "effectExtent" == name)
        return (OpenXmlElement) new EffectExtent();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WrapTopBottom.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WrapTopBottom.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public EffectExtent EffectExtent
    {
      get
      {
        return this.GetElement<EffectExtent>(0);
      }
      set
      {
        this.SetElement<EffectExtent>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "distT" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "distB" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WrapTopBottom>(deep);
    }
  }
}
