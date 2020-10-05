﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Run
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Text))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunProperties))]
  public class Run : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "rPr",
      "t"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "r";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11215;

    public override string LocalName
    {
      get
      {
        return "r";
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
        return 11215;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Run()
    {
    }

    public Run(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Run(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Run(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      if (22 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new Text();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Run.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Run.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunProperties RunProperties
    {
      get
      {
        return this.GetElement<RunProperties>(0);
      }
      set
      {
        this.SetElement<RunProperties>(0, value);
      }
    }

    public Text Text
    {
      get
      {
        return this.GetElement<Text>(1);
      }
      set
      {
        this.SetElement<Text>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Run>(deep);
    }
  }
}
