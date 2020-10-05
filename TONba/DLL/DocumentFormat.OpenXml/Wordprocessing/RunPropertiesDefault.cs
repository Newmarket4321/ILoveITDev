// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunPropertiesBaseStyle))]
  public class RunPropertiesDefault : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "rPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "rPrDefault";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11894;

    public override string LocalName
    {
      get
      {
        return "rPrDefault";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11894;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RunPropertiesDefault()
    {
    }

    public RunPropertiesDefault(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RunPropertiesDefault(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RunPropertiesDefault(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunPropertiesBaseStyle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RunPropertiesDefault.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RunPropertiesDefault.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunPropertiesBaseStyle RunPropertiesBaseStyle
    {
      get
      {
        return this.GetElement<RunPropertiesBaseStyle>(0);
      }
      set
      {
        this.SetElement<RunPropertiesBaseStyle>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RunPropertiesDefault>(deep);
    }
  }
}
