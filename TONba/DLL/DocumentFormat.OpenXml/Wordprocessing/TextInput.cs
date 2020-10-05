// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TextInput
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TextBoxFormFieldType))]
  [ChildElementInfo(typeof (MaxLength))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DefaultTextBoxFormFieldString))]
  [ChildElementInfo(typeof (Format))]
  public class TextInput : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "type",
      "default",
      "maxLength",
      "format"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "textInput";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11798;

    public override string LocalName
    {
      get
      {
        return "textInput";
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
        return 11798;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TextInput()
    {
    }

    public TextInput(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextInput(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextInput(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlElement) new TextBoxFormFieldType();
      if (23 == (int) namespaceId && "default" == name)
        return (OpenXmlElement) new DefaultTextBoxFormFieldString();
      if (23 == (int) namespaceId && "maxLength" == name)
        return (OpenXmlElement) new MaxLength();
      if (23 == (int) namespaceId && "format" == name)
        return (OpenXmlElement) new Format();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextInput.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextInput.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TextBoxFormFieldType TextBoxFormFieldType
    {
      get
      {
        return this.GetElement<TextBoxFormFieldType>(0);
      }
      set
      {
        this.SetElement<TextBoxFormFieldType>(0, value);
      }
    }

    public DefaultTextBoxFormFieldString DefaultTextBoxFormFieldString
    {
      get
      {
        return this.GetElement<DefaultTextBoxFormFieldString>(1);
      }
      set
      {
        this.SetElement<DefaultTextBoxFormFieldString>(1, value);
      }
    }

    public MaxLength MaxLength
    {
      get
      {
        return this.GetElement<MaxLength>(2);
      }
      set
      {
        this.SetElement<MaxLength>(2, value);
      }
    }

    public Format Format
    {
      get
      {
        return this.GetElement<Format>(3);
      }
      set
      {
        this.SetElement<Format>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextInput>(deep);
    }
  }
}
