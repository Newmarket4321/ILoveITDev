// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ListEntryFormField))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DefaultDropDownListItemIndex))]
  [ChildElementInfo(typeof (DropDownListSelection))]
  public class DropDownListFormField : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "result",
      "default",
      "listEntry"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "ddList";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11797;

    public override string LocalName
    {
      get
      {
        return "ddList";
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
        return 11797;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DropDownListFormField()
    {
    }

    public DropDownListFormField(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DropDownListFormField(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DropDownListFormField(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "result" == name)
        return (OpenXmlElement) new DropDownListSelection();
      if (23 == (int) namespaceId && "default" == name)
        return (OpenXmlElement) new DefaultDropDownListItemIndex();
      if (23 == (int) namespaceId && "listEntry" == name)
        return (OpenXmlElement) new ListEntryFormField();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DropDownListFormField.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DropDownListFormField.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DropDownListSelection DropDownListSelection
    {
      get
      {
        return this.GetElement<DropDownListSelection>(0);
      }
      set
      {
        this.SetElement<DropDownListSelection>(0, value);
      }
    }

    public DefaultDropDownListItemIndex DefaultDropDownListItemIndex
    {
      get
      {
        return this.GetElement<DefaultDropDownListItemIndex>(1);
      }
      set
      {
        this.SetElement<DefaultDropDownListItemIndex>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DropDownListFormField>(deep);
    }
  }
}
