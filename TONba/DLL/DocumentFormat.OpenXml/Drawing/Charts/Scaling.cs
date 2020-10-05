// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Scaling
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Orientation))]
  [ChildElementInfo(typeof (MaxAxisValue))]
  [ChildElementInfo(typeof (MinAxisValue))]
  [ChildElementInfo(typeof (LogBase))]
  [GeneratedCode("DomGen", "2.0")]
  public class Scaling : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "logBase",
      "orientation",
      "max",
      "min",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "scaling";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10380;

    public override string LocalName
    {
      get
      {
        return "scaling";
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
        return 10380;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Scaling()
    {
    }

    public Scaling(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Scaling(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Scaling(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "logBase" == name)
        return (OpenXmlElement) new LogBase();
      if (11 == (int) namespaceId && "orientation" == name)
        return (OpenXmlElement) new Orientation();
      if (11 == (int) namespaceId && "max" == name)
        return (OpenXmlElement) new MaxAxisValue();
      if (11 == (int) namespaceId && "min" == name)
        return (OpenXmlElement) new MinAxisValue();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Scaling.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Scaling.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LogBase LogBase
    {
      get
      {
        return this.GetElement<LogBase>(0);
      }
      set
      {
        this.SetElement<LogBase>(0, value);
      }
    }

    public Orientation Orientation
    {
      get
      {
        return this.GetElement<Orientation>(1);
      }
      set
      {
        this.SetElement<Orientation>(1, value);
      }
    }

    public MaxAxisValue MaxAxisValue
    {
      get
      {
        return this.GetElement<MaxAxisValue>(2);
      }
      set
      {
        this.SetElement<MaxAxisValue>(2, value);
      }
    }

    public MinAxisValue MinAxisValue
    {
      get
      {
        return this.GetElement<MinAxisValue>(3);
      }
      set
      {
        this.SetElement<MinAxisValue>(3, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Scaling>(deep);
    }
  }
}
