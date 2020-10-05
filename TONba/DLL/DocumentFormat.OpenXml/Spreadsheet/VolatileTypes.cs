// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.VolatileTypes
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (VolatileType))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class VolatileTypes : OpenXmlPartRootElement
  {
    private const string tagName = "volTypes";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11113;

    public override string LocalName
    {
      get
      {
        return "volTypes";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11113;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal VolatileTypes(VolatileDependenciesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(VolatileDependenciesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public VolatileDependenciesPart VolatileDependenciesPart
    {
      get
      {
        return this.OpenXmlPart as VolatileDependenciesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public VolatileTypes(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VolatileTypes(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VolatileTypes(string outerXml)
      : base(outerXml)
    {
    }

    public VolatileTypes()
    {
    }

    public void Save(VolatileDependenciesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "volType" == name)
        return (OpenXmlElement) new VolatileType();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VolatileTypes>(deep);
    }
  }
}
