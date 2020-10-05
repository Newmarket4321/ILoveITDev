// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.VolatileType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Main))]
  public class VolatileType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "type"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "volType";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11352;

    public override string LocalName
    {
      get
      {
        return "volType";
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
        return 11352;
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
        return VolatileType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return VolatileType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<VolatileDependencyValues> Type
    {
      get
      {
        return (EnumValue<VolatileDependencyValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public VolatileType()
    {
    }

    public VolatileType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VolatileType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VolatileType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "main" == name)
        return (OpenXmlElement) new Main();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<VolatileDependencyValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VolatileType>(deep);
    }
  }
}
