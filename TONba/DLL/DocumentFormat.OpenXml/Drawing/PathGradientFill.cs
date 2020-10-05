// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.PathGradientFill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (FillToRectangle))]
  [GeneratedCode("DomGen", "2.0")]
  public class PathGradientFill : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "path"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "fillToRect"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "path";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10044;

    public override string LocalName
    {
      get
      {
        return "path";
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
        return 10044;
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
        return PathGradientFill.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PathGradientFill.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "path")]
    public EnumValue<PathShadeValues> Path
    {
      get
      {
        return (EnumValue<PathShadeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public PathGradientFill()
    {
    }

    public PathGradientFill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PathGradientFill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PathGradientFill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "fillToRect" == name)
        return (OpenXmlElement) new FillToRectangle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PathGradientFill.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PathGradientFill.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FillToRectangle FillToRectangle
    {
      get
      {
        return this.GetElement<FillToRectangle>(0);
      }
      set
      {
        this.SetElement<FillToRectangle>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "path" == name)
        return (OpenXmlSimpleType) new EnumValue<PathShadeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PathGradientFill>(deep);
    }
  }
}
