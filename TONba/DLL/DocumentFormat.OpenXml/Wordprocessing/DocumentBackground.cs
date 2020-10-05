// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DocumentBackground
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Background))]
  [GeneratedCode("DomGen", "2.0")]
  public class DocumentBackground : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "color",
      "themeColor",
      "themeTint",
      "themeShade"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "background"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 26
    };
    private const string tagName = "background";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11982;

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
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11982;
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
        return DocumentBackground.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentBackground.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "color")]
    public StringValue Color
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

    [SchemaAttr(23, "themeColor")]
    public EnumValue<ThemeColorValues> ThemeColor
    {
      get
      {
        return (EnumValue<ThemeColorValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "themeTint")]
    public StringValue ThemeTint
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

    [SchemaAttr(23, "themeShade")]
    public StringValue ThemeShade
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public DocumentBackground()
    {
    }

    public DocumentBackground(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocumentBackground(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocumentBackground(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "background" == name)
        return (OpenXmlElement) new Background();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentBackground.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentBackground.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public Background Background
    {
      get
      {
        return this.GetElement<Background>(0);
      }
      set
      {
        this.SetElement<Background>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeColor" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeColorValues>();
      if (23 == (int) namespaceId && "themeTint" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeShade" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentBackground>(deep);
    }
  }
}
