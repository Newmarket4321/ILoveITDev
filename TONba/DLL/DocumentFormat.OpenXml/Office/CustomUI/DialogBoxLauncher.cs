// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (UnsizedButton))]
  public class DialogBoxLauncher : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "button"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 34
    };
    private const string tagName = "dialogBoxLauncher";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12674;

    public override string LocalName
    {
      get
      {
        return "dialogBoxLauncher";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 34;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12674;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DialogBoxLauncher()
    {
    }

    public DialogBoxLauncher(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DialogBoxLauncher(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DialogBoxLauncher(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (34 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new UnsizedButton();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DialogBoxLauncher.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DialogBoxLauncher.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public UnsizedButton UnsizedButton
    {
      get
      {
        return this.GetElement<UnsizedButton>(0);
      }
      set
      {
        this.SetElement<UnsizedButton>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DialogBoxLauncher>(deep);
    }
  }
}
