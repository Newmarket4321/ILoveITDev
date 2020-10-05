﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class TabularSlicerCacheItem : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "x",
      "s",
      "nd"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "i";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13072;

    public override string LocalName
    {
      get
      {
        return "i";
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
        return 13072;
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
        return TabularSlicerCacheItem.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TabularSlicerCacheItem.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "x")]
    public UInt32Value Atom
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

    [SchemaAttr(0, "s")]
    public BooleanValue IsSelected
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "nd")]
    public BooleanValue NonDisplay
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "x" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "s" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "nd" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TabularSlicerCacheItem>(deep);
    }
  }
}
