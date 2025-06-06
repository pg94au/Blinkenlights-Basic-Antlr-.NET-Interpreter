using Blinkenlights.Basic.App.Equations;

namespace Blinkenlights.Basic.App.Statements
{
    public class IfStatement : IStatement
    {
        public IEquation Equation { get; }
        public IStatement Statement { get; }
        public int TargetLineNumber { get; }

        public IfStatement(IEquation equation, IStatement statement)
        {
            Equation = equation;
            Statement = statement;
        }

        public IfStatement(IEquation equation, int targetLineNumber)
        {
            Equation = equation;
            TargetLineNumber = targetLineNumber;
        }

        public void Execute(Interpreter interpreter)
        {
            if (Equation.Solve(interpreter))
            {
                if (Statement != null)
                {
                    interpreter.ExecuteStatement(Statement);
                }
                else
                {
                    interpreter.GotoLine(TargetLineNumber);
                }
            }
            else
            {
                interpreter.AdvanceLine();
            }
        }
    }
}
