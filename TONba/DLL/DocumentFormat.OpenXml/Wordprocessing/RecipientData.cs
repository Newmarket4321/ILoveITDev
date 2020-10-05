// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RecipientData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ColumnIndex))]
  [ChildElementInfo(typeof (Active))]
  [ChildElementInfo(typeof (UniqueTag))]
  [GeneratedCode("DomGen", "2.0")]
  public class RecipientData : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "active",
      "column",
      "uniqueTag"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "recipientData";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11860;

    public override string LocalName
    {
      get
      {
        return "recipientData";
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
        return 11860;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RecipientData()
    {
    }

    public RecipientData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RecipientData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RecipientData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "active" == name)
        return (OpenXmlElement) new Active();
      if (23 == (int) namespaceId && "column" == name)
        return (OpenXmlElement) new ColumnIndex();
      if (23 == (int) namespaceId && "uniqueTag" == name)
        return (OpenXmlElement) new UniqueTag();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RecipientData.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RecipientData.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Active Active
    {
      get
      {
        return this.GetElement<Active>(0);
      }
      set
      {
        this.SetElement<Active>(0, value);
      }
    }

    public ColumnIndex ColumnIndex
    {
      get
      {
        return this.GetElement<ColumnIndex>(1);
      }
      set
      {
        this.SetElement<ColumnIndex>(1, value);
      }
    }

    public UniqueTag UniqueTag
    {
      get
      {
        return this.GetElement<UniqueTag>(2);
      }
      set
      {
        this.SetElement<UniqueTag>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RecipientData>(deep);
    }
  }
}
