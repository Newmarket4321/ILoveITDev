// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableRow
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TableCell))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  public class TableRow : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "h"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "tr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10261;

    public override string LocalName
    {
      get
      {
        return "tr";
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
        return 10261;
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
        return TableRow.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableRow.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "h")]
    public Int64Value Height
    {
      get
      {
        return (Int64Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public TableRow()
    {
    }

    public TableRow(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableRow(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableRow(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tc" == name)
        return (OpenXmlElement) new TableCell();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "h" == name)
        return (OpenXmlSimpleType) new Int64Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableRow>(deep);
    }
  }
}
