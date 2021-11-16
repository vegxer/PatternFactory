using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternFactory.MathSign;
using System;

namespace PatternUnitTest
{
    [TestClass]
    public class PatternUnitTest
    {
        [TestMethod]
        public void SignEqual()
        {
            Sign sign = SignFactory.Create("=");
            Assert.IsTrue(sign.Compare(1, 1));
            Assert.IsFalse(sign.Compare(-1, 1));
            Assert.AreEqual("=", sign.ToString());
            Assert.IsInstanceOfType(sign.Clone(), typeof(SignEqual));
            Assert.IsInstanceOfType(sign.Inverse(), typeof(SignNotEqual));
        }

        [TestMethod]
        public void SignNotEqual()
        {
            Sign sign = SignFactory.Create("!=");
            Assert.IsTrue(sign.Compare(-1, 1));
            Assert.IsFalse(sign.Compare(1, 1));
            Assert.AreEqual("!=", sign.ToString());
            Assert.IsInstanceOfType(sign.Clone(), typeof(SignNotEqual));
            Assert.IsInstanceOfType(sign.Inverse(), typeof(SignEqual));
        }

        [TestMethod]
        public void SignMore()
        {
            Sign sign = SignFactory.Create(">");
            Assert.IsTrue(sign.Compare(1, -1));
            Assert.IsFalse(sign.Compare(-1, 1));
            Assert.AreEqual(">", sign.ToString());
            Assert.IsInstanceOfType(sign.Clone(), typeof(SignMore));
            Assert.IsInstanceOfType(sign.Inverse(), typeof(SignLess));
        }

        [TestMethod]
        public void SignLess()
        {
            Sign sign = SignFactory.Create("<");
            Assert.IsTrue(sign.Compare(-1, 1));
            Assert.IsFalse(sign.Compare(1, -1));
            Assert.AreEqual("<", sign.ToString());
            Assert.IsInstanceOfType(sign.Clone(), typeof(SignLess));
            Assert.IsInstanceOfType(sign.Inverse(), typeof(SignMore));
        }

        [TestMethod]
        public void SignMoreOrEqual()
        {
            Sign sign = SignFactory.Create(">=");
            Assert.IsTrue(sign.Compare(1, 1));
            Assert.IsTrue(sign.Compare(2, 1));
            Assert.IsFalse(sign.Compare(-1, 1));
            Assert.AreEqual(">=", sign.ToString());
            Assert.IsInstanceOfType(sign.Clone(), typeof(SignMoreOrEqual));
            Assert.IsInstanceOfType(sign.Inverse(), typeof(SignLessOrEqual));
        }

        [TestMethod]
        public void SignLessOrEqual()
        {
            Sign sign = SignFactory.Create("<=");
            Assert.IsTrue(sign.Compare(1, 1));
            Assert.IsTrue(sign.Compare(-1, 1));
            Assert.IsFalse(sign.Compare(2, 1));
            Assert.AreEqual("<=", sign.ToString());
            Assert.IsInstanceOfType(sign.Clone(), typeof(SignLessOrEqual));
            Assert.IsInstanceOfType(sign.Inverse(), typeof(SignMoreOrEqual));
        }
    }
}
