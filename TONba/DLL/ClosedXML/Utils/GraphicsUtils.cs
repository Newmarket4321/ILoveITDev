// Decompiled with JetBrains decompiler
// Type: ClosedXML.Utils.GraphicsUtils
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Drawing;

namespace ClosedXML.Utils
{
  internal static class GraphicsUtils
  {
    public static SizeF MeasureString(string s, Font font)
    {
      using (Bitmap bitmap = new Bitmap(1, 1))
      {
        using (Graphics graphics = Graphics.FromImage((Image) bitmap))
          return graphics.MeasureString(s, font, int.MaxValue, StringFormat.GenericTypographic);
      }
    }
  }
}
