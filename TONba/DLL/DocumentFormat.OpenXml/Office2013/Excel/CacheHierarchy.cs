﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.CacheHierarchy
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class CacheHierarchy : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "aggregatedColumn"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "cacheHierarchy";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13373;

    public override string LocalName
    {
      get
      {
        return "cacheHierarchy";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13373;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return CacheHierarchy.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CacheHierarchy.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "aggregatedColumn")]
    public Int32Value AggregatedColumn
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "aggregatedColumn" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CacheHierarchy>(deep);
    }
  }
}
