// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SimpleTypeRestrictions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class SimpleTypeRestrictions
  {
    public int SimpleTypeCount { get; set; }

    public SimpleTypeRestriction[] SimpleTypes { get; set; }

    internal void Serialize(Stream stream)
    {
      new BinaryFormatter()
      {
        AssemblyFormat = FormatterAssemblyStyle.Full
      }.Serialize(stream, (object) this);
    }

    internal static SimpleTypeRestrictions Deserialize(Stream stream, FileFormatVersions fileFormat)
    {
      SimpleTypeRestrictions typeRestrictions = (SimpleTypeRestrictions) new BinaryFormatter()
      {
        AssemblyFormat = FormatterAssemblyStyle.Full
      }.Deserialize(stream);
      foreach (SimpleTypeRestriction simpleType in typeRestrictions.SimpleTypes)
        simpleType.FileFormat = fileFormat;
      return typeRestrictions;
    }

    public SimpleTypeRestriction this[int index]
    {
      get
      {
        return this.SimpleTypes[index];
      }
    }
  }
}
