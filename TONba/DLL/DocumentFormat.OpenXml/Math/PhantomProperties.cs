// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.PhantomProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (ShowPhantom))]
  [ChildElementInfo(typeof (Transparent))]
  [ChildElementInfo(typeof (ZeroDescent))]
  [ChildElementInfo(typeof (ControlProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ZeroWidth))]
  [ChildElementInfo(typeof (ZeroAscent))]
  public class PhantomProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "show",
      "zeroWid",
      "zeroAsc",
      "zeroDesc",
      "transp",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "phantPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 11000;

    public override string LocalName
    {
      get
      {
        return "phantPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11000;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PhantomProperties()
    {
    }

    public PhantomProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PhantomProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PhantomProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "show" == name)
        return (OpenXmlElement) new ShowPhantom();
      if (21 == (int) namespaceId && "zeroWid" == name)
        return (OpenXmlElement) new ZeroWidth();
      if (21 == (int) namespaceId && "zeroAsc" == name)
        return (OpenXmlElement) new ZeroAscent();
      if (21 == (int) namespaceId && "zeroDesc" == name)
        return (OpenXmlElement) new ZeroDescent();
      if (21 == (int) namespaceId && "transp" == name)
        return (OpenXmlElement) new Transparent();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PhantomProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PhantomProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShowPhantom ShowPhantom
    {
      get
      {
        return this.GetElement<ShowPhantom>(0);
      }
      set
      {
        this.SetElement<ShowPhantom>(0, value);
      }
    }

    public ZeroWidth ZeroWidth
    {
      get
      {
        return this.GetElement<ZeroWidth>(1);
      }
      set
      {
        this.SetElement<ZeroWidth>(1, value);
      }
    }

    public ZeroAscent ZeroAscent
    {
      get
      {
        return this.GetElement<ZeroAscent>(2);
      }
      set
      {
        this.SetElement<ZeroAscent>(2, value);
      }
    }

    public ZeroDescent ZeroDescent
    {
      get
      {
        return this.GetElement<ZeroDescent>(3);
      }
      set
      {
        this.SetElement<ZeroDescent>(3, value);
      }
    }

    public Transparent Transparent
    {
      get
      {
        return this.GetElement<Transparent>(4);
      }
      set
      {
        this.SetElement<Transparent>(4, value);
      }
    }

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(5);
      }
      set
      {
        this.SetElement<ControlProperties>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PhantomProperties>(deep);
    }
  }
}
