/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurvestylefont.htm
	/// </summary>
	internal  partial class CurveStyleFont : PresentationItem 
	{
		public CurveStyleFontPatternList PatternList {get;set;}

		public String Name {get;set;}

		public CurveStyleFont(CurveStyleFontPatternList patternList,
				String name) : base()
		{
			this.PatternList = patternList;
			this.Name = name;
		}
	}
}