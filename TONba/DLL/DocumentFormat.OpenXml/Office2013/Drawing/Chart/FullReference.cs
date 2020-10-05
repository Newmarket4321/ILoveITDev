// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SequenceOfReferences), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class FullReference : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "sqref"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 64
    };
    private const string tagName = "fullRef";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13213;

    public override string LocalName
    {
      get
      {
        return "fullRef";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13213;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public FullReference()
    {
    }

    public FullReference(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FullReference(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FullReference(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "sqref" == name)
        return (OpenXmlElement) new SequenceOfReferences();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FullReference.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FullReference.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SequenceOfReferences SequenceOfReferences
    {
      get
      {
        return this.GetElement<SequenceOfReferences>(0);
      }
      set
      {
        this.SetElement<SequenceOfReferences>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FullReference>(deep);
    }
  }
}
