// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (HiddenScene3D), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (HiddenShape3D), FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HiddenFillProperties), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (HiddenLineProperties), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (HiddenEffectsProperties), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ShadowObscured), FileFormatVersions.Office2010)]
  public class ShapePropertiesExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10312;

    public override string LocalName
    {
      get
      {
        return "ext";
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
        return 10312;
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
        return ShapePropertiesExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ShapePropertiesExtension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
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

    public ShapePropertiesExtension()
    {
    }

    public ShapePropertiesExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShapePropertiesExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShapePropertiesExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (48 == (int) namespaceId && "hiddenFill" == name)
        return (OpenXmlElement) new HiddenFillProperties();
      if (48 == (int) namespaceId && "hiddenLine" == name)
        return (OpenXmlElement) new HiddenLineProperties();
      if (48 == (int) namespaceId && "hiddenEffects" == name)
        return (OpenXmlElement) new HiddenEffectsProperties();
      if (48 == (int) namespaceId && "hiddenScene3d" == name)
        return (OpenXmlElement) new HiddenScene3D();
      if (48 == (int) namespaceId && "hiddenSp3d" == name)
        return (OpenXmlElement) new HiddenShape3D();
      if (48 == (int) namespaceId && "shadowObscured" == name)
        return (OpenXmlElement) new ShadowObscured();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapePropertiesExtension>(deep);
    }
  }
}
