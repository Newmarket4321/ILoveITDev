// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Fill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (PatternFill))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GradientFill))]
  public class Fill : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "patternFill",
      "gradientFill"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "fill";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11318;

    public override string LocalName
    {
      get
      {
        return "fill";
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
        return 11318;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Fill()
    {
    }

    public Fill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Fill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Fill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "patternFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (22 == (int) namespaceId && "gradientFill" == name)
        return (OpenXmlElement) new GradientFill();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Fill.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Fill.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public PatternFill PatternFill
    {
      get
      {
        return this.GetElement<PatternFill>(0);
      }
      set
      {
        this.SetElement<PatternFill>(0, value);
      }
    }

    public GradientFill GradientFill
    {
      get
      {
        return this.GetElement<GradientFill>(1);
      }
      set
      {
        this.SetElement<GradientFill>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Fill>(deep);
    }
  }
}
