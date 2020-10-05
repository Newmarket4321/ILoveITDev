// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlElementContext
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public class OpenXmlElementContext
  {
    private int _lazySteps = 3;
    internal const string xmlnsUri = "http://www.w3.org/2000/xmlns/";
    internal const string xmlnsPrefix = "xmlns";
    private OpenXmlPart _ownerPart;
    private XmlNameTable _xmlNameTable;
    private XmlReaderSettings _xmlReaderSettings;
    private OpenXmlLoadMode _loadMode;
    private EventHandler<ElementEventArgs> _onElementInserting;
    private EventHandler<ElementEventArgs> _onElementInserted;
    private EventHandler<ElementEventArgs> _onElementRemoving;
    private EventHandler<ElementEventArgs> _onElementRemoved;
    private MarkupCompatibilityProcessSettings _mcSettings;

    internal MarkupCompatibilityProcessSettings MCSettings
    {
      get
      {
        if (this._mcSettings == null)
          this._mcSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013);
        return this._mcSettings;
      }
      set
      {
        this._mcSettings = value;
      }
    }

    internal OpenXmlPart OwnerPart
    {
      get
      {
        return this._ownerPart;
      }
      set
      {
        this._ownerPart = value;
      }
    }

    private XmlNameTable XmlNameTable
    {
      get
      {
        return this._xmlNameTable;
      }
    }

    internal XmlReaderSettings XmlReaderSettings
    {
      get
      {
        return this._xmlReaderSettings;
      }
      set
      {
        this._xmlReaderSettings = value;
      }
    }

    internal OpenXmlLoadMode LoadMode
    {
      get
      {
        return this._loadMode;
      }
      set
      {
        this._loadMode = value;
      }
    }

    internal int LazySteps
    {
      get
      {
        return this._lazySteps;
      }
      set
      {
        if (value < 0)
          this._lazySteps = 0;
        else
          this._lazySteps = value;
      }
    }

    public OpenXmlElementContext()
    {
      this._xmlNameTable = (XmlNameTable) new NameTable();
      this.MCContext = new MCContext();
      this.Init();
    }

    internal static XmlReaderSettings CreateDefaultXmlReaderSettings()
    {
      XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
      xmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
      xmlReaderSettings.NameTable = (XmlNameTable) new NameTable();
      xmlReaderSettings.IgnoreWhitespace = false;
      for (int index = 1; index < NamespaceIdMap.Count; ++index)
        xmlReaderSettings.NameTable.Add(NamespaceIdMap.GetNamespaceUri((byte) index));
      xmlReaderSettings.NameTable.Add("http://www.w3.org/2000/xmlns/");
      return xmlReaderSettings;
    }

    internal bool IsXmlnsUri(string nsUri)
    {
      return this._xmlNameTable.Get(nsUri) == "http://www.w3.org/2000/xmlns/";
    }

    private void Init()
    {
      for (int index = 1; index < NamespaceIdMap.Count; ++index)
        this._xmlNameTable.Add(NamespaceIdMap.GetNamespaceUri((byte) index));
      this._xmlNameTable.Add("http://www.w3.org/2000/xmlns/");
      this.XmlReaderSettings = new XmlReaderSettings();
      this.XmlReaderSettings.NameTable = this.XmlNameTable;
      this.XmlReaderSettings.IgnoreWhitespace = false;
    }

    internal void ElementInsertingEvent(OpenXmlElement element, OpenXmlElement parent)
    {
      if (this._onElementInserting == null)
        return;
      this._onElementInserting((object) this, new ElementEventArgs(element, parent));
    }

    internal void ElementInsertedEvent(OpenXmlElement element, OpenXmlElement parent)
    {
      if (this._onElementInserted == null)
        return;
      this._onElementInserted((object) this, new ElementEventArgs(element, parent));
    }

    internal void ElementRemovingEvent(OpenXmlElement element, OpenXmlElement parent)
    {
      if (this._onElementRemoving == null)
        return;
      this._onElementRemoving((object) this, new ElementEventArgs(element, parent));
    }

    internal void ElementRemovedEvent(OpenXmlElement element, OpenXmlElement parent)
    {
      if (this._onElementRemoved == null)
        return;
      this._onElementRemoved((object) this, new ElementEventArgs(element, parent));
    }

    public event EventHandler<ElementEventArgs> ElementInserting
    {
      add
      {
        this._onElementInserting += value;
      }
      remove
      {
        this._onElementInserting -= value;
      }
    }

    public event EventHandler<ElementEventArgs> ElementInserted
    {
      add
      {
        this._onElementInserted += value;
      }
      remove
      {
        this._onElementInserted -= value;
      }
    }

    public event EventHandler<ElementEventArgs> ElementRemoving
    {
      add
      {
        this._onElementRemoving += value;
      }
      remove
      {
        this._onElementRemoving -= value;
      }
    }

    public event EventHandler<ElementEventArgs> ElementRemoved
    {
      add
      {
        this._onElementRemoved += value;
      }
      remove
      {
        this._onElementRemoved -= value;
      }
    }

    internal MCContext MCContext { get; set; }

    internal uint ACBlockLevel { get; set; }
  }
}
