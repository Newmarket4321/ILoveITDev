// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.BuildParagraph
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (TemplateList))]
  [GeneratedCode("DomGen", "2.0")]
  public class BuildParagraph : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "spid",
      "grpId",
      "uiExpand",
      "build",
      "bldLvl",
      "animBg",
      "autoUpdateAnimBg",
      "rev",
      "advAuto"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private static readonly string[] eleTagNames = new string[1]
    {
      "tmplLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "bldP";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12294;

    public override string LocalName
    {
      get
      {
        return "bldP";
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
        return 12294;
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
        return BuildParagraph.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BuildParagraph.attributeNamespaceIds;
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

    [SchemaAttr(0, "build")]
    public EnumValue<ParagraphBuildValues> Build
    {
      get
      {
        return (EnumValue<ParagraphBuildValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bldLvl")]
    public UInt32Value BuildLevel
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "animBg")]
    public BooleanValue AnimateBackground
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoUpdateAnimBg")]
    public BooleanValue AutoAnimateBackground
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rev")]
    public BooleanValue Reverse
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "advAuto")]
    public StringValue AutoAdvance
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public BuildParagraph()
    {
    }

    public BuildParagraph(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BuildParagraph(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BuildParagraph(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "tmplLst" == name)
        return (OpenXmlElement) new TemplateList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BuildParagraph.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BuildParagraph.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TemplateList TemplateList
    {
      get
      {
        return this.GetElement<TemplateList>(0);
      }
      set
      {
        this.SetElement<TemplateList>(0, value);
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
      if ((int) namespaceId == 0 && "build" == name)
        return (OpenXmlSimpleType) new EnumValue<ParagraphBuildValues>();
      if ((int) namespaceId == 0 && "bldLvl" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "animBg" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoUpdateAnimBg" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rev" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "advAuto" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BuildParagraph>(deep);
    }
  }
}
