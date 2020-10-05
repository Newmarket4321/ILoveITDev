// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SchemaTypeData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("OpenXmlTypeId={OpenXmlTypeId}")]
  internal class SchemaTypeData
  {
    internal SchemaTypeData(int openxmlTypeId, AttributeConstraint[] attributeConstraints)
    {
      this.OpenXmlTypeId = openxmlTypeId;
      this.AttributeConstraints = (IList<AttributeConstraint>) attributeConstraints;
    }

    internal SchemaTypeData(int openxmlTypeId, AttributeConstraint[] attributeConstraints, ParticleConstraint particleConstraint)
      : this(openxmlTypeId, attributeConstraints)
    {
      this.ParticleConstraint = particleConstraint;
    }

    internal SchemaTypeData(int openxmlTypeId, AttributeConstraint[] attributeConstraints, SimpleTypeRestriction simpleTypeConstraint)
      : this(openxmlTypeId, attributeConstraints)
    {
      this.SimpleTypeConstraint = simpleTypeConstraint;
    }

    internal int OpenXmlTypeId { get; private set; }

    internal ParticleConstraint ParticleConstraint { get; private set; }

    internal SimpleTypeRestriction SimpleTypeConstraint { get; private set; }

    internal IList<AttributeConstraint> AttributeConstraints { get; private set; }

    internal bool HasAttributeConstraints
    {
      get
      {
        if (this.AttributeConstraints != null)
          return this.AttributeConstraints.Count > 0;
        return false;
      }
    }

    internal int AttributeConstraintsCount
    {
      get
      {
        if (this.AttributeConstraints != null)
          return this.AttributeConstraints.Count;
        return 0;
      }
    }

    internal bool IsCompositeType
    {
      get
      {
        return this.ParticleConstraint != null;
      }
    }

    internal bool IsSimpleContent
    {
      get
      {
        return this.SimpleTypeConstraint != null;
      }
    }
  }
}
