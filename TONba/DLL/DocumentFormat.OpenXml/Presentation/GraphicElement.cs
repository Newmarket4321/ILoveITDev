﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.GraphicElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Diagram))]
  [ChildElementInfo(typeof (Chart))]
  [GeneratedCode("DomGen", "2.0")]
  public class GraphicElement : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "dgm",
      "chart"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "graphicEl";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12445;

    public override string LocalName
    {
      get
      {
        return "graphicEl";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12445;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GraphicElement()
    {
    }

    public GraphicElement(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GraphicElement(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GraphicElement(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "dgm" == name)
        return (OpenXmlElement) new Diagram();
      if (10 == (int) namespaceId && "chart" == name)
        return (OpenXmlElement) new Chart();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GraphicElement.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GraphicElement.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public Diagram Diagram
    {
      get
      {
        return this.GetElement<Diagram>(0);
      }
      set
      {
        this.SetElement<Diagram>(0, value);
      }
    }

    public Chart Chart
    {
      get
      {
        return this.GetElement<Chart>(1);
      }
      set
      {
        this.SetElement<Chart>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GraphicElement>(deep);
    }
  }
}
