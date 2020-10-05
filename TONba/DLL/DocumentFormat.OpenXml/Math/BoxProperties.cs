// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.BoxProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (Break))]
  [ChildElementInfo(typeof (Differential))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NoBreak))]
  [ChildElementInfo(typeof (OperatorEmulator))]
  [ChildElementInfo(typeof (Alignment))]
  [ChildElementInfo(typeof (ControlProperties))]
  public class BoxProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "opEmu",
      "noBreak",
      "diff",
      "brk",
      "aln",
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
    private const string tagName = "boxPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10945;

    public override string LocalName
    {
      get
      {
        return "boxPr";
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
        return 10945;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BoxProperties()
    {
    }

    public BoxProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BoxProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BoxProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "opEmu" == name)
        return (OpenXmlElement) new OperatorEmulator();
      if (21 == (int) namespaceId && "noBreak" == name)
        return (OpenXmlElement) new NoBreak();
      if (21 == (int) namespaceId && "diff" == name)
        return (OpenXmlElement) new Differential();
      if (21 == (int) namespaceId && "brk" == name)
        return (OpenXmlElement) new Break();
      if (21 == (int) namespaceId && "aln" == name)
        return (OpenXmlElement) new Alignment();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BoxProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BoxProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OperatorEmulator OperatorEmulator
    {
      get
      {
        return this.GetElement<OperatorEmulator>(0);
      }
      set
      {
        this.SetElement<OperatorEmulator>(0, value);
      }
    }

    public NoBreak NoBreak
    {
      get
      {
        return this.GetElement<NoBreak>(1);
      }
      set
      {
        this.SetElement<NoBreak>(1, value);
      }
    }

    public Differential Differential
    {
      get
      {
        return this.GetElement<Differential>(2);
      }
      set
      {
        this.SetElement<Differential>(2, value);
      }
    }

    public Break Break
    {
      get
      {
        return this.GetElement<Break>(3);
      }
      set
      {
        this.SetElement<Break>(3, value);
      }
    }

    public Alignment Alignment
    {
      get
      {
        return this.GetElement<Alignment>(4);
      }
      set
      {
        this.SetElement<Alignment>(4, value);
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
      return (OpenXmlElement) this.CloneImp<BoxProperties>(deep);
    }
  }
}
