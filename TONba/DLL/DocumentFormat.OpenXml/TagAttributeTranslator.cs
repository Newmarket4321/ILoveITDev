// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.TagAttributeTranslator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal abstract class TagAttributeTranslator
  {
    protected int indexOfAttr;
    protected string strAttrName;
    protected string strAttrValue;
    protected string[] arrayOfOrigAttrNames;
    protected string[] arrayOfNewAttrNames;
    protected string[] arrayOfOrigAttrValues;
    protected string[] arrayOfNewAttrValues;
    protected long[] arrayOfAttrTraits;
    protected AttributeFormatter formatter;

    internal TagAttributeTranslator()
    {
      this.indexOfAttr = -1;
      this.strAttrName = (string) null;
      this.strAttrValue = (string) null;
    }

    internal void SetLocalNameAndValue(string strLocalName, string strValue)
    {
      this.indexOfAttr = -1;
      this.strAttrName = strLocalName;
      this.strAttrValue = strValue;
    }

    protected int GetIndexByAttributeName()
    {
      int num = -1;
      for (int index = 0; index < this.arrayOfOrigAttrNames.Length; ++index)
      {
        if (this.arrayOfOrigAttrNames[index] == this.strAttrName)
        {
          num = index;
          break;
        }
      }
      return num;
    }

    protected int GetIndexByValue()
    {
      int num = -1;
      for (int index = 0; index < this.arrayOfOrigAttrValues.Length; ++index)
      {
        if (this.arrayOfOrigAttrValues[index] == this.strAttrValue)
        {
          num = index;
          break;
        }
      }
      return num;
    }

    protected abstract int SetIndex();

    internal virtual int Index
    {
      get
      {
        if (this.indexOfAttr == -1)
          this.indexOfAttr = this.SetIndex();
        return this.indexOfAttr;
      }
    }

    internal virtual string LocalName
    {
      get
      {
        if (this.Index != -1)
          return this.arrayOfNewAttrNames[this.Index];
        return this.strAttrName;
      }
    }

    internal virtual string Value
    {
      get
      {
        if (this.Index != -1)
          return this.arrayOfNewAttrValues[this.Index];
        return this.strAttrValue;
      }
    }

    internal virtual long Trait
    {
      get
      {
        if (this.Index != -1)
          return this.arrayOfAttrTraits[this.Index];
        return 0;
      }
    }

    internal virtual AttributeFormatter Formatter
    {
      get
      {
        return this.formatter;
      }
    }

    internal enum State
    {
      NotInitialized = -1,
    }
  }
}
