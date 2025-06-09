using System.Collections.Generic;
using System.IO;
using Blinkenlights.Basic.App.Statements;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors;

public class ProgramVisitor : BasicBaseVisitor<string>
{
    private readonly TextWriter _error;

    public ProgramVisitor(TextWriter error)
    {
        _error = error;
    }

    public SortedDictionary<int, IStatement> Statements { get; } = new();

    public override string VisitLine(BasicParser.LineContext context)
    {
        var currentLineNumber = int.Parse(context.lineNum().INT().ToString());

        var statementVisitor = new StatementVisitor(_error);
        var statement = statementVisitor.Visit(context.statement());

        if (statement != null)
        {
            Statements[currentLineNumber] = statement;
        }

        return base.VisitLine(context);
    }
}