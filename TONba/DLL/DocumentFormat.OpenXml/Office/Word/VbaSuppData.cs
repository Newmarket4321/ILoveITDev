// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.VbaSuppData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocEvents))]
  [ChildElementInfo(typeof (Mcds))]
  public class VbaSuppData : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "docEvents",
      "mcds"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "vbaSuppData";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12610;

    public override string LocalName
    {
      get
      {
        return "vbaSuppData";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12610;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal VbaSuppData(VbaDataPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(VbaDataPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public VbaDataPart VbaDataPart
    {
      get
      {
        return this.OpenXmlPart as VbaDataPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public VbaSuppData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VbaSuppData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VbaSuppData(string outerXml)
      : base(outerXml)
    {
    }

    public VbaSuppData()
    {
    }

    public void Save(VbaDataPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "docEvents" == name)
        return (OpenXmlElement) new DocEvents();
      if (33 == (int) namespaceId && "mcds" == name)
        return (OpenXmlElement) new Mcds();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return VbaSuppData.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return VbaSuppData.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocEvents DocEvents
    {
      get
      {
        return this.GetElement<DocEvents>(0);
      }
      set
      {
        this.SetElement<DocEvents>(0, value);
      }
    }

    public Mcds Mcds
    {
      get
      {
        return this.GetElement<Mcds>(1);
      }
      set
      {
        this.SetElement<Mcds>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VbaSuppData>(deep);
    }
  }
}
