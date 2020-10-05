// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.ActiveX.SharedComFont
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ActiveXObjectProperty))]
  public class SharedComFont : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "persistence",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 35,
      (byte) 19
    };
    private const string tagName = "font";
    private const byte tagNsId = 35;
    internal const int ElementTypeIdConst = 12690;

    public override string LocalName
    {
      get
      {
        return "font";
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
        return 12690;
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
        return SharedComFont.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SharedComFont.attributeNamespaceIds;
      }
    }

    [SchemaAttr(35, "persistence")]
    public EnumValue<PersistenceValues> Persistence
    {
      get
      {
        return (EnumValue<PersistenceValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    public SharedComFont()
    {
    }

    public SharedComFont(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SharedComFont(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SharedComFont(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (35 == (int) namespaceId && "ocxPr" == name)
        return (OpenXmlElement) new ActiveXObjectProperty();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (35 == (int) namespaceId && "persistence" == name)
        return (OpenXmlSimpleType) new EnumValue<PersistenceValues>();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SharedComFont>(deep);
    }
  }
}
