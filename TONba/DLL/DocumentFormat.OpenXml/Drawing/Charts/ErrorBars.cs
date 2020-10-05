// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ErrorBars
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ErrorBarType))]
  [ChildElementInfo(typeof (ErrorDirection))]
  [ChildElementInfo(typeof (ErrorBarValueType))]
  [ChildElementInfo(typeof (NoEndCap))]
  [ChildElementInfo(typeof (Plus))]
  [ChildElementInfo(typeof (Minus))]
  [ChildElementInfo(typeof (ErrorBarValue))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class ErrorBars : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "errDir",
      "errBarType",
      "errValType",
      "noEndCap",
      "plus",
      "minus",
      "val",
      "spPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "errBars";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10582;

    public override string LocalName
    {
      get
      {
        return "errBars";
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
        return 10582;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ErrorBars()
    {
    }

    public ErrorBars(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ErrorBars(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ErrorBars(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "errDir" == name)
        return (OpenXmlElement) new ErrorDirection();
      if (11 == (int) namespaceId && "errBarType" == name)
        return (OpenXmlElement) new ErrorBarType();
      if (11 == (int) namespaceId && "errValType" == name)
        return (OpenXmlElement) new ErrorBarValueType();
      if (11 == (int) namespaceId && "noEndCap" == name)
        return (OpenXmlElement) new NoEndCap();
      if (11 == (int) namespaceId && "plus" == name)
        return (OpenXmlElement) new Plus();
      if (11 == (int) namespaceId && "minus" == name)
        return (OpenXmlElement) new Minus();
      if (11 == (int) namespaceId && "val" == name)
        return (OpenXmlElement) new ErrorBarValue();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ErrorBars.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ErrorBars.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ErrorDirection ErrorDirection
    {
      get
      {
        return this.GetElement<ErrorDirection>(0);
      }
      set
      {
        this.SetElement<ErrorDirection>(0, value);
      }
    }

    public ErrorBarType ErrorBarType
    {
      get
      {
        return this.GetElement<ErrorBarType>(1);
      }
      set
      {
        this.SetElement<ErrorBarType>(1, value);
      }
    }

    public ErrorBarValueType ErrorBarValueType
    {
      get
      {
        return this.GetElement<ErrorBarValueType>(2);
      }
      set
      {
        this.SetElement<ErrorBarValueType>(2, value);
      }
    }

    public NoEndCap NoEndCap
    {
      get
      {
        return this.GetElement<NoEndCap>(3);
      }
      set
      {
        this.SetElement<NoEndCap>(3, value);
      }
    }

    public Plus Plus
    {
      get
      {
        return this.GetElement<Plus>(4);
      }
      set
      {
        this.SetElement<Plus>(4, value);
      }
    }

    public Minus Minus
    {
      get
      {
        return this.GetElement<Minus>(5);
      }
      set
      {
        this.SetElement<Minus>(5, value);
      }
    }

    public ErrorBarValue ErrorBarValue
    {
      get
      {
        return this.GetElement<ErrorBarValue>(6);
      }
      set
      {
        this.SetElement<ErrorBarValue>(6, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(7);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(7, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(8);
      }
      set
      {
        this.SetElement<ExtensionList>(8, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ErrorBars>(deep);
    }
  }
}
