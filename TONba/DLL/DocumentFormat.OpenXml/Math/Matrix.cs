// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Matrix
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (MatrixProperties))]
  [ChildElementInfo(typeof (MatrixRow))]
  [GeneratedCode("DomGen", "2.0")]
  public class Matrix : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "mPr",
      "mr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "m";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10919;

    public override string LocalName
    {
      get
      {
        return "m";
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
        return 10919;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Matrix()
    {
    }

    public Matrix(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Matrix(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Matrix(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "mPr" == name)
        return (OpenXmlElement) new MatrixProperties();
      if (21 == (int) namespaceId && "mr" == name)
        return (OpenXmlElement) new MatrixRow();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Matrix.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Matrix.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MatrixProperties MatrixProperties
    {
      get
      {
        return this.GetElement<MatrixProperties>(0);
      }
      set
      {
        this.SetElement<MatrixProperties>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Matrix>(deep);
    }
  }
}
