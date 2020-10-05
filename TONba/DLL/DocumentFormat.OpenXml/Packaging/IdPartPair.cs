// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.IdPartPair
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Packaging
{
  public class IdPartPair
  {
    private string _id;
    private OpenXmlPart _part;

    public string RelationshipId
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }

    public OpenXmlPart OpenXmlPart
    {
      get
      {
        return this._part;
      }
      set
      {
        this._part = value;
      }
    }

    public IdPartPair(string id, OpenXmlPart part)
    {
      this.RelationshipId = id;
      this.OpenXmlPart = part;
    }

    public bool Equals(IdPartPair value)
    {
      if (value == null || !this._id.Equals(value._id))
        return false;
      return this._part == value._part;
    }
  }
}
