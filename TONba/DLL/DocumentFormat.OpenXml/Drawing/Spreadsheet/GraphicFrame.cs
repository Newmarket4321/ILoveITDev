// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (Graphic))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualGraphicFrameProperties))]
  [ChildElementInfo(typeof (Transform))]
  public class GraphicFrame : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "macro",
      "fPublished"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "nvGraphicFramePr",
      "xfrm",
      "graphic"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 18,
      (byte) 18,
      (byte) 10
    };
    private const string tagName = "graphicFrame";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10791;

    public override string LocalName
    {
      get
      {
        return "graphicFrame";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10791;
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
        return GraphicFrame.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GraphicFrame.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
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

    public GraphicFrame()
    {
    }

    public GraphicFrame(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GraphicFrame(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GraphicFrame(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "nvGraphicFramePr" == name)
        return (OpenXmlElement) new NonVisualGraphicFrameProperties();
      if (18 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new Transform();
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GraphicFrame.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GraphicFrame.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
    {
      get
      {
        return this.GetElement<NonVisualGraphicFrameProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualGraphicFrameProperties>(0, value);
      }
    }

    public Transform Transform
    {
      get
      {
        return this.GetElement<Transform>(1);
      }
      set
      {
        this.SetElement<Transform>(1, value);
      }
    }

    public Graphic Graphic
    {
      get
      {
        return this.GetElement<Graphic>(2);
      }
      set
      {
        this.SetElement<Graphic>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "macro" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fPublished" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GraphicFrame>(deep);
    }
  }
}
