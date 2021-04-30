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
        public static List<Tuple<Point, Point>> Encryption(string message, EllipticCurve E, Point BobPublicKey)
        {
            List<Point> plainText = Utility.EmbededTextOnCurve(message, E);

            List<Tuple<Point, Point>> cyphertext = new List<Tuple<Point, Point>>();
            foreach (var point in plainText)
            {
                BigInteger k = Utility.RandomIntegerBelow(E.N);
                Point m1 = Point.Multiply(E.G, k, E.A, E.P);
                Point m2 = Point.Add(point, Point.Multiply(BobPublicKey, k, E.A, E.P), E.P);
                cyphertext.Add(new Tuple<Point, Point>(m1, m2));
            }
            return cyphertext;
        }
        public static string Decryption(List<Tuple<Point, Point>> cyphertext, BigInteger BobPrivateKey, EllipticCurve E)
        {
            string plaintext = "";
            foreach (var text in cyphertext)
            {
                Point S = Point.Subtract(text.Item2, Point.Multiply(text.Item1, BobPrivateKey, E.A, E.P), E.P);
                //Console.WriteLine(Point.pointPrinter(S));
                plaintext += Utility.GetTextFromProcessedNumber(S.X, 64);
            }
            return plaintext;
        }
    }
}
