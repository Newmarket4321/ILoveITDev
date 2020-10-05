// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SequenceTimeNode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonTimeNode))]
  [ChildElementInfo(typeof (NextConditionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PreviousConditionList))]
  public class SequenceTimeNode : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "concurrent",
      "prevAc",
      "nextAc"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[3]
    {
      "cTn",
      "prevCondLst",
      "nextCondLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "seq";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12260;

    public override string LocalName
    {
      get
      {
        return "seq";
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
        return 12260;
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
        return SequenceTimeNode.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SequenceTimeNode.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "concurrent")]
    public BooleanValue Concurrent
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

    [SchemaAttr(0, "prevAc")]
    public EnumValue<PreviousActionValues> PreviousAction
    {
      get
      {
        return (EnumValue<PreviousActionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "nextAc")]
    public EnumValue<NextActionValues> NextAction
    {
      get
      {
        return (EnumValue<NextActionValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public SequenceTimeNode()
    {
    }

    public SequenceTimeNode(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SequenceTimeNode(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SequenceTimeNode(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cTn" == name)
        return (OpenXmlElement) new CommonTimeNode();
      if (24 == (int) namespaceId && "prevCondLst" == name)
        return (OpenXmlElement) new PreviousConditionList();
      if (24 == (int) namespaceId && "nextCondLst" == name)
        return (OpenXmlElement) new NextConditionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SequenceTimeNode.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SequenceTimeNode.eleNamespaceIds;
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

    public PreviousConditionList PreviousConditionList
    {
      get
      {
        return this.GetElement<PreviousConditionList>(1);
      }
      set
      {
        this.SetElement<PreviousConditionList>(1, value);
      }
    }

    public NextConditionList NextConditionList
    {
      get
      {
        return this.GetElement<NextConditionList>(2);
      }
      set
      {
        this.SetElement<NextConditionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "concurrent" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "prevAc" == name)
        return (OpenXmlSimpleType) new EnumValue<PreviousActionValues>();
      if ((int) namespaceId == 0 && "nextAc" == name)
        return (OpenXmlSimpleType) new EnumValue<NextActionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SequenceTimeNode>(deep);
    }
  }
}
