/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcLightIntensityDistribution : Entity 
	{
		public IfcLightIntensityDistribution(IfcLightIntensityDistributionDistributionData distributionData,
				IfcLightDistributionCurveEnum lightDistributionCurve,
				Boolean lightDistributionCurveSpecified) : base()
		{
			this.distributionDataField = distributionData;
			this.lightDistributionCurveField = lightDistributionCurve;
			this.lightDistributionCurveSpecifiedField = lightDistributionCurveSpecified;
		}
	}
}