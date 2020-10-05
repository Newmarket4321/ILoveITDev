// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.NotesSlide
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonSlideData))]
  [ChildElementInfo(typeof (ColorMapOverride))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  public class NotesSlide : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "showMasterSp",
      "showMasterPhAnim"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "cSld",
      "clrMapOvr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "notes";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12243;

    public override string LocalName
    {
      get
      {
        return "notes";
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
        return 12243;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return NotesSlide.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NotesSlide.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "showMasterSp")]
    public BooleanValue ShowMasterShapes
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showMasterPhAnim")]
    public BooleanValue ShowMasterPlaceholderAnimations
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal NotesSlide(NotesSlidePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(NotesSlidePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public NotesSlidePart NotesSlidePart
    {
      get
      {
        return this.OpenXmlPart as NotesSlidePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public NotesSlide(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NotesSlide(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NotesSlide(string outerXml)
      : base(outerXml)
    {
    }

    public NotesSlide()
    {
    }

    public void Save(NotesSlidePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cSld" == name)
        return (OpenXmlElement) new CommonSlideData();
      if (24 == (int) namespaceId && "clrMapOvr" == name)
        return (OpenXmlElement) new ColorMapOverride();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NotesSlide.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NotesSlide.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonSlideData CommonSlideData
    {
      get
      {
        return this.GetElement<CommonSlideData>(0);
      }
      set
      {
        this.SetElement<CommonSlideData>(0, value);
      }
    }

    public ColorMapOverride ColorMapOverride
    {
      get
      {
        return this.GetElement<ColorMapOverride>(1);
      }
      set
      {
        this.SetElement<ColorMapOverride>(1, value);
      }
    }

    public ExtensionListWithModification ExtensionListWithModification
    {
      get
      {
        return this.GetElement<ExtensionListWithModification>(2);
      }
      set
      {
        this.SetElement<ExtensionListWithModification>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "showMasterSp" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showMasterPhAnim" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NotesSlide>(deep);
    }
  }
}
