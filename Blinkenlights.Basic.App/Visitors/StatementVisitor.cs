using Blinkenlights.Basic.App.Statements;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors;
public class StatementVisitor : BasicBaseVisitor<IStatement>
{
    public override IStatement VisitEndStatement(BasicParser.EndStatementContext context)
    {
        var endStatement = new EndStatement();

        return endStatement;
    }

    public override IStatement VisitForStatement(BasicParser.ForStatementContext context)
    {
        var variableName = context.VARNAME().ToString();
        var fromValue = int.Parse(context.INT(0).ToString());
        var toValue = int.Parse(context.INT(1).ToString());

        var forStatement = new ForStatement(variableName, fromValue, toValue);

        return forStatement;
    }

    public override IStatement VisitGosubStatement(BasicParser.GosubStatementContext context)
    {
        var targetLineNumber = int.Parse(context.INT().ToString());
        var gosubStatement = new GosubStatement(targetLineNumber);

        return gosubStatement;
    }

    public override IStatement VisitGotoStatement(BasicParser.GotoStatementContext context)
    {
        var targetLineNumber = int.Parse(context.INT().ToString());
        var gotoStatement = new GotoStatement(targetLineNumber);

        return gotoStatement;
    }

    public override IStatement VisitIfStatement(BasicParser.IfStatementContext context)
    {
        var equationVisitor = new EquationVisitor();
        var equation = equationVisitor.Visit(context.equation());

        var statementVisitor = new StatementVisitor();

        IfStatement ifStatement;
        if (context.statement() != null)
        {
            var statement = statementVisitor.Visit(context.statement());
            ifStatement = new IfStatement(equation, statement);
        }
        else
        {
            var targetLineNumber = int.Parse(context.INT().ToString());
            ifStatement = new IfStatement(equation, targetLineNumber);
        }

        return ifStatement;
    }

    public override IStatement VisitInputStatement(BasicParser.InputStatementContext context)
    {
        var variableName = context.VARNAME().ToString();
        var inputStatement = new InputStatement(variableName);

        return inputStatement;
    }

    public override IStatement VisitLetStatement(BasicParser.LetStatementContext context)
    {
        var variableName = context.VARNAME().ToString();
        var expressionVisitor = new ExpressionVisitor();
        var expression = expressionVisitor.Visit(context.expression());
        var letStatement = new LetStatement(variableName, expression);

        return letStatement;
    }

    public override IStatement VisitNextStatement(BasicParser.NextStatementContext context)
    {
        var variableName = context.VARNAME().ToString();
        var nextStatement = new NextStatement(variableName);

        return nextStatement;
    }

    public override IStatement VisitPrintStatement(BasicParser.PrintStatementContext context)
    {
        var printArgumentVisitor = new PrintArgumentVisitor();
        printArgumentVisitor.Visit(context);
        var args = printArgumentVisitor.Arguments;
        var printStatement = new PrintStatement(args.ToArray());

        return printStatement;
    }

    public override IStatement VisitReturnStatement(BasicParser.ReturnStatementContext context)
    {
        var returnStatement = new ReturnStatement();

        return returnStatement;
    }
}
