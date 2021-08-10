using NewDSL;
using NUnit.Framework;

namespace NewDSLTests
{
    public class ParserTests
    {
        [Test]
        public void ParseTest()
        {
            var parser = new Parser("1+2+3");
            var nextToken = parser.GetNextToken();
            Assert.AreEqual(1, nextToken.Value);
            Assert.AreEqual(TokenType.Double, nextToken.Type);
        }
        
        [Test]
        public void ParseTest2()
        {
            var parser = new Parser("1+2+3");
            var _ = parser.GetNextToken();
            var nextToken = parser.GetNextToken();
            Assert.AreEqual("+", nextToken.Value);
            Assert.AreEqual(TokenType.OperatorPlus, nextToken.Type);
        }

        [Test]
        public void ParseTest3()
        {
            var parser = new Parser("1-2+3");
            var _ = parser.GetNextToken();
            var nextToken = parser.GetNextToken();
            Assert.AreEqual("-", nextToken.Value);
            Assert.AreEqual(TokenType.OperatorMinus, nextToken.Type);
        }

        [Test]
        public void ParseTest4()
        {
            var parser = new Parser("1-2+3");
            var _ = parser.GetNextToken();
            _ = parser.GetNextToken();
            _ = parser.GetNextToken();
            _ = parser.GetNextToken();
            _ = parser.GetNextToken();
            var nextToken = parser.GetNextToken();
            Assert.AreEqual(TokenType.EOF, nextToken.Type);
        }
    }
}