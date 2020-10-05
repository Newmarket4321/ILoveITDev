// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.GroupInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [GeneratedCode("DomGen", "2.0")]
  public class GroupInfo : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ref"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "group-info";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12749;

    public override string LocalName
    {
      get
      {
        return "group-info";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 44;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12749;
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
        return GroupInfo.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GroupInfo.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ref")]
    public StringValue Reference
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

    public GroupInfo()
    {
    }

    public GroupInfo(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GroupInfo(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GroupInfo(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GroupInfo>(deep);
    }
  }
}
