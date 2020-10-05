// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Background
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Fill))]
  public class Background : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "id",
      "fill",
      "fillcolor",
      "bwmode",
      "bwpure",
      "bwnormal",
      "targetscreensize"
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "fill"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 26
    };
    private const string tagName = "background";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12589;

    public override string LocalName
    {
      get
      {
        return "background";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12589;
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
        return Background.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Background.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "fill")]
    public TrueFalseValue Filled
    {
      get
      {
        return (TrueFalseValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fillcolor")]
    public StringValue Fillcolor
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bwmode")]
    public EnumValue<BlackAndWhiteModeValues> BlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackAndWhiteModeValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bwpure")]
    public EnumValue<BlackAndWhiteModeValues> PureBlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackAndWhiteModeValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bwnormal")]
    public EnumValue<BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackAndWhiteModeValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "targetscreensize")]
    public EnumValue<ScreenSizeValues> TargetScreenSize
    {
      get
      {
        return (EnumValue<ScreenSizeValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    public Background()
    {
    }

    public Background(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Background(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Background(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new Fill();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Background.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Background.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Fill Fill
    {
      get
      {
        return this.GetElement<Fill>(0);
      }
      set
      {
        this.SetElement<Fill>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fill" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "fillcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "bwmode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackAndWhiteModeValues>();
      if (27 == (int) namespaceId && "bwpure" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackAndWhiteModeValues>();
      if (27 == (int) namespaceId && "bwnormal" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackAndWhiteModeValues>();
      if (27 == (int) namespaceId && "targetscreensize" == name)
        return (OpenXmlSimpleType) new EnumValue<ScreenSizeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Background>(deep);
    }
  }
}
