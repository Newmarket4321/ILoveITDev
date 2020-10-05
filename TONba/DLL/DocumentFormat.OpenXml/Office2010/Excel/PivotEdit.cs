// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.PivotEdit
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (TupleItems), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotArea), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (PivotUserEdit), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class PivotEdit : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "userEdit",
      "tupleItems",
      "pivotArea",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "pivotEdit";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13041;

    public override string LocalName
    {
      get
      {
        return "pivotEdit";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13041;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotEdit()
    {
    }

    public PivotEdit(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotEdit(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotEdit(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "userEdit" == name)
        return (OpenXmlElement) new PivotUserEdit();
      if (53 == (int) namespaceId && "tupleItems" == name)
        return (OpenXmlElement) new TupleItems();
      if (53 == (int) namespaceId && "pivotArea" == name)
        return (OpenXmlElement) new PivotArea();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotEdit.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotEdit.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PivotUserEdit PivotUserEdit
    {
      get
      {
        return this.GetElement<PivotUserEdit>(0);
      }
      set
      {
        this.SetElement<PivotUserEdit>(0, value);
      }
    }

    public TupleItems TupleItems
    {
      get
      {
        return this.GetElement<TupleItems>(1);
      }
      set
      {
        this.SetElement<TupleItems>(1, value);
      }
    }

    public PivotArea PivotArea
    {
      get
      {
        return this.GetElement<PivotArea>(2);
      }
      set
      {
        this.SetElement<PivotArea>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotEdit>(deep);
    }
  }
}
