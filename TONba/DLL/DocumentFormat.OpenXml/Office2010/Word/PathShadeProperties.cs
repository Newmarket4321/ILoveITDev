// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FillToRectangle), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class PathShadeProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "path"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 52
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "fillToRect"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 52
    };
    private const string tagName = "path";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12912;

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
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12912;
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
        return PathShadeProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PathShadeProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "path")]
    public EnumValue<PathShadeTypeValues> Path
    {
      get
      {
        return (EnumValue<PathShadeTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public PathShadeProperties()
    {
    }

    public PathShadeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PathShadeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PathShadeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "fillToRect" == name)
        return (OpenXmlElement) new FillToRectangle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PathShadeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PathShadeProperties.eleNamespaceIds;
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
      if (52 == (int) namespaceId && "path" == name)
        return (OpenXmlSimpleType) new EnumValue<PathShadeTypeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PathShadeProperties>(deep);
    }
  }
}
