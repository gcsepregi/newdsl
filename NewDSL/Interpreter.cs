using System.Numerics;

namespace NewDSL
{
    public class Interpreter
    {
        public double Eval(string expression)
        {
            var parser = new Parser(expression);
            var result = (double)parser.GetNextToken().Value; //1
            var op = parser.GetNextToken(); //+
            while (op.Type != TokenType.EOF)
            {
                if (op.Type == TokenType.OperatorPlus)
                {
                    result += (double)parser.GetNextToken().Value; //1
                }
                else
                {
                    result -= (double)parser.GetNextToken().Value; //1
                }

                op = parser.GetNextToken();//+
            }

            return result;
        }
    }
}