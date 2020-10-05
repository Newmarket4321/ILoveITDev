// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlElementList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlElementList : IEnumerable<OpenXmlElement>, IEnumerable
  {
    public abstract OpenXmlElement GetItem(int index);

    public abstract int Count { get; }

    public virtual OpenXmlElement this[int i]
    {
      get
      {
        return this.GetItem(i);
      }
    }

    public T First<T>() where T : OpenXmlElement
    {
      foreach (OpenXmlElement openXmlElement in this)
      {
        if (openXmlElement is T)
          return (T) openXmlElement;
      }
      return default (T);
    }

    public IEnumerable<T> OfType<T>() where T : OpenXmlElement
    {
      foreach (OpenXmlElement openXmlElement in this)
      {
        if (openXmlElement is T)
          yield return (T) openXmlElement;
      }
    }

    public abstract IEnumerator<OpenXmlElement> GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}
