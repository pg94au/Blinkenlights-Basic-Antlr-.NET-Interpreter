using NUnit.Framework;
using System.IO;

namespace Blinkenlights.Basic.Tests.Statements
{
    [TestFixture]
    public class IfStatementTests
    {
        [Test]
        [TestCase("123 == 123", true)]
        [TestCase("X + 50 == (50 * 3) * 2", true)]
        [TestCase("123 == 321", false)]
        [TestCase("123 != 321", true)]
        [TestCase("123 != 123", false)]
        [TestCase("321 > 123", true)]
        [TestCase("123 > 321", false)]
        [TestCase("123 < 321", true)]
        [TestCase("321 < 123", false)]
        [TestCase("321 >= 123", true)]
        [TestCase("123 >= 123", true)]
        [TestCase("123 >= 321", false)]
        [TestCase("123 <= 321", true)]
        [TestCase("123 <= 123", true)]
        [TestCase("321 <= 123", false)]
        public void BranchesAsAppropriateToLineNumber(string expression, bool shouldBranch)
        {
            var interpreter = $@"
                10 LET X = 250
                20 IF {expression} THEN 40
                30 LET X=500
                40 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(shouldBranch ? 250 : 500));
        }

        [Test]
        [TestCase("123 == 123", true)]
        [TestCase("X + 50 == (50 * 3) * 2", true)]
        [TestCase("123 == 321", false)]
        [TestCase("123 != 321", true)]
        [TestCase("123 != 123", false)]
        [TestCase("321 > 123", true)]
        [TestCase("123 > 321", false)]
        [TestCase("123 < 321", true)]
        [TestCase("321 < 123", false)]
        [TestCase("321 >= 123", true)]
        [TestCase("123 >= 123", true)]
        [TestCase("123 >= 321", false)]
        [TestCase("123 <= 321", true)]
        [TestCase("123 <= 123", true)]
        [TestCase("321 <= 123", false)]
        public void BranchesAsAppropriateExecutingGotoStatement(string expression, bool shouldBranch)
        {
            var interpreter = $@"
                10 LET X = 250
                20 IF {expression} THEN GOTO 40
                30 LET X=500
                40 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(shouldBranch ? 250 : 500));
        }

        [Test]
        public void ConditionalStatementCanBeEnd()
        {
            var interpreter = @"
                10 LET X = 250
                20 IF X > 0 THEN END
                30 X = 500
                40 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(250));
        }

        [Test]
        public void ConditionalStatementCanBeGosub()
        {
            var interpreter = @"
                10 LET X = 250
                20 IF X > 0 THEN GOSUB 40
                30 END
                40 LET X = 500
                50 RETURN
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(500));
        }

        [Test]
        public void ConditionalStatementCanBeInput()
        {
            var inputReader = new StringReader("123");

            var interpreter = @"
                10 LET X = 250
                20 IF X > 0 THEN INPUT X
                30 END
            ".ExecuteWithInputReader(inputReader);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(123));
        }

        [Test]
        public void ConditionalStatementCanBeLet()
        {
            var interpreter = @"
                10 LET X = 250
                20 IF X > 0 THEN LET X = 500
                30 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(500));
        }

        [Test]
        public void ConditionalStatementCanBePrint()
        {
            @"
                10 LET X = 250
                20 IF X > 0 THEN PRINT ""HELLO""
                30 END
            ".ExecuteWithOutput(out var output);

            Assert.That(output, Contains.Substring("HELLO"));
        }

        [Test]
        public void ConditionalStatementCanBeReturn()
        {
            var interpreter = @"
                10 LET X = 250
                20 GOSUB 40
                30 END
                40 IF X > 0 THEN RETURN
                50 LET X = 500
                60 RETURN
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(250));
        }

        [Test]
        public void ConditionalStatementCannotCallLoopStatements()
        {
            @"
                10 LET X = 1
                20 IF X > 0 THEN FOR Y = 1 TO 10
                30 NEXT Y
                40 END
            ".ExecuteWithError(out var output);

            Assert.That(output, Contains.Substring("Illegal"));
        }
    }
}
