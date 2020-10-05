// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EmptyEnumerator`1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal sealed class EmptyEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
  {
    private static readonly IEnumerator<T> _EmptyEnumerator = (IEnumerator<T>) new EmptyEnumerator<T>();

    private EmptyEnumerator()
    {
    }

    internal static IEnumerator<T> EmptyEnumeratorSingleton
    {
      get
      {
        return EmptyEnumerator<T>._EmptyEnumerator;
      }
    }

    public T Current
    {
      get
      {
        throw new InvalidOperationException(ExceptionMessages.EmptyCollection);
      }
    }

    object IEnumerator.Current
    {
      get
      {
        return (object) this.Current;
      }
    }

    public bool MoveNext()
    {
      return false;
    }

    public void Reset()
    {
    }

    public void Dispose()
    {
    }
  }
}
