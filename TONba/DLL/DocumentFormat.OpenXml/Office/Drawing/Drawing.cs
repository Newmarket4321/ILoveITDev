// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Drawing.Drawing
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Drawing
{
  [ChildElementInfo(typeof (ShapeTree))]
  [GeneratedCode("DomGen", "2.0")]
  public class Drawing : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "spTree"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 56
    };
    private const string tagName = "drawing";
    private const byte tagNsId = 56;
    internal const int ElementTypeIdConst = 13083;

    public override string LocalName
    {
      get
      {
        return "drawing";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 56;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13083;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Drawing(DiagramPersistLayoutPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(DiagramPersistLayoutPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public DiagramPersistLayoutPart DiagramPersistLayoutPart
    {
      get
      {
        return this.OpenXmlPart as DiagramPersistLayoutPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Drawing(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Drawing(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Drawing(string outerXml)
      : base(outerXml)
    {
    }

    public Drawing()
    {
    }

    public void Save(DiagramPersistLayoutPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (56 == (int) namespaceId && "spTree" == name)
        return (OpenXmlElement) new ShapeTree();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office.Drawing.Drawing.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office.Drawing.Drawing.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShapeTree ShapeTree
    {
      get
      {
        return this.GetElement<ShapeTree>(0);
      }
      set
      {
        this.SetElement<ShapeTree>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office.Drawing.Drawing>(deep);
    }
  }
}
