// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.FillTextEffect
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (GradientFillProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NoFillEmpty), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SolidColorFillProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class FillTextEffect : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "noFill",
      "solidFill",
      "gradFill"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "textFill";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12924;

    public override string LocalName
    {
      get
      {
        return "textFill";
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
        return 12924;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public FillTextEffect()
    {
    }

    public FillTextEffect(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FillTextEffect(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FillTextEffect(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFillEmpty();
      if (52 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidColorFillProperties();
      if (52 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFillProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FillTextEffect.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FillTextEffect.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public NoFillEmpty NoFillEmpty
    {
      get
      {
        return this.GetElement<NoFillEmpty>(0);
      }
      set
      {
        this.SetElement<NoFillEmpty>(0, value);
      }
    }

    public SolidColorFillProperties SolidColorFillProperties
    {
      get
      {
        return this.GetElement<SolidColorFillProperties>(1);
      }
      set
      {
        this.SetElement<SolidColorFillProperties>(1, value);
      }
    }

    public GradientFillProperties GradientFillProperties
    {
      get
      {
        return this.GetElement<GradientFillProperties>(2);
      }
      set
      {
        this.SetElement<GradientFillProperties>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FillTextEffect>(deep);
    }
  }
}
