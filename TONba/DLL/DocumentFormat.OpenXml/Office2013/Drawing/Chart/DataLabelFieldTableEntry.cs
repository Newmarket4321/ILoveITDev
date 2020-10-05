// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextFieldGuid), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Formula), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabelFieldTableCache), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class DataLabelFieldTableEntry : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "txfldGUID",
      "f",
      "dlblFieldTableCache"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 64,
      (byte) 64,
      (byte) 64
    };
    private const string tagName = "dlblFTEntry";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13255;

    public override string LocalName
    {
      get
      {
        return "dlblFTEntry";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13255;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public DataLabelFieldTableEntry()
    {
    }

    public DataLabelFieldTableEntry(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataLabelFieldTableEntry(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataLabelFieldTableEntry(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "txfldGUID" == name)
        return (OpenXmlElement) new TextFieldGuid();
      if (64 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (64 == (int) namespaceId && "dlblFieldTableCache" == name)
        return (OpenXmlElement) new DataLabelFieldTableCache();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataLabelFieldTableEntry.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataLabelFieldTableEntry.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TextFieldGuid TextFieldGuid
    {
      get
      {
        return this.GetElement<TextFieldGuid>(0);
      }
      set
      {
        this.SetElement<TextFieldGuid>(0, value);
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(1);
      }
      set
      {
        this.SetElement<Formula>(1, value);
      }
    }

    public DataLabelFieldTableCache DataLabelFieldTableCache
    {
      get
      {
        return this.GetElement<DataLabelFieldTableCache>(2);
      }
      set
      {
        this.SetElement<DataLabelFieldTableCache>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataLabelFieldTableEntry>(deep);
    }
  }
}
