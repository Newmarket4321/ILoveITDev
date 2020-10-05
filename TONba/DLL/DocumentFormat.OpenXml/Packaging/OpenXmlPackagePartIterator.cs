// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.OpenXmlPackagePartIterator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  internal class OpenXmlPackagePartIterator : IEnumerable<OpenXmlPart>, IEnumerable
  {
    private OpenXmlPackage _package;

    public OpenXmlPackagePartIterator(OpenXmlPackage package)
    {
      this._package = package;
    }

    public IEnumerator<OpenXmlPart> GetEnumerator()
    {
      return this.GetPartsByBreadthFirstTraversal();
    }

    private IEnumerator<OpenXmlPart> GetPartsByBreadthFirstTraversal()
    {
      List<OpenXmlPart> openXmlPartList = new List<OpenXmlPart>();
      Queue<OpenXmlPart> openXmlPartQueue = new Queue<OpenXmlPart>();
      foreach (IdPartPair part in this._package.Parts)
        openXmlPartQueue.Enqueue(part.OpenXmlPart);
      while (openXmlPartQueue.Count > 0)
      {
        OpenXmlPart openXmlPart = openXmlPartQueue.Dequeue();
        openXmlPartList.Add(openXmlPart);
        foreach (IdPartPair part in openXmlPart.Parts)
        {
          if (!openXmlPartQueue.Contains(part.OpenXmlPart) && !openXmlPartList.Contains(part.OpenXmlPart))
            openXmlPartQueue.Enqueue(part.OpenXmlPart);
        }
      }
      return (IEnumerator<OpenXmlPart>) openXmlPartList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}
