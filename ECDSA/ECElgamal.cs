using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ECDSA
{
    public class ECElgamal
    {
        public static List<Tuple<Point, Point>> Encryption(string message, EllipticCurve E, Point Bobpublickey)
        {
            BigInteger k = Utility.RandomIntegerBelow(E.N);
            List<Point> plainText = Utility.EmbededTextOnCurve(message, E);
            List<Tuple<Point, Point>> cyphertext = new List<Tuple<Point, Point>>();
            foreach (var point in plainText)
            {
                Point m1 = Point.Multiply(E.G, k, E.A, E.P);
                Point m2 = Point.Add(point, Point.Multiply(Bobpublickey, k, E.A, E.P), E.P);
                cyphertext.Add(new Tuple<Point, Point>(m1, m2));
            }
            return cyphertext;
        }
    }
}
