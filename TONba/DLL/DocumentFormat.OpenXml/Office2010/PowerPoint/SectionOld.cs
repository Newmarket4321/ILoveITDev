// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.SectionOld
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SectionOld : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "name",
      "slideIdLst",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 49
    };
    private const string tagName = "section";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12874;

    public override string LocalName
    {
      get
      {
        return "section";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 49;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12874;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return SectionOld.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SectionOld.attributeNamespaceIds;
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

    [SchemaAttr(0, "slideIdLst")]
    public ListValue<UInt32Value> SlideIdList
    {
      get
      {
        return (ListValue<UInt32Value>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public SectionOld()
    {
    }

    public SectionOld(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SectionOld(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SectionOld(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SectionOld.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SectionOld.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "slideIdLst" == name)
        return (OpenXmlSimpleType) new ListValue<UInt32Value>();
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SectionOld>(deep);
    }
  }
}
