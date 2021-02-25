using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ECDSA;
using System.Numerics;

namespace ECDSATest
{
    [TestClass]
    public class UtilityTest
    {
        BigInteger x = BigInteger.Parse("89331754253887578797563435133102512887994304215780976787019717066334694809561"),
                   y = BigInteger.Parse("113287199914826466244105331622300178703997415229834845059184543789052866443847");
        BigInteger z = BigInteger.Parse("8933175425388757879756343513310251288799430421578096633469480956139425792135469"),
                   t = BigInteger.Parse("2546235461335412348921235468798464512354687954123546548798745621333479133358");
        
            
        [TestMethod]
        public void TestIsProbablyPrime()
        {
            //assert
            Assert.AreEqual(Utility.IsProbablyPrime(x), true);
            Assert.AreEqual(Utility.IsProbablyPrime(y), true);
            Assert.AreEqual(Utility.IsProbablyPrime(z), false);
        }
        [TestMethod]
        public void TestReverseModulo()
        {
            //arrange

            //act
            BigInteger result1 = Utility.Modulo(z*Utility.Reverse_modulo(z, x),x);
            //assert
            Assert.AreEqual(result1, 1);
        }
        [TestMethod]
        public void TestModulo()
        {
            Assert.AreEqual(Utility.Modulo(BigInteger.Parse("-15345"), BigInteger.Parse("2867891")), 2852546);
        }

    }
}
