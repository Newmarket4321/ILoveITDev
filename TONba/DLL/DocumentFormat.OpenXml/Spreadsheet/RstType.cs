// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RstType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Text))]
  [ChildElementInfo(typeof (PhoneticProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Run))]
  [ChildElementInfo(typeof (PhoneticRun))]
  public abstract class RstType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "t",
      "r",
      "rPh",
      "phoneticPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new Text();
      if (22 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new Run();
      if (22 == (int) namespaceId && "rPh" == name)
        return (OpenXmlElement) new PhoneticRun();
      if (22 == (int) namespaceId && "phoneticPr" == name)
        return (OpenXmlElement) new PhoneticProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RstType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RstType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Text Text
    {
      get
      {
        return this.GetElement<Text>(0);
      }
      set
      {
        this.SetElement<Text>(0, value);
      }
    }

    protected RstType()
    {
    }

    protected RstType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected RstType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected RstType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
