// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Document
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (DocumentBackground))]
  [ChildElementInfo(typeof (Body))]
  [GeneratedCode("DomGen", "2.0")]
  public class Document : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "conformance"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "background",
      "body"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "document";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11765;

    public override string LocalName
    {
      get
      {
        return "document";
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
        return 11765;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Document.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Document.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "conformance")]
    public EnumValue<DocumentConformance> Conformance
    {
      get
      {
        return (EnumValue<DocumentConformance>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal Document(MainDocumentPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(MainDocumentPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public MainDocumentPart MainDocumentPart
    {
      get
      {
        return this.OpenXmlPart as MainDocumentPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Document(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Document(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Document(string outerXml)
      : base(outerXml)
    {
    }

    public Document()
    {
    }

    public void Save(MainDocumentPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "background" == name)
        return (OpenXmlElement) new DocumentBackground();
      if (23 == (int) namespaceId && "body" == name)
        return (OpenXmlElement) new Body();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Document.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Document.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocumentBackground DocumentBackground
    {
      get
      {
        return this.GetElement<DocumentBackground>(0);
      }
      set
      {
        this.SetElement<DocumentBackground>(0, value);
      }
    }

    public Body Body
    {
      get
      {
        return this.GetElement<Body>(1);
      }
      set
      {
        this.SetElement<Body>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "conformance" == name)
        return (OpenXmlSimpleType) new EnumValue<DocumentConformance>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Document>(deep);
    }
  }
}
