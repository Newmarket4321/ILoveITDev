﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.EmbeddedFontDataIdType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class EmbeddedFontDataIdType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 19
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return EmbeddedFontDataIdType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EmbeddedFontDataIdType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
