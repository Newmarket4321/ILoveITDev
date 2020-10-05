// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ShapeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class InvertSolidFillFormat : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "spPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 46
    };
    private const string tagName = "invertSolidFillFmt";
    private const byte tagNsId = 46;
    internal const int ElementTypeIdConst = 12764;

    public override string LocalName
    {
      get
      {
        return "invertSolidFillFmt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 46;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12764;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public InvertSolidFillFormat()
    {
    }

    public InvertSolidFillFormat(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public InvertSolidFillFormat(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public InvertSolidFillFormat(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (46 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return InvertSolidFillFormat.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return InvertSolidFillFormat.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(0);
      }
      set
      {
        this.SetElement<ShapeProperties>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<InvertSolidFillFormat>(deep);
    }
  }
}
