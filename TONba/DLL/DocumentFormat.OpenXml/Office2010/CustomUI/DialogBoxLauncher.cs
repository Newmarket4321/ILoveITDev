// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class DialogBoxLauncher : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "button"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 57
    };
    private const string tagName = "dialogBoxLauncher";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13147;

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
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13147;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
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
      if (57 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new ButtonRegular();
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

    public ButtonRegular ButtonRegular
    {
      get
      {
        return this.GetElement<ButtonRegular>(0);
      }
      set
      {
        this.SetElement<ButtonRegular>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DialogBoxLauncher>(deep);
    }
  }
}
