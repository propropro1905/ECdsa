using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace ECDSA
{
    class ECDSA
    {
        public static Tuple<BigInteger, BigInteger> SignData(EllipticCurve E, string message, BigInteger d, HashAlgorithm hash)
        {
            BigInteger r = 1, s = 1;
            bool valid = true;
            do
            {
                BigInteger k = Utility.RandomIntegerBelow(E.N);
                Point P = Point.Multiply(E.G, k, E.A, E.P);
                r = Utility.Modulo(P.X, E.N);
                if (r == 0)
                {
                    valid = false;
                    continue;
                }
                Byte[] e = hash.ComputeHash(Encoding.ASCII.GetBytes("message"));
                BigInteger eInt = new BigInteger(e);
                s = Utility.Modulo(Utility.Reverse_modulo(k, E.N) * (eInt + d * r), E.N);
                if (s == 0)
                {
                    valid = false;
                }
            } while (!valid);

            return new Tuple<BigInteger, BigInteger>(r, s);
        }
        public static bool VerifySign(EllipticCurve E, Point Q, HashAlgorithm hash, Tuple<BigInteger, BigInteger> sign)
        {
            if ((sign.Item1 < 1 && sign.Item1 >E.N-1 )|| (sign.Item2 < 1 && sign.Item2 > E.N - 1))
                return false;
            Byte[] e = hash.ComputeHash(Encoding.ASCII.GetBytes("message"));
            BigInteger eInt = new BigInteger(e);
            BigInteger w = Utility.Reverse_modulo(sign.Item2, E.N);
            BigInteger u1 = Utility.Modulo(eInt * w, E.N), u2 = Utility.Modulo(sign.Item1 * w, E.N);
            Point X = Point.Add(Point.Multiply(E.G, u1, E.A, E.P), Point.Multiply(Q, u2, E.A, E.P), E.P);
            BigInteger v = Utility.Modulo(X.X, E.N);
            if (v == sign.Item1) return true;
            return false;
        }
    }
}
