namespace NewDSL
{
    public class Parser
    {
        private readonly string _expression;
        private int _pos;

        public Parser(string expression)
        {
            _expression = expression;
            _pos = 0;
        }

        public Token GetNextToken()
        {
            if (_pos >= _expression.Length)
            {
                return new Token()
                {
                    Type = TokenType.EOF
                };
            }
            
            if (char.IsDigit(_expression[_pos]))
            {
                return ReadDouble();
            }

            switch (_expression[_pos])
            {
                case '+':
                {
                    _pos++;
                    return new Token()
                    {
                        Value = "+",
                        Type = TokenType.OperatorPlus
                    };
                }
                case '-':
                {
                    _pos++;
                    return new Token()
                    {
                        Value = "-",
                        Type = TokenType.OperatorMinus
                    };
                }
            }

            throw new ParserException($"Illegal character {_expression[_pos]} found at position {_pos}");
        }

        private Token ReadDouble()
        {
            var result = "";
            while (_pos < _expression.Length && char.IsDigit(_expression[_pos]))
            {
                result = $"{result}{_expression[_pos]}";
                _pos++;
            }

            return new Token()
            {
                Value = double.Parse(result),
                Type = TokenType.Double
            };
        }
    }
}