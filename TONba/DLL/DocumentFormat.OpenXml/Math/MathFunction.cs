// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.MathFunction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (Base))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FunctionProperties))]
  [ChildElementInfo(typeof (FunctionName))]
  public class MathFunction : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "funcPr",
      "fName",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "func";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10915;

    public override string LocalName
    {
      get
      {
        return "func";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10915;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MathFunction()
    {
    }

    public MathFunction(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MathFunction(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MathFunction(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "funcPr" == name)
        return (OpenXmlElement) new FunctionProperties();
      if (21 == (int) namespaceId && "fName" == name)
        return (OpenXmlElement) new FunctionName();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MathFunction.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MathFunction.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FunctionProperties FunctionProperties
    {
      get
      {
        return this.GetElement<FunctionProperties>(0);
      }
      set
      {
        this.SetElement<FunctionProperties>(0, value);
      }
    }

    public FunctionName FunctionName
    {
      get
      {
        return this.GetElement<FunctionName>(1);
      }
      set
      {
        this.SetElement<FunctionName>(1, value);
      }
    }

    public Base Base
    {
      get
      {
        return this.GetElement<Base>(2);
      }
      set
      {
        this.SetElement<Base>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MathFunction>(deep);
    }
  }
}
