// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (NumberReference))]
  [ChildElementInfo(typeof (MultiLevelStringReference))]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NumberLiteral))]
  [ChildElementInfo(typeof (StringReference))]
  [ChildElementInfo(typeof (StringLiteral))]
  [GeneratedCode("DomGen", "2.0")]
  public class AxisDataSourceType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "multiLvlStrRef",
      "numRef",
      "numLit",
      "strRef",
      "strLit"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "cat";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13236;

    public override string LocalName
    {
      get
      {
        return "cat";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13236;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public AxisDataSourceType()
    {
    }

    public AxisDataSourceType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AxisDataSourceType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AxisDataSourceType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "multiLvlStrRef" == name)
        return (OpenXmlElement) new MultiLevelStringReference();
      if (11 == (int) namespaceId && "numRef" == name)
        return (OpenXmlElement) new NumberReference();
      if (11 == (int) namespaceId && "numLit" == name)
        return (OpenXmlElement) new NumberLiteral();
      if (11 == (int) namespaceId && "strRef" == name)
        return (OpenXmlElement) new StringReference();
      if (11 == (int) namespaceId && "strLit" == name)
        return (OpenXmlElement) new StringLiteral();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AxisDataSourceType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AxisDataSourceType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public MultiLevelStringReference MultiLevelStringReference
    {
      get
      {
        return this.GetElement<MultiLevelStringReference>(0);
      }
      set
      {
        this.SetElement<MultiLevelStringReference>(0, value);
      }
    }

    public NumberReference NumberReference
    {
      get
      {
        return this.GetElement<NumberReference>(1);
      }
      set
      {
        this.SetElement<NumberReference>(1, value);
      }
    }

    public NumberLiteral NumberLiteral
    {
      get
      {
        return this.GetElement<NumberLiteral>(2);
      }
      set
      {
        this.SetElement<NumberLiteral>(2, value);
      }
    }

    public StringReference StringReference
    {
      get
      {
        return this.GetElement<StringReference>(3);
      }
      set
      {
        this.SetElement<StringReference>(3, value);
      }
    }

    public StringLiteral StringLiteral
    {
      get
      {
        return this.GetElement<StringLiteral>(4);
      }
      set
      {
        this.SetElement<StringLiteral>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AxisDataSourceType>(deep);
    }
  }
}
