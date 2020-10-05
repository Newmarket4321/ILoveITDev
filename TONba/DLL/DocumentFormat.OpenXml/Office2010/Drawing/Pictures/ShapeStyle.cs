// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Pictures
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (LineReference))]
  [ChildElementInfo(typeof (FillReference))]
  [ChildElementInfo(typeof (EffectReference))]
  [ChildElementInfo(typeof (FontReference))]
  public class ShapeStyle : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "lnRef",
      "fillRef",
      "effectRef",
      "fontRef"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "style";
    private const byte tagNsId = 50;
    internal const int ElementTypeIdConst = 12887;

    public override string LocalName
    {
      get
      {
        return "style";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 50;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12887;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ShapeStyle()
    {
    }

    public ShapeStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShapeStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShapeStyle(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "lnRef" == name)
        return (OpenXmlElement) new LineReference();
      if (10 == (int) namespaceId && "fillRef" == name)
        return (OpenXmlElement) new FillReference();
      if (10 == (int) namespaceId && "effectRef" == name)
        return (OpenXmlElement) new EffectReference();
      if (10 == (int) namespaceId && "fontRef" == name)
        return (OpenXmlElement) new FontReference();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ShapeStyle.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ShapeStyle.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LineReference LineReference
    {
      get
      {
        return this.GetElement<LineReference>(0);
      }
      set
      {
        this.SetElement<LineReference>(0, value);
      }
    }

    public FillReference FillReference
    {
      get
      {
        return this.GetElement<FillReference>(1);
      }
      set
      {
        this.SetElement<FillReference>(1, value);
      }
    }

    public EffectReference EffectReference
    {
      get
      {
        return this.GetElement<EffectReference>(2);
      }
      set
      {
        this.SetElement<EffectReference>(2, value);
      }
    }

    public FontReference FontReference
    {
      get
      {
        return this.GetElement<FontReference>(3);
      }
      set
      {
        this.SetElement<FontReference>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapeStyle>(deep);
    }
  }
}
