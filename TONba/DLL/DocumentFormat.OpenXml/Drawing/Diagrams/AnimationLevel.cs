﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  public class AnimationLevel : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "animLvl";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10740;

    public override string LocalName
    {
      get
      {
        return "animLvl";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10740;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return AnimationLevel.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnimationLevel.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "val")]
    public EnumValue<AnimationLevelStringValues> Val
    {
      get
      {
        return (EnumValue<AnimationLevelStringValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimationLevelStringValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnimationLevel>(deep);
    }
  }
}
