// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.Sparkline
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Formula))]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ReferenceSequence))]
  public class Sparkline : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "f",
      "sqref"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 32,
      (byte) 32
    };
    private const string tagName = "sparkline";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13011;

    public override string LocalName
    {
      get
      {
        return "sparkline";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13011;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Sparkline()
    {
    }

    public Sparkline(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Sparkline(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Sparkline(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (32 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (32 == (int) namespaceId && "sqref" == name)
        return (OpenXmlElement) new ReferenceSequence();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Sparkline.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Sparkline.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(0);
      }
      set
      {
        this.SetElement<Formula>(0, value);
      }
    }

    public ReferenceSequence ReferenceSequence
    {
      get
      {
        return this.GetElement<ReferenceSequence>(1);
      }
      set
      {
        this.SetElement<ReferenceSequence>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Sparkline>(deep);
    }
  }
}
