using System.Collections.Generic;
using Blinkenlights.Basic.App.Statements;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors
{
    public class ProgramVisitor : BasicBaseVisitor<string>
    {
        public SortedDictionary<int, IStatement> Statements { get; } = new SortedDictionary<int, IStatement>();

        public override string VisitLine(BasicParser.LineContext context)
        {
            var currentLineNumber = int.Parse(context.lineNum().INT().ToString());

            var statementVisitor = new StatementVisitor();
            var statement = statementVisitor.Visit(context.statement());

            if (statement != null)
            {
                Statements[currentLineNumber] = statement;
            }

            return base.VisitLine(context);
        }
    }
}
 