// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommonMediaNode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (TargetElement))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonTimeNode))]
  public class CommonMediaNode : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "vol",
      "mute",
      "numSld",
      "showWhenStopped"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[2]
    {
      "cTn",
      "tgtEl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cMediaNode";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12288;

    public override string LocalName
    {
      get
      {
        return "cMediaNode";
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
        return 12288;
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
        return CommonMediaNode.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommonMediaNode.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "vol")]
    public Int32Value Volume
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

    [SchemaAttr(0, "mute")]
    public BooleanValue Mute
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "numSld")]
    public UInt32Value SlideCount
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

    [SchemaAttr(0, "showWhenStopped")]
    public BooleanValue ShowWhenStopped
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public CommonMediaNode()
    {
    }

    public CommonMediaNode(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommonMediaNode(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommonMediaNode(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cTn" == name)
        return (OpenXmlElement) new CommonTimeNode();
      if (24 == (int) namespaceId && "tgtEl" == name)
        return (OpenXmlElement) new TargetElement();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CommonMediaNode.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CommonMediaNode.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonTimeNode CommonTimeNode
    {
      get
      {
        return this.GetElement<CommonTimeNode>(0);
      }
      set
      {
        this.SetElement<CommonTimeNode>(0, value);
      }
    }

    public TargetElement TargetElement
    {
      get
      {
        return this.GetElement<TargetElement>(1);
      }
      set
      {
        this.SetElement<TargetElement>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "vol" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "mute" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "numSld" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "showWhenStopped" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommonMediaNode>(deep);
    }
  }
}
