// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Delimiter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (DelimiterProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  public class Delimiter : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "dPr",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "d";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10912;

    public override string LocalName
    {
      get
      {
        return "d";
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
        return 10912;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Delimiter()
    {
    }

    public Delimiter(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Delimiter(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Delimiter(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "dPr" == name)
        return (OpenXmlElement) new DelimiterProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Delimiter.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Delimiter.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DelimiterProperties DelimiterProperties
    {
      get
      {
        return this.GetElement<DelimiterProperties>(0);
      }
      set
      {
        this.SetElement<DelimiterProperties>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Delimiter>(deep);
    }
  }
}
