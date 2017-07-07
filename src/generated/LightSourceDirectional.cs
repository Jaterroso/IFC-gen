/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class LightSourceDirectional : LightSource 
	{
		public Direction Orientation {get;set;}

		public LightSourceDirectional(Direction orientation,
				ColourRgb lightColour,
				String name,
				Double ambientIntensity,
				Boolean ambientIntensitySpecified,
				Double intensity,
				Boolean intensitySpecified,
				StyledItem styledByItem) : base(lightColour,
				name,
				ambientIntensity,
				intensity,
				styledByItem)
		{
			this.Orientation = orientation;
		}
	}
}