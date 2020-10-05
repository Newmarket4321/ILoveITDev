// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.BackgroundProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (EffectDag))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (EffectList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.BlipFill))]
  [ChildElementInfo(typeof (PatternFill))]
  public class BackgroundProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "shadeToTitle"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "bgPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12231;

    public override string LocalName
    {
      get
      {
        return "bgPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12231;
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
        return BackgroundProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BackgroundProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "shadeToTitle")]
    public BooleanValue ShadeToTitle
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public BackgroundProperties()
    {
    }

    public BackgroundProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BackgroundProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BackgroundProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.BlipFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "shadeToTitle" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BackgroundProperties>(deep);
    }
  }
}
