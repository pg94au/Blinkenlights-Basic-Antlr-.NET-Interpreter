//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../antlr/Basic.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Blinkenlights.Basic.Gen {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IBasicListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class BasicBaseListener : IBasicListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] BasicParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] BasicParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] BasicParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] BasicParser.LineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.lineNum"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineNum([NotNull] BasicParser.LineNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.lineNum"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineNum([NotNull] BasicParser.LineNumContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] BasicParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] BasicParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.endStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEndStatement([NotNull] BasicParser.EndStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.endStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEndStatement([NotNull] BasicParser.EndStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] BasicParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] BasicParser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.gosubStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGosubStatement([NotNull] BasicParser.GosubStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.gosubStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGosubStatement([NotNull] BasicParser.GosubStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.gotoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotoStatement([NotNull] BasicParser.GotoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.gotoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotoStatement([NotNull] BasicParser.GotoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] BasicParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] BasicParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.inputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInputStatement([NotNull] BasicParser.InputStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.inputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInputStatement([NotNull] BasicParser.InputStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.letStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLetStatement([NotNull] BasicParser.LetStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.letStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLetStatement([NotNull] BasicParser.LetStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.nextStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNextStatement([NotNull] BasicParser.NextStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.nextStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNextStatement([NotNull] BasicParser.NextStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.printStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintStatement([NotNull] BasicParser.PrintStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.printStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintStatement([NotNull] BasicParser.PrintStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] BasicParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] BasicParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printQuotedString</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintQuotedString([NotNull] BasicParser.PrintQuotedStringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printQuotedString</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintQuotedString([NotNull] BasicParser.PrintQuotedStringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printExpression</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpression([NotNull] BasicParser.PrintExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpression</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpression([NotNull] BasicParser.PrintExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printVariable</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintVariable([NotNull] BasicParser.PrintVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printVariable</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintVariable([NotNull] BasicParser.PrintVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.argSeparator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgSeparator([NotNull] BasicParser.ArgSeparatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.argSeparator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgSeparator([NotNull] BasicParser.ArgSeparatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDivision([NotNull] BasicParser.DivisionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDivision([NotNull] BasicParser.DivisionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParentheses([NotNull] BasicParser.ParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParentheses([NotNull] BasicParser.ParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] BasicParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] BasicParser.VariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubtraction([NotNull] BasicParser.SubtractionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubtraction([NotNull] BasicParser.SubtractionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplication([NotNull] BasicParser.MultiplicationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplication([NotNull] BasicParser.MultiplicationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>value</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] BasicParser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>value</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] BasicParser.ValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddition([NotNull] BasicParser.AdditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddition([NotNull] BasicParser.AdditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>equals</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquals([NotNull] BasicParser.EqualsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>equals</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquals([NotNull] BasicParser.EqualsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>doesNotEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoesNotEqual([NotNull] BasicParser.DoesNotEqualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>doesNotEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoesNotEqual([NotNull] BasicParser.DoesNotEqualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGreaterThan([NotNull] BasicParser.GreaterThanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGreaterThan([NotNull] BasicParser.GreaterThanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLessThan([NotNull] BasicParser.LessThanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLessThan([NotNull] BasicParser.LessThanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>greaterThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGreaterThanOrEqual([NotNull] BasicParser.GreaterThanOrEqualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>greaterThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGreaterThanOrEqual([NotNull] BasicParser.GreaterThanOrEqualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lessThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLessThanOrEqual([NotNull] BasicParser.LessThanOrEqualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lessThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLessThanOrEqual([NotNull] BasicParser.LessThanOrEqualContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Blinkenlights.Basic.Gen
