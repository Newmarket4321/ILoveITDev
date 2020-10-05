// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ConditionalFormattingRule))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class ConditionalFormatting : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "pivot",
      "sqref"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "conditionalFormatting";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11415;

    public override string LocalName
    {
      get
      {
        return "conditionalFormatting";
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
        return 11415;
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
        return ConditionalFormatting.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ConditionalFormatting.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "pivot")]
    public BooleanValue Pivot
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sqref")]
    public ListValue<StringValue> SequenceOfReferences
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public ConditionalFormatting()
    {
    }

    public ConditionalFormatting(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ConditionalFormatting(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ConditionalFormatting(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "cfRule" == name)
        return (OpenXmlElement) new ConditionalFormattingRule();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "pivot" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sqref" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConditionalFormatting>(deep);
    }
  }
}
