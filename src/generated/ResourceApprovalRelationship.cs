/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ResourceApprovalRelationship : ResourceLevelRelationship 
	{
		public ResourceApprovalRelationshipRelatedResourceObjects RelatedResourceObjects {get;set;}

		public Approval RelatingApproval {get;set;}

		public ResourceApprovalRelationship(ResourceApprovalRelationshipRelatedResourceObjects relatedResourceObjects,
				Approval relatingApproval,
				String name,
				String description) : base(name,
				description)
		{
			this.RelatedResourceObjects = relatedResourceObjects;
			this.RelatingApproval = relatingApproval;
		}
	}
}