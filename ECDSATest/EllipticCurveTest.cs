using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ECDSA;
using System.Numerics;
namespace ECDSATest
{
    [TestClass]
    public class EllipticCurveTest
    {
        BigInteger p = BigInteger.Parse("89331754253887578797563435133102512887994304215780976787019717066334694809561");
        [TestMethod]
        public void TestRandomGenerator()
        {
            EllipticCurve E = EllipticCurve.ECRandomGenerator(p);

        }
    }
}
