/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class PresentationStyleAssignment : Entity 
	{
		public PresentationStyleAssignmentStyles Styles {get;set;}

		public PresentationStyleAssignment(PresentationStyleAssignmentStyles styles) : base()
		{
			this.Styles = styles;
		}
	}
}