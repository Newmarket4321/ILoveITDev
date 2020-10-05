// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.GroupLevel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Groups))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class GroupLevel : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "uniqueName",
      "caption",
      "user",
      "customRollUp"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[2]
    {
      "groups",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "groupLevel";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11151;

    public override string LocalName
    {
      get
      {
        return "groupLevel";
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
        return 11151;
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
        return GroupLevel.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GroupLevel.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
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

    [SchemaAttr(0, "caption")]
    public StringValue Caption
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

    [SchemaAttr(0, "user")]
    public BooleanValue User
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customRollUp")]
    public BooleanValue CustomRollUp
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public GroupLevel()
    {
    }

    public GroupLevel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GroupLevel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GroupLevel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "groups" == name)
        return (OpenXmlElement) new Groups();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GroupLevel.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GroupLevel.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Groups Groups
    {
      get
      {
        return this.GetElement<Groups>(0);
      }
      set
      {
        this.SetElement<Groups>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "caption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "user" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "customRollUp" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GroupLevel>(deep);
    }
  }
}
