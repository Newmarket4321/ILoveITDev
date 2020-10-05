// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Protection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ChartObject))]
  [ChildElementInfo(typeof (Data))]
  [ChildElementInfo(typeof (Formatting))]
  [ChildElementInfo(typeof (Selection))]
  [ChildElementInfo(typeof (UserInterface))]
  [GeneratedCode("DomGen", "2.0")]
  public class Protection : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "chartObject",
      "data",
      "formatting",
      "selection",
      "userInterface"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "protection";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10645;

    public override string LocalName
    {
      get
      {
        return "protection";
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
        return 10645;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Protection()
    {
    }

    public Protection(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Protection(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Protection(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "chartObject" == name)
        return (OpenXmlElement) new ChartObject();
      if (11 == (int) namespaceId && "data" == name)
        return (OpenXmlElement) new Data();
      if (11 == (int) namespaceId && "formatting" == name)
        return (OpenXmlElement) new Formatting();
      if (11 == (int) namespaceId && "selection" == name)
        return (OpenXmlElement) new Selection();
      if (11 == (int) namespaceId && "userInterface" == name)
        return (OpenXmlElement) new UserInterface();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Protection.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Protection.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ChartObject ChartObject
    {
      get
      {
        return this.GetElement<ChartObject>(0);
      }
      set
      {
        this.SetElement<ChartObject>(0, value);
      }
    }

    public Data Data
    {
      get
      {
        return this.GetElement<Data>(1);
      }
      set
      {
        this.SetElement<Data>(1, value);
      }
    }

    public Formatting Formatting
    {
      get
      {
        return this.GetElement<Formatting>(2);
      }
      set
      {
        this.SetElement<Formatting>(2, value);
      }
    }

    public Selection Selection
    {
      get
      {
        return this.GetElement<Selection>(3);
      }
      set
      {
        this.SetElement<Selection>(3, value);
      }
    }

    public UserInterface UserInterface
    {
      get
      {
        return this.GetElement<UserInterface>(4);
      }
      set
      {
        this.SetElement<UserInterface>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Protection>(deep);
    }
  }
}
