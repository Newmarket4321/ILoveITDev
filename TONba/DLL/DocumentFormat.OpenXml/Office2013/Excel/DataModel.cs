// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.DataModel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ModelTables), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ModelRelationships), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  public class DataModel : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "minVersionLoad"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "modelTables",
      "modelRelationships",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 71,
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "dataModel";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13376;

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
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13376;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return DataModel.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataModel.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "minVersionLoad")]
    public ByteValue MinVersionLoad
    {
      get
      {
        return (ByteValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
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
      if (71 == (int) namespaceId && "modelTables" == name)
        return (OpenXmlElement) new ModelTables();
      if (71 == (int) namespaceId && "modelRelationships" == name)
        return (OpenXmlElement) new ModelRelationships();
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
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

    public ModelTables ModelTables
    {
      get
      {
        return this.GetElement<ModelTables>(0);
      }
      set
      {
        this.SetElement<ModelTables>(0, value);
      }
    }

    public ModelRelationships ModelRelationships
    {
      get
      {
        return this.GetElement<ModelRelationships>(1);
      }
      set
      {
        this.SetElement<ModelRelationships>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "minVersionLoad" == name)
        return (OpenXmlSimpleType) new ByteValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataModel>(deep);
    }
  }
}
