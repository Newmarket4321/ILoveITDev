// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.O15UnionHelper
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2010.Ink;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class O15UnionHelper
  {
    internal static OpenXmlSimpleType[] CreatePossibleMembers(UnionValueRestriction unionValueRestriction)
    {
      OpenXmlSimpleType[] openXmlSimpleTypeArray = new OpenXmlSimpleType[unionValueRestriction.UnionTypes.Length];
      switch (unionValueRestriction.UnionId)
      {
        case 25:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<AnimationBuildValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<AnimationDiagramOnlyBuildValues>();
          break;
        case 27:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<AnimationBuildValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<AnimationChartOnlyBuildValues>();
          break;
        case 45:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int64Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 46:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 145:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<ShapeTypeValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<OutputShapeValues>();
          break;
        case 183:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HorizontalAlignmentValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VerticalAlignmentValues>();
          openXmlSimpleTypeArray[2] = (OpenXmlSimpleType) new EnumValue<ChildDirectionValues>();
          openXmlSimpleTypeArray[3] = (OpenXmlSimpleType) new EnumValue<ChildAlignmentValues>();
          openXmlSimpleTypeArray[4] = (OpenXmlSimpleType) new EnumValue<SecondaryChildAlignmentValues>();
          openXmlSimpleTypeArray[5] = (OpenXmlSimpleType) new EnumValue<LinearDirectionValues>();
          openXmlSimpleTypeArray[6] = (OpenXmlSimpleType) new EnumValue<SecondaryLinearDirectionValues>();
          openXmlSimpleTypeArray[7] = (OpenXmlSimpleType) new EnumValue<StartingElementValues>();
          openXmlSimpleTypeArray[8] = (OpenXmlSimpleType) new EnumValue<BendPointValues>();
          openXmlSimpleTypeArray[9] = (OpenXmlSimpleType) new EnumValue<ConnectorRoutingValues>();
          openXmlSimpleTypeArray[10] = (OpenXmlSimpleType) new EnumValue<ArrowheadStyleValues>();
          openXmlSimpleTypeArray[11] = (OpenXmlSimpleType) new EnumValue<ConnectorDimensionValues>();
          openXmlSimpleTypeArray[12] = (OpenXmlSimpleType) new EnumValue<RotationPathValues>();
          openXmlSimpleTypeArray[13] = (OpenXmlSimpleType) new EnumValue<CenterShapeMappingValues>();
          openXmlSimpleTypeArray[14] = (OpenXmlSimpleType) new EnumValue<NodeHorizontalAlignmentValues>();
          openXmlSimpleTypeArray[15] = (OpenXmlSimpleType) new EnumValue<NodeVerticalAlignmentValues>();
          openXmlSimpleTypeArray[16] = (OpenXmlSimpleType) new EnumValue<FallbackDimensionValues>();
          openXmlSimpleTypeArray[17] = (OpenXmlSimpleType) new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextDirectionValues>();
          openXmlSimpleTypeArray[18] = (OpenXmlSimpleType) new EnumValue<PyramidAccentPositionValues>();
          openXmlSimpleTypeArray[19] = (OpenXmlSimpleType) new EnumValue<PyramidAccentTextMarginValues>();
          openXmlSimpleTypeArray[20] = (OpenXmlSimpleType) new EnumValue<TextBlockDirectionValues>();
          openXmlSimpleTypeArray[21] = (OpenXmlSimpleType) new EnumValue<TextAnchorHorizontalValues>();
          openXmlSimpleTypeArray[22] = (OpenXmlSimpleType) new EnumValue<TextAnchorVerticalValues>();
          openXmlSimpleTypeArray[23] = (OpenXmlSimpleType) new EnumValue<TextAlignmentValues>();
          openXmlSimpleTypeArray[24] = (OpenXmlSimpleType) new EnumValue<AutoTextRotationValues>();
          openXmlSimpleTypeArray[25] = (OpenXmlSimpleType) new EnumValue<GrowDirectionValues>();
          openXmlSimpleTypeArray[26] = (OpenXmlSimpleType) new EnumValue<FlowDirectionValues>();
          openXmlSimpleTypeArray[27] = (OpenXmlSimpleType) new EnumValue<ContinueDirectionValues>();
          openXmlSimpleTypeArray[28] = (OpenXmlSimpleType) new EnumValue<BreakpointValues>();
          openXmlSimpleTypeArray[29] = (OpenXmlSimpleType) new EnumValue<OffsetValues>();
          openXmlSimpleTypeArray[30] = (OpenXmlSimpleType) new EnumValue<HierarchyAlignmentValues>();
          openXmlSimpleTypeArray[31] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[32] = (OpenXmlSimpleType) new DoubleValue();
          openXmlSimpleTypeArray[33] = (OpenXmlSimpleType) new BooleanValue();
          openXmlSimpleTypeArray[34] = (OpenXmlSimpleType) new StringValue();
          openXmlSimpleTypeArray[35] = (OpenXmlSimpleType) new EnumValue<ConnectorPointValues>();
          break;
        case 184:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 207:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new BooleanValue();
          openXmlSimpleTypeArray[2] = (OpenXmlSimpleType) new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>();
          openXmlSimpleTypeArray[3] = (OpenXmlSimpleType) new EnumValue<HierarchyBranchStyleValues>();
          openXmlSimpleTypeArray[4] = (OpenXmlSimpleType) new EnumValue<AnimateOneByOneValues>();
          openXmlSimpleTypeArray[5] = (OpenXmlSimpleType) new EnumValue<AnimationLevelStringValues>();
          openXmlSimpleTypeArray[6] = (OpenXmlSimpleType) new EnumValue<ResizeHandlesStringValues>();
          break;
        case 209:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<VariableValues>();
          break;
        case 368:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new Int32Value();
          break;
        case 375:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new Int32Value();
          break;
        case 404:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<AutomaticColorValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new HexBinaryValue();
          break;
        case 507:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new StringValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new Int32Value();
          break;
        case 525:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new IntegerValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 528:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new UInt32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 531:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new IntegerValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 534:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new UInt32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 544:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<TransitionSlideDirectionValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<TransitionCornerDirectionValues>();
          break;
        case 561:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new Int32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<IndefiniteTimeDeclarationValues>();
          break;
        case 603:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new UInt32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<IndefiniteTimeDeclarationValues>();
          break;
        case 604:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new StringValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<IndefiniteTimeDeclarationValues>();
          break;
        case 689:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new DateTimeValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new DateTimeValue();
          openXmlSimpleTypeArray[2] = (OpenXmlSimpleType) new StringValue();
          break;
        case 697:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new DecimalValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new BooleanValue();
          break;
        case 701:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<StandardChannelPropertyNameValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 704:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<StandardBrushPropertyNameValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 707:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<StandardChannelNameValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 719:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<StandardLengthUnitsValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<StandardPerLengthUnitsValues>();
          openXmlSimpleTypeArray[2] = (OpenXmlSimpleType) new EnumValue<StandardTimeUnitsValues>();
          openXmlSimpleTypeArray[3] = (OpenXmlSimpleType) new EnumValue<StandardPerTimeUnitsValues>();
          openXmlSimpleTypeArray[4] = (OpenXmlSimpleType) new EnumValue<StandardMassForceUnitsValues>();
          openXmlSimpleTypeArray[5] = (OpenXmlSimpleType) new EnumValue<StandardPerMassForceUnitsValues>();
          openXmlSimpleTypeArray[6] = (OpenXmlSimpleType) new EnumValue<StandardAngleUnitsValues>();
          openXmlSimpleTypeArray[7] = (OpenXmlSimpleType) new EnumValue<StandardPerAngleUnitsValues>();
          openXmlSimpleTypeArray[8] = (OpenXmlSimpleType) new EnumValue<StandardOtherUnitsValues>();
          openXmlSimpleTypeArray[9] = (OpenXmlSimpleType) new EnumValue<StandardPerOtherUnitsValues>();
          openXmlSimpleTypeArray[10] = (OpenXmlSimpleType) new StringValue();
          break;
        case 732:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new DecimalValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new BooleanValue();
          openXmlSimpleTypeArray[2] = (OpenXmlSimpleType) new EnumValue<PenTipShapeValues>();
          openXmlSimpleTypeArray[3] = (OpenXmlSimpleType) new EnumValue<RasterOperationValues>();
          openXmlSimpleTypeArray[4] = (OpenXmlSimpleType) new StringValue();
          break;
        case 746:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new StringValue();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new UInt32Value();
          break;
        case 747:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<KnownContextNodeTypeValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 750:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<KnownSemanticTypeValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new UInt32Value();
          break;
        case 753:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new ListValue<StringValue>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new Int32Value();
          break;
        case 766:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<TransitionCornerDirectionValues>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<TransitionCenterDirectionTypeValues>();
          break;
        case 835:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<ColorStyleMethodEnum>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 837:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<StyleReferenceModifierEnum>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
        case 840:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new UInt32Value();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new EnumValue<StyleColorEnum>();
          openXmlSimpleTypeArray[2] = (OpenXmlSimpleType) new StringValue();
          break;
        case 842:
          openXmlSimpleTypeArray[0] = (OpenXmlSimpleType) new EnumValue<StyleEntryModifierEnum>();
          openXmlSimpleTypeArray[1] = (OpenXmlSimpleType) new StringValue();
          break;
      }
      return openXmlSimpleTypeArray;
    }

    internal static OpenXmlSimpleType CreateTargetValueObject(RedirectedRestriction redirectedRestriction)
    {
      OpenXmlSimpleType openXmlSimpleType = (OpenXmlSimpleType) null;
      switch (redirectedRestriction.AttributeId)
      {
        case 2591:
          openXmlSimpleType = (OpenXmlSimpleType) new StringValue();
          break;
        case 2849:
          openXmlSimpleType = (OpenXmlSimpleType) new StringValue();
          break;
        case 2926:
          openXmlSimpleType = (OpenXmlSimpleType) new StringValue();
          break;
        case 3073:
          openXmlSimpleType = (OpenXmlSimpleType) new UInt32Value();
          break;
        case 3082:
          openXmlSimpleType = (OpenXmlSimpleType) new UInt32Value();
          break;
        case 3086:
          openXmlSimpleType = (OpenXmlSimpleType) new UInt32Value();
          break;
        case 3091:
          openXmlSimpleType = (OpenXmlSimpleType) new UInt32Value();
          break;
        case 3152:
          openXmlSimpleType = (OpenXmlSimpleType) new StringValue();
          break;
        case 3155:
          openXmlSimpleType = (OpenXmlSimpleType) new UInt32Value();
          break;
      }
      return openXmlSimpleType;
    }
  }
}
