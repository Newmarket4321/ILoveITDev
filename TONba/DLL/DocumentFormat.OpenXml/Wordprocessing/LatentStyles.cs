// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.LatentStyles
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (LatentStyleExceptionInfo))]
  [GeneratedCode("DomGen", "2.0")]
  public class LatentStyles : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "defLockedState",
      "defUIPriority",
      "defSemiHidden",
      "defUnhideWhenUsed",
      "defQFormat",
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "latentStyles";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11961;

    public override string LocalName
    {
      get
      {
        return "latentStyles";
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
        return 11961;
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
        return LatentStyles.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LatentStyles.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "defLockedState")]
    public OnOffValue DefaultLockedState
    {
      get
      {
        return (OnOffValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "defUIPriority")]
    public Int32Value DefaultUiPriority
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "defSemiHidden")]
    public OnOffValue DefaultSemiHidden
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "defUnhideWhenUsed")]
    public OnOffValue DefaultUnhideWhenUsed
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "defQFormat")]
    public OnOffValue DefaultPrimaryStyle
    {
      get
      {
        return (OnOffValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "count")]
    public Int32Value Count
    {
      get
      {
        return (Int32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public LatentStyles()
    {
    }

    public LatentStyles(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LatentStyles(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LatentStyles(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "lsdException" == name)
        return (OpenXmlElement) new LatentStyleExceptionInfo();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "defLockedState" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "defUIPriority" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "defSemiHidden" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "defUnhideWhenUsed" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "defQFormat" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "count" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LatentStyles>(deep);
    }
  }
}
