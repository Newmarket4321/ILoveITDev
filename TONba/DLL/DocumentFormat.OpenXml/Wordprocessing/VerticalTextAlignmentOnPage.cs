﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class VerticalTextAlignmentOnPage : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "vAlign";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11747;

    public override string LocalName
    {
      get
      {
        return "vAlign";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11747;
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
        return VerticalTextAlignmentOnPage.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return VerticalTextAlignmentOnPage.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public EnumValue<VerticalJustificationValues> Val
    {
      get
      {
        return (EnumValue<VerticalJustificationValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalJustificationValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VerticalTextAlignmentOnPage>(deep);
    }
  }
}
