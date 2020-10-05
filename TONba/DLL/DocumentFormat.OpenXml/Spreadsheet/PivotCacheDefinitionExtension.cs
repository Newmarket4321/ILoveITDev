// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotCacheDefinitionExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.PivotCacheDefinition), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (TimelinePivotCacheDefinition), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PivotCacheDecoupled), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotCacheIdVersion), FileFormatVersions.Office2013)]
  public class PivotCacheDefinitionExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11459;

    public override string LocalName
    {
      get
      {
        return "ext";
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
        return 11459;
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
        return PivotCacheDefinitionExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotCacheDefinitionExtension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
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

    public PivotCacheDefinitionExtension()
    {
    }

    public PivotCacheDefinitionExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotCacheDefinitionExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotCacheDefinitionExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "pivotCacheDefinition" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.PivotCacheDefinition();
      if (71 == (int) namespaceId && "pivotCacheDecoupled" == name)
        return (OpenXmlElement) new PivotCacheDecoupled();
      if (71 == (int) namespaceId && "timelinePivotCacheDefinition" == name)
        return (OpenXmlElement) new TimelinePivotCacheDefinition();
      if (71 == (int) namespaceId && "pivotCacheIdVersion" == name)
        return (OpenXmlElement) new PivotCacheIdVersion();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotCacheDefinitionExtension>(deep);
    }
  }
}
