// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Graphic
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (GraphicData))]
  [GeneratedCode("DomGen", "2.0")]
  public class Graphic : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "graphicData"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "graphic";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10120;

    public override string LocalName
    {
      get
      {
        return "graphic";
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
        return 10120;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Graphic()
    {
    }

    public Graphic(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Graphic(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Graphic(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "graphicData" == name)
        return (OpenXmlElement) new GraphicData();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Graphic.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Graphic.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public GraphicData GraphicData
    {
      get
      {
        return this.GetElement<GraphicData>(0);
      }
      set
      {
        this.SetElement<GraphicData>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Graphic>(deep);
    }
  }
}
