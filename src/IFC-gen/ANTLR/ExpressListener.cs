//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./ANTLR/Express.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Express {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ExpressParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IExpressListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.schema_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_declaration([NotNull] ExpressParser.Schema_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.schema_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_declaration([NotNull] ExpressParser.Schema_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.type_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_declaration([NotNull] ExpressParser.Type_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.type_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_declaration([NotNull] ExpressParser.Type_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.value_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue_type([NotNull] ExpressParser.Value_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.value_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue_type([NotNull] ExpressParser.Value_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.enumeration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumeration([NotNull] ExpressParser.EnumerationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.enumeration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumeration([NotNull] ExpressParser.EnumerationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.id_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId_list([NotNull] ExpressParser.Id_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.id_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId_list([NotNull] ExpressParser.Id_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.enum_id_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_id_list([NotNull] ExpressParser.Enum_id_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.enum_id_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_id_list([NotNull] ExpressParser.Enum_id_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.type_declaration_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_declaration_body([NotNull] ExpressParser.Type_declaration_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.type_declaration_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_declaration_body([NotNull] ExpressParser.Type_declaration_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.where_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_declaration([NotNull] ExpressParser.Where_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.where_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_declaration([NotNull] ExpressParser.Where_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.where_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_statement([NotNull] ExpressParser.Where_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.where_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_statement([NotNull] ExpressParser.Where_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.entity_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity_declaration([NotNull] ExpressParser.Entity_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.entity_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity_declaration([NotNull] ExpressParser.Entity_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.entity_declaration_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity_declaration_body([NotNull] ExpressParser.Entity_declaration_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.entity_declaration_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity_declaration_body([NotNull] ExpressParser.Entity_declaration_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.subtype_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtype_declaration([NotNull] ExpressParser.Subtype_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.subtype_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtype_declaration([NotNull] ExpressParser.Subtype_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.one_of"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOne_of([NotNull] ExpressParser.One_ofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.one_of"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOne_of([NotNull] ExpressParser.One_ofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.supertype_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupertype_declaration([NotNull] ExpressParser.Supertype_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.supertype_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupertype_declaration([NotNull] ExpressParser.Supertype_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.inverse_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInverse_declaration([NotNull] ExpressParser.Inverse_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.inverse_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInverse_declaration([NotNull] ExpressParser.Inverse_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.inverse_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInverse_statement([NotNull] ExpressParser.Inverse_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.inverse_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInverse_statement([NotNull] ExpressParser.Inverse_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.unique_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnique_declaration([NotNull] ExpressParser.Unique_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.unique_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnique_declaration([NotNull] ExpressParser.Unique_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.unique_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnique_statement([NotNull] ExpressParser.Unique_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.unique_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnique_statement([NotNull] ExpressParser.Unique_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.function_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_declaration([NotNull] ExpressParser.Function_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.function_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_declaration([NotNull] ExpressParser.Function_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.function_declaration_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_declaration_body([NotNull] ExpressParser.Function_declaration_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.function_declaration_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_declaration_body([NotNull] ExpressParser.Function_declaration_bodyContext context);
}
} // namespace Express
