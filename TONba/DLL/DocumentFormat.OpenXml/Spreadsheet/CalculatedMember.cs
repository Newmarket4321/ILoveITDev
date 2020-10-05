// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CalculatedMember
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (CalculatedMemberExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class CalculatedMember : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "name",
      "mdx",
      "memberName",
      "hierarchy",
      "parent",
      "solveOrder",
      "set"
    };
    private static byte[] attributeNamespaceIds = new byte[7];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "calculatedMember";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11167;

    public override string LocalName
    {
      get
      {
        return "calculatedMember";
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
        return 11167;
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
        return CalculatedMember.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CalculatedMember.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
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

    [SchemaAttr(0, "mdx")]
    public StringValue Mdx
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

    [SchemaAttr(0, "memberName")]
    public StringValue MemberName
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

    [SchemaAttr(0, "hierarchy")]
    public StringValue Hierarchy
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

    [SchemaAttr(0, "parent")]
    public StringValue ParentName
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "solveOrder")]
    public Int32Value SolveOrder
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

    [SchemaAttr(0, "set")]
    public BooleanValue Set
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    public CalculatedMember()
    {
    }

    public CalculatedMember(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CalculatedMember(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CalculatedMember(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new CalculatedMemberExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CalculatedMember.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CalculatedMember.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CalculatedMemberExtensionList CalculatedMemberExtensionList
    {
      get
      {
        return this.GetElement<CalculatedMemberExtensionList>(0);
      }
      set
      {
        this.SetElement<CalculatedMemberExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "mdx" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "memberName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hierarchy" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "parent" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "solveOrder" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "set" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CalculatedMember>(deep);
    }
  }
}
