// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Users
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (UserInfo))]
  public class Users : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "users";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11104;

    public override string LocalName
    {
      get
      {
        return "users";
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
        return 11104;
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
        return Users.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Users.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "count")]
    public UInt32Value Count
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

    internal Users(WorkbookUserDataPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorkbookUserDataPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorkbookUserDataPart WorkbookUserDataPart
    {
      get
      {
        return this.OpenXmlPart as WorkbookUserDataPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Users(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Users(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Users(string outerXml)
      : base(outerXml)
    {
    }

    public Users()
    {
    }

    public void Save(WorkbookUserDataPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "userInfo" == name)
        return (OpenXmlElement) new UserInfo();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Users>(deep);
    }
  }
}
