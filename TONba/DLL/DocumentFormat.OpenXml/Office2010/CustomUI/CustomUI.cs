// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [ChildElementInfo(typeof (Commands), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Ribbon), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Backstage), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ContextMenus), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomUI : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "onLoad",
      "loadImage"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[4]
    {
      "commands",
      "ribbon",
      "backstage",
      "contextMenus"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 57,
      (byte) 57,
      (byte) 57,
      (byte) 57
    };
    private const string tagName = "customUI";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13142;

    public override string LocalName
    {
      get
      {
        return "customUI";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13142;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "onLoad")]
    public StringValue OnLoad
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

    [SchemaAttr(0, "loadImage")]
    public StringValue LoadImage
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal CustomUI(RibbonAndBackstageCustomizationsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(RibbonAndBackstageCustomizationsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
    {
      get
      {
        return this.OpenXmlPart as RibbonAndBackstageCustomizationsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public CustomUI(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomUI(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomUI(string outerXml)
      : base(outerXml)
    {
    }

    public CustomUI()
    {
    }

    public void Save(RibbonAndBackstageCustomizationsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "commands" == name)
        return (OpenXmlElement) new Commands();
      if (57 == (int) namespaceId && "ribbon" == name)
        return (OpenXmlElement) new Ribbon();
      if (57 == (int) namespaceId && "backstage" == name)
        return (OpenXmlElement) new Backstage();
      if (57 == (int) namespaceId && "contextMenus" == name)
        return (OpenXmlElement) new ContextMenus();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Commands Commands
    {
      get
      {
        return this.GetElement<Commands>(0);
      }
      set
      {
        this.SetElement<Commands>(0, value);
      }
    }

    public Ribbon Ribbon
    {
      get
      {
        return this.GetElement<Ribbon>(1);
      }
      set
      {
        this.SetElement<Ribbon>(1, value);
      }
    }

    public Backstage Backstage
    {
      get
      {
        return this.GetElement<Backstage>(2);
      }
      set
      {
        this.SetElement<Backstage>(2, value);
      }
    }

    public ContextMenus ContextMenus
    {
      get
      {
        return this.GetElement<ContextMenus>(3);
      }
      set
      {
        this.SetElement<ContextMenus>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "onLoad" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "loadImage" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI>(deep);
    }
  }
}
