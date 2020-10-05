// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CalculationChain
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CalculationCell))]
  public class CalculationChain : OpenXmlPartRootElement
  {
    private const string tagName = "calcChain";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11093;

    public override string LocalName
    {
      get
      {
        return "calcChain";
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
        return 11093;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal CalculationChain(CalculationChainPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CalculationChainPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CalculationChainPart CalculationChainPart
    {
      get
      {
        return this.OpenXmlPart as CalculationChainPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public CalculationChain(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CalculationChain(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CalculationChain(string outerXml)
      : base(outerXml)
    {
    }

    public CalculationChain()
    {
    }

    public void Save(CalculationChainPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "c" == name)
        return (OpenXmlElement) new CalculationCell();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CalculationChain>(deep);
    }
  }
}
