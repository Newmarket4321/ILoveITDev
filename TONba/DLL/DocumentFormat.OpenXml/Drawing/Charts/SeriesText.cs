// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.SeriesText
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (StringReference))]
  [ChildElementInfo(typeof (NumericValue))]
  [GeneratedCode("DomGen", "2.0")]
  public class SeriesText : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "strRef",
      "v"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "tx";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10365;

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
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10365;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SeriesText()
    {
    }

    public SeriesText(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SeriesText(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SeriesText(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "strRef" == name)
        return (OpenXmlElement) new StringReference();
      if (11 == (int) namespaceId && "v" == name)
        return (OpenXmlElement) new NumericValue();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SeriesText.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SeriesText.eleNamespaceIds;
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

    public NumericValue NumericValue
    {
      get
      {
        return this.GetElement<NumericValue>(1);
      }
      set
      {
        this.SetElement<NumericValue>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SeriesText>(deep);
    }
  }
}
