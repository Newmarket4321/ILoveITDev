// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.AttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal static class AttributeTranslator
  {
    private static Dictionary<string, TagAttributeTranslator> dicOfTranslators = (Dictionary<string, TagAttributeTranslator>) null;
    private static TagAttributeTranslator translator;

    private static Dictionary<string, TagAttributeTranslator> DicOfTranslators
    {
      get
      {
        if (AttributeTranslator.dicOfTranslators == null)
        {
          AttributeTranslator.dicOfTranslators = new Dictionary<string, TagAttributeTranslator>();
          AttributeTranslator.dicOfTranslators["document"] = (TagAttributeTranslator) null;
          AttributeTranslator.dicOfTranslators["cnfStyle"] = (TagAttributeTranslator) null;
          AttributeTranslator.dicOfTranslators["tblLook"] = (TagAttributeTranslator) null;
          AttributeTranslator.dicOfTranslators["ind"] = (TagAttributeTranslator) null;
          AttributeTranslator.dicOfTranslators["tab"] = (TagAttributeTranslator) null;
          AttributeTranslator.dicOfTranslators["stylePaneSortMethod"] = (TagAttributeTranslator) null;
          AttributeTranslator.dicOfTranslators["textDirection"] = (TagAttributeTranslator) null;
        }
        return AttributeTranslator.dicOfTranslators;
      }
    }

    internal static TagAttributeTranslator Translate(string strTag, string strLocalName, string strValue)
    {
      AttributeTranslator.translator = (TagAttributeTranslator) null;
      if (strTag != null && strLocalName != null)
      {
        if (strValue != null)
        {
          try
          {
            if (AttributeTranslator.DicOfTranslators.ContainsKey(strTag))
            {
              AttributeTranslator.translator = AttributeTranslator.DicOfTranslators[strTag];
              if (AttributeTranslator.translator == null)
              {
                switch (strTag)
                {
                  case "document":
                    AttributeTranslator.translator = (TagAttributeTranslator) new DocumentTagAttributeTranslator();
                    break;
                  case "cnfStyle":
                    AttributeTranslator.translator = (TagAttributeTranslator) new CnfStyleTagAttributeTranslator();
                    break;
                  case "tblLook":
                    AttributeTranslator.translator = (TagAttributeTranslator) new TblLookTagAttributeTranslator();
                    break;
                  case "ind":
                    AttributeTranslator.translator = (TagAttributeTranslator) new IndTagAttributeTranslator();
                    break;
                  case "jc":
                  case "tab":
                    AttributeTranslator.translator = (TagAttributeTranslator) new JcTabTagAttributeTranslator();
                    break;
                  case "stylePaneSortMethod":
                    AttributeTranslator.translator = (TagAttributeTranslator) new StylePaneSortMethodTagAttributeTranslator();
                    break;
                  case "textDirection":
                    AttributeTranslator.translator = (TagAttributeTranslator) new TextDirectionTagAttributeTranslator();
                    break;
                }
                AttributeTranslator.DicOfTranslators[strTag] = AttributeTranslator.translator;
              }
            }
            if (AttributeTranslator.translator != null)
            {
              AttributeTranslator.translator.SetLocalNameAndValue(strLocalName, strValue);
              if (AttributeTranslator.translator.Index == -1)
                AttributeTranslator.translator = (TagAttributeTranslator) null;
            }
          }
          catch
          {
            AttributeTranslator.translator = (TagAttributeTranslator) null;
          }
        }
      }
      return AttributeTranslator.translator;
    }
  }
}
