/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CircleHollowProfileDef : CircleProfileDef 
	{
		public Double WallThickness {get;set;}

		public CircleHollowProfileDef(Double wallThickness,
				Boolean wallThicknessSpecified,
				Double radius,
				Boolean radiusSpecified,
				Axis2Placement2D position,
				ProfileDefHasProperties hasProperties,
				ProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName) : base(radius,
				position,
				hasProperties,
				profileType,
				profileName)
		{
			this.WallThickness = wallThickness;
		}
	}
}