// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ParticleMatchInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("Match={Match}")]
  internal class ParticleMatchInfo
  {
    internal ParticleMatchInfo()
    {
      this.Match = ParticleMatch.Nomatch;
    }

    internal ParticleMatchInfo(OpenXmlElement startElement)
    {
      this.Match = ParticleMatch.Nomatch;
      this.StartElement = startElement;
    }

    internal ParticleMatch Match { get; set; }

    internal OpenXmlElement StartElement { get; private set; }

    internal OpenXmlElement LastMatchedElement { get; set; }

    internal string ErrorMessage { get; set; }

    internal ExpectedChildren ExpectedChildren { get; private set; }

    internal void InitExpectedChildren()
    {
      if (this.ExpectedChildren == null)
        this.ExpectedChildren = new ExpectedChildren();
      else
        this.ExpectedChildren.Clear();
    }

    internal void SetExpectedChildren(ExpectedChildren expectedChildren)
    {
      if (expectedChildren == null || expectedChildren.Count == 0)
      {
        if (this.ExpectedChildren == null)
          return;
        this.ExpectedChildren.Clear();
      }
      else
      {
        if (this.ExpectedChildren == null)
          this.ExpectedChildren = new ExpectedChildren();
        this.ExpectedChildren.Clear();
        this.ExpectedChildren.Add(expectedChildren);
      }
    }

    internal void Reset(OpenXmlElement startElement)
    {
      this.StartElement = startElement;
      this.Match = ParticleMatch.Nomatch;
      this.LastMatchedElement = (OpenXmlElement) null;
      this.ErrorMessage = (string) null;
      if (this.ExpectedChildren == null)
        return;
      this.ExpectedChildren.Clear();
    }
  }
}
