// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Rules
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [ChildElementInfo(typeof (Rule))]
  [GeneratedCode("DomGen", "2.0")]
  public class Rules : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ext"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 26
    };
    private const string tagName = "rules";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12490;

    public override string LocalName
    {
      get
      {
        return "rules";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12490;
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
        return Rules.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Rules.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public Rules()
    {
    }

    public Rules(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Rules(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Rules(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new Rule();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Rules>(deep);
    }
  }
}
