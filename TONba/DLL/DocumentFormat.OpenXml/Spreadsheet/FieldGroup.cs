// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.FieldGroup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (RangeProperties))]
  [ChildElementInfo(typeof (GroupItems))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DiscreteProperties))]
  public class FieldGroup : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "par",
      "base"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "fieldGroup";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11461;

    public override string LocalName
    {
      get
      {
        return "fieldGroup";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11461;
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
        return FieldGroup.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FieldGroup.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "par")]
    public UInt32Value ParentId
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "base")]
    public UInt32Value Base
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public FieldGroup()
    {
    }

    public FieldGroup(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FieldGroup(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FieldGroup(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "rangePr" == name)
        return (OpenXmlElement) new RangeProperties();
      if (22 == (int) namespaceId && "discretePr" == name)
        return (OpenXmlElement) new DiscreteProperties();
      if (22 == (int) namespaceId && "groupItems" == name)
        return (OpenXmlElement) new GroupItems();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "par" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "base" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FieldGroup>(deep);
    }
  }
}
