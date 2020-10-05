// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EmptyElementList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal sealed class EmptyElementList : OpenXmlElementList
  {
    private static readonly EmptyElementList _EmptyElementList = new EmptyElementList();

    private EmptyElementList()
    {
    }

    internal static EmptyElementList EmptyElementListSingleton
    {
      get
      {
        return EmptyElementList._EmptyElementList;
      }
    }

    public override OpenXmlElement GetItem(int index)
    {
      throw new ArgumentOutOfRangeException(nameof (index));
    }

    public override int Count
    {
      get
      {
        return 0;
      }
    }

    public override IEnumerator<OpenXmlElement> GetEnumerator()
    {
      return EmptyEnumerator<OpenXmlElement>.EmptyEnumeratorSingleton;
    }
  }
}
