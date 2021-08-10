using System;
using NewDSL;

namespace NewDSLConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new Interpreter();
            while (true)
            {
                Console.Write("expr   >> ");
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                Console.WriteLine($"result >> {interpreter.Eval(input)}");
            }
        }
    }
}