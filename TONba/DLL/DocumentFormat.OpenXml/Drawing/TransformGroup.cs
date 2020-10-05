// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TransformGroup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Offset))]
  [ChildElementInfo(typeof (Extents))]
  [ChildElementInfo(typeof (ChildOffset))]
  [ChildElementInfo(typeof (ChildExtents))]
  public class TransformGroup : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "rot",
      "flipH",
      "flipV"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[4]
    {
      "off",
      "ext",
      "chOff",
      "chExt"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "xfrm";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10235;

    public override string LocalName
    {
      get
      {
        return "xfrm";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10235;
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
        return TransformGroup.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TransformGroup.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
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

    [SchemaAttr(0, "flipH")]
    public BooleanValue HorizontalFlip
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

    [SchemaAttr(0, "flipV")]
    public BooleanValue VerticalFlip
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public TransformGroup()
    {
    }

    public TransformGroup(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TransformGroup(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TransformGroup(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "off" == name)
        return (OpenXmlElement) new Offset();
      if (10 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new Extents();
      if (10 == (int) namespaceId && "chOff" == name)
        return (OpenXmlElement) new ChildOffset();
      if (10 == (int) namespaceId && "chExt" == name)
        return (OpenXmlElement) new ChildExtents();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TransformGroup.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TransformGroup.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Offset Offset
    {
      get
      {
        return this.GetElement<Offset>(0);
      }
      set
      {
        this.SetElement<Offset>(0, value);
      }
    }

    public Extents Extents
    {
      get
      {
        return this.GetElement<Extents>(1);
      }
      set
      {
        this.SetElement<Extents>(1, value);
      }
    }

    public ChildOffset ChildOffset
    {
      get
      {
        return this.GetElement<ChildOffset>(2);
      }
      set
      {
        this.SetElement<ChildOffset>(2, value);
      }
    }

    public ChildExtents ChildExtents
    {
      get
      {
        return this.GetElement<ChildExtents>(3);
      }
      set
      {
        this.SetElement<ChildExtents>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rot" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "flipH" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "flipV" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TransformGroup>(deep);
    }
  }
}
