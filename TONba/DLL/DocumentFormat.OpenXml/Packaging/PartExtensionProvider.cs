// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PartExtensionProvider
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Packaging
{
  [Serializable]
  public sealed class PartExtensionProvider : Dictionary<string, string>
  {
    public PartExtensionProvider()
    {
    }

    public PartExtensionProvider(PartExtensionProvider partExtProvider)
      : base((IDictionary<string, string>) partExtProvider)
    {
    }

    public PartExtensionProvider(int capacity)
      : base(capacity)
    {
    }

    private PartExtensionProvider(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public void AddPartExtension(string contentType, string partExtension)
    {
      this.Add(contentType, partExtension);
    }

    public void MakeSurePartExtensionExist(string contentType, string partExtension)
    {
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (partExtension == null)
        throw new ArgumentNullException(nameof (partExtension));
      string str = (string) null;
      if (this.TryGetValue(contentType, out str) && str == partExtension)
        return;
      this.Add(contentType, partExtension);
    }
  }
}
