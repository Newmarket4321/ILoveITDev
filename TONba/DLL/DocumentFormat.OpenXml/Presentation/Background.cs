// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Background
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BackgroundProperties))]
  [ChildElementInfo(typeof (BackgroundStyleReference))]
  public class Background : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "bwMode"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "bgPr",
      "bgRef"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "bg";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12371;

    public override string LocalName
    {
      get
      {
        return "bg";
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
        return 12371;
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

    [SchemaAttr(0, "bwMode")]
    public EnumValue<BlackWhiteModeValues> BlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
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
      if (24 == (int) namespaceId && "bgPr" == name)
        return (OpenXmlElement) new BackgroundProperties();
      if (24 == (int) namespaceId && "bgRef" == name)
        return (OpenXmlElement) new BackgroundStyleReference();
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
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public BackgroundProperties BackgroundProperties
    {
      get
      {
        return this.GetElement<BackgroundProperties>(0);
      }
      set
      {
        this.SetElement<BackgroundProperties>(0, value);
      }
    }

    public BackgroundStyleReference BackgroundStyleReference
    {
      get
      {
        return this.GetElement<BackgroundStyleReference>(1);
      }
      set
      {
        this.SetElement<BackgroundStyleReference>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "bwMode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Background>(deep);
    }
  }
}
