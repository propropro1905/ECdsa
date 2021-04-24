using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ECDSA;
using System.Numerics;
using System.Globalization;
namespace ECDSATest
{
    [TestClass]
    public class EllipticCurveTest
    {
        BigInteger p = BigInteger.Parse("89331754253887578797563435133102512887994304215780976787019717066334694809561");
   

        //BigInteger p = (BigInteger.Pow(2, 128) - 3) / 76439;
        BigInteger a = BigInteger.Parse("0DB7C2ABF62E35E668076BEAD2088", NumberStyles.AllowHexSpecifier);
        BigInteger b = BigInteger.Parse("0659EF8BA043916EEDE8911702B22", NumberStyles.AllowHexSpecifier);
        BigInteger xG = BigInteger.Parse("009487239995A5EE76B55F9C2F098", NumberStyles.AllowHexSpecifier);
        BigInteger yG = BigInteger.Parse("0A89CE5AF8724C0A23E0E0FF77500", NumberStyles.AllowHexSpecifier);
        BigInteger n = BigInteger.Parse("0DB7C2ABF62E35E7628DFAC6561C5", NumberStyles.AllowHexSpecifier);


        /**
        BigInteger p = BigInteger.Pow(2,521)-1;
        BigInteger a = BigInteger.Parse("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC", NumberStyles.AllowHexSpecifier);
        BigInteger b = BigInteger.Parse("0051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00", NumberStyles.AllowHexSpecifier);
        BigInteger xG = BigInteger.Parse("00C6858E06B70404E9CD9E3ECB662395B4429C648139053FB521F828AF606B4D3DBAA14B5E77EFE75928FE1DC127A2FFA8DE3348B3C1856A429BF97E7E31C2E5BD66", NumberStyles.AllowHexSpecifier);
        BigInteger yG = BigInteger.Parse("011839296A789A3BC0045C8A5FB42C7D1BD998F54449579B446817AFBD17273E662C97EE72995EF42640C550B9013FAD0761353C7086A272C24088BE94769FD16650", NumberStyles.AllowHexSpecifier);
        BigInteger n = BigInteger.Parse("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409", NumberStyles.AllowHexSpecifier);
        */
        [TestMethod]
        public void TestRandomGenerator()
        {
            for(int i = 0; i< 50; i++)
            {
                EllipticCurve E = EllipticCurve.ECRandomGenerator(p);
                Assert.AreNotEqual(Utility.Modulo(4 * BigInteger.Pow(E.A,3) + 27 * BigInteger.Pow(E.B,2), p), 0);
            }
        }
    }
}
