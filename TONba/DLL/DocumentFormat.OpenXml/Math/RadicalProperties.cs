// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.RadicalProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (HideDegree))]
  [ChildElementInfo(typeof (ControlProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public class RadicalProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "degHide",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "radPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 11002;

    public override string LocalName
    {
      get
      {
        return "radPr";
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
        return 11002;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RadicalProperties()
    {
    }

    public RadicalProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RadicalProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RadicalProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "degHide" == name)
        return (OpenXmlElement) new HideDegree();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RadicalProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RadicalProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public HideDegree HideDegree
    {
      get
      {
        return this.GetElement<HideDegree>(0);
      }
      set
      {
        this.SetElement<HideDegree>(0, value);
      }
    }

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(1);
      }
      set
      {
        this.SetElement<ControlProperties>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RadicalProperties>(deep);
    }
  }
}
