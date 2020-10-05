// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (StringReference))]
  [ChildElementInfo(typeof (RichText))]
  [ChildElementInfo(typeof (StringLiteral))]
  [GeneratedCode("DomGen", "2.0")]
  public class ChartText : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "strRef",
      "rich",
      "strLit"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "tx";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13231;

    public override string LocalName
    {
      get
      {
        return "tx";
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
        return 13231;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public ChartText()
    {
    }

    public ChartText(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ChartText(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ChartText(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "strRef" == name)
        return (OpenXmlElement) new StringReference();
      if (11 == (int) namespaceId && "rich" == name)
        return (OpenXmlElement) new RichText();
      if (11 == (int) namespaceId && "strLit" == name)
        return (OpenXmlElement) new StringLiteral();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ChartText.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ChartText.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public StringReference StringReference
    {
      get
      {
        return this.GetElement<StringReference>(0);
      }
      set
      {
        this.SetElement<StringReference>(0, value);
      }
    }

    public RichText RichText
    {
      get
      {
        return this.GetElement<RichText>(1);
      }
      set
      {
        this.SetElement<RichText>(1, value);
      }
    }

    public StringLiteral StringLiteral
    {
      get
      {
        return this.GetElement<StringLiteral>(2);
      }
      set
      {
        this.SetElement<StringLiteral>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ChartText>(deep);
    }
  }
}
