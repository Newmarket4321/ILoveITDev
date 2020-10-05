// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomXsn.CustomXsn
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomXsn
{
  [ChildElementInfo(typeof (Scope))]
  [ChildElementInfo(typeof (XsnLocation))]
  [ChildElementInfo(typeof (CachedView))]
  [ChildElementInfo(typeof (OpenByDefault))]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomXsn : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "xsnLocation",
      "cached",
      "openByDefault",
      "xsnScope"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 39,
      (byte) 39,
      (byte) 39,
      (byte) 39
    };
    private const string tagName = "customXsn";
    private const byte tagNsId = 39;
    internal const int ElementTypeIdConst = 12706;

    public override string LocalName
    {
      get
      {
        return "customXsn";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 39;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12706;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CustomXsn()
    {
    }

    public CustomXsn(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomXsn(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomXsn(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (39 == (int) namespaceId && "xsnLocation" == name)
        return (OpenXmlElement) new XsnLocation();
      if (39 == (int) namespaceId && "cached" == name)
        return (OpenXmlElement) new CachedView();
      if (39 == (int) namespaceId && "openByDefault" == name)
        return (OpenXmlElement) new OpenByDefault();
      if (39 == (int) namespaceId && "xsnScope" == name)
        return (OpenXmlElement) new Scope();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office.CustomXsn.CustomXsn.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office.CustomXsn.CustomXsn.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public XsnLocation XsnLocation
    {
      get
      {
        return this.GetElement<XsnLocation>(0);
      }
      set
      {
        this.SetElement<XsnLocation>(0, value);
      }
    }

    public CachedView CachedView
    {
      get
      {
        return this.GetElement<CachedView>(1);
      }
      set
      {
        this.SetElement<CachedView>(1, value);
      }
    }

    public OpenByDefault OpenByDefault
    {
      get
      {
        return this.GetElement<OpenByDefault>(2);
      }
      set
      {
        this.SetElement<OpenByDefault>(2, value);
      }
    }

    public Scope Scope
    {
      get
      {
        return this.GetElement<Scope>(3);
      }
      set
      {
        this.SetElement<Scope>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office.CustomXsn.CustomXsn>(deep);
    }
  }
}
