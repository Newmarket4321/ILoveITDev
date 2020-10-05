// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
  [ChildElementInfo(typeof (ShowSketchButton), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (InSketchMode), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class SketchOptions : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "inSketchMode",
      "showSketchBtn"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 46,
      (byte) 46
    };
    private const string tagName = "sketchOptions";
    private const byte tagNsId = 46;
    internal const int ElementTypeIdConst = 12763;

    public override string LocalName
    {
      get
      {
        return "sketchOptions";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 46;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12763;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SketchOptions()
    {
    }

    public SketchOptions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SketchOptions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SketchOptions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (46 == (int) namespaceId && "inSketchMode" == name)
        return (OpenXmlElement) new InSketchMode();
      if (46 == (int) namespaceId && "showSketchBtn" == name)
        return (OpenXmlElement) new ShowSketchButton();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SketchOptions.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SketchOptions.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public InSketchMode InSketchMode
    {
      get
      {
        return this.GetElement<InSketchMode>(0);
      }
      set
      {
        this.SetElement<InSketchMode>(0, value);
      }
    }

    public ShowSketchButton ShowSketchButton
    {
      get
      {
        return this.GetElement<ShowSketchButton>(1);
      }
      set
      {
        this.SetElement<ShowSketchButton>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SketchOptions>(deep);
    }
  }
}
