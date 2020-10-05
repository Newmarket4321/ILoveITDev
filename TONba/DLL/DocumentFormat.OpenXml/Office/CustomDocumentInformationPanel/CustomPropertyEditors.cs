// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.CustomPropertyEditors
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel
{
  [ChildElementInfo(typeof (ShowOnOpen))]
  [ChildElementInfo(typeof (DefaultPropertyEditorNamespace))]
  [ChildElementInfo(typeof (CustomPropertyEditor))]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomPropertyEditors : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "showOnOpen",
      "defaultPropertyEditorNamespace",
      "customPropertyEditor"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 37,
      (byte) 37,
      (byte) 37
    };
    private const string tagName = "customPropertyEditors";
    private const byte tagNsId = 37;
    internal const int ElementTypeIdConst = 12699;

    public override string LocalName
    {
      get
      {
        return "customPropertyEditors";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 37;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12699;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CustomPropertyEditors()
    {
    }

    public CustomPropertyEditors(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomPropertyEditors(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomPropertyEditors(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (37 == (int) namespaceId && "showOnOpen" == name)
        return (OpenXmlElement) new ShowOnOpen();
      if (37 == (int) namespaceId && "defaultPropertyEditorNamespace" == name)
        return (OpenXmlElement) new DefaultPropertyEditorNamespace();
      if (37 == (int) namespaceId && "customPropertyEditor" == name)
        return (OpenXmlElement) new CustomPropertyEditor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomPropertyEditors.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomPropertyEditors.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShowOnOpen ShowOnOpen
    {
      get
      {
        return this.GetElement<ShowOnOpen>(0);
      }
      set
      {
        this.SetElement<ShowOnOpen>(0, value);
      }
    }

    public DefaultPropertyEditorNamespace DefaultPropertyEditorNamespace
    {
      get
      {
        return this.GetElement<DefaultPropertyEditorNamespace>(1);
      }
      set
      {
        this.SetElement<DefaultPropertyEditorNamespace>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomPropertyEditors>(deep);
    }
  }
}
