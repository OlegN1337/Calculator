using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_43and82_125returned()
        {
            //arrenge - настроить
            double x = 43;
            double y = 82;
            double expect = 125;
            //acton - выполнить
            Calc s = new Calc();
            double real = s.Sum(x, y);
            //assert - проверить
            Assert.AreEqual(expect, real);
        }
        [TestMethod]
        public void Dif_82and43_39returned()
        {
            //arrenge - настроить
            double x = 82;
            double y = 43;
            double expect = 39;
            //acton - выполнить
            Calc s = new Calc();
            double real = s.Dif(x, y);
            //assert - проверить
            Assert.AreEqual(expect, real);
        }
        [TestMethod]
        public void Mult_82and43_3526returned()
        {
            //arrenge - настроить
            double x = 82;
            double y = 43;
            double expect = 3526;
            //acton - выполнить
            Calc s = new Calc();
            double real = s.Mult(x, y);
            //assert - проверить
            Assert.AreEqual(expect, real);
        }
        [TestMethod]
        public void Div_80and40_2returned()
        {
            //arrenge - настроить
            double x = 82;
            double y = 43;
            double expect = 3526;
            //acton - выполнить
            Calc s = new Calc();
            double real = s.Div(x, y);
            //assert - проверить
            Assert.AreEqual(expect, real);
        }
    }
}
