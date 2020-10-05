// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.VariantTypes;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
  [ChildElementInfo(typeof (VTBlob))]
  [GeneratedCode("DomGen", "2.0")]
  public class DigitalSignature : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "blob"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 5
    };
    private const string tagName = "DigSig";
    private const byte tagNsId = 3;
    internal const int ElementTypeIdConst = 11088;

    public override string LocalName
    {
      get
      {
        return "DigSig";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 3;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11088;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DigitalSignature()
    {
    }

    public DigitalSignature(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DigitalSignature(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DigitalSignature(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (5 == (int) namespaceId && "blob" == name)
        return (OpenXmlElement) new VTBlob();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DigitalSignature.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DigitalSignature.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public VTBlob VTBlob
    {
      get
      {
        return this.GetElement<VTBlob>(0);
      }
      set
      {
        this.SetElement<VTBlob>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DigitalSignature>(deep);
    }
  }
}
