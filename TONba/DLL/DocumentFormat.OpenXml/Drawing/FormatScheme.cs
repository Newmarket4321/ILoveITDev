// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.FormatScheme
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (BackgroundFillStyleList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FillStyleList))]
  [ChildElementInfo(typeof (LineStyleList))]
  [ChildElementInfo(typeof (EffectStyleList))]
  public class FormatScheme : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[4]
    {
      "fillStyleLst",
      "lnStyleLst",
      "effectStyleLst",
      "bgFillStyleLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "fmtScheme";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10146;

    public override string LocalName
    {
      get
      {
        return "fmtScheme";
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
        return 10146;
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
        return FormatScheme.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FormatScheme.attributeNamespaceIds;
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

    public FormatScheme()
    {
    }

    public FormatScheme(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FormatScheme(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FormatScheme(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "fillStyleLst" == name)
        return (OpenXmlElement) new FillStyleList();
      if (10 == (int) namespaceId && "lnStyleLst" == name)
        return (OpenXmlElement) new LineStyleList();
      if (10 == (int) namespaceId && "effectStyleLst" == name)
        return (OpenXmlElement) new EffectStyleList();
      if (10 == (int) namespaceId && "bgFillStyleLst" == name)
        return (OpenXmlElement) new BackgroundFillStyleList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FormatScheme.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FormatScheme.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FillStyleList FillStyleList
    {
      get
      {
        return this.GetElement<FillStyleList>(0);
      }
      set
      {
        this.SetElement<FillStyleList>(0, value);
      }
    }

    public LineStyleList LineStyleList
    {
      get
      {
        return this.GetElement<LineStyleList>(1);
      }
      set
      {
        this.SetElement<LineStyleList>(1, value);
      }
    }

    public EffectStyleList EffectStyleList
    {
      get
      {
        return this.GetElement<EffectStyleList>(2);
      }
      set
      {
        this.SetElement<EffectStyleList>(2, value);
      }
    }

    public BackgroundFillStyleList BackgroundFillStyleList
    {
      get
      {
        return this.GetElement<BackgroundFillStyleList>(3);
      }
      set
      {
        this.SetElement<BackgroundFillStyleList>(3, value);
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
      return (OpenXmlElement) this.CloneImp<FormatScheme>(deep);
    }
  }
}
