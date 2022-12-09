using System;

namespace Interpreter
{
    public class Program
    {
        public static void Main()
        {
            Context context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };

            var expression = new NonterminalExpression();
            expression.Interpret(context);

            Console.WriteLine(context.Result);
        }
    }
}