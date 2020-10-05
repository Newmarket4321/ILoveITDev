// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [ChildElementInfo(typeof (ContextualTabs), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (QuickAccessToolbar), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Tabs), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class Ribbon : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "startFromScratch"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "qat",
      "tabs",
      "contextualTabs"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 57,
      (byte) 57,
      (byte) 57
    };
    private const string tagName = "ribbon";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13177;

    public override string LocalName
    {
      get
      {
        return "ribbon";
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
        return 13177;
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
        return Ribbon.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Ribbon.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "startFromScratch")]
    public BooleanValue StartFromScratch
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

    public Ribbon()
    {
    }

    public Ribbon(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Ribbon(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Ribbon(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "qat" == name)
        return (OpenXmlElement) new QuickAccessToolbar();
      if (57 == (int) namespaceId && "tabs" == name)
        return (OpenXmlElement) new Tabs();
      if (57 == (int) namespaceId && "contextualTabs" == name)
        return (OpenXmlElement) new ContextualTabs();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Ribbon.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Ribbon.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public QuickAccessToolbar QuickAccessToolbar
    {
      get
      {
        return this.GetElement<QuickAccessToolbar>(0);
      }
      set
      {
        this.SetElement<QuickAccessToolbar>(0, value);
      }
    }

    public Tabs Tabs
    {
      get
      {
        return this.GetElement<Tabs>(1);
      }
      set
      {
        this.SetElement<Tabs>(1, value);
      }
    }

    public ContextualTabs ContextualTabs
    {
      get
      {
        return this.GetElement<ContextualTabs>(2);
      }
      set
      {
        this.SetElement<ContextualTabs>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "startFromScratch" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Ribbon>(deep);
    }
  }
}
