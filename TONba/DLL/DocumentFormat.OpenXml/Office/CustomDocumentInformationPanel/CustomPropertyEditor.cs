// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.CustomPropertyEditor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel
{
  [ChildElementInfo(typeof (XsnFileLocation))]
  [ChildElementInfo(typeof (PropertyEditorNamespace))]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomPropertyEditor : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "XMLNamespace",
      "XSNLocation"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 37,
      (byte) 37
    };
    private const string tagName = "customPropertyEditor";
    private const byte tagNsId = 37;
    internal const int ElementTypeIdConst = 12704;

    public override string LocalName
    {
      get
      {
        return "customPropertyEditor";
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
        return 12704;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CustomPropertyEditor()
    {
    }

    public CustomPropertyEditor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomPropertyEditor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomPropertyEditor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (37 == (int) namespaceId && "XMLNamespace" == name)
        return (OpenXmlElement) new PropertyEditorNamespace();
      if (37 == (int) namespaceId && "XSNLocation" == name)
        return (OpenXmlElement) new XsnFileLocation();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomPropertyEditor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomPropertyEditor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PropertyEditorNamespace PropertyEditorNamespace
    {
      get
      {
        return this.GetElement<PropertyEditorNamespace>(0);
      }
      set
      {
        this.SetElement<PropertyEditorNamespace>(0, value);
      }
    }

    public XsnFileLocation XsnFileLocation
    {
      get
      {
        return this.GetElement<XsnFileLocation>(1);
      }
      set
      {
        this.SetElement<XsnFileLocation>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomPropertyEditor>(deep);
    }
  }
}
