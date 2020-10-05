// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Stretch
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (FillRectangle))]
  [GeneratedCode("DomGen", "2.0")]
  public class Stretch : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "fillRect"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "stretch";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10046;

    public override string LocalName
    {
      get
      {
        return "stretch";
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
        return 10046;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Stretch()
    {
    }

    public Stretch(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Stretch(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Stretch(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "fillRect" == name)
        return (OpenXmlElement) new FillRectangle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Stretch.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Stretch.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FillRectangle FillRectangle
    {
      get
      {
        return this.GetElement<FillRectangle>(0);
      }
      set
      {
        this.SetElement<FillRectangle>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Stretch>(deep);
    }
  }
}
