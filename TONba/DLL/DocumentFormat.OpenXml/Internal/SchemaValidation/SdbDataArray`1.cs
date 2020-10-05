// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SdbDataArray`1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SdbDataArray<T> where T : SdbData, new()
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] _sdbDataBytes;

    public SdbDataArray(byte[] sdbDataBytes)
    {
      this._sdbDataBytes = sdbDataBytes;
    }

    public T this[int index]
    {
      get
      {
        T instance = Activator.CreateInstance<T>();
        instance.LoadFromBytes(this._sdbDataBytes, index * instance.DataSize);
        return instance;
      }
    }
  }
}
