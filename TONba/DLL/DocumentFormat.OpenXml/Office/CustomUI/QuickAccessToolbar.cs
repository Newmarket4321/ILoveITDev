// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [ChildElementInfo(typeof (SharedQatControls))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocumentSpecificQuickAccessToolbarControls))]
  public class QuickAccessToolbar : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "sharedControls",
      "documentControls"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 34,
      (byte) 34
    };
    private const string tagName = "qat";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12683;

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
        return 34;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12683;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
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
      if (34 == (int) namespaceId && "sharedControls" == name)
        return (OpenXmlElement) new SharedQatControls();
      if (34 == (int) namespaceId && "documentControls" == name)
        return (OpenXmlElement) new DocumentSpecificQuickAccessToolbarControls();
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

    public SharedQatControls SharedQatControls
    {
      get
      {
        return this.GetElement<SharedQatControls>(0);
      }
      set
      {
        this.SetElement<SharedQatControls>(0, value);
      }
    }

    public DocumentSpecificQuickAccessToolbarControls DocumentSpecificQuickAccessToolbarControls
    {
      get
      {
        return this.GetElement<DocumentSpecificQuickAccessToolbarControls>(1);
      }
      set
      {
        this.SetElement<DocumentSpecificQuickAccessToolbarControls>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<QuickAccessToolbar>(deep);
    }
  }
}
