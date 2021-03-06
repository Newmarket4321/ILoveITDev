﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.Backstage
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (BackstageTab), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageFastCommandButton), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Backstage : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "onShow",
      "onHide"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "backstage";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13178;

    public override string LocalName
    {
      get
      {
        return "backstage";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13178;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Backstage.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Backstage.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "onShow")]
    public StringValue OnShow
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "onHide")]
    public StringValue OnHide
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public Backstage()
    {
    }

    public Backstage(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Backstage(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Backstage(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "tab" == name)
        return (OpenXmlElement) new BackstageTab();
      if (57 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new BackstageFastCommandButton();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "onShow" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "onHide" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Backstage>(deep);
    }
  }
}
