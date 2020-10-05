// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLColor
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClosedXML.Excel
{
  public class XLColor : IEquatable<XLColor>
  {
    private static readonly Dictionary<Color, XLColor> ByColor = new Dictionary<Color, XLColor>();
    private static readonly object ByColorLock = new object();
    private static readonly Dictionary<int, XLColor> ByIndex = new Dictionary<int, XLColor>();
    private static readonly object ByIndexLock = new object();
    private static readonly Dictionary<XLThemeColor, XLColor> ByTheme = new Dictionary<XLThemeColor, XLColor>();
    private static readonly object ByThemeLock = new object();
    private static readonly Dictionary<XLThemeColor, Dictionary<double, XLColor>> ByThemeTint = new Dictionary<XLThemeColor, Dictionary<double, XLColor>>();
    private static readonly object ByThemeTintLock = new object();
    private static XLColor noColor = new XLColor();
    private static Dictionary<int, XLColor> _indexedColors;
    private readonly XLColorType _colorType;
    private int _hashCode;
    private readonly int _indexed;
    private readonly XLThemeColor _themeColor;
    private readonly double _themeTint;
    private Color _color;

    public static XLColor FromColor(Color color)
    {
      XLColor xlColor;
      lock (XLColor.ByColorLock)
      {
        if (!XLColor.ByColor.TryGetValue(color, out xlColor))
        {
          xlColor = new XLColor(color);
          XLColor.ByColor.Add(color, xlColor);
        }
      }
      return xlColor;
    }

    public static XLColor FromArgb(int argb)
    {
      return XLColor.FromColor(Color.FromArgb(argb));
    }

    public static XLColor FromArgb(int r, int g, int b)
    {
      return XLColor.FromColor(Color.FromArgb(r, g, b));
    }

    public static XLColor FromArgb(int a, int r, int g, int b)
    {
      return XLColor.FromColor(Color.FromArgb(a, r, g, b));
    }

    public static XLColor FromKnownColor(KnownColor color)
    {
      return XLColor.FromColor(Color.FromKnownColor(color));
    }

    public static XLColor FromName(string name)
    {
      return XLColor.FromColor(Color.FromName(name));
    }

    public static XLColor FromHtml(string htmlColor)
    {
      return XLColor.FromColor(ColorTranslator.FromHtml(htmlColor));
    }

    public static XLColor FromIndex(int index)
    {
      XLColor xlColor;
      lock (XLColor.ByIndexLock)
      {
        if (!XLColor.ByIndex.TryGetValue(index, out xlColor))
        {
          xlColor = new XLColor(index);
          XLColor.ByIndex.Add(index, xlColor);
        }
      }
      return xlColor;
    }

    public static XLColor FromTheme(XLThemeColor themeColor)
    {
      XLColor xlColor;
      lock (XLColor.ByThemeLock)
      {
        if (!XLColor.ByTheme.TryGetValue(themeColor, out xlColor))
        {
          xlColor = new XLColor(themeColor);
          XLColor.ByTheme.Add(themeColor, xlColor);
        }
      }
      return xlColor;
    }

    public static XLColor FromTheme(XLThemeColor themeColor, double themeTint)
    {
      XLColor xlColor;
      lock (XLColor.ByThemeTintLock)
      {
        Dictionary<double, XLColor> dictionary;
        if (XLColor.ByThemeTint.TryGetValue(themeColor, out dictionary))
        {
          if (!dictionary.TryGetValue(themeTint, out xlColor))
          {
            xlColor = new XLColor(themeColor, themeTint);
            dictionary.Add(themeTint, xlColor);
          }
        }
        else
        {
          dictionary = new Dictionary<double, XLColor>();
          xlColor = new XLColor(themeColor, themeTint);
          dictionary.Add(themeTint, xlColor);
          XLColor.ByThemeTint.Add(themeColor, dictionary);
        }
      }
      return xlColor;
    }

    public static Dictionary<int, XLColor> IndexedColors
    {
      get
      {
        if (XLColor._indexedColors == null)
          XLColor._indexedColors = new Dictionary<int, XLColor>()
          {
            {
              0,
              XLColor.FromHtml("#FF000000")
            },
            {
              1,
              XLColor.FromHtml("#FFFFFFFF")
            },
            {
              2,
              XLColor.FromHtml("#FFFF0000")
            },
            {
              3,
              XLColor.FromHtml("#FF00FF00")
            },
            {
              4,
              XLColor.FromHtml("#FF0000FF")
            },
            {
              5,
              XLColor.FromHtml("#FFFFFF00")
            },
            {
              6,
              XLColor.FromHtml("#FFFF00FF")
            },
            {
              7,
              XLColor.FromHtml("#FF00FFFF")
            },
            {
              8,
              XLColor.FromHtml("#FF000000")
            },
            {
              9,
              XLColor.FromHtml("#FFFFFFFF")
            },
            {
              10,
              XLColor.FromHtml("#FFFF0000")
            },
            {
              11,
              XLColor.FromHtml("#FF00FF00")
            },
            {
              12,
              XLColor.FromHtml("#FF0000FF")
            },
            {
              13,
              XLColor.FromHtml("#FFFFFF00")
            },
            {
              14,
              XLColor.FromHtml("#FFFF00FF")
            },
            {
              15,
              XLColor.FromHtml("#FF00FFFF")
            },
            {
              16,
              XLColor.FromHtml("#FF800000")
            },
            {
              17,
              XLColor.FromHtml("#FF008000")
            },
            {
              18,
              XLColor.FromHtml("#FF000080")
            },
            {
              19,
              XLColor.FromHtml("#FF808000")
            },
            {
              20,
              XLColor.FromHtml("#FF800080")
            },
            {
              21,
              XLColor.FromHtml("#FF008080")
            },
            {
              22,
              XLColor.FromHtml("#FFC0C0C0")
            },
            {
              23,
              XLColor.FromHtml("#FF808080")
            },
            {
              24,
              XLColor.FromHtml("#FF9999FF")
            },
            {
              25,
              XLColor.FromHtml("#FF993366")
            },
            {
              26,
              XLColor.FromHtml("#FFFFFFCC")
            },
            {
              27,
              XLColor.FromHtml("#FFCCFFFF")
            },
            {
              28,
              XLColor.FromHtml("#FF660066")
            },
            {
              29,
              XLColor.FromHtml("#FFFF8080")
            },
            {
              30,
              XLColor.FromHtml("#FF0066CC")
            },
            {
              31,
              XLColor.FromHtml("#FFCCCCFF")
            },
            {
              32,
              XLColor.FromHtml("#FF000080")
            },
            {
              33,
              XLColor.FromHtml("#FFFF00FF")
            },
            {
              34,
              XLColor.FromHtml("#FFFFFF00")
            },
            {
              35,
              XLColor.FromHtml("#FF00FFFF")
            },
            {
              36,
              XLColor.FromHtml("#FF800080")
            },
            {
              37,
              XLColor.FromHtml("#FF800000")
            },
            {
              38,
              XLColor.FromHtml("#FF008080")
            },
            {
              39,
              XLColor.FromHtml("#FF0000FF")
            },
            {
              40,
              XLColor.FromHtml("#FF00CCFF")
            },
            {
              41,
              XLColor.FromHtml("#FFCCFFFF")
            },
            {
              42,
              XLColor.FromHtml("#FFCCFFCC")
            },
            {
              43,
              XLColor.FromHtml("#FFFFFF99")
            },
            {
              44,
              XLColor.FromHtml("#FF99CCFF")
            },
            {
              45,
              XLColor.FromHtml("#FFFF99CC")
            },
            {
              46,
              XLColor.FromHtml("#FFCC99FF")
            },
            {
              47,
              XLColor.FromHtml("#FFFFCC99")
            },
            {
              48,
              XLColor.FromHtml("#FF3366FF")
            },
            {
              49,
              XLColor.FromHtml("#FF33CCCC")
            },
            {
              50,
              XLColor.FromHtml("#FF99CC00")
            },
            {
              51,
              XLColor.FromHtml("#FFFFCC00")
            },
            {
              52,
              XLColor.FromHtml("#FFFF9900")
            },
            {
              53,
              XLColor.FromHtml("#FFFF6600")
            },
            {
              54,
              XLColor.FromHtml("#FF666699")
            },
            {
              55,
              XLColor.FromHtml("#FF969696")
            },
            {
              56,
              XLColor.FromHtml("#FF003366")
            },
            {
              57,
              XLColor.FromHtml("#FF339966")
            },
            {
              58,
              XLColor.FromHtml("#FF003300")
            },
            {
              59,
              XLColor.FromHtml("#FF333300")
            },
            {
              60,
              XLColor.FromHtml("#FF993300")
            },
            {
              61,
              XLColor.FromHtml("#FF993366")
            },
            {
              62,
              XLColor.FromHtml("#FF333399")
            },
            {
              63,
              XLColor.FromHtml("#FF333333")
            },
            {
              64,
              XLColor.FromColor(Color.Transparent)
            }
          };
        return XLColor._indexedColors;
      }
    }

    public static XLColor NoColor
    {
      get
      {
        return XLColor.noColor;
      }
    }

    public static XLColor AliceBlue
    {
      get
      {
        return XLColor.FromColor(Color.AliceBlue);
      }
    }

    public static XLColor AntiqueWhite
    {
      get
      {
        return XLColor.FromColor(Color.AntiqueWhite);
      }
    }

    public static XLColor Aqua
    {
      get
      {
        return XLColor.FromColor(Color.Aqua);
      }
    }

    public static XLColor Aquamarine
    {
      get
      {
        return XLColor.FromColor(Color.Aquamarine);
      }
    }

    public static XLColor Azure
    {
      get
      {
        return XLColor.FromColor(Color.Azure);
      }
    }

    public static XLColor Beige
    {
      get
      {
        return XLColor.FromColor(Color.Beige);
      }
    }

    public static XLColor Bisque
    {
      get
      {
        return XLColor.FromColor(Color.Bisque);
      }
    }

    public static XLColor Black
    {
      get
      {
        return XLColor.FromColor(Color.Black);
      }
    }

    public static XLColor BlanchedAlmond
    {
      get
      {
        return XLColor.FromColor(Color.BlanchedAlmond);
      }
    }

    public static XLColor Blue
    {
      get
      {
        return XLColor.FromColor(Color.Blue);
      }
    }

    public static XLColor BlueViolet
    {
      get
      {
        return XLColor.FromColor(Color.BlueViolet);
      }
    }

    public static XLColor Brown
    {
      get
      {
        return XLColor.FromColor(Color.Brown);
      }
    }

    public static XLColor BurlyWood
    {
      get
      {
        return XLColor.FromColor(Color.BurlyWood);
      }
    }

    public static XLColor CadetBlue
    {
      get
      {
        return XLColor.FromColor(Color.CadetBlue);
      }
    }

    public static XLColor Chartreuse
    {
      get
      {
        return XLColor.FromColor(Color.Chartreuse);
      }
    }

    public static XLColor Chocolate
    {
      get
      {
        return XLColor.FromColor(Color.Chocolate);
      }
    }

    public static XLColor Coral
    {
      get
      {
        return XLColor.FromColor(Color.Coral);
      }
    }

    public static XLColor CornflowerBlue
    {
      get
      {
        return XLColor.FromColor(Color.CornflowerBlue);
      }
    }

    public static XLColor Cornsilk
    {
      get
      {
        return XLColor.FromColor(Color.Cornsilk);
      }
    }

    public static XLColor Crimson
    {
      get
      {
        return XLColor.FromColor(Color.Crimson);
      }
    }

    public static XLColor Cyan
    {
      get
      {
        return XLColor.FromColor(Color.Cyan);
      }
    }

    public static XLColor DarkBlue
    {
      get
      {
        return XLColor.FromColor(Color.DarkBlue);
      }
    }

    public static XLColor DarkCyan
    {
      get
      {
        return XLColor.FromColor(Color.DarkCyan);
      }
    }

    public static XLColor DarkGoldenrod
    {
      get
      {
        return XLColor.FromColor(Color.DarkGoldenrod);
      }
    }

    public static XLColor DarkGray
    {
      get
      {
        return XLColor.FromColor(Color.DarkGray);
      }
    }

    public static XLColor DarkGreen
    {
      get
      {
        return XLColor.FromColor(Color.DarkGreen);
      }
    }

    public static XLColor DarkKhaki
    {
      get
      {
        return XLColor.FromColor(Color.DarkKhaki);
      }
    }

    public static XLColor DarkMagenta
    {
      get
      {
        return XLColor.FromColor(Color.DarkMagenta);
      }
    }

    public static XLColor DarkOliveGreen
    {
      get
      {
        return XLColor.FromColor(Color.DarkOliveGreen);
      }
    }

    public static XLColor DarkOrange
    {
      get
      {
        return XLColor.FromColor(Color.DarkOrange);
      }
    }

    public static XLColor DarkOrchid
    {
      get
      {
        return XLColor.FromColor(Color.DarkOrchid);
      }
    }

    public static XLColor DarkRed
    {
      get
      {
        return XLColor.FromColor(Color.DarkRed);
      }
    }

    public static XLColor DarkSalmon
    {
      get
      {
        return XLColor.FromColor(Color.DarkSalmon);
      }
    }

    public static XLColor DarkSeaGreen
    {
      get
      {
        return XLColor.FromColor(Color.DarkSeaGreen);
      }
    }

    public static XLColor DarkSlateBlue
    {
      get
      {
        return XLColor.FromColor(Color.DarkSlateBlue);
      }
    }

    public static XLColor DarkSlateGray
    {
      get
      {
        return XLColor.FromColor(Color.DarkSlateGray);
      }
    }

    public static XLColor DarkTurquoise
    {
      get
      {
        return XLColor.FromColor(Color.DarkTurquoise);
      }
    }

    public static XLColor DarkViolet
    {
      get
      {
        return XLColor.FromColor(Color.DarkViolet);
      }
    }

    public static XLColor DeepPink
    {
      get
      {
        return XLColor.FromColor(Color.DeepPink);
      }
    }

    public static XLColor DeepSkyBlue
    {
      get
      {
        return XLColor.FromColor(Color.DeepSkyBlue);
      }
    }

    public static XLColor DimGray
    {
      get
      {
        return XLColor.FromColor(Color.DimGray);
      }
    }

    public static XLColor DodgerBlue
    {
      get
      {
        return XLColor.FromColor(Color.DodgerBlue);
      }
    }

    public static XLColor Firebrick
    {
      get
      {
        return XLColor.FromColor(Color.Firebrick);
      }
    }

    public static XLColor FloralWhite
    {
      get
      {
        return XLColor.FromColor(Color.FloralWhite);
      }
    }

    public static XLColor ForestGreen
    {
      get
      {
        return XLColor.FromColor(Color.ForestGreen);
      }
    }

    public static XLColor Fuchsia
    {
      get
      {
        return XLColor.FromColor(Color.Fuchsia);
      }
    }

    public static XLColor Gainsboro
    {
      get
      {
        return XLColor.FromColor(Color.Gainsboro);
      }
    }

    public static XLColor GhostWhite
    {
      get
      {
        return XLColor.FromColor(Color.GhostWhite);
      }
    }

    public static XLColor Gold
    {
      get
      {
        return XLColor.FromColor(Color.Gold);
      }
    }

    public static XLColor Goldenrod
    {
      get
      {
        return XLColor.FromColor(Color.Goldenrod);
      }
    }

    public static XLColor Gray
    {
      get
      {
        return XLColor.FromColor(Color.Gray);
      }
    }

    public static XLColor Green
    {
      get
      {
        return XLColor.FromColor(Color.Green);
      }
    }

    public static XLColor GreenYellow
    {
      get
      {
        return XLColor.FromColor(Color.GreenYellow);
      }
    }

    public static XLColor Honeydew
    {
      get
      {
        return XLColor.FromColor(Color.Honeydew);
      }
    }

    public static XLColor HotPink
    {
      get
      {
        return XLColor.FromColor(Color.HotPink);
      }
    }

    public static XLColor IndianRed
    {
      get
      {
        return XLColor.FromColor(Color.IndianRed);
      }
    }

    public static XLColor Indigo
    {
      get
      {
        return XLColor.FromColor(Color.Indigo);
      }
    }

    public static XLColor Ivory
    {
      get
      {
        return XLColor.FromColor(Color.Ivory);
      }
    }

    public static XLColor Khaki
    {
      get
      {
        return XLColor.FromColor(Color.Khaki);
      }
    }

    public static XLColor Lavender
    {
      get
      {
        return XLColor.FromColor(Color.Lavender);
      }
    }

    public static XLColor LavenderBlush
    {
      get
      {
        return XLColor.FromColor(Color.LavenderBlush);
      }
    }

    public static XLColor LawnGreen
    {
      get
      {
        return XLColor.FromColor(Color.LawnGreen);
      }
    }

    public static XLColor LemonChiffon
    {
      get
      {
        return XLColor.FromColor(Color.LemonChiffon);
      }
    }

    public static XLColor LightBlue
    {
      get
      {
        return XLColor.FromColor(Color.LightBlue);
      }
    }

    public static XLColor LightCoral
    {
      get
      {
        return XLColor.FromColor(Color.LightCoral);
      }
    }

    public static XLColor LightCyan
    {
      get
      {
        return XLColor.FromColor(Color.LightCyan);
      }
    }

    public static XLColor LightGoldenrodYellow
    {
      get
      {
        return XLColor.FromColor(Color.LightGoldenrodYellow);
      }
    }

    public static XLColor LightGray
    {
      get
      {
        return XLColor.FromColor(Color.LightGray);
      }
    }

    public static XLColor LightGreen
    {
      get
      {
        return XLColor.FromColor(Color.LightGreen);
      }
    }

    public static XLColor LightPink
    {
      get
      {
        return XLColor.FromColor(Color.LightPink);
      }
    }

    public static XLColor LightSalmon
    {
      get
      {
        return XLColor.FromColor(Color.LightSalmon);
      }
    }

    public static XLColor LightSeaGreen
    {
      get
      {
        return XLColor.FromColor(Color.LightSeaGreen);
      }
    }

    public static XLColor LightSkyBlue
    {
      get
      {
        return XLColor.FromColor(Color.LightSkyBlue);
      }
    }

    public static XLColor LightSlateGray
    {
      get
      {
        return XLColor.FromColor(Color.LightSlateGray);
      }
    }

    public static XLColor LightSteelBlue
    {
      get
      {
        return XLColor.FromColor(Color.LightSteelBlue);
      }
    }

    public static XLColor LightYellow
    {
      get
      {
        return XLColor.FromColor(Color.LightYellow);
      }
    }

    public static XLColor Lime
    {
      get
      {
        return XLColor.FromColor(Color.Lime);
      }
    }

    public static XLColor LimeGreen
    {
      get
      {
        return XLColor.FromColor(Color.LimeGreen);
      }
    }

    public static XLColor Linen
    {
      get
      {
        return XLColor.FromColor(Color.Linen);
      }
    }

    public static XLColor Magenta
    {
      get
      {
        return XLColor.FromColor(Color.Magenta);
      }
    }

    public static XLColor Maroon
    {
      get
      {
        return XLColor.FromColor(Color.Maroon);
      }
    }

    public static XLColor MediumAquamarine
    {
      get
      {
        return XLColor.FromColor(Color.MediumAquamarine);
      }
    }

    public static XLColor MediumBlue
    {
      get
      {
        return XLColor.FromColor(Color.MediumBlue);
      }
    }

    public static XLColor MediumOrchid
    {
      get
      {
        return XLColor.FromColor(Color.MediumOrchid);
      }
    }

    public static XLColor MediumPurple
    {
      get
      {
        return XLColor.FromColor(Color.MediumPurple);
      }
    }

    public static XLColor MediumSeaGreen
    {
      get
      {
        return XLColor.FromColor(Color.MediumSeaGreen);
      }
    }

    public static XLColor MediumSlateBlue
    {
      get
      {
        return XLColor.FromColor(Color.MediumSlateBlue);
      }
    }

    public static XLColor MediumSpringGreen
    {
      get
      {
        return XLColor.FromColor(Color.MediumSpringGreen);
      }
    }

    public static XLColor MediumTurquoise
    {
      get
      {
        return XLColor.FromColor(Color.MediumTurquoise);
      }
    }

    public static XLColor MediumVioletRed
    {
      get
      {
        return XLColor.FromColor(Color.MediumVioletRed);
      }
    }

    public static XLColor MidnightBlue
    {
      get
      {
        return XLColor.FromColor(Color.MidnightBlue);
      }
    }

    public static XLColor MintCream
    {
      get
      {
        return XLColor.FromColor(Color.MintCream);
      }
    }

    public static XLColor MistyRose
    {
      get
      {
        return XLColor.FromColor(Color.MistyRose);
      }
    }

    public static XLColor Moccasin
    {
      get
      {
        return XLColor.FromColor(Color.Moccasin);
      }
    }

    public static XLColor NavajoWhite
    {
      get
      {
        return XLColor.FromColor(Color.NavajoWhite);
      }
    }

    public static XLColor Navy
    {
      get
      {
        return XLColor.FromColor(Color.Navy);
      }
    }

    public static XLColor OldLace
    {
      get
      {
        return XLColor.FromColor(Color.OldLace);
      }
    }

    public static XLColor Olive
    {
      get
      {
        return XLColor.FromColor(Color.Olive);
      }
    }

    public static XLColor OliveDrab
    {
      get
      {
        return XLColor.FromColor(Color.OliveDrab);
      }
    }

    public static XLColor Orange
    {
      get
      {
        return XLColor.FromColor(Color.Orange);
      }
    }

    public static XLColor OrangeRed
    {
      get
      {
        return XLColor.FromColor(Color.OrangeRed);
      }
    }

    public static XLColor Orchid
    {
      get
      {
        return XLColor.FromColor(Color.Orchid);
      }
    }

    public static XLColor PaleGoldenrod
    {
      get
      {
        return XLColor.FromColor(Color.PaleGoldenrod);
      }
    }

    public static XLColor PaleGreen
    {
      get
      {
        return XLColor.FromColor(Color.PaleGreen);
      }
    }

    public static XLColor PaleTurquoise
    {
      get
      {
        return XLColor.FromColor(Color.PaleTurquoise);
      }
    }

    public static XLColor PaleVioletRed
    {
      get
      {
        return XLColor.FromColor(Color.PaleVioletRed);
      }
    }

    public static XLColor PapayaWhip
    {
      get
      {
        return XLColor.FromColor(Color.PapayaWhip);
      }
    }

    public static XLColor PeachPuff
    {
      get
      {
        return XLColor.FromColor(Color.PeachPuff);
      }
    }

    public static XLColor Peru
    {
      get
      {
        return XLColor.FromColor(Color.Peru);
      }
    }

    public static XLColor Pink
    {
      get
      {
        return XLColor.FromColor(Color.Pink);
      }
    }

    public static XLColor Plum
    {
      get
      {
        return XLColor.FromColor(Color.Plum);
      }
    }

    public static XLColor PowderBlue
    {
      get
      {
        return XLColor.FromColor(Color.PowderBlue);
      }
    }

    public static XLColor Purple
    {
      get
      {
        return XLColor.FromColor(Color.Purple);
      }
    }

    public static XLColor Red
    {
      get
      {
        return XLColor.FromColor(Color.Red);
      }
    }

    public static XLColor RosyBrown
    {
      get
      {
        return XLColor.FromColor(Color.RosyBrown);
      }
    }

    public static XLColor RoyalBlue
    {
      get
      {
        return XLColor.FromColor(Color.RoyalBlue);
      }
    }

    public static XLColor SaddleBrown
    {
      get
      {
        return XLColor.FromColor(Color.SaddleBrown);
      }
    }

    public static XLColor Salmon
    {
      get
      {
        return XLColor.FromColor(Color.Salmon);
      }
    }

    public static XLColor SandyBrown
    {
      get
      {
        return XLColor.FromColor(Color.SandyBrown);
      }
    }

    public static XLColor SeaGreen
    {
      get
      {
        return XLColor.FromColor(Color.SeaGreen);
      }
    }

    public static XLColor SeaShell
    {
      get
      {
        return XLColor.FromColor(Color.SeaShell);
      }
    }

    public static XLColor Sienna
    {
      get
      {
        return XLColor.FromColor(Color.Sienna);
      }
    }

    public static XLColor Silver
    {
      get
      {
        return XLColor.FromColor(Color.Silver);
      }
    }

    public static XLColor SkyBlue
    {
      get
      {
        return XLColor.FromColor(Color.SkyBlue);
      }
    }

    public static XLColor SlateBlue
    {
      get
      {
        return XLColor.FromColor(Color.SlateBlue);
      }
    }

    public static XLColor SlateGray
    {
      get
      {
        return XLColor.FromColor(Color.SlateGray);
      }
    }

    public static XLColor Snow
    {
      get
      {
        return XLColor.FromColor(Color.Snow);
      }
    }

    public static XLColor SpringGreen
    {
      get
      {
        return XLColor.FromColor(Color.SpringGreen);
      }
    }

    public static XLColor SteelBlue
    {
      get
      {
        return XLColor.FromColor(Color.SteelBlue);
      }
    }

    public static XLColor Tan
    {
      get
      {
        return XLColor.FromColor(Color.Tan);
      }
    }

    public static XLColor Teal
    {
      get
      {
        return XLColor.FromColor(Color.Teal);
      }
    }

    public static XLColor Thistle
    {
      get
      {
        return XLColor.FromColor(Color.Thistle);
      }
    }

    public static XLColor Tomato
    {
      get
      {
        return XLColor.FromColor(Color.Tomato);
      }
    }

    public static XLColor Turquoise
    {
      get
      {
        return XLColor.FromColor(Color.Turquoise);
      }
    }

    public static XLColor Violet
    {
      get
      {
        return XLColor.FromColor(Color.Violet);
      }
    }

    public static XLColor Wheat
    {
      get
      {
        return XLColor.FromColor(Color.Wheat);
      }
    }

    public static XLColor White
    {
      get
      {
        return XLColor.FromColor(Color.White);
      }
    }

    public static XLColor WhiteSmoke
    {
      get
      {
        return XLColor.FromColor(Color.WhiteSmoke);
      }
    }

    public static XLColor Yellow
    {
      get
      {
        return XLColor.FromColor(Color.Yellow);
      }
    }

    public static XLColor YellowGreen
    {
      get
      {
        return XLColor.FromColor(Color.YellowGreen);
      }
    }

    public static XLColor AirForceBlue
    {
      get
      {
        return XLColor.FromHtml("#FF5D8AA8");
      }
    }

    public static XLColor Alizarin
    {
      get
      {
        return XLColor.FromHtml("#FFE32636");
      }
    }

    public static XLColor Almond
    {
      get
      {
        return XLColor.FromHtml("#FFEFDECD");
      }
    }

    public static XLColor Amaranth
    {
      get
      {
        return XLColor.FromHtml("#FFE52B50");
      }
    }

    public static XLColor Amber
    {
      get
      {
        return XLColor.FromHtml("#FFFFBF00");
      }
    }

    public static XLColor AmberSaeEce
    {
      get
      {
        return XLColor.FromHtml("#FFFF7E00");
      }
    }

    public static XLColor AmericanRose
    {
      get
      {
        return XLColor.FromHtml("#FFFF033E");
      }
    }

    public static XLColor Amethyst
    {
      get
      {
        return XLColor.FromHtml("#FF9966CC");
      }
    }

    public static XLColor AntiFlashWhite
    {
      get
      {
        return XLColor.FromHtml("#FFF2F3F4");
      }
    }

    public static XLColor AntiqueBrass
    {
      get
      {
        return XLColor.FromHtml("#FFCD9575");
      }
    }

    public static XLColor AntiqueFuchsia
    {
      get
      {
        return XLColor.FromHtml("#FF915C83");
      }
    }

    public static XLColor AppleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF8DB600");
      }
    }

    public static XLColor Apricot
    {
      get
      {
        return XLColor.FromHtml("#FFFBCEB1");
      }
    }

    public static XLColor Aquamarine1
    {
      get
      {
        return XLColor.FromHtml("#FF7FFFD0");
      }
    }

    public static XLColor ArmyGreen
    {
      get
      {
        return XLColor.FromHtml("#FF4B5320");
      }
    }

    public static XLColor Arsenic
    {
      get
      {
        return XLColor.FromHtml("#FF3B444B");
      }
    }

    public static XLColor ArylideYellow
    {
      get
      {
        return XLColor.FromHtml("#FFE9D66B");
      }
    }

    public static XLColor AshGrey
    {
      get
      {
        return XLColor.FromHtml("#FFB2BEB5");
      }
    }

    public static XLColor Asparagus
    {
      get
      {
        return XLColor.FromHtml("#FF87A96B");
      }
    }

    public static XLColor AtomicTangerine
    {
      get
      {
        return XLColor.FromHtml("#FFFF9966");
      }
    }

    public static XLColor Auburn
    {
      get
      {
        return XLColor.FromHtml("#FF6D351A");
      }
    }

    public static XLColor Aureolin
    {
      get
      {
        return XLColor.FromHtml("#FFFDEE00");
      }
    }

    public static XLColor Aurometalsaurus
    {
      get
      {
        return XLColor.FromHtml("#FF6E7F80");
      }
    }

    public static XLColor Awesome
    {
      get
      {
        return XLColor.FromHtml("#FFFF2052");
      }
    }

    public static XLColor AzureColorWheel
    {
      get
      {
        return XLColor.FromHtml("#FF007FFF");
      }
    }

    public static XLColor BabyBlue
    {
      get
      {
        return XLColor.FromHtml("#FF89CFF0");
      }
    }

    public static XLColor BabyBlueEyes
    {
      get
      {
        return XLColor.FromHtml("#FFA1CAF1");
      }
    }

    public static XLColor BabyPink
    {
      get
      {
        return XLColor.FromHtml("#FFF4C2C2");
      }
    }

    public static XLColor BallBlue
    {
      get
      {
        return XLColor.FromHtml("#FF21ABCD");
      }
    }

    public static XLColor BananaMania
    {
      get
      {
        return XLColor.FromHtml("#FFFAE7B5");
      }
    }

    public static XLColor BattleshipGrey
    {
      get
      {
        return XLColor.FromHtml("#FF848482");
      }
    }

    public static XLColor Bazaar
    {
      get
      {
        return XLColor.FromHtml("#FF98777B");
      }
    }

    public static XLColor BeauBlue
    {
      get
      {
        return XLColor.FromHtml("#FFBCD4E6");
      }
    }

    public static XLColor Beaver
    {
      get
      {
        return XLColor.FromHtml("#FF9F8170");
      }
    }

    public static XLColor Bistre
    {
      get
      {
        return XLColor.FromHtml("#FF3D2B1F");
      }
    }

    public static XLColor Bittersweet
    {
      get
      {
        return XLColor.FromHtml("#FFFE6F5E");
      }
    }

    public static XLColor BleuDeFrance
    {
      get
      {
        return XLColor.FromHtml("#FF318CE7");
      }
    }

    public static XLColor BlizzardBlue
    {
      get
      {
        return XLColor.FromHtml("#FFACE5EE");
      }
    }

    public static XLColor Blond
    {
      get
      {
        return XLColor.FromHtml("#FFFAF0BE");
      }
    }

    public static XLColor BlueBell
    {
      get
      {
        return XLColor.FromHtml("#FFA2A2D0");
      }
    }

    public static XLColor BlueGray
    {
      get
      {
        return XLColor.FromHtml("#FF6699CC");
      }
    }

    public static XLColor BlueGreen
    {
      get
      {
        return XLColor.FromHtml("#FF00DDDD");
      }
    }

    public static XLColor BluePigment
    {
      get
      {
        return XLColor.FromHtml("#FF333399");
      }
    }

    public static XLColor BlueRyb
    {
      get
      {
        return XLColor.FromHtml("#FF0247FE");
      }
    }

    public static XLColor Blush
    {
      get
      {
        return XLColor.FromHtml("#FFDE5D83");
      }
    }

    public static XLColor Bole
    {
      get
      {
        return XLColor.FromHtml("#FF79443B");
      }
    }

    public static XLColor BondiBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0095B6");
      }
    }

    public static XLColor BostonUniversityRed
    {
      get
      {
        return XLColor.FromHtml("#FFCC0000");
      }
    }

    public static XLColor BrandeisBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0070FF");
      }
    }

    public static XLColor Brass
    {
      get
      {
        return XLColor.FromHtml("#FFB5A642");
      }
    }

    public static XLColor BrickRed
    {
      get
      {
        return XLColor.FromHtml("#FFCB4154");
      }
    }

    public static XLColor BrightCerulean
    {
      get
      {
        return XLColor.FromHtml("#FF1DACD6");
      }
    }

    public static XLColor BrightGreen
    {
      get
      {
        return XLColor.FromHtml("#FF66FF00");
      }
    }

    public static XLColor BrightLavender
    {
      get
      {
        return XLColor.FromHtml("#FFBF94E4");
      }
    }

    public static XLColor BrightMaroon
    {
      get
      {
        return XLColor.FromHtml("#FFC32148");
      }
    }

    public static XLColor BrightPink
    {
      get
      {
        return XLColor.FromHtml("#FFFF007F");
      }
    }

    public static XLColor BrightTurquoise
    {
      get
      {
        return XLColor.FromHtml("#FF08E8DE");
      }
    }

    public static XLColor BrightUbe
    {
      get
      {
        return XLColor.FromHtml("#FFD19FE8");
      }
    }

    public static XLColor BrilliantLavender
    {
      get
      {
        return XLColor.FromHtml("#FFF4BBFF");
      }
    }

    public static XLColor BrilliantRose
    {
      get
      {
        return XLColor.FromHtml("#FFFF55A3");
      }
    }

    public static XLColor BrinkPink
    {
      get
      {
        return XLColor.FromHtml("#FFFB607F");
      }
    }

    public static XLColor BritishRacingGreen
    {
      get
      {
        return XLColor.FromHtml("#FF004225");
      }
    }

    public static XLColor Bronze
    {
      get
      {
        return XLColor.FromHtml("#FFCD7F32");
      }
    }

    public static XLColor BrownTraditional
    {
      get
      {
        return XLColor.FromHtml("#FF964B00");
      }
    }

    public static XLColor BubbleGum
    {
      get
      {
        return XLColor.FromHtml("#FFFFC1CC");
      }
    }

    public static XLColor Bubbles
    {
      get
      {
        return XLColor.FromHtml("#FFE7FEFF");
      }
    }

    public static XLColor Buff
    {
      get
      {
        return XLColor.FromHtml("#FFF0DC82");
      }
    }

    public static XLColor BulgarianRose
    {
      get
      {
        return XLColor.FromHtml("#FF480607");
      }
    }

    public static XLColor Burgundy
    {
      get
      {
        return XLColor.FromHtml("#FF800020");
      }
    }

    public static XLColor BurntOrange
    {
      get
      {
        return XLColor.FromHtml("#FFCC5500");
      }
    }

    public static XLColor BurntSienna
    {
      get
      {
        return XLColor.FromHtml("#FFE97451");
      }
    }

    public static XLColor BurntUmber
    {
      get
      {
        return XLColor.FromHtml("#FF8A3324");
      }
    }

    public static XLColor Byzantine
    {
      get
      {
        return XLColor.FromHtml("#FFBD33A4");
      }
    }

    public static XLColor Byzantium
    {
      get
      {
        return XLColor.FromHtml("#FF702963");
      }
    }

    public static XLColor Cadet
    {
      get
      {
        return XLColor.FromHtml("#FF536872");
      }
    }

    public static XLColor CadetGrey
    {
      get
      {
        return XLColor.FromHtml("#FF91A3B0");
      }
    }

    public static XLColor CadmiumGreen
    {
      get
      {
        return XLColor.FromHtml("#FF006B3C");
      }
    }

    public static XLColor CadmiumOrange
    {
      get
      {
        return XLColor.FromHtml("#FFED872D");
      }
    }

    public static XLColor CadmiumRed
    {
      get
      {
        return XLColor.FromHtml("#FFE30022");
      }
    }

    public static XLColor CadmiumYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFF600");
      }
    }

    public static XLColor CalPolyPomonaGreen
    {
      get
      {
        return XLColor.FromHtml("#FF1E4D2B");
      }
    }

    public static XLColor CambridgeBlue
    {
      get
      {
        return XLColor.FromHtml("#FFA3C1AD");
      }
    }

    public static XLColor Camel
    {
      get
      {
        return XLColor.FromHtml("#FFC19A6B");
      }
    }

    public static XLColor CamouflageGreen
    {
      get
      {
        return XLColor.FromHtml("#FF78866B");
      }
    }

    public static XLColor CanaryYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFEF00");
      }
    }

    public static XLColor CandyAppleRed
    {
      get
      {
        return XLColor.FromHtml("#FFFF0800");
      }
    }

    public static XLColor CandyPink
    {
      get
      {
        return XLColor.FromHtml("#FFE4717A");
      }
    }

    public static XLColor CaputMortuum
    {
      get
      {
        return XLColor.FromHtml("#FF592720");
      }
    }

    public static XLColor Cardinal
    {
      get
      {
        return XLColor.FromHtml("#FFC41E3A");
      }
    }

    public static XLColor CaribbeanGreen
    {
      get
      {
        return XLColor.FromHtml("#FF00CC99");
      }
    }

    public static XLColor Carmine
    {
      get
      {
        return XLColor.FromHtml("#FF960018");
      }
    }

    public static XLColor CarminePink
    {
      get
      {
        return XLColor.FromHtml("#FFEB4C42");
      }
    }

    public static XLColor CarmineRed
    {
      get
      {
        return XLColor.FromHtml("#FFFF0038");
      }
    }

    public static XLColor CarnationPink
    {
      get
      {
        return XLColor.FromHtml("#FFFFA6C9");
      }
    }

    public static XLColor Carnelian
    {
      get
      {
        return XLColor.FromHtml("#FFB31B1B");
      }
    }

    public static XLColor CarolinaBlue
    {
      get
      {
        return XLColor.FromHtml("#FF99BADD");
      }
    }

    public static XLColor CarrotOrange
    {
      get
      {
        return XLColor.FromHtml("#FFED9121");
      }
    }

    public static XLColor Ceil
    {
      get
      {
        return XLColor.FromHtml("#FF92A1CF");
      }
    }

    public static XLColor Celadon
    {
      get
      {
        return XLColor.FromHtml("#FFACE1AF");
      }
    }

    public static XLColor CelestialBlue
    {
      get
      {
        return XLColor.FromHtml("#FF4997D0");
      }
    }

    public static XLColor Cerise
    {
      get
      {
        return XLColor.FromHtml("#FFDE3163");
      }
    }

    public static XLColor CerisePink
    {
      get
      {
        return XLColor.FromHtml("#FFEC3B83");
      }
    }

    public static XLColor Cerulean
    {
      get
      {
        return XLColor.FromHtml("#FF007BA7");
      }
    }

    public static XLColor CeruleanBlue
    {
      get
      {
        return XLColor.FromHtml("#FF2A52BE");
      }
    }

    public static XLColor Chamoisee
    {
      get
      {
        return XLColor.FromHtml("#FFA0785A");
      }
    }

    public static XLColor Champagne
    {
      get
      {
        return XLColor.FromHtml("#FFF7E7CE");
      }
    }

    public static XLColor Charcoal
    {
      get
      {
        return XLColor.FromHtml("#FF36454F");
      }
    }

    public static XLColor ChartreuseTraditional
    {
      get
      {
        return XLColor.FromHtml("#FFDFFF00");
      }
    }

    public static XLColor CherryBlossomPink
    {
      get
      {
        return XLColor.FromHtml("#FFFFB7C5");
      }
    }

    public static XLColor Chocolate1
    {
      get
      {
        return XLColor.FromHtml("#FF7B3F00");
      }
    }

    public static XLColor ChromeYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFA700");
      }
    }

    public static XLColor Cinereous
    {
      get
      {
        return XLColor.FromHtml("#FF98817B");
      }
    }

    public static XLColor Cinnabar
    {
      get
      {
        return XLColor.FromHtml("#FFE34234");
      }
    }

    public static XLColor Citrine
    {
      get
      {
        return XLColor.FromHtml("#FFE4D00A");
      }
    }

    public static XLColor ClassicRose
    {
      get
      {
        return XLColor.FromHtml("#FFFBCCE7");
      }
    }

    public static XLColor Cobalt
    {
      get
      {
        return XLColor.FromHtml("#FF0047AB");
      }
    }

    public static XLColor ColumbiaBlue
    {
      get
      {
        return XLColor.FromHtml("#FF9BDDFF");
      }
    }

    public static XLColor CoolBlack
    {
      get
      {
        return XLColor.FromHtml("#FF002E63");
      }
    }

    public static XLColor CoolGrey
    {
      get
      {
        return XLColor.FromHtml("#FF8C92AC");
      }
    }

    public static XLColor Copper
    {
      get
      {
        return XLColor.FromHtml("#FFB87333");
      }
    }

    public static XLColor CopperRose
    {
      get
      {
        return XLColor.FromHtml("#FF996666");
      }
    }

    public static XLColor Coquelicot
    {
      get
      {
        return XLColor.FromHtml("#FFFF3800");
      }
    }

    public static XLColor CoralPink
    {
      get
      {
        return XLColor.FromHtml("#FFF88379");
      }
    }

    public static XLColor CoralRed
    {
      get
      {
        return XLColor.FromHtml("#FFFF4040");
      }
    }

    public static XLColor Cordovan
    {
      get
      {
        return XLColor.FromHtml("#FF893F45");
      }
    }

    public static XLColor Corn
    {
      get
      {
        return XLColor.FromHtml("#FFFBEC5D");
      }
    }

    public static XLColor CornellRed
    {
      get
      {
        return XLColor.FromHtml("#FFB31B1B");
      }
    }

    public static XLColor CosmicLatte
    {
      get
      {
        return XLColor.FromHtml("#FFFFF8E7");
      }
    }

    public static XLColor CottonCandy
    {
      get
      {
        return XLColor.FromHtml("#FFFFBCD9");
      }
    }

    public static XLColor Cream
    {
      get
      {
        return XLColor.FromHtml("#FFFFFDD0");
      }
    }

    public static XLColor CrimsonGlory
    {
      get
      {
        return XLColor.FromHtml("#FFBE0032");
      }
    }

    public static XLColor CyanProcess
    {
      get
      {
        return XLColor.FromHtml("#FF00B7EB");
      }
    }

    public static XLColor Daffodil
    {
      get
      {
        return XLColor.FromHtml("#FFFFFF31");
      }
    }

    public static XLColor Dandelion
    {
      get
      {
        return XLColor.FromHtml("#FFF0E130");
      }
    }

    public static XLColor DarkBrown
    {
      get
      {
        return XLColor.FromHtml("#FF654321");
      }
    }

    public static XLColor DarkByzantium
    {
      get
      {
        return XLColor.FromHtml("#FF5D3954");
      }
    }

    public static XLColor DarkCandyAppleRed
    {
      get
      {
        return XLColor.FromHtml("#FFA40000");
      }
    }

    public static XLColor DarkCerulean
    {
      get
      {
        return XLColor.FromHtml("#FF08457E");
      }
    }

    public static XLColor DarkChampagne
    {
      get
      {
        return XLColor.FromHtml("#FFC2B280");
      }
    }

    public static XLColor DarkChestnut
    {
      get
      {
        return XLColor.FromHtml("#FF986960");
      }
    }

    public static XLColor DarkCoral
    {
      get
      {
        return XLColor.FromHtml("#FFCD5B45");
      }
    }

    public static XLColor DarkElectricBlue
    {
      get
      {
        return XLColor.FromHtml("#FF536878");
      }
    }

    public static XLColor DarkGreen1
    {
      get
      {
        return XLColor.FromHtml("#FF013220");
      }
    }

    public static XLColor DarkJungleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF1A2421");
      }
    }

    public static XLColor DarkLava
    {
      get
      {
        return XLColor.FromHtml("#FF483C32");
      }
    }

    public static XLColor DarkLavender
    {
      get
      {
        return XLColor.FromHtml("#FF734F96");
      }
    }

    public static XLColor DarkMidnightBlue
    {
      get
      {
        return XLColor.FromHtml("#FF003366");
      }
    }

    public static XLColor DarkPastelBlue
    {
      get
      {
        return XLColor.FromHtml("#FF779ECB");
      }
    }

    public static XLColor DarkPastelGreen
    {
      get
      {
        return XLColor.FromHtml("#FF03C03C");
      }
    }

    public static XLColor DarkPastelPurple
    {
      get
      {
        return XLColor.FromHtml("#FF966FD6");
      }
    }

    public static XLColor DarkPastelRed
    {
      get
      {
        return XLColor.FromHtml("#FFC23B22");
      }
    }

    public static XLColor DarkPink
    {
      get
      {
        return XLColor.FromHtml("#FFE75480");
      }
    }

    public static XLColor DarkPowderBlue
    {
      get
      {
        return XLColor.FromHtml("#FF003399");
      }
    }

    public static XLColor DarkRaspberry
    {
      get
      {
        return XLColor.FromHtml("#FF872657");
      }
    }

    public static XLColor DarkScarlet
    {
      get
      {
        return XLColor.FromHtml("#FF560319");
      }
    }

    public static XLColor DarkSienna
    {
      get
      {
        return XLColor.FromHtml("#FF3C1414");
      }
    }

    public static XLColor DarkSpringGreen
    {
      get
      {
        return XLColor.FromHtml("#FF177245");
      }
    }

    public static XLColor DarkTan
    {
      get
      {
        return XLColor.FromHtml("#FF918151");
      }
    }

    public static XLColor DarkTangerine
    {
      get
      {
        return XLColor.FromHtml("#FFFFA812");
      }
    }

    public static XLColor DarkTaupe
    {
      get
      {
        return XLColor.FromHtml("#FF483C32");
      }
    }

    public static XLColor DarkTerraCotta
    {
      get
      {
        return XLColor.FromHtml("#FFCC4E5C");
      }
    }

    public static XLColor DartmouthGreen
    {
      get
      {
        return XLColor.FromHtml("#FF00693E");
      }
    }

    public static XLColor DavysGrey
    {
      get
      {
        return XLColor.FromHtml("#FF555555");
      }
    }

    public static XLColor DebianRed
    {
      get
      {
        return XLColor.FromHtml("#FFD70A53");
      }
    }

    public static XLColor DeepCarmine
    {
      get
      {
        return XLColor.FromHtml("#FFA9203E");
      }
    }

    public static XLColor DeepCarminePink
    {
      get
      {
        return XLColor.FromHtml("#FFEF3038");
      }
    }

    public static XLColor DeepCarrotOrange
    {
      get
      {
        return XLColor.FromHtml("#FFE9692C");
      }
    }

    public static XLColor DeepCerise
    {
      get
      {
        return XLColor.FromHtml("#FFDA3287");
      }
    }

    public static XLColor DeepChampagne
    {
      get
      {
        return XLColor.FromHtml("#FFFAD6A5");
      }
    }

    public static XLColor DeepChestnut
    {
      get
      {
        return XLColor.FromHtml("#FFB94E48");
      }
    }

    public static XLColor DeepFuchsia
    {
      get
      {
        return XLColor.FromHtml("#FFC154C1");
      }
    }

    public static XLColor DeepJungleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF004B49");
      }
    }

    public static XLColor DeepLilac
    {
      get
      {
        return XLColor.FromHtml("#FF9955BB");
      }
    }

    public static XLColor DeepMagenta
    {
      get
      {
        return XLColor.FromHtml("#FFCC00CC");
      }
    }

    public static XLColor DeepPeach
    {
      get
      {
        return XLColor.FromHtml("#FFFFCBA4");
      }
    }

    public static XLColor DeepSaffron
    {
      get
      {
        return XLColor.FromHtml("#FFFF9933");
      }
    }

    public static XLColor Denim
    {
      get
      {
        return XLColor.FromHtml("#FF1560BD");
      }
    }

    public static XLColor Desert
    {
      get
      {
        return XLColor.FromHtml("#FFC19A6B");
      }
    }

    public static XLColor DesertSand
    {
      get
      {
        return XLColor.FromHtml("#FFEDC9AF");
      }
    }

    public static XLColor DogwoodRose
    {
      get
      {
        return XLColor.FromHtml("#FFD71868");
      }
    }

    public static XLColor DollarBill
    {
      get
      {
        return XLColor.FromHtml("#FF85BB65");
      }
    }

    public static XLColor Drab
    {
      get
      {
        return XLColor.FromHtml("#FF967117");
      }
    }

    public static XLColor DukeBlue
    {
      get
      {
        return XLColor.FromHtml("#FF00009C");
      }
    }

    public static XLColor EarthYellow
    {
      get
      {
        return XLColor.FromHtml("#FFE1A95F");
      }
    }

    public static XLColor Ecru
    {
      get
      {
        return XLColor.FromHtml("#FFC2B280");
      }
    }

    public static XLColor Eggplant
    {
      get
      {
        return XLColor.FromHtml("#FF614051");
      }
    }

    public static XLColor Eggshell
    {
      get
      {
        return XLColor.FromHtml("#FFF0EAD6");
      }
    }

    public static XLColor EgyptianBlue
    {
      get
      {
        return XLColor.FromHtml("#FF1034A6");
      }
    }

    public static XLColor ElectricBlue
    {
      get
      {
        return XLColor.FromHtml("#FF7DF9FF");
      }
    }

    public static XLColor ElectricCrimson
    {
      get
      {
        return XLColor.FromHtml("#FFFF003F");
      }
    }

    public static XLColor ElectricIndigo
    {
      get
      {
        return XLColor.FromHtml("#FF6F00FF");
      }
    }

    public static XLColor ElectricLavender
    {
      get
      {
        return XLColor.FromHtml("#FFF4BBFF");
      }
    }

    public static XLColor ElectricLime
    {
      get
      {
        return XLColor.FromHtml("#FFCCFF00");
      }
    }

    public static XLColor ElectricPurple
    {
      get
      {
        return XLColor.FromHtml("#FFBF00FF");
      }
    }

    public static XLColor ElectricUltramarine
    {
      get
      {
        return XLColor.FromHtml("#FF3F00FF");
      }
    }

    public static XLColor ElectricViolet
    {
      get
      {
        return XLColor.FromHtml("#FF8F00FF");
      }
    }

    public static XLColor Emerald
    {
      get
      {
        return XLColor.FromHtml("#FF50C878");
      }
    }

    public static XLColor EtonBlue
    {
      get
      {
        return XLColor.FromHtml("#FF96C8A2");
      }
    }

    public static XLColor Fallow
    {
      get
      {
        return XLColor.FromHtml("#FFC19A6B");
      }
    }

    public static XLColor FaluRed
    {
      get
      {
        return XLColor.FromHtml("#FF801818");
      }
    }

    public static XLColor Fandango
    {
      get
      {
        return XLColor.FromHtml("#FFB53389");
      }
    }

    public static XLColor FashionFuchsia
    {
      get
      {
        return XLColor.FromHtml("#FFF400A1");
      }
    }

    public static XLColor Fawn
    {
      get
      {
        return XLColor.FromHtml("#FFE5AA70");
      }
    }

    public static XLColor Feldgrau
    {
      get
      {
        return XLColor.FromHtml("#FF4D5D53");
      }
    }

    public static XLColor FernGreen
    {
      get
      {
        return XLColor.FromHtml("#FF4F7942");
      }
    }

    public static XLColor FerrariRed
    {
      get
      {
        return XLColor.FromHtml("#FFFF2800");
      }
    }

    public static XLColor FieldDrab
    {
      get
      {
        return XLColor.FromHtml("#FF6C541E");
      }
    }

    public static XLColor FireEngineRed
    {
      get
      {
        return XLColor.FromHtml("#FFCE2029");
      }
    }

    public static XLColor Flame
    {
      get
      {
        return XLColor.FromHtml("#FFE25822");
      }
    }

    public static XLColor FlamingoPink
    {
      get
      {
        return XLColor.FromHtml("#FFFC8EAC");
      }
    }

    public static XLColor Flavescent
    {
      get
      {
        return XLColor.FromHtml("#FFF7E98E");
      }
    }

    public static XLColor Flax
    {
      get
      {
        return XLColor.FromHtml("#FFEEDC82");
      }
    }

    public static XLColor FluorescentOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFFBF00");
      }
    }

    public static XLColor FluorescentYellow
    {
      get
      {
        return XLColor.FromHtml("#FFCCFF00");
      }
    }

    public static XLColor Folly
    {
      get
      {
        return XLColor.FromHtml("#FFFF004F");
      }
    }

    public static XLColor ForestGreenTraditional
    {
      get
      {
        return XLColor.FromHtml("#FF014421");
      }
    }

    public static XLColor FrenchBeige
    {
      get
      {
        return XLColor.FromHtml("#FFA67B5B");
      }
    }

    public static XLColor FrenchBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0072BB");
      }
    }

    public static XLColor FrenchLilac
    {
      get
      {
        return XLColor.FromHtml("#FF86608E");
      }
    }

    public static XLColor FrenchRose
    {
      get
      {
        return XLColor.FromHtml("#FFF64A8A");
      }
    }

    public static XLColor FuchsiaPink
    {
      get
      {
        return XLColor.FromHtml("#FFFF77FF");
      }
    }

    public static XLColor Fulvous
    {
      get
      {
        return XLColor.FromHtml("#FFE48400");
      }
    }

    public static XLColor FuzzyWuzzy
    {
      get
      {
        return XLColor.FromHtml("#FFCC6666");
      }
    }

    public static XLColor Gamboge
    {
      get
      {
        return XLColor.FromHtml("#FFE49B0F");
      }
    }

    public static XLColor Ginger
    {
      get
      {
        return XLColor.FromHtml("#FFF9F9FF");
      }
    }

    public static XLColor Glaucous
    {
      get
      {
        return XLColor.FromHtml("#FF6082B6");
      }
    }

    public static XLColor GoldenBrown
    {
      get
      {
        return XLColor.FromHtml("#FF996515");
      }
    }

    public static XLColor GoldenPoppy
    {
      get
      {
        return XLColor.FromHtml("#FFFCC200");
      }
    }

    public static XLColor GoldenYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFDF00");
      }
    }

    public static XLColor GoldMetallic
    {
      get
      {
        return XLColor.FromHtml("#FFD4AF37");
      }
    }

    public static XLColor GrannySmithApple
    {
      get
      {
        return XLColor.FromHtml("#FFA8E4A0");
      }
    }

    public static XLColor GrayAsparagus
    {
      get
      {
        return XLColor.FromHtml("#FF465945");
      }
    }

    public static XLColor GreenPigment
    {
      get
      {
        return XLColor.FromHtml("#FF00A550");
      }
    }

    public static XLColor GreenRyb
    {
      get
      {
        return XLColor.FromHtml("#FF66B032");
      }
    }

    public static XLColor Grullo
    {
      get
      {
        return XLColor.FromHtml("#FFA99A86");
      }
    }

    public static XLColor HalayaUbe
    {
      get
      {
        return XLColor.FromHtml("#FF663854");
      }
    }

    public static XLColor HanBlue
    {
      get
      {
        return XLColor.FromHtml("#FF446CCF");
      }
    }

    public static XLColor HanPurple
    {
      get
      {
        return XLColor.FromHtml("#FF5218FA");
      }
    }

    public static XLColor HansaYellow
    {
      get
      {
        return XLColor.FromHtml("#FFE9D66B");
      }
    }

    public static XLColor Harlequin
    {
      get
      {
        return XLColor.FromHtml("#FF3FFF00");
      }
    }

    public static XLColor HarvardCrimson
    {
      get
      {
        return XLColor.FromHtml("#FFC90016");
      }
    }

    public static XLColor HarvestGold
    {
      get
      {
        return XLColor.FromHtml("#FFDA9100");
      }
    }

    public static XLColor Heliotrope
    {
      get
      {
        return XLColor.FromHtml("#FFDF73FF");
      }
    }

    public static XLColor HollywoodCerise
    {
      get
      {
        return XLColor.FromHtml("#FFF400A1");
      }
    }

    public static XLColor HookersGreen
    {
      get
      {
        return XLColor.FromHtml("#FF007000");
      }
    }

    public static XLColor HotMagenta
    {
      get
      {
        return XLColor.FromHtml("#FFFF1DCE");
      }
    }

    public static XLColor HunterGreen
    {
      get
      {
        return XLColor.FromHtml("#FF355E3B");
      }
    }

    public static XLColor Iceberg
    {
      get
      {
        return XLColor.FromHtml("#FF71A6D2");
      }
    }

    public static XLColor Icterine
    {
      get
      {
        return XLColor.FromHtml("#FFFCF75E");
      }
    }

    public static XLColor Inchworm
    {
      get
      {
        return XLColor.FromHtml("#FFB2EC5D");
      }
    }

    public static XLColor IndiaGreen
    {
      get
      {
        return XLColor.FromHtml("#FF138808");
      }
    }

    public static XLColor IndianYellow
    {
      get
      {
        return XLColor.FromHtml("#FFE3A857");
      }
    }

    public static XLColor IndigoDye
    {
      get
      {
        return XLColor.FromHtml("#FF00416A");
      }
    }

    public static XLColor InternationalKleinBlue
    {
      get
      {
        return XLColor.FromHtml("#FF002FA7");
      }
    }

    public static XLColor InternationalOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFF4F00");
      }
    }

    public static XLColor Iris
    {
      get
      {
        return XLColor.FromHtml("#FF5A4FCF");
      }
    }

    public static XLColor Isabelline
    {
      get
      {
        return XLColor.FromHtml("#FFF4F0EC");
      }
    }

    public static XLColor IslamicGreen
    {
      get
      {
        return XLColor.FromHtml("#FF009000");
      }
    }

    public static XLColor Jade
    {
      get
      {
        return XLColor.FromHtml("#FF00A86B");
      }
    }

    public static XLColor Jasper
    {
      get
      {
        return XLColor.FromHtml("#FFD73B3E");
      }
    }

    public static XLColor JazzberryJam
    {
      get
      {
        return XLColor.FromHtml("#FFA50B5E");
      }
    }

    public static XLColor Jonquil
    {
      get
      {
        return XLColor.FromHtml("#FFFADA5E");
      }
    }

    public static XLColor JuneBud
    {
      get
      {
        return XLColor.FromHtml("#FFBDDA57");
      }
    }

    public static XLColor JungleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF29AB87");
      }
    }

    public static XLColor KellyGreen
    {
      get
      {
        return XLColor.FromHtml("#FF4CBB17");
      }
    }

    public static XLColor KhakiHtmlCssKhaki
    {
      get
      {
        return XLColor.FromHtml("#FFC3B091");
      }
    }

    public static XLColor LanguidLavender
    {
      get
      {
        return XLColor.FromHtml("#FFD6CADD");
      }
    }

    public static XLColor LapisLazuli
    {
      get
      {
        return XLColor.FromHtml("#FF26619C");
      }
    }

    public static XLColor LaSalleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF087830");
      }
    }

    public static XLColor LaserLemon
    {
      get
      {
        return XLColor.FromHtml("#FFFEFE22");
      }
    }

    public static XLColor Lava
    {
      get
      {
        return XLColor.FromHtml("#FFCF1020");
      }
    }

    public static XLColor LavenderBlue
    {
      get
      {
        return XLColor.FromHtml("#FFCCCCFF");
      }
    }

    public static XLColor LavenderFloral
    {
      get
      {
        return XLColor.FromHtml("#FFB57EDC");
      }
    }

    public static XLColor LavenderGray
    {
      get
      {
        return XLColor.FromHtml("#FFC4C3D0");
      }
    }

    public static XLColor LavenderIndigo
    {
      get
      {
        return XLColor.FromHtml("#FF9457EB");
      }
    }

    public static XLColor LavenderPink
    {
      get
      {
        return XLColor.FromHtml("#FFFBAED2");
      }
    }

    public static XLColor LavenderPurple
    {
      get
      {
        return XLColor.FromHtml("#FF967BB6");
      }
    }

    public static XLColor LavenderRose
    {
      get
      {
        return XLColor.FromHtml("#FFFBA0E3");
      }
    }

    public static XLColor Lemon
    {
      get
      {
        return XLColor.FromHtml("#FFFFF700");
      }
    }

    public static XLColor LightApricot
    {
      get
      {
        return XLColor.FromHtml("#FFFDD5B1");
      }
    }

    public static XLColor LightBrown
    {
      get
      {
        return XLColor.FromHtml("#FFB5651D");
      }
    }

    public static XLColor LightCarminePink
    {
      get
      {
        return XLColor.FromHtml("#FFE66771");
      }
    }

    public static XLColor LightCornflowerBlue
    {
      get
      {
        return XLColor.FromHtml("#FF93CCEA");
      }
    }

    public static XLColor LightFuchsiaPink
    {
      get
      {
        return XLColor.FromHtml("#FFF984EF");
      }
    }

    public static XLColor LightMauve
    {
      get
      {
        return XLColor.FromHtml("#FFDCD0FF");
      }
    }

    public static XLColor LightPastelPurple
    {
      get
      {
        return XLColor.FromHtml("#FFB19CD9");
      }
    }

    public static XLColor LightSalmonPink
    {
      get
      {
        return XLColor.FromHtml("#FFFF9999");
      }
    }

    public static XLColor LightTaupe
    {
      get
      {
        return XLColor.FromHtml("#FFB38B6D");
      }
    }

    public static XLColor LightThulianPink
    {
      get
      {
        return XLColor.FromHtml("#FFE68FAC");
      }
    }

    public static XLColor LightYellow1
    {
      get
      {
        return XLColor.FromHtml("#FFFFFFED");
      }
    }

    public static XLColor Lilac
    {
      get
      {
        return XLColor.FromHtml("#FFC8A2C8");
      }
    }

    public static XLColor LimeColorWheel
    {
      get
      {
        return XLColor.FromHtml("#FFBFFF00");
      }
    }

    public static XLColor LincolnGreen
    {
      get
      {
        return XLColor.FromHtml("#FF195905");
      }
    }

    public static XLColor Liver
    {
      get
      {
        return XLColor.FromHtml("#FF534B4F");
      }
    }

    public static XLColor Lust
    {
      get
      {
        return XLColor.FromHtml("#FFE62020");
      }
    }

    public static XLColor MacaroniAndCheese
    {
      get
      {
        return XLColor.FromHtml("#FFFFBD88");
      }
    }

    public static XLColor MagentaDye
    {
      get
      {
        return XLColor.FromHtml("#FFCA1F7B");
      }
    }

    public static XLColor MagentaProcess
    {
      get
      {
        return XLColor.FromHtml("#FFFF0090");
      }
    }

    public static XLColor MagicMint
    {
      get
      {
        return XLColor.FromHtml("#FFAAF0D1");
      }
    }

    public static XLColor Magnolia
    {
      get
      {
        return XLColor.FromHtml("#FFF8F4FF");
      }
    }

    public static XLColor Mahogany
    {
      get
      {
        return XLColor.FromHtml("#FFC04000");
      }
    }

    public static XLColor Maize
    {
      get
      {
        return XLColor.FromHtml("#FFFBEC5D");
      }
    }

    public static XLColor MajorelleBlue
    {
      get
      {
        return XLColor.FromHtml("#FF6050DC");
      }
    }

    public static XLColor Malachite
    {
      get
      {
        return XLColor.FromHtml("#FF0BDA51");
      }
    }

    public static XLColor Manatee
    {
      get
      {
        return XLColor.FromHtml("#FF979AAA");
      }
    }

    public static XLColor MangoTango
    {
      get
      {
        return XLColor.FromHtml("#FFFF8243");
      }
    }

    public static XLColor MaroonX11
    {
      get
      {
        return XLColor.FromHtml("#FFB03060");
      }
    }

    public static XLColor Mauve
    {
      get
      {
        return XLColor.FromHtml("#FFE0B0FF");
      }
    }

    public static XLColor Mauvelous
    {
      get
      {
        return XLColor.FromHtml("#FFEF98AA");
      }
    }

    public static XLColor MauveTaupe
    {
      get
      {
        return XLColor.FromHtml("#FF915F6D");
      }
    }

    public static XLColor MayaBlue
    {
      get
      {
        return XLColor.FromHtml("#FF73C2FB");
      }
    }

    public static XLColor MeatBrown
    {
      get
      {
        return XLColor.FromHtml("#FFE5B73B");
      }
    }

    public static XLColor MediumAquamarine1
    {
      get
      {
        return XLColor.FromHtml("#FF66DDAA");
      }
    }

    public static XLColor MediumCandyAppleRed
    {
      get
      {
        return XLColor.FromHtml("#FFE2062C");
      }
    }

    public static XLColor MediumCarmine
    {
      get
      {
        return XLColor.FromHtml("#FFAF4035");
      }
    }

    public static XLColor MediumChampagne
    {
      get
      {
        return XLColor.FromHtml("#FFF3E5AB");
      }
    }

    public static XLColor MediumElectricBlue
    {
      get
      {
        return XLColor.FromHtml("#FF035096");
      }
    }

    public static XLColor MediumJungleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF1C352D");
      }
    }

    public static XLColor MediumPersianBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0067A5");
      }
    }

    public static XLColor MediumRedViolet
    {
      get
      {
        return XLColor.FromHtml("#FFBB3385");
      }
    }

    public static XLColor MediumSpringBud
    {
      get
      {
        return XLColor.FromHtml("#FFC9DC87");
      }
    }

    public static XLColor MediumTaupe
    {
      get
      {
        return XLColor.FromHtml("#FF674C47");
      }
    }

    public static XLColor Melon
    {
      get
      {
        return XLColor.FromHtml("#FFFDBCB4");
      }
    }

    public static XLColor MidnightGreenEagleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF004953");
      }
    }

    public static XLColor MikadoYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFC40C");
      }
    }

    public static XLColor Mint
    {
      get
      {
        return XLColor.FromHtml("#FF3EB489");
      }
    }

    public static XLColor MintGreen
    {
      get
      {
        return XLColor.FromHtml("#FF98FF98");
      }
    }

    public static XLColor ModeBeige
    {
      get
      {
        return XLColor.FromHtml("#FF967117");
      }
    }

    public static XLColor MoonstoneBlue
    {
      get
      {
        return XLColor.FromHtml("#FF73A9C2");
      }
    }

    public static XLColor MordantRed19
    {
      get
      {
        return XLColor.FromHtml("#FFAE0C00");
      }
    }

    public static XLColor MossGreen
    {
      get
      {
        return XLColor.FromHtml("#FFADDFAD");
      }
    }

    public static XLColor MountainMeadow
    {
      get
      {
        return XLColor.FromHtml("#FF30BA8F");
      }
    }

    public static XLColor MountbattenPink
    {
      get
      {
        return XLColor.FromHtml("#FF997A8D");
      }
    }

    public static XLColor MsuGreen
    {
      get
      {
        return XLColor.FromHtml("#FF18453B");
      }
    }

    public static XLColor Mulberry
    {
      get
      {
        return XLColor.FromHtml("#FFC54B8C");
      }
    }

    public static XLColor Mustard
    {
      get
      {
        return XLColor.FromHtml("#FFFFDB58");
      }
    }

    public static XLColor Myrtle
    {
      get
      {
        return XLColor.FromHtml("#FF21421E");
      }
    }

    public static XLColor NadeshikoPink
    {
      get
      {
        return XLColor.FromHtml("#FFF6ADC6");
      }
    }

    public static XLColor NapierGreen
    {
      get
      {
        return XLColor.FromHtml("#FF2A8000");
      }
    }

    public static XLColor NaplesYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFADA5E");
      }
    }

    public static XLColor NeonCarrot
    {
      get
      {
        return XLColor.FromHtml("#FFFFA343");
      }
    }

    public static XLColor NeonFuchsia
    {
      get
      {
        return XLColor.FromHtml("#FFFE59C2");
      }
    }

    public static XLColor NeonGreen
    {
      get
      {
        return XLColor.FromHtml("#FF39FF14");
      }
    }

    public static XLColor NonPhotoBlue
    {
      get
      {
        return XLColor.FromHtml("#FFA4DDED");
      }
    }

    public static XLColor OceanBoatBlue
    {
      get
      {
        return XLColor.FromHtml("#FFCC7422");
      }
    }

    public static XLColor Ochre
    {
      get
      {
        return XLColor.FromHtml("#FFCC7722");
      }
    }

    public static XLColor OldGold
    {
      get
      {
        return XLColor.FromHtml("#FFCFB53B");
      }
    }

    public static XLColor OldLavender
    {
      get
      {
        return XLColor.FromHtml("#FF796878");
      }
    }

    public static XLColor OldMauve
    {
      get
      {
        return XLColor.FromHtml("#FF673147");
      }
    }

    public static XLColor OldRose
    {
      get
      {
        return XLColor.FromHtml("#FFC08081");
      }
    }

    public static XLColor OliveDrab7
    {
      get
      {
        return XLColor.FromHtml("#FF3C341F");
      }
    }

    public static XLColor Olivine
    {
      get
      {
        return XLColor.FromHtml("#FF9AB973");
      }
    }

    public static XLColor Onyx
    {
      get
      {
        return XLColor.FromHtml("#FF0F0F0F");
      }
    }

    public static XLColor OperaMauve
    {
      get
      {
        return XLColor.FromHtml("#FFB784A7");
      }
    }

    public static XLColor OrangeColorWheel
    {
      get
      {
        return XLColor.FromHtml("#FFFF7F00");
      }
    }

    public static XLColor OrangePeel
    {
      get
      {
        return XLColor.FromHtml("#FFFF9F00");
      }
    }

    public static XLColor OrangeRyb
    {
      get
      {
        return XLColor.FromHtml("#FFFB9902");
      }
    }

    public static XLColor OtterBrown
    {
      get
      {
        return XLColor.FromHtml("#FF654321");
      }
    }

    public static XLColor OuCrimsonRed
    {
      get
      {
        return XLColor.FromHtml("#FF990000");
      }
    }

    public static XLColor OuterSpace
    {
      get
      {
        return XLColor.FromHtml("#FF414A4C");
      }
    }

    public static XLColor OutrageousOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFF6E4A");
      }
    }

    public static XLColor OxfordBlue
    {
      get
      {
        return XLColor.FromHtml("#FF002147");
      }
    }

    public static XLColor PakistanGreen
    {
      get
      {
        return XLColor.FromHtml("#FF00421B");
      }
    }

    public static XLColor PalatinateBlue
    {
      get
      {
        return XLColor.FromHtml("#FF273BE2");
      }
    }

    public static XLColor PalatinatePurple
    {
      get
      {
        return XLColor.FromHtml("#FF682860");
      }
    }

    public static XLColor PaleAqua
    {
      get
      {
        return XLColor.FromHtml("#FFBCD4E6");
      }
    }

    public static XLColor PaleBrown
    {
      get
      {
        return XLColor.FromHtml("#FF987654");
      }
    }

    public static XLColor PaleCarmine
    {
      get
      {
        return XLColor.FromHtml("#FFAF4035");
      }
    }

    public static XLColor PaleCerulean
    {
      get
      {
        return XLColor.FromHtml("#FF9BC4E2");
      }
    }

    public static XLColor PaleChestnut
    {
      get
      {
        return XLColor.FromHtml("#FFDDADAF");
      }
    }

    public static XLColor PaleCopper
    {
      get
      {
        return XLColor.FromHtml("#FFDA8A67");
      }
    }

    public static XLColor PaleCornflowerBlue
    {
      get
      {
        return XLColor.FromHtml("#FFABCDEF");
      }
    }

    public static XLColor PaleGold
    {
      get
      {
        return XLColor.FromHtml("#FFE6BE8A");
      }
    }

    public static XLColor PaleMagenta
    {
      get
      {
        return XLColor.FromHtml("#FFF984E5");
      }
    }

    public static XLColor PalePink
    {
      get
      {
        return XLColor.FromHtml("#FFFADADD");
      }
    }

    public static XLColor PaleRobinEggBlue
    {
      get
      {
        return XLColor.FromHtml("#FF96DED1");
      }
    }

    public static XLColor PaleSilver
    {
      get
      {
        return XLColor.FromHtml("#FFC9C0BB");
      }
    }

    public static XLColor PaleSpringBud
    {
      get
      {
        return XLColor.FromHtml("#FFECEBBD");
      }
    }

    public static XLColor PaleTaupe
    {
      get
      {
        return XLColor.FromHtml("#FFBC987E");
      }
    }

    public static XLColor PansyPurple
    {
      get
      {
        return XLColor.FromHtml("#FF78184A");
      }
    }

    public static XLColor ParisGreen
    {
      get
      {
        return XLColor.FromHtml("#FF50C878");
      }
    }

    public static XLColor PastelBlue
    {
      get
      {
        return XLColor.FromHtml("#FFAEC6CF");
      }
    }

    public static XLColor PastelBrown
    {
      get
      {
        return XLColor.FromHtml("#FF836953");
      }
    }

    public static XLColor PastelGray
    {
      get
      {
        return XLColor.FromHtml("#FFCFCFC4");
      }
    }

    public static XLColor PastelGreen
    {
      get
      {
        return XLColor.FromHtml("#FF77DD77");
      }
    }

    public static XLColor PastelMagenta
    {
      get
      {
        return XLColor.FromHtml("#FFF49AC2");
      }
    }

    public static XLColor PastelOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFFB347");
      }
    }

    public static XLColor PastelPink
    {
      get
      {
        return XLColor.FromHtml("#FFFFD1DC");
      }
    }

    public static XLColor PastelPurple
    {
      get
      {
        return XLColor.FromHtml("#FFB39EB5");
      }
    }

    public static XLColor PastelRed
    {
      get
      {
        return XLColor.FromHtml("#FFFF6961");
      }
    }

    public static XLColor PastelViolet
    {
      get
      {
        return XLColor.FromHtml("#FFCB99C9");
      }
    }

    public static XLColor PastelYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFDFD96");
      }
    }

    public static XLColor PaynesGrey
    {
      get
      {
        return XLColor.FromHtml("#FF40404F");
      }
    }

    public static XLColor Peach
    {
      get
      {
        return XLColor.FromHtml("#FFFFE5B4");
      }
    }

    public static XLColor PeachOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFFCC99");
      }
    }

    public static XLColor PeachYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFADFAD");
      }
    }

    public static XLColor Pear
    {
      get
      {
        return XLColor.FromHtml("#FFD1E231");
      }
    }

    public static XLColor Pearl
    {
      get
      {
        return XLColor.FromHtml("#FFF0EAD6");
      }
    }

    public static XLColor Peridot
    {
      get
      {
        return XLColor.FromHtml("#FFE6E200");
      }
    }

    public static XLColor Periwinkle
    {
      get
      {
        return XLColor.FromHtml("#FFCCCCFF");
      }
    }

    public static XLColor PersianBlue
    {
      get
      {
        return XLColor.FromHtml("#FF1C39BB");
      }
    }

    public static XLColor PersianGreen
    {
      get
      {
        return XLColor.FromHtml("#FF00A693");
      }
    }

    public static XLColor PersianIndigo
    {
      get
      {
        return XLColor.FromHtml("#FF32127A");
      }
    }

    public static XLColor PersianOrange
    {
      get
      {
        return XLColor.FromHtml("#FFD99058");
      }
    }

    public static XLColor PersianPink
    {
      get
      {
        return XLColor.FromHtml("#FFF77FBE");
      }
    }

    public static XLColor PersianPlum
    {
      get
      {
        return XLColor.FromHtml("#FF701C1C");
      }
    }

    public static XLColor PersianRed
    {
      get
      {
        return XLColor.FromHtml("#FFCC3333");
      }
    }

    public static XLColor PersianRose
    {
      get
      {
        return XLColor.FromHtml("#FFFE28A2");
      }
    }

    public static XLColor Persimmon
    {
      get
      {
        return XLColor.FromHtml("#FFEC5800");
      }
    }

    public static XLColor Phlox
    {
      get
      {
        return XLColor.FromHtml("#FFDF00FF");
      }
    }

    public static XLColor PhthaloBlue
    {
      get
      {
        return XLColor.FromHtml("#FF000F89");
      }
    }

    public static XLColor PhthaloGreen
    {
      get
      {
        return XLColor.FromHtml("#FF123524");
      }
    }

    public static XLColor PiggyPink
    {
      get
      {
        return XLColor.FromHtml("#FFFDDDE6");
      }
    }

    public static XLColor PineGreen
    {
      get
      {
        return XLColor.FromHtml("#FF01796F");
      }
    }

    public static XLColor PinkOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFF9966");
      }
    }

    public static XLColor PinkPearl
    {
      get
      {
        return XLColor.FromHtml("#FFE7ACCF");
      }
    }

    public static XLColor PinkSherbet
    {
      get
      {
        return XLColor.FromHtml("#FFF78FA7");
      }
    }

    public static XLColor Pistachio
    {
      get
      {
        return XLColor.FromHtml("#FF93C572");
      }
    }

    public static XLColor Platinum
    {
      get
      {
        return XLColor.FromHtml("#FFE5E4E2");
      }
    }

    public static XLColor PlumTraditional
    {
      get
      {
        return XLColor.FromHtml("#FF8E4585");
      }
    }

    public static XLColor PortlandOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFF5A36");
      }
    }

    public static XLColor PrincetonOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFF8F00");
      }
    }

    public static XLColor Prune
    {
      get
      {
        return XLColor.FromHtml("#FF701C1C");
      }
    }

    public static XLColor PrussianBlue
    {
      get
      {
        return XLColor.FromHtml("#FF003153");
      }
    }

    public static XLColor PsychedelicPurple
    {
      get
      {
        return XLColor.FromHtml("#FFDF00FF");
      }
    }

    public static XLColor Puce
    {
      get
      {
        return XLColor.FromHtml("#FFCC8899");
      }
    }

    public static XLColor Pumpkin
    {
      get
      {
        return XLColor.FromHtml("#FFFF7518");
      }
    }

    public static XLColor PurpleHeart
    {
      get
      {
        return XLColor.FromHtml("#FF69359C");
      }
    }

    public static XLColor PurpleMountainMajesty
    {
      get
      {
        return XLColor.FromHtml("#FF9678B6");
      }
    }

    public static XLColor PurpleMunsell
    {
      get
      {
        return XLColor.FromHtml("#FF9F00C5");
      }
    }

    public static XLColor PurplePizzazz
    {
      get
      {
        return XLColor.FromHtml("#FFFE4EDA");
      }
    }

    public static XLColor PurpleTaupe
    {
      get
      {
        return XLColor.FromHtml("#FF50404D");
      }
    }

    public static XLColor PurpleX11
    {
      get
      {
        return XLColor.FromHtml("#FFA020F0");
      }
    }

    public static XLColor RadicalRed
    {
      get
      {
        return XLColor.FromHtml("#FFFF355E");
      }
    }

    public static XLColor Raspberry
    {
      get
      {
        return XLColor.FromHtml("#FFE30B5D");
      }
    }

    public static XLColor RaspberryGlace
    {
      get
      {
        return XLColor.FromHtml("#FF915F6D");
      }
    }

    public static XLColor RaspberryPink
    {
      get
      {
        return XLColor.FromHtml("#FFE25098");
      }
    }

    public static XLColor RaspberryRose
    {
      get
      {
        return XLColor.FromHtml("#FFB3446C");
      }
    }

    public static XLColor RawUmber
    {
      get
      {
        return XLColor.FromHtml("#FF826644");
      }
    }

    public static XLColor RazzleDazzleRose
    {
      get
      {
        return XLColor.FromHtml("#FFFF33CC");
      }
    }

    public static XLColor Razzmatazz
    {
      get
      {
        return XLColor.FromHtml("#FFE3256B");
      }
    }

    public static XLColor RedMunsell
    {
      get
      {
        return XLColor.FromHtml("#FFF2003C");
      }
    }

    public static XLColor RedNcs
    {
      get
      {
        return XLColor.FromHtml("#FFC40233");
      }
    }

    public static XLColor RedPigment
    {
      get
      {
        return XLColor.FromHtml("#FFED1C24");
      }
    }

    public static XLColor RedRyb
    {
      get
      {
        return XLColor.FromHtml("#FFFE2712");
      }
    }

    public static XLColor Redwood
    {
      get
      {
        return XLColor.FromHtml("#FFAB4E52");
      }
    }

    public static XLColor Regalia
    {
      get
      {
        return XLColor.FromHtml("#FF522D80");
      }
    }

    public static XLColor RichBlack
    {
      get
      {
        return XLColor.FromHtml("#FF004040");
      }
    }

    public static XLColor RichBrilliantLavender
    {
      get
      {
        return XLColor.FromHtml("#FFF1A7FE");
      }
    }

    public static XLColor RichCarmine
    {
      get
      {
        return XLColor.FromHtml("#FFD70040");
      }
    }

    public static XLColor RichElectricBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0892D0");
      }
    }

    public static XLColor RichLavender
    {
      get
      {
        return XLColor.FromHtml("#FFA76BCF");
      }
    }

    public static XLColor RichLilac
    {
      get
      {
        return XLColor.FromHtml("#FFB666D2");
      }
    }

    public static XLColor RichMaroon
    {
      get
      {
        return XLColor.FromHtml("#FFB03060");
      }
    }

    public static XLColor RifleGreen
    {
      get
      {
        return XLColor.FromHtml("#FF414833");
      }
    }

    public static XLColor RobinEggBlue
    {
      get
      {
        return XLColor.FromHtml("#FF00CCCC");
      }
    }

    public static XLColor Rose
    {
      get
      {
        return XLColor.FromHtml("#FFFF007F");
      }
    }

    public static XLColor RoseBonbon
    {
      get
      {
        return XLColor.FromHtml("#FFF9429E");
      }
    }

    public static XLColor RoseEbony
    {
      get
      {
        return XLColor.FromHtml("#FF674846");
      }
    }

    public static XLColor RoseGold
    {
      get
      {
        return XLColor.FromHtml("#FFB76E79");
      }
    }

    public static XLColor RoseMadder
    {
      get
      {
        return XLColor.FromHtml("#FFE32636");
      }
    }

    public static XLColor RosePink
    {
      get
      {
        return XLColor.FromHtml("#FFFF66CC");
      }
    }

    public static XLColor RoseQuartz
    {
      get
      {
        return XLColor.FromHtml("#FFAA98A9");
      }
    }

    public static XLColor RoseTaupe
    {
      get
      {
        return XLColor.FromHtml("#FF905D5D");
      }
    }

    public static XLColor RoseVale
    {
      get
      {
        return XLColor.FromHtml("#FFAB4E52");
      }
    }

    public static XLColor Rosewood
    {
      get
      {
        return XLColor.FromHtml("#FF65000B");
      }
    }

    public static XLColor RossoCorsa
    {
      get
      {
        return XLColor.FromHtml("#FFD40000");
      }
    }

    public static XLColor RoyalAzure
    {
      get
      {
        return XLColor.FromHtml("#FF0038A8");
      }
    }

    public static XLColor RoyalBlueTraditional
    {
      get
      {
        return XLColor.FromHtml("#FF002366");
      }
    }

    public static XLColor RoyalFuchsia
    {
      get
      {
        return XLColor.FromHtml("#FFCA2C92");
      }
    }

    public static XLColor RoyalPurple
    {
      get
      {
        return XLColor.FromHtml("#FF7851A9");
      }
    }

    public static XLColor Ruby
    {
      get
      {
        return XLColor.FromHtml("#FFE0115F");
      }
    }

    public static XLColor Ruddy
    {
      get
      {
        return XLColor.FromHtml("#FFFF0028");
      }
    }

    public static XLColor RuddyBrown
    {
      get
      {
        return XLColor.FromHtml("#FFBB6528");
      }
    }

    public static XLColor RuddyPink
    {
      get
      {
        return XLColor.FromHtml("#FFE18E96");
      }
    }

    public static XLColor Rufous
    {
      get
      {
        return XLColor.FromHtml("#FFA81C07");
      }
    }

    public static XLColor Russet
    {
      get
      {
        return XLColor.FromHtml("#FF80461B");
      }
    }

    public static XLColor Rust
    {
      get
      {
        return XLColor.FromHtml("#FFB7410E");
      }
    }

    public static XLColor SacramentoStateGreen
    {
      get
      {
        return XLColor.FromHtml("#FF00563F");
      }
    }

    public static XLColor SafetyOrangeBlazeOrange
    {
      get
      {
        return XLColor.FromHtml("#FFFF6700");
      }
    }

    public static XLColor Saffron
    {
      get
      {
        return XLColor.FromHtml("#FFF4C430");
      }
    }

    public static XLColor Salmon1
    {
      get
      {
        return XLColor.FromHtml("#FFFF8C69");
      }
    }

    public static XLColor SalmonPink
    {
      get
      {
        return XLColor.FromHtml("#FFFF91A4");
      }
    }

    public static XLColor Sand
    {
      get
      {
        return XLColor.FromHtml("#FFC2B280");
      }
    }

    public static XLColor SandDune
    {
      get
      {
        return XLColor.FromHtml("#FF967117");
      }
    }

    public static XLColor Sandstorm
    {
      get
      {
        return XLColor.FromHtml("#FFECD540");
      }
    }

    public static XLColor SandyTaupe
    {
      get
      {
        return XLColor.FromHtml("#FF967117");
      }
    }

    public static XLColor Sangria
    {
      get
      {
        return XLColor.FromHtml("#FF92000A");
      }
    }

    public static XLColor SapGreen
    {
      get
      {
        return XLColor.FromHtml("#FF507D2A");
      }
    }

    public static XLColor Sapphire
    {
      get
      {
        return XLColor.FromHtml("#FF082567");
      }
    }

    public static XLColor SatinSheenGold
    {
      get
      {
        return XLColor.FromHtml("#FFCBA135");
      }
    }

    public static XLColor Scarlet
    {
      get
      {
        return XLColor.FromHtml("#FFFF2000");
      }
    }

    public static XLColor SchoolBusYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFD800");
      }
    }

    public static XLColor ScreaminGreen
    {
      get
      {
        return XLColor.FromHtml("#FF76FF7A");
      }
    }

    public static XLColor SealBrown
    {
      get
      {
        return XLColor.FromHtml("#FF321414");
      }
    }

    public static XLColor SelectiveYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFBA00");
      }
    }

    public static XLColor Sepia
    {
      get
      {
        return XLColor.FromHtml("#FF704214");
      }
    }

    public static XLColor Shadow
    {
      get
      {
        return XLColor.FromHtml("#FF8A795D");
      }
    }

    public static XLColor ShamrockGreen
    {
      get
      {
        return XLColor.FromHtml("#FF009E60");
      }
    }

    public static XLColor ShockingPink
    {
      get
      {
        return XLColor.FromHtml("#FFFC0FC0");
      }
    }

    public static XLColor Sienna1
    {
      get
      {
        return XLColor.FromHtml("#FF882D17");
      }
    }

    public static XLColor Sinopia
    {
      get
      {
        return XLColor.FromHtml("#FFCB410B");
      }
    }

    public static XLColor Skobeloff
    {
      get
      {
        return XLColor.FromHtml("#FF007474");
      }
    }

    public static XLColor SkyMagenta
    {
      get
      {
        return XLColor.FromHtml("#FFCF71AF");
      }
    }

    public static XLColor SmaltDarkPowderBlue
    {
      get
      {
        return XLColor.FromHtml("#FF003399");
      }
    }

    public static XLColor SmokeyTopaz
    {
      get
      {
        return XLColor.FromHtml("#FF933D41");
      }
    }

    public static XLColor SmokyBlack
    {
      get
      {
        return XLColor.FromHtml("#FF100C08");
      }
    }

    public static XLColor SpiroDiscoBall
    {
      get
      {
        return XLColor.FromHtml("#FF0FC0FC");
      }
    }

    public static XLColor SplashedWhite
    {
      get
      {
        return XLColor.FromHtml("#FFFEFDFF");
      }
    }

    public static XLColor SpringBud
    {
      get
      {
        return XLColor.FromHtml("#FFA7FC00");
      }
    }

    public static XLColor StPatricksBlue
    {
      get
      {
        return XLColor.FromHtml("#FF23297A");
      }
    }

    public static XLColor StilDeGrainYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFADA5E");
      }
    }

    public static XLColor Straw
    {
      get
      {
        return XLColor.FromHtml("#FFE4D96F");
      }
    }

    public static XLColor Sunglow
    {
      get
      {
        return XLColor.FromHtml("#FFFFCC33");
      }
    }

    public static XLColor Sunset
    {
      get
      {
        return XLColor.FromHtml("#FFFAD6A5");
      }
    }

    public static XLColor Tangelo
    {
      get
      {
        return XLColor.FromHtml("#FFF94D00");
      }
    }

    public static XLColor Tangerine
    {
      get
      {
        return XLColor.FromHtml("#FFF28500");
      }
    }

    public static XLColor TangerineYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFCC00");
      }
    }

    public static XLColor Taupe
    {
      get
      {
        return XLColor.FromHtml("#FF483C32");
      }
    }

    public static XLColor TaupeGray
    {
      get
      {
        return XLColor.FromHtml("#FF8B8589");
      }
    }

    public static XLColor TeaGreen
    {
      get
      {
        return XLColor.FromHtml("#FFD0F0C0");
      }
    }

    public static XLColor TealBlue
    {
      get
      {
        return XLColor.FromHtml("#FF367588");
      }
    }

    public static XLColor TealGreen
    {
      get
      {
        return XLColor.FromHtml("#FF006D5B");
      }
    }

    public static XLColor TeaRoseOrange
    {
      get
      {
        return XLColor.FromHtml("#FFF88379");
      }
    }

    public static XLColor TeaRoseRose
    {
      get
      {
        return XLColor.FromHtml("#FFF4C2C2");
      }
    }

    public static XLColor TennéTawny
    {
      get
      {
        return XLColor.FromHtml("#FFCD5700");
      }
    }

    public static XLColor TerraCotta
    {
      get
      {
        return XLColor.FromHtml("#FFE2725B");
      }
    }

    public static XLColor ThulianPink
    {
      get
      {
        return XLColor.FromHtml("#FFDE6FA1");
      }
    }

    public static XLColor TickleMePink
    {
      get
      {
        return XLColor.FromHtml("#FFFC89AC");
      }
    }

    public static XLColor TiffanyBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0ABAB5");
      }
    }

    public static XLColor TigersEye
    {
      get
      {
        return XLColor.FromHtml("#FFE08D3C");
      }
    }

    public static XLColor Timberwolf
    {
      get
      {
        return XLColor.FromHtml("#FFDBD7D2");
      }
    }

    public static XLColor TitaniumYellow
    {
      get
      {
        return XLColor.FromHtml("#FFEEE600");
      }
    }

    public static XLColor Toolbox
    {
      get
      {
        return XLColor.FromHtml("#FF746CC0");
      }
    }

    public static XLColor TractorRed
    {
      get
      {
        return XLColor.FromHtml("#FFFD0E35");
      }
    }

    public static XLColor TropicalRainForest
    {
      get
      {
        return XLColor.FromHtml("#FF00755E");
      }
    }

    public static XLColor TuftsBlue
    {
      get
      {
        return XLColor.FromHtml("#FF417DC1");
      }
    }

    public static XLColor Tumbleweed
    {
      get
      {
        return XLColor.FromHtml("#FFDEAA88");
      }
    }

    public static XLColor TurkishRose
    {
      get
      {
        return XLColor.FromHtml("#FFB57281");
      }
    }

    public static XLColor Turquoise1
    {
      get
      {
        return XLColor.FromHtml("#FF30D5C8");
      }
    }

    public static XLColor TurquoiseBlue
    {
      get
      {
        return XLColor.FromHtml("#FF00FFEF");
      }
    }

    public static XLColor TurquoiseGreen
    {
      get
      {
        return XLColor.FromHtml("#FFA0D6B4");
      }
    }

    public static XLColor TuscanRed
    {
      get
      {
        return XLColor.FromHtml("#FF823535");
      }
    }

    public static XLColor TwilightLavender
    {
      get
      {
        return XLColor.FromHtml("#FF8A496B");
      }
    }

    public static XLColor TyrianPurple
    {
      get
      {
        return XLColor.FromHtml("#FF66023C");
      }
    }

    public static XLColor UaBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0033AA");
      }
    }

    public static XLColor UaRed
    {
      get
      {
        return XLColor.FromHtml("#FFD9004C");
      }
    }

    public static XLColor Ube
    {
      get
      {
        return XLColor.FromHtml("#FF8878C3");
      }
    }

    public static XLColor UclaBlue
    {
      get
      {
        return XLColor.FromHtml("#FF536895");
      }
    }

    public static XLColor UclaGold
    {
      get
      {
        return XLColor.FromHtml("#FFFFB300");
      }
    }

    public static XLColor UfoGreen
    {
      get
      {
        return XLColor.FromHtml("#FF3CD070");
      }
    }

    public static XLColor Ultramarine
    {
      get
      {
        return XLColor.FromHtml("#FF120A8F");
      }
    }

    public static XLColor UltramarineBlue
    {
      get
      {
        return XLColor.FromHtml("#FF4166F5");
      }
    }

    public static XLColor UltraPink
    {
      get
      {
        return XLColor.FromHtml("#FFFF6FFF");
      }
    }

    public static XLColor Umber
    {
      get
      {
        return XLColor.FromHtml("#FF635147");
      }
    }

    public static XLColor UnitedNationsBlue
    {
      get
      {
        return XLColor.FromHtml("#FF5B92E5");
      }
    }

    public static XLColor UnmellowYellow
    {
      get
      {
        return XLColor.FromHtml("#FFFFFF66");
      }
    }

    public static XLColor UpForestGreen
    {
      get
      {
        return XLColor.FromHtml("#FF014421");
      }
    }

    public static XLColor UpMaroon
    {
      get
      {
        return XLColor.FromHtml("#FF7B1113");
      }
    }

    public static XLColor UpsdellRed
    {
      get
      {
        return XLColor.FromHtml("#FFAE2029");
      }
    }

    public static XLColor Urobilin
    {
      get
      {
        return XLColor.FromHtml("#FFE1AD21");
      }
    }

    public static XLColor UscCardinal
    {
      get
      {
        return XLColor.FromHtml("#FF990000");
      }
    }

    public static XLColor UscGold
    {
      get
      {
        return XLColor.FromHtml("#FFFFCC00");
      }
    }

    public static XLColor UtahCrimson
    {
      get
      {
        return XLColor.FromHtml("#FFD3003F");
      }
    }

    public static XLColor Vanilla
    {
      get
      {
        return XLColor.FromHtml("#FFF3E5AB");
      }
    }

    public static XLColor VegasGold
    {
      get
      {
        return XLColor.FromHtml("#FFC5B358");
      }
    }

    public static XLColor VenetianRed
    {
      get
      {
        return XLColor.FromHtml("#FFC80815");
      }
    }

    public static XLColor Verdigris
    {
      get
      {
        return XLColor.FromHtml("#FF43B3AE");
      }
    }

    public static XLColor Vermilion
    {
      get
      {
        return XLColor.FromHtml("#FFE34234");
      }
    }

    public static XLColor Veronica
    {
      get
      {
        return XLColor.FromHtml("#FFA020F0");
      }
    }

    public static XLColor Violet1
    {
      get
      {
        return XLColor.FromHtml("#FF8F00FF");
      }
    }

    public static XLColor VioletColorWheel
    {
      get
      {
        return XLColor.FromHtml("#FF7F00FF");
      }
    }

    public static XLColor VioletRyb
    {
      get
      {
        return XLColor.FromHtml("#FF8601AF");
      }
    }

    public static XLColor Viridian
    {
      get
      {
        return XLColor.FromHtml("#FF40826D");
      }
    }

    public static XLColor VividAuburn
    {
      get
      {
        return XLColor.FromHtml("#FF922724");
      }
    }

    public static XLColor VividBurgundy
    {
      get
      {
        return XLColor.FromHtml("#FF9F1D35");
      }
    }

    public static XLColor VividCerise
    {
      get
      {
        return XLColor.FromHtml("#FFDA1D81");
      }
    }

    public static XLColor VividTangerine
    {
      get
      {
        return XLColor.FromHtml("#FFFFA089");
      }
    }

    public static XLColor VividViolet
    {
      get
      {
        return XLColor.FromHtml("#FF9F00FF");
      }
    }

    public static XLColor WarmBlack
    {
      get
      {
        return XLColor.FromHtml("#FF004242");
      }
    }

    public static XLColor Wenge
    {
      get
      {
        return XLColor.FromHtml("#FF645452");
      }
    }

    public static XLColor WildBlueYonder
    {
      get
      {
        return XLColor.FromHtml("#FFA2ADD0");
      }
    }

    public static XLColor WildStrawberry
    {
      get
      {
        return XLColor.FromHtml("#FFFF43A4");
      }
    }

    public static XLColor WildWatermelon
    {
      get
      {
        return XLColor.FromHtml("#FFFC6C85");
      }
    }

    public static XLColor Wisteria
    {
      get
      {
        return XLColor.FromHtml("#FFC9A0DC");
      }
    }

    public static XLColor Xanadu
    {
      get
      {
        return XLColor.FromHtml("#FF738678");
      }
    }

    public static XLColor YaleBlue
    {
      get
      {
        return XLColor.FromHtml("#FF0F4D92");
      }
    }

    public static XLColor YellowMunsell
    {
      get
      {
        return XLColor.FromHtml("#FFEFCC00");
      }
    }

    public static XLColor YellowNcs
    {
      get
      {
        return XLColor.FromHtml("#FFFFD300");
      }
    }

    public static XLColor YellowProcess
    {
      get
      {
        return XLColor.FromHtml("#FFFFEF00");
      }
    }

    public static XLColor YellowRyb
    {
      get
      {
        return XLColor.FromHtml("#FFFEFE33");
      }
    }

    public static XLColor Zaffre
    {
      get
      {
        return XLColor.FromHtml("#FF0014A8");
      }
    }

    public static XLColor ZinnwalditeBrown
    {
      get
      {
        return XLColor.FromHtml("#FF2C1608");
      }
    }

    public static XLColor Transparent
    {
      get
      {
        return XLColor.FromColor(Color.Transparent);
      }
    }

    public bool HasValue { get; private set; }

    public XLColorType ColorType
    {
      get
      {
        return this._colorType;
      }
    }

    public Color Color
    {
      get
      {
        if (this._colorType == XLColorType.Theme)
          throw new Exception("Cannot convert theme color to Color.");
        if (this._colorType == XLColorType.Indexed)
          return XLColor.IndexedColors[this._indexed].Color;
        return this._color;
      }
    }

    public int Indexed
    {
      get
      {
        if (this.ColorType == XLColorType.Theme)
          throw new Exception("Cannot convert theme color to indexed color.");
        if (this.ColorType == XLColorType.Indexed)
          return this._indexed;
        throw new Exception("Cannot convert Color to indexed color.");
      }
    }

    public XLThemeColor ThemeColor
    {
      get
      {
        if (this.ColorType == XLColorType.Theme)
          return this._themeColor;
        if (this.ColorType == XLColorType.Indexed)
          throw new Exception("Cannot convert indexed color to theme color.");
        throw new Exception("Cannot convert Color to theme color.");
      }
    }

    public double ThemeTint
    {
      get
      {
        if (this.ColorType == XLColorType.Theme)
          return this._themeTint;
        if (this.ColorType == XLColorType.Indexed)
          throw new Exception("Cannot extract theme tint from an indexed color.");
        return (double) this._color.A / (double) byte.MaxValue;
      }
    }

    public bool Equals(XLColor other)
    {
      if (this._colorType != other._colorType)
        return false;
      if (this._colorType == XLColorType.Color)
        return this._color == other._color;
      if (this._colorType != XLColorType.Theme)
        return this._indexed == other._indexed;
      if (this._themeColor == other._themeColor)
        return Math.Abs(this._themeTint - other._themeTint) < 1E-10;
      return false;
    }

    public override bool Equals(object obj)
    {
      return this.Equals((XLColor) obj);
    }

    public override int GetHashCode()
    {
      if (this._hashCode == 0)
        this._hashCode = this._colorType != XLColorType.Color ? (this._colorType != XLColorType.Theme ? this._indexed : this._themeColor.GetHashCode() ^ this._themeTint.GetHashCode()) : this._color.GetHashCode();
      return this._hashCode;
    }

    public override string ToString()
    {
      if (this._colorType == XLColorType.Color)
        return this.Color.ToHex();
      if (this._colorType == XLColorType.Theme)
        return string.Format("Color Theme: {0}, Tint: {1}", (object) this._themeColor.ToString(), (object) this._themeTint.ToString());
      return "Color Index: " + (object) this._indexed;
    }

    public static bool operator ==(XLColor left, XLColor right)
    {
      if (object.ReferenceEquals((object) left, (object) right))
        return true;
      if ((object) left == null || (object) right == null)
        return false;
      return left.Equals(right);
    }

    public static bool operator !=(XLColor left, XLColor right)
    {
      return !(left == right);
    }

    private XLColor(XLColor defaultColor)
    {
      XLColor xlColor = defaultColor;
      if (xlColor._colorType == XLColorType.Color)
        this._color = xlColor._color;
      else if (xlColor._colorType == XLColorType.Theme)
      {
        this._themeColor = xlColor._themeColor;
        this._themeTint = xlColor._themeTint;
      }
      else
        this._indexed = xlColor._indexed;
      this.HasValue = true;
      this._hashCode = xlColor._hashCode;
      this._colorType = xlColor._colorType;
    }

    private XLColor()
    {
      this.HasValue = false;
      this._hashCode = 0;
    }

    private XLColor(Color color)
    {
      this._color = color;
      this._hashCode = 13 ^ color.ToArgb();
      this.HasValue = true;
      this._colorType = XLColorType.Color;
    }

    private XLColor(int index)
    {
      this._indexed = index;
      this._hashCode = 11 ^ this._indexed;
      this.HasValue = true;
      this._colorType = XLColorType.Indexed;
    }

    private XLColor(XLThemeColor themeColor)
    {
      this._themeColor = themeColor;
      this._themeTint = 0.0;
      this._hashCode = 7 ^ this._themeColor.GetHashCode() ^ this._themeTint.GetHashCode();
      this.HasValue = true;
      this._colorType = XLColorType.Theme;
    }

    private XLColor(XLThemeColor themeColor, double themeTint)
    {
      this._themeColor = themeColor;
      this._themeTint = themeTint;
      this._hashCode = 7 ^ this._themeColor.GetHashCode() ^ this._themeTint.GetHashCode();
      this.HasValue = true;
      this._colorType = XLColorType.Theme;
    }
  }
}
