/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRectangularPyramid : IfcCsgPrimitive3D 
	{
		public IfcRectangularPyramid(Double xLength,
				Boolean xLengthSpecified,
				Double yLength,
				Boolean yLengthSpecified,
				Double height,
				Boolean heightSpecified,
				IfcAxis2Placement3D position,
				IfcStyledItem styledByItem) : base(position,
				styledByItem)
		{
			this.xLengthField = xLength;
			this.xLengthSpecifiedField = xLengthSpecified;
			this.yLengthField = yLength;
			this.yLengthSpecifiedField = yLengthSpecified;
			this.heightField = height;
			this.heightSpecifiedField = heightSpecified;
		}
	}
}