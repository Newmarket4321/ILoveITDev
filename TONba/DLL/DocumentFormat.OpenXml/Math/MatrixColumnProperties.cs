// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.MatrixColumnProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (MatrixColumnCount))]
  [ChildElementInfo(typeof (MatrixColumnJustification))]
  [GeneratedCode("DomGen", "2.0")]
  public class MatrixColumnProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "count",
      "mcJc"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "mcPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10980;

    public override string LocalName
    {
      get
      {
        return "mcPr";
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
        return 10980;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MatrixColumnProperties()
    {
    }

    public MatrixColumnProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MatrixColumnProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MatrixColumnProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "count" == name)
        return (OpenXmlElement) new MatrixColumnCount();
      if (21 == (int) namespaceId && "mcJc" == name)
        return (OpenXmlElement) new MatrixColumnJustification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MatrixColumnProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MatrixColumnProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MatrixColumnCount MatrixColumnCount
    {
      get
      {
        return this.GetElement<MatrixColumnCount>(0);
      }
      set
      {
        this.SetElement<MatrixColumnCount>(0, value);
      }
    }

    public MatrixColumnJustification MatrixColumnJustification
    {
      get
      {
        return this.GetElement<MatrixColumnJustification>(1);
      }
      set
      {
        this.SetElement<MatrixColumnJustification>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MatrixColumnProperties>(deep);
    }
  }
}
