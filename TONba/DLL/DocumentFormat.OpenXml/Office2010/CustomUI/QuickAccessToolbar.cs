// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SharedControlsQatItems), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentControlsQatItems), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class QuickAccessToolbar : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "sharedControls",
      "documentControls"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 57,
      (byte) 57
    };
    private const string tagName = "qat";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13155;

    public override string LocalName
    {
      get
      {
        return "qat";
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
        return 13155;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public QuickAccessToolbar()
    {
    }

    public QuickAccessToolbar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public QuickAccessToolbar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public QuickAccessToolbar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "sharedControls" == name)
        return (OpenXmlElement) new SharedControlsQatItems();
      if (57 == (int) namespaceId && "documentControls" == name)
        return (OpenXmlElement) new DocumentControlsQatItems();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return QuickAccessToolbar.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return QuickAccessToolbar.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SharedControlsQatItems SharedControlsQatItems
    {
      get
      {
        return this.GetElement<SharedControlsQatItems>(0);
      }
      set
      {
        this.SetElement<SharedControlsQatItems>(0, value);
      }
    }

    public DocumentControlsQatItems DocumentControlsQatItems
    {
      get
      {
        return this.GetElement<DocumentControlsQatItems>(1);
      }
      set
      {
        this.SetElement<DocumentControlsQatItems>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<QuickAccessToolbar>(deep);
    }
  }
}
