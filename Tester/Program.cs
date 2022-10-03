using DLL;

namespace Tester;

public static class Program
{
    public static void Main()
    {
        string function = Request("function: ")!;
        Interpreter interpreter = new Interpreter();
        //First you have to parse the string and then convert to an expression using the interpreter class
        Expression expression = interpreter.GetExpression(interpreter.Parse(function));
        //Then you have to pass it to the evaluator, because it handler how to evaluate the expresion in some interval
        /*The variables in the function are named IDs in the classes, and you have to let know to the evaluator those
         using the interpreter who store those*/
        Evaluator evaluator = new Evaluator(expression, interpreter.IDs);
        //After this you only have to evaluate the function using the evaluator
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(evaluator.Evaluate(i));
        }
    }

    public static string? Request(string request)
    {
        Console.Write(request);
        return Console.ReadLine();
    }
}