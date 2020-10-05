// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PictureBulletBase))]
  [ChildElementInfo(typeof (Drawing))]
  public class NumberingPictureBullet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "numPicBulletId"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "pict",
      "drawing"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "numPicBullet";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11932;

    public override string LocalName
    {
      get
      {
        return "numPicBullet";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11932;
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
        return NumberingPictureBullet.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NumberingPictureBullet.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "numPicBulletId")]
    public Int32Value NumberingPictureBulletId
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public NumberingPictureBullet()
    {
    }

    public NumberingPictureBullet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NumberingPictureBullet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NumberingPictureBullet(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "pict" == name)
        return (OpenXmlElement) new PictureBulletBase();
      if (23 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new Drawing();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberingPictureBullet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberingPictureBullet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public PictureBulletBase PictureBulletBase
    {
      get
      {
        return this.GetElement<PictureBulletBase>(0);
      }
      set
      {
        this.SetElement<PictureBulletBase>(0, value);
      }
    }

    public Drawing Drawing
    {
      get
      {
        return this.GetElement<Drawing>(1);
      }
      set
      {
        this.SetElement<Drawing>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "numPicBulletId" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberingPictureBullet>(deep);
    }
  }
}
