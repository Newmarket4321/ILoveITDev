// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ChildElementInfoAttribute
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
  public sealed class ChildElementInfoAttribute : Attribute
  {
    private Type _type;
    private FileFormatVersions format;

    public ChildElementInfoAttribute(Type elementType)
    {
      this._type = elementType;
      this.format = FileFormatVersions.Office2007 | FileFormatVersions.Office2010;
    }

    public ChildElementInfoAttribute(Type elementType, FileFormatVersions availableInOfficeVersion)
    {
      this._type = elementType;
      this.format = availableInOfficeVersion;
    }

    public Type ElementType
    {
      get
      {
        return this._type;
      }
    }

    public FileFormatVersions AvailableInVersion
    {
      get
      {
        return this.format;
      }
    }
  }
}
