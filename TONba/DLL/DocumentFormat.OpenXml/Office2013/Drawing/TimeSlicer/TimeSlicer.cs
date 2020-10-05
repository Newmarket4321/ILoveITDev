// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  public class TimeSlicer : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 77
    };
    private const string tagName = "timeslicer";
    private const byte tagNsId = 77;
    internal const int ElementTypeIdConst = 13444;

    public override string LocalName
    {
      get
      {
        return "timeslicer";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 77;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13444;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public TimeSlicer()
    {
    }

    public TimeSlicer(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimeSlicer(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimeSlicer(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (77 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(0);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer>(deep);
    }
  }
}
