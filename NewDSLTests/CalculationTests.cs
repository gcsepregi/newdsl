using NewDSL;
using NUnit.Framework;

namespace NewDSLTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("1+1", 2)]
        [TestCase("1+2", 3)]
        [TestCase("2+1", 3)]
        [TestCase("1+3", 4)]
        [TestCase("2+2", 4)]
        [TestCase("87+1098", 1185)]
        [TestCase("2-1", 1)]
        [TestCase("1+1+1", 3)]
        [TestCase("15-1+1-15", 0)]
        public void Test1(string expression, double expectedResult)
        {
            var interpreter = new Interpreter();
            Assert.AreEqual(expectedResult, interpreter.Eval(expression));
        }

    }
}


///
/// 1. Create a failing test
/// 2. Create code to pass the test
/// 3. Refactor code and test
///
///
///
/// YAGNI - You Ain't Gonna Need It
/// DRY - Don't Repeat Yourself
/// KISS - Keep It Simple and Stupid