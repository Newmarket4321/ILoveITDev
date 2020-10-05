// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SharedComPicture))]
  [ChildElementInfo(typeof (SharedComFont))]
  public class ActiveXObjectProperty : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "name",
      "value"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 35,
      (byte) 35
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "font",
      "picture"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 35,
      (byte) 35
    };
    private const string tagName = "ocxPr";
    private const byte tagNsId = 35;
    internal const int ElementTypeIdConst = 12689;

    public override string LocalName
    {
      get
      {
        return "ocxPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 35;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12689;
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
        return ActiveXObjectProperty.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ActiveXObjectProperty.attributeNamespaceIds;
      }
    }

    [SchemaAttr(35, "name")]
    public StringValue Name
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

    [SchemaAttr(35, "value")]
    public StringValue Value
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

    public ActiveXObjectProperty()
    {
    }

    public ActiveXObjectProperty(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ActiveXObjectProperty(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ActiveXObjectProperty(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (35 == (int) namespaceId && "font" == name)
        return (OpenXmlElement) new SharedComFont();
      if (35 == (int) namespaceId && "picture" == name)
        return (OpenXmlElement) new SharedComPicture();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ActiveXObjectProperty.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ActiveXObjectProperty.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public SharedComFont SharedComFont
    {
      get
      {
        return this.GetElement<SharedComFont>(0);
      }
      set
      {
        this.SetElement<SharedComFont>(0, value);
      }
    }

    public SharedComPicture SharedComPicture
    {
      get
      {
        return this.GetElement<SharedComPicture>(1);
      }
      set
      {
        this.SetElement<SharedComPicture>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (35 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (35 == (int) namespaceId && "value" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ActiveXObjectProperty>(deep);
    }
  }
}
