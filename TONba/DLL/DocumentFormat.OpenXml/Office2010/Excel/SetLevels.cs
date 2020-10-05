// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SetLevels
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SetLevel), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SetLevels : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "setLevels";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13024;

    public override string LocalName
    {
      get
      {
        return "setLevels";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13024;
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
        return SetLevels.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SetLevels.attributeNamespaceIds;
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

    public SetLevels()
    {
    }

    public SetLevels(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SetLevels(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SetLevels(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "setLevel" == name)
        return (OpenXmlElement) new SetLevel();
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
      return (OpenXmlElement) this.CloneImp<SetLevels>(deep);
    }
  }
}
