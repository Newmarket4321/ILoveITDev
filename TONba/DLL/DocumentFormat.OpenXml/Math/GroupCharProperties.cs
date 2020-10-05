// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.GroupCharProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (Position))]
  [ChildElementInfo(typeof (ControlProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (VerticalJustification))]
  [ChildElementInfo(typeof (AccentChar))]
  public class GroupCharProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "chr",
      "pos",
      "vertJc",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "groupChrPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10974;

    public override string LocalName
    {
      get
      {
        return "groupChrPr";
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
        return 10974;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GroupCharProperties()
    {
    }

    public GroupCharProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GroupCharProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GroupCharProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "chr" == name)
        return (OpenXmlElement) new AccentChar();
      if (21 == (int) namespaceId && "pos" == name)
        return (OpenXmlElement) new Position();
      if (21 == (int) namespaceId && "vertJc" == name)
        return (OpenXmlElement) new VerticalJustification();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GroupCharProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GroupCharProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AccentChar AccentChar
    {
      get
      {
        return this.GetElement<AccentChar>(0);
      }
      set
      {
        this.SetElement<AccentChar>(0, value);
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(1);
      }
      set
      {
        this.SetElement<Position>(1, value);
      }
    }

    public VerticalJustification VerticalJustification
    {
      get
      {
        return this.GetElement<VerticalJustification>(2);
      }
      set
      {
        this.SetElement<VerticalJustification>(2, value);
      }
    }

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(3);
      }
      set
      {
        this.SetElement<ControlProperties>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GroupCharProperties>(deep);
    }
  }
}
