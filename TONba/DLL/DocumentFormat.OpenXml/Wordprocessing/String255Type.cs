﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.String255Type
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class String255Type : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return String255Type.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return String255Type.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public StringValue Val
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
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
