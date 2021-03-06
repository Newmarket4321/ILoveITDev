﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.NonVisualConnectorShapeDrawingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ConnectionShapeLocks))]
  [ChildElementInfo(typeof (StartConnection))]
  [ChildElementInfo(typeof (EndConnection))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "cxnSpLocks",
      "stCxn",
      "endCxn",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cNvCxnSpPr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10185;

    public override string LocalName
    {
      get
      {
        return "cNvCxnSpPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10185;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualConnectorShapeDrawingProperties()
    {
    }

    public NonVisualConnectorShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualConnectorShapeDrawingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualConnectorShapeDrawingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "cxnSpLocks" == name)
        return (OpenXmlElement) new ConnectionShapeLocks();
      if (10 == (int) namespaceId && "stCxn" == name)
        return (OpenXmlElement) new StartConnection();
      if (10 == (int) namespaceId && "endCxn" == name)
        return (OpenXmlElement) new EndConnection();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualConnectorShapeDrawingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualConnectorShapeDrawingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ConnectionShapeLocks ConnectionShapeLocks
    {
      get
      {
        return this.GetElement<ConnectionShapeLocks>(0);
      }
      set
      {
        this.SetElement<ConnectionShapeLocks>(0, value);
      }
    }

    public StartConnection StartConnection
    {
      get
      {
        return this.GetElement<StartConnection>(1);
      }
      set
      {
        this.SetElement<StartConnection>(1, value);
      }
    }

    public EndConnection EndConnection
    {
      get
      {
        return this.GetElement<EndConnection>(2);
      }
      set
      {
        this.SetElement<EndConnection>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);
    }
  }
}
