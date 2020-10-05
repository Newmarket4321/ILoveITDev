// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Consolidation
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (RangeSets))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Pages))]
  public class Consolidation : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "autoPage"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "pages",
      "rangeSets"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "consolidation";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11424;

    public override string LocalName
    {
      get
      {
        return "consolidation";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11424;
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
        return Consolidation.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Consolidation.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "autoPage")]
    public BooleanValue AutoPage
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

    public Consolidation()
    {
    }

    public Consolidation(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Consolidation(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Consolidation(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "pages" == name)
        return (OpenXmlElement) new Pages();
      if (22 == (int) namespaceId && "rangeSets" == name)
        return (OpenXmlElement) new RangeSets();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Consolidation.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Consolidation.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Pages Pages
    {
      get
      {
        return this.GetElement<Pages>(0);
      }
      set
      {
        this.SetElement<Pages>(0, value);
      }
    }

    public RangeSets RangeSets
    {
      get
      {
        return this.GetElement<RangeSets>(1);
      }
      set
      {
        this.SetElement<RangeSets>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "autoPage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Consolidation>(deep);
    }
  }
}
