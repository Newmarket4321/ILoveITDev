// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (MultiLvlStrRefExtensionList))]
  [ChildElementInfo(typeof (MultiLevelStringCache))]
  [ChildElementInfo(typeof (Formula))]
  [GeneratedCode("DomGen", "2.0")]
  public class MultiLevelStringReference : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "f",
      "multiLvlStrCache",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "multiLvlStrRef";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10404;

    public override string LocalName
    {
      get
      {
        return "multiLvlStrRef";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10404;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MultiLevelStringReference()
    {
    }

    public MultiLevelStringReference(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MultiLevelStringReference(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MultiLevelStringReference(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (11 == (int) namespaceId && "multiLvlStrCache" == name)
        return (OpenXmlElement) new MultiLevelStringCache();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new MultiLvlStrRefExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MultiLevelStringReference.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MultiLevelStringReference.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(0);
      }
      set
      {
        this.SetElement<Formula>(0, value);
      }
    }

    public MultiLevelStringCache MultiLevelStringCache
    {
      get
      {
        return this.GetElement<MultiLevelStringCache>(1);
      }
      set
      {
        this.SetElement<MultiLevelStringCache>(1, value);
      }
    }

    public MultiLvlStrRefExtensionList MultiLvlStrRefExtensionList
    {
      get
      {
        return this.GetElement<MultiLvlStrRefExtensionList>(2);
      }
      set
      {
        this.SetElement<MultiLvlStrRefExtensionList>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MultiLevelStringReference>(deep);
    }
  }
}
