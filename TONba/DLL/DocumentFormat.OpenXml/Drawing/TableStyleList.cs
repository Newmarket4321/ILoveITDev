// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableStyleList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TableStyleEntry))]
  [GeneratedCode("DomGen", "2.0")]
  public class TableStyleList : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "def"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "tblStyleLst";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10126;

    public override string LocalName
    {
      get
      {
        return "tblStyleLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10126;
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
        return TableStyleList.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableStyleList.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "def")]
    public StringValue Default
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

    internal TableStyleList(TableStylesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(TableStylesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public TableStylesPart TableStylesPart
    {
      get
      {
        return this.OpenXmlPart as TableStylesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public TableStyleList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableStyleList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableStyleList(string outerXml)
      : base(outerXml)
    {
    }

    public TableStyleList()
    {
    }

    public void Save(TableStylesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tblStyle" == name)
        return (OpenXmlElement) new TableStyleEntry();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "def" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableStyleList>(deep);
    }
  }
}
