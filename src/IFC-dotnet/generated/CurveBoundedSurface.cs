/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurveboundedsurface.htm
	/// </summary>
	internal  partial class CurveBoundedSurface : BoundedSurface 
	{
		public Surface BasisSurface {get;set;}

		public CurveBoundedSurfaceBoundaries Boundaries {get;set;}

		public Boolean ImplicitOuter {get;set;}

		public CurveBoundedSurface(Surface basisSurface,
				CurveBoundedSurfaceBoundaries boundaries,
				Boolean implicitOuter,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.BasisSurface = basisSurface;
			this.Boundaries = boundaries;
			this.ImplicitOuter = implicitOuter;
		}
	}
}