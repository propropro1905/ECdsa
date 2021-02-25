using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using ECDSA;

namespace ECDSATest
{
    [TestClass]
    public class PointTest
    {
        //prime 260 bits

        BigInteger x = BigInteger.Parse("89331754253887578797563435133102512887994304215780976787019717066334694809561"),
                      y = BigInteger.Parse("113287199914826466244105331622300178703997415229834845059184543789052866443847"),
        //not prime
                      z = BigInteger.Parse("8933175425388757879756343513310251288799430421578096633469480956139425792135469"),
                      t = BigInteger.Parse("2546235461335412348921235468798464512354687954123546548798745621333479133358");
        //test point

        Point P1 = new Point(BigInteger.Parse("12354655687942321356879799751235466521223212333345858513"),
                             BigInteger.Parse("12358223156879123546512321556478999999999852456135456872181945"));
        Point Q1 = new Point(BigInteger.Parse("12354655687942321356879799751235466521223212333345858513"),
                             BigInteger.Parse("12358223156879123546512321556478999999999852456135456872181945"));
        // testing curve y2=x3+7 mod x
        int a = 0, b = 7;
        
        Point P_ = new Point(BigInteger.Parse("12354655687942321356879799751235466521223212341234"),
                             BigInteger.Parse("50409424367856687823329329772725313561507427718056025805370372766445944710765"));
        Point Q_ = new Point(BigInteger.Parse("8933175425388757879756343513310251288799430421578096633469480956139425792135469"),
                         BigInteger.Parse("940571569069746711255388278377423954830336755847954312017789871642698418271"));
        [TestMethod]
        public void TestIsEqual()
        {
            Point P = new Point(x, y);
            Point Q = new Point(z, t);
            Point P2 = new Point(BigInteger.Parse("12354655687942321356879799751235466521223212333345858513"), x);
            Point Q2 = new Point(BigInteger.Parse("12354655687942321356879799751235466521223212333345858513"), y);
            Assert.AreEqual(Point.Equal(P, Q), false);
            Assert.AreEqual(Point.Equal(P1, Q1), true);
            Assert.AreEqual(Point.Equal(P2, Q2), false);
        }

        [TestMethod]
        public void TestAddPoint()
        {
            Point R_ = Point.Add(P_, Q_, x);
            Point Rtest = new Point(BigInteger.Parse("60137059024190559599050715552679134518917818274171137851349443619422140691501"),
                                    BigInteger.Parse("44675560446543784452016230598289428677304761471742353514488787089956588007614"));

            // assert
            Assert.AreEqual(Point.Equal(Rtest, R_), true);
        }
        [TestMethod]
        public void TestDoublePoint()
        {
            Point R_ = Point.Doubling(P_, a, x);
            Point Rtest = new Point(BigInteger.Parse("16024780185906593207927851689044411544147088727298102385929667173589812433312"),
                                    BigInteger.Parse("20856345860221025448836294884375870192730146222334436913458138565673995820720"));

            Assert.AreEqual(Point.Equal(Rtest, R_), true);
        }
        [TestMethod]
        public void TestMultiply()
        {
            Point R_ = Point.Multiply(P_, 10, a, x);
            Point Rtest = new Point(BigInteger.Parse("18895488335660065350115791273065752693846674684667067199749578493141104561358"),
                                    BigInteger.Parse("22237364998586598440951686845224134494162593106317702459287855783965578708346"));

            Assert.AreEqual(Point.Equal(Rtest, R_), true);

        }
    }
}
