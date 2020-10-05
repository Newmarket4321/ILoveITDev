// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EmptyEnumerable`1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal class EmptyEnumerable<T> : IEnumerable<T>, IEnumerable
  {
    private static readonly EmptyEnumerable<T> _dummy = new EmptyEnumerable<T>();

    public IEnumerator<T> GetEnumerator()
    {
      return EmptyEnumerator<T>.EmptyEnumeratorSingleton;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) EmptyEnumerator<T>.EmptyEnumeratorSingleton;
    }

    private EmptyEnumerable()
    {
    }

    public static EmptyEnumerable<T> EmptyEnumerableSingleton
    {
      get
      {
        return EmptyEnumerable<T>._dummy;
      }
    }
  }
}
