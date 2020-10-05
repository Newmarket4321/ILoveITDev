// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.AnimateColor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ToColor))]
  [ChildElementInfo(typeof (CommonBehavior))]
  [ChildElementInfo(typeof (ByColor))]
  [ChildElementInfo(typeof (FromColor))]
  public class AnimateColor : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "clrSpc",
      "dir"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[4]
    {
      "cBhvr",
      "by",
      "from",
      "to"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "animClr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12263;

    public override string LocalName
    {
      get
      {
        return "animClr";
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
        return 12263;
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
        return AnimateColor.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnimateColor.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "clrSpc")]
    public EnumValue<AnimateColorSpaceValues> ColorSpace
    {
      get
      {
        return (EnumValue<AnimateColorSpaceValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dir")]
    public EnumValue<AnimateColorDirectionValues> Direction
    {
      get
      {
        return (EnumValue<AnimateColorDirectionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public AnimateColor()
    {
    }

    public AnimateColor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AnimateColor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AnimateColor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cBhvr" == name)
        return (OpenXmlElement) new CommonBehavior();
      if (24 == (int) namespaceId && "by" == name)
        return (OpenXmlElement) new ByColor();
      if (24 == (int) namespaceId && "from" == name)
        return (OpenXmlElement) new FromColor();
      if (24 == (int) namespaceId && "to" == name)
        return (OpenXmlElement) new ToColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AnimateColor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AnimateColor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonBehavior CommonBehavior
    {
      get
      {
        return this.GetElement<CommonBehavior>(0);
      }
      set
      {
        this.SetElement<CommonBehavior>(0, value);
      }
    }

    public ByColor ByColor
    {
      get
      {
        return this.GetElement<ByColor>(1);
      }
      set
      {
        this.SetElement<ByColor>(1, value);
      }
    }

    public FromColor FromColor
    {
      get
      {
        return this.GetElement<FromColor>(2);
      }
      set
      {
        this.SetElement<FromColor>(2, value);
      }
    }

    public ToColor ToColor
    {
      get
      {
        return this.GetElement<ToColor>(3);
      }
      set
      {
        this.SetElement<ToColor>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "clrSpc" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateColorSpaceValues>();
      if ((int) namespaceId == 0 && "dir" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateColorDirectionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnimateColor>(deep);
    }
  }
}
