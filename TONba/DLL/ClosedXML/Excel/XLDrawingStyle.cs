// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingStyle
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingStyle : IXLDrawingStyle
  {
    public XLDrawingStyle()
    {
      this.Alignment = (IXLDrawingAlignment) new XLDrawingAlignment((IXLDrawingStyle) this);
      this.ColorsAndLines = (IXLDrawingColorsAndLines) new XLDrawingColorsAndLines((IXLDrawingStyle) this);
      this.Size = (IXLDrawingSize) new XLDrawingSize((IXLDrawingStyle) this);
      this.Protection = (IXLDrawingProtection) new XLDrawingProtection((IXLDrawingStyle) this);
      this.Properties = (IXLDrawingProperties) new XLDrawingProperties((IXLDrawingStyle) this);
      this.Margins = (IXLDrawingMargins) new XLDrawingMargins((IXLDrawingStyle) this);
      this.Web = (IXLDrawingWeb) new XLDrawingWeb((IXLDrawingStyle) this);
    }

    public IXLDrawingAlignment Alignment { get; private set; }

    public IXLDrawingColorsAndLines ColorsAndLines { get; private set; }

    public IXLDrawingSize Size { get; private set; }

    public IXLDrawingProtection Protection { get; private set; }

    public IXLDrawingProperties Properties { get; private set; }

    public IXLDrawingMargins Margins { get; private set; }

    public IXLDrawingWeb Web { get; private set; }
  }
}
