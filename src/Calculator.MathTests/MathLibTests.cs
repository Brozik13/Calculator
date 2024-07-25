namespace Calculator.MathTests
{
    public class MathLibTests
    {
        private double _delta;

        [SetUp]
        public void Setup()
        {
            _delta = 0.0000001;
        }

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(0, MathLib.MathLib.Addition(0, 0), _delta);
            Assert.AreEqual(4252.3523 + 1534.3413, MathLib.MathLib.Addition(4252.3523, 1534.3413), _delta);
            Assert.AreEqual(28343.1341 + (-1342.3524), MathLib.MathLib.Addition(28343.1341, -1342.3524), _delta);
            Assert.AreEqual(-143142.1234 + (-1634.3413), MathLib.MathLib.Addition(-143142.1234, -1634.3413), _delta);
            Assert.AreEqual(-1342.3524 + 28343.1341, MathLib.MathLib.Addition(-1342.3524, 28343.1341), _delta);
        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(0, MathLib.MathLib.Subtraction(0, 0), _delta);
            Assert.AreEqual(4252.3523 - 1534.3413, MathLib.MathLib.Subtraction(4252.3523, 1534.3413), _delta);
            Assert.AreEqual(28343.1341 - (-1342.3524), MathLib.MathLib.Subtraction(28343.1341, -1342.3524), _delta);
            Assert.AreEqual(-143142.1234 - (-1634.3413), MathLib.MathLib.Subtraction(-143142.1234, -1634.3413), _delta);
            Assert.AreEqual(-1342.3524 - 28343.1341, MathLib.MathLib.Subtraction(-1342.3524, 28343.1341), _delta);
        }

        [Test]
        public void MulTest()
        {
            Assert.AreEqual(0, MathLib.MathLib.Multiplication(0, 0), _delta);
            Assert.AreEqual(4252.3523 * 1534.3413, MathLib.MathLib.Multiplication(4252.3523, 1534.3413), _delta);
            Assert.AreEqual((28343.1341) * (-1342.3524), MathLib.MathLib.Multiplication(28343.1341, -1342.3524), _delta);
            Assert.AreEqual((-143142.1234) * (-1634.3413), MathLib.MathLib.Multiplication(-143142.1234, -1634.3413), _delta);
            Assert.AreEqual((-1342.3524) * 28343.1341, MathLib.MathLib.Multiplication(-1342.3524, 28343.1341), _delta);
        }

        [Test]
        public void DivTest()
        {
            Assert.IsNaN(MathLib.MathLib.Division(0, 0));
            Assert.AreEqual(4252.3523 / 1534.3413, MathLib.MathLib.Division(4252.3523, 1534.3413), _delta);
            Assert.AreEqual((28343.1341) / (-1342.3524), MathLib.MathLib.Division(28343.1341, -1342.3524), _delta);
            Assert.AreEqual((-143142.1234) / (-1634.3413), MathLib.MathLib.Division(-143142.1234, -1634.3413), _delta);
            Assert.AreEqual((-1342.3524) / 28343.1341, MathLib.MathLib.Division(-1342.3524, 28343.1341), _delta);
        }

        [Test]
        public void FactorialTest()
        {
            Assert.AreEqual(1, MathLib.MathLib.Factorial(0));
            Assert.AreEqual(3628800, MathLib.MathLib.Factorial(10));
            Assert.AreEqual(479001600, MathLib.MathLib.Factorial(12));
        }

        [Test]
        public void PowTest()
        {
            Assert.IsNaN(MathLib.MathLib.Power(0, 0));
            Assert.AreEqual(0, MathLib.MathLib.Power(0, 100), _delta);
            Assert.AreEqual(1, MathLib.MathLib.Power(123, 0), _delta);
            Assert.Positive(MathLib.MathLib.Power(-123, 4));
            Assert.Negative(MathLib.MathLib.Power(-123, 5));
            Assert.AreEqual(117649, MathLib.MathLib.Power(7, 6), _delta);
            Assert.AreEqual(-39304, MathLib.MathLib.Power(-34, 3), _delta);
            Assert.AreEqual(17.926756, MathLib.MathLib.Power(4.234, 2), _delta);
        }

        [Test]
        public void RootTest()
        {
            Assert.IsNaN(MathLib.MathLib.Root(-1, 2));
            Assert.AreEqual(0, MathLib.MathLib.Root(0, 100), _delta);
            Assert.IsNaN(MathLib.MathLib.Root(1, 0));
            Assert.AreEqual(6, MathLib.MathLib.Root(1296, 4), _delta);
            Assert.AreEqual(-5, MathLib.MathLib.Root(-125, 3), _delta);
            Assert.AreEqual(3.56, MathLib.MathLib.Root(12.6736, 2), _delta);
        }


        [Test]
        public void LogarithmTest()
        {
            Assert.IsNaN(MathLib.MathLib.Logarithm(0, 10));
            Assert.IsNaN(MathLib.MathLib.Logarithm(1, 1));
            Assert.IsNaN(MathLib.MathLib.Logarithm(1, 0));
            Assert.AreEqual(1, MathLib.MathLib.Logarithm(10, 10), _delta);
            Assert.AreEqual(2, MathLib.MathLib.Logarithm(256, 16), _delta);
            Assert.AreEqual(3, MathLib.MathLib.Logarithm(456533, 77), _delta);
        }
    }
}