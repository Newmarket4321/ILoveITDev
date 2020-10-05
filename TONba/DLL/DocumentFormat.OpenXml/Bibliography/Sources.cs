// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.Sources
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Source))]
  public class Sources : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      nameof (SelectedStyle),
      nameof (StyleName),
      "URI"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "Sources";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10824;

    public override string LocalName
    {
      get
      {
        return nameof (Sources);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10824;
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
        return Sources.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Sources.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "SelectedStyle")]
    public StringValue SelectedStyle
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

    [SchemaAttr(0, "StyleName")]
    public StringValue StyleName
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "URI")]
    public StringValue Uri
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

    public Sources()
    {
    }

    public Sources(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Sources(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Sources(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "Source" == name)
        return (OpenXmlElement) new Source();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "SelectedStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "StyleName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "URI" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Sources>(deep);
    }

    internal Sources(CustomXmlPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomXmlPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public void Save(CustomXmlPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }
  }
}
