// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ScaleFactor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ScaleX))]
  [ChildElementInfo(typeof (ScaleY))]
  public class ScaleFactor : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "sx",
      "sy"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "scale";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12347;

    public override string LocalName
    {
      get
      {
        return "scale";
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
        return 12347;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ScaleFactor()
    {
    }

    public ScaleFactor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ScaleFactor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ScaleFactor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "sx" == name)
        return (OpenXmlElement) new ScaleX();
      if (10 == (int) namespaceId && "sy" == name)
        return (OpenXmlElement) new ScaleY();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ScaleFactor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ScaleFactor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ScaleX ScaleX
    {
      get
      {
        return this.GetElement<ScaleX>(0);
      }
      set
      {
        this.SetElement<ScaleX>(0, value);
      }
    }

    public ScaleY ScaleY
    {
      get
      {
        return this.GetElement<ScaleY>(1);
      }
      set
      {
        this.SetElement<ScaleY>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ScaleFactor>(deep);
    }
  }
}
