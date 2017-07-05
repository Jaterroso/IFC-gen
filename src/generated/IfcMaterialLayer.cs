/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMaterialLayer : IfcMaterialDefinition 
	{
		public IfcMaterialLayer(IfcMaterial material,
				Double layerThickness,
				Boolean layerThicknessSpecified,
				IfcLogical isVentilated,
				Boolean isVentilatedSpecified,
				String name,
				String description,
				String category,
				Int64 priority,
				Boolean prioritySpecified,
				IfcMaterialDefinitionHasProperties hasProperties) : base(hasProperties)
		{
			this.materialField = material;
			this.layerThicknessField = layerThickness;
			this.layerThicknessSpecifiedField = layerThicknessSpecified;
			this.isVentilatedField = isVentilated;
			this.isVentilatedSpecifiedField = isVentilatedSpecified;
			this.nameField = name;
			this.descriptionField = description;
			this.categoryField = category;
			this.priorityField = priority;
			this.prioritySpecifiedField = prioritySpecified;
		}
	}
}