using System;

namespace ExactOnline.Client.Models.Manufacturing
{
    public class MaterialPlanCalculator
    {
        /// <summary>Fixed calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public FixedCalculator FixedCalculator { get; set; }
        /// <summary>Materials per piece calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
		public MaterialsPerPieceCalculator MaterialsPerPieceCalculator { get; set; }
        /// <summary>Pieces per material calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public PiecesPerMaterialCalculator PiecesPerMaterialCalculator { get; set; }
        /// <summary>Bar calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public BarCalculator BarCalculator { get; set; }
        /// <summary>Sheet calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public SheetCalculator SheetCalculator { get; set; }
        /// <summary>Coil wire length calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public CoilWireLengthCalculator CoilWireLengthCalculator { get; set; }
        /// <summary>Coil wire weight calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public CoilWireWeightCalculator CoilWireWeightCalculator { get; set; }
        /// <summary>Volume calculator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public VolumeCalculator VolumeCalculator { get; set; }
    }

    public class FixedCalculator
    {
        /// <summary>Fixed quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? FixedQuantity { get; set; }
        /// <summary>Pieces per make item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerMakeItem { get; set; }
    }

    public class MaterialsPerPieceCalculator
    {
        /// <summary>Materials per piece</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? MaterialsPerPiece { get; set; }
        /// <summary>Pieces per make item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerMakeItem { get; set; }
    }

    public class PiecesPerMaterialCalculator
    {
        /// <summary>Pieces per material</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerMaterial { get; set; }
        /// <summary>Pieces per make item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerMakeItem { get; set; }
    }

    public class CalculatorBase
    {
        /// <summary>Pieces per material</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemStockUnit { get; set;}
        /// <summary>Shape unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ShapeUnit { get; set; }
        /// <summary>Conversion unit factor</summary>
        public Double? ConversionUnitFactor { get; set; }
        /// <summary>Conversion unit factor type - 1 := 1 stockUnit = X shapeunits, 2 := 1 Shape Unit = X Stock Units</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ConversionUnitFactorType { get; set; }
        /// <summary>Conversion unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ConversionUnitDescription { get; set; }
        /// <summary>Pieces per make item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerMakeItem { get; set; }
    }

    public class BarCalculator : CalculatorBase
    {
        /// <summary>Bar length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String BarLengthUnit { get; set; }

        /// <summary>Bar length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? BarLength { get; set; }

        /// <summary>Bar end</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? BarEnd { get; set; }

        /// <summary>Weight per length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WeightPerLengthUnit { get; set; }

        /// <summary>Weight per length unit factor</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? WeightPerLengthUnitFactor { get; set; }

        /// <summary>Length to weight unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String LengthToWeightUnitDescription { get; set; }

        /// <summary>PieceLength</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceLength { get; set; }

        /// <summary>Piece facing</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceFacing { get; set; }

        /// <summary>Piece cut off</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceCutOff { get; set; }

        /// <summary>Weight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedWeight { get; set; }

        /// <summary>Weight unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedWeightUnit { get; set; }

        /// <summary>Length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedLength { get; set; }

        /// <summary>Length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedLengthUnit { get; set; }

        /// <summary>Whole bars</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? WholeBars { get; set; }

        /// <summary>Whole pieces per bars</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? WholePiecesPerBar { get; set; }

        /// <summary>Bars</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedBars { get; set; }

        /// <summary>Pieces per bar</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerBar { get; set; }

        /// <summary>Is calculated -  if Length = 0 and PieceFacing = 0 and PieceCutOff = 0 and PiecesPerMakeItem = 1 then false</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsCalculated { get; set; }
    }

    public class SheetCalculator : CalculatorBase
    {

        /// <summary>Sheet length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SheetLengthUnit { get; set; }

        /// <summary>Sheet length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? SheetLength { get; set; }

        /// <summary>Sheet width</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? SheetWidth { get; set; }

        /// <summary>Margin</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Margin { get; set; }

        /// <summary>Weight per area unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WeightPerAreaUnit { get; set; }

        /// <summary>Weight per area unit factor</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? WeightPerAreaUnitFactor { get; set; }

        /// <summary>Length to weight unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AreaToWeightUnitDescription { get; set; }

        /// <summary>Piece length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceLength { get; set; }

        /// <summary>Piece width</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceWidth { get; set; }

        /// <summary>Allowance</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Allowance { get; set; }

        /// <summary>Weight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedWeight { get; set; }

        /// <summary>Weight unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedWeightUnit { get; set; }

        /// <summary>Area</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedArea { get; set; }

        /// <summary>Area unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedAreaUnit { get; set; }

        /// <summary>Whole sheets</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? WholeSheets { get; set; }

        /// <summary>Whole pieces per sheet</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? WholePiecesPerSheet { get; set; }

        /// <summary>Sheets</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedSheets { get; set; }

        /// <summary>Pieces per sheet</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesPerSheet { get; set; }

        /// <summary>Is calculated -  if Length = 0 and Width = 0 and Allowance = 0 and PiecesPerMakeItem = 1 then false</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsCalculated { get; set; }
    }

    public class CoilWireLengthCalculator : CalculatorBase
    {
        /// <summary>Length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String LengthUnit { get; set; }

        /// <summary>Coil wire length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? CoilWireLength { get; set; }

        /// <summary>Coil wire width</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? CoilWireWidth { get; set; }

        /// <summary>Weight per length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WeightPerLengthUnit{ get; set; }

        /// <summary>Weight per length unit factor</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? WeightPerLengthUnitFactor { get; set; }

        /// <summary>Length to weight unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String LengthToWeightUnitDescription { get; set; }

        /// <summary>Piece length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceLength { get; set; }

        /// <summary>Pieces across</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PiecesAcross { get; set; }

        /// <summary>Allowance</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Allowance { get; set; }

        /// <summary>Weight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedWeight { get; set; }

        /// <summary>Weight unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedWeightUnit { get; set; }

        /// <summary>Length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedLength { get; set; }

        /// <summary>Length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedLengthUnit { get; set; }

        /// <summary>Is calculated -  Always true for CoilWireWeight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsCalculated { get; set; }
    }

    public class CoilWireWeightCalculator : CalculatorBase
    {
        /// <summary>Weight unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WeightUnit { get; set; }

        /// <summary>Piece weight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceWeight { get; set; }

        /// <summary>Planned weight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedWeight { get; set; }

        /// <summary>Weight unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlannedWeightUnit { get; set; }

        /// <summary>Is calculated -  Always true for CoilWireWeight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsCalculated { get; set; }
    }

    public class VolumeCalculator : CalculatorBase
    {
        /// <summary>Length unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String LengthUnit { get; set; }

        /// <summary>Length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Length { get; set; }

        /// <summary>Width</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Width { get; set; }

        /// <summary>Depth</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Depth { get; set; }

        /// <summary>Piece length</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceLength { get; set; }

        /// <summary>Piece facing</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceFacing { get; set; }

        /// <summary>Piece cut off</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PieceCutOff { get; set; }

        /// <summary>Is calculated -  if Length = 0 and PieceFacing = 0 and PieceCutOff = 0 and PiecesPerMakeItem = 1 then false</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsCalculated { get; set; }
    }
}

