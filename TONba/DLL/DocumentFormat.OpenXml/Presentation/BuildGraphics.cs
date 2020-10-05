// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.BuildGraphics
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (BuildAsOne))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BuildSubElement))]
  public class BuildGraphics : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "spid",
      "grpId",
      "uiExpand"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[2]
    {
      "bldAsOne",
      "bldSub"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "bldGraphic";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12297;

    public override string LocalName
    {
      get
      {
        return "bldGraphic";
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
        return 12297;
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
        return BuildGraphics.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BuildGraphics.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
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

    [SchemaAttr(0, "grpId")]
    public UInt32Value GroupId
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

    [SchemaAttr(0, "uiExpand")]
    public BooleanValue UiExpand
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

    public BuildGraphics()
    {
    }

    public BuildGraphics(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BuildGraphics(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BuildGraphics(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "bldAsOne" == name)
        return (OpenXmlElement) new BuildAsOne();
      if (24 == (int) namespaceId && "bldSub" == name)
        return (OpenXmlElement) new BuildSubElement();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BuildGraphics.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BuildGraphics.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public BuildAsOne BuildAsOne
    {
      get
      {
        return this.GetElement<BuildAsOne>(0);
      }
      set
      {
        this.SetElement<BuildAsOne>(0, value);
      }
    }

    public BuildSubElement BuildSubElement
    {
      get
      {
        return this.GetElement<BuildSubElement>(1);
      }
      set
      {
        this.SetElement<BuildSubElement>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "spid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "grpId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "uiExpand" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BuildGraphics>(deep);
    }
  }
}
