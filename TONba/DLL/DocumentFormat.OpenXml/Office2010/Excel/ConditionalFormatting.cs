// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormatting
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ReferenceSequence))]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ConditionalFormattingRule), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class ConditionalFormatting : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "pivot"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "conditionalFormatting";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12995;

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
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12995;
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
      if (53 == (int) namespaceId && "cfRule" == name)
        return (OpenXmlElement) new ConditionalFormattingRule();
      if (32 == (int) namespaceId && "sqref" == name)
        return (OpenXmlElement) new ReferenceSequence();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "pivot" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConditionalFormatting>(deep);
    }
  }
}
