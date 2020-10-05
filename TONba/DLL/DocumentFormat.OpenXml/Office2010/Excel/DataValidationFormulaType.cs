// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.DataValidationFormulaType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (Formula))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class DataValidationFormulaType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "f"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 32
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (32 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataValidationFormulaType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataValidationFormulaType.eleNamespaceIds;
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

    protected DataValidationFormulaType()
    {
    }

    protected DataValidationFormulaType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected DataValidationFormulaType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected DataValidationFormulaType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
