// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.KeymapsType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [ChildElementInfo(typeof (KeyMapEntry))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class KeymapsType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "keymap" == name)
        return (OpenXmlElement) new KeyMapEntry();
      return (OpenXmlElement) null;
    }

    protected KeymapsType()
    {
    }

    protected KeymapsType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected KeymapsType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected KeymapsType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
