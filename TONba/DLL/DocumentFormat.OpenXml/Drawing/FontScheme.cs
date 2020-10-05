// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.FontScheme
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (MinorFont))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MajorFont))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class FontScheme : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "majorFont",
      "minorFont",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "fontScheme";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10145;

    public override string LocalName
    {
      get
      {
        return "fontScheme";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10145;
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
        return FontScheme.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FontScheme.attributeNamespaceIds;
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

    public FontScheme()
    {
    }

    public FontScheme(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FontScheme(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FontScheme(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "majorFont" == name)
        return (OpenXmlElement) new MajorFont();
      if (10 == (int) namespaceId && "minorFont" == name)
        return (OpenXmlElement) new MinorFont();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FontScheme.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FontScheme.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MajorFont MajorFont
    {
      get
      {
        return this.GetElement<MajorFont>(0);
      }
      set
      {
        this.SetElement<MajorFont>(0, value);
      }
    }

    public MinorFont MinorFont
    {
      get
      {
        return this.GetElement<MinorFont>(1);
      }
      set
      {
        this.SetElement<MinorFont>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
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
      return (OpenXmlElement) this.CloneImp<FontScheme>(deep);
    }
  }
}
