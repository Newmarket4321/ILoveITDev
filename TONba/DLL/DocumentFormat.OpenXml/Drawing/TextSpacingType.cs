// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TextSpacingType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SpacingPercent))]
  [ChildElementInfo(typeof (SpacingPoints))]
  public abstract class TextSpacingType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "spcPct",
      "spcPts"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "spcPct" == name)
        return (OpenXmlElement) new SpacingPercent();
      if (10 == (int) namespaceId && "spcPts" == name)
        return (OpenXmlElement) new SpacingPoints();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextSpacingType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextSpacingType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public SpacingPercent SpacingPercent
    {
      get
      {
        return this.GetElement<SpacingPercent>(0);
      }
      set
      {
        this.SetElement<SpacingPercent>(0, value);
      }
    }

    public SpacingPoints SpacingPoints
    {
      get
      {
        return this.GetElement<SpacingPoints>(1);
      }
      set
      {
        this.SetElement<SpacingPoints>(1, value);
      }
    }

    protected TextSpacingType()
    {
    }

    protected TextSpacingType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TextSpacingType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TextSpacingType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
