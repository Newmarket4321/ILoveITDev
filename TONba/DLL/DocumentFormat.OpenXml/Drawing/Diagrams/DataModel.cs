// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.DataModel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (PointList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ConnectionList))]
  [ChildElementInfo(typeof (Background))]
  [ChildElementInfo(typeof (Whole))]
  [ChildElementInfo(typeof (DataModelExtensionList))]
  public class DataModel : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "ptLst",
      "cxnLst",
      "bg",
      "whole",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14
    };
    private const string tagName = "dataModel";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10723;

    public override string LocalName
    {
      get
      {
        return "dataModel";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10723;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataModel()
    {
    }

    public DataModel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataModel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataModel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "ptLst" == name)
        return (OpenXmlElement) new PointList();
      if (14 == (int) namespaceId && "cxnLst" == name)
        return (OpenXmlElement) new ConnectionList();
      if (14 == (int) namespaceId && "bg" == name)
        return (OpenXmlElement) new Background();
      if (14 == (int) namespaceId && "whole" == name)
        return (OpenXmlElement) new Whole();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DataModelExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataModel.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataModel.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PointList PointList
    {
      get
      {
        return this.GetElement<PointList>(0);
      }
      set
      {
        this.SetElement<PointList>(0, value);
      }
    }

    public ConnectionList ConnectionList
    {
      get
      {
        return this.GetElement<ConnectionList>(1);
      }
      set
      {
        this.SetElement<ConnectionList>(1, value);
      }
    }

    public Background Background
    {
      get
      {
        return this.GetElement<Background>(2);
      }
      set
      {
        this.SetElement<Background>(2, value);
      }
    }

    public Whole Whole
    {
      get
      {
        return this.GetElement<Whole>(3);
      }
      set
      {
        this.SetElement<Whole>(3, value);
      }
    }

    public DataModelExtensionList DataModelExtensionList
    {
      get
      {
        return this.GetElement<DataModelExtensionList>(4);
      }
      set
      {
        this.SetElement<DataModelExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataModel>(deep);
    }
  }
}
