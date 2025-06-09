# Blinkenlights-.NET-Basic-Interpreter
A simple BASIC interpreter built in C# for .NET Core using Antlr4

Based on https://github.com/pg94au/Blinkenlights-Basic-Interpreter

You can build and run this with the already generated antlr source in the Blinkenlights.Basic.Gen project.  If you wish to re-generate this source from the Basic.g4 input, you can manually perform the following steps:

```
cd Blinkenlights.Basic.Gen
java -jar ../antlr-4.13.2-complete.jar -Dlanguage=CSharp ../antlr/Basic.g4 -visitor -package Blinkenlights.Basic.Gen
```

To get the antlr jar file:

```
wget https://www.antlr.org/download/antlr-4.13.2-complete.jar
```

# Reference

This simple BASIC programming language requires each statement to have a line number.
The following statements are supported:

END, FOR, GOSUB, GOTO, IF, INPUT, LET, NEXT, PRINT and RETURN

The best reference for statement options and behavior would be the tests, but here is a sample program:

```
10 LET Answer = 123
20 FOR TURN = 1 TO 10
30 PRINT "Guess which number I am thinking?"
40 INPUT Guess
50 IF Guess == Answer THEN GOTO 110
60 IF Guess < Answer THEN PRINT "A little higher."
70 IF Guess > Answer THEN PRINT "A little lower."
80 NEXT TURN
90 PRINT "Too bad, you didn't get it."
100 END 
110 PRINT "Wow, you got it!"
120 END
```
