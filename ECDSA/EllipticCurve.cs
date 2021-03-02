using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.Collections;
namespace ECDSA
{
    public class EllipticCurve
    {
        private BigInteger p;
        private BigInteger a;
        private BigInteger b;
        private string seed;
        public BigInteger P { get => p; set => p = value; }
        public BigInteger A { get => a; set => a = value; }
        public BigInteger B { get => b; set => b = value; }
        public string Seed { get => seed; set => seed = value; }

        public static EllipticCurve ECRandomGenerator(BigInteger p)
        {
            EllipticCurve E = new EllipticCurve();
            // asset
            int t = (int) Math.Ceiling(BigInteger.Log(p, 2));
            int s =  (int) Math.Floor((double) (t-1)/160);
            int v = t - 160*s ;
            var rng = new RNGCryptoServiceProvider();

            BigInteger r = new BigInteger();
            do
            {
                // get random 160 bit string seed
                Byte[] bytes = new byte[20]; //160 bit string;
                rng.GetBytes(bytes);



                string seedE = Convert.ToBase64String(bytes);
                E.Seed = seedE;
                SHA1 sha1 = SHA1.Create();

                Byte[] h = sha1.ComputeHash(bytes);
                // c0 is the rightmost v bit of h
                BitArray w0 = Utility.GetRightMost(new BitArray(h), v);
                // Make sure r<p
                if (w0[0]) w0[0] = false;



                BigInteger z = new BigInteger(bytes);
                // make sure z > 0
                if (z < 0) z = -z;


                string[] w = new string[s + 1];
                w[0] = Utility.BitArrayToStringFormat(w0);
                for (int i = 1; i <= s; i++)
                {
                    BigInteger num= Utility.Modulo(z + i, BigInteger.Pow(2, 160));
                    BitArray si = new BitArray(sha1.ComputeHash(num.ToByteArray()));
                    w[i] = Utility.BitArrayToStringFormat(si);
                }
                string concate = "";
                foreach (string wi in w)
                {
                    concate += wi;
                }
                r = new BigInteger(Utility.BitArrayToBytes(Utility.StringToBitArray(concate)));
            } while (r == 0 || Utility.Modulo(4 * r + 27,p) == 0);
            //Random 128 bit interger such that q%p != 0
            BigInteger q = new BigInteger();
            do
            {
                Byte[] qx = new byte[16]; //128 bit integer;
                rng.GetBytes(qx);
                q = new BigInteger(qx);
            } while (q % p == 0);
            // a = rq^2, b= rq^3, r.b^2 = a^3 mod p
            E.A = (r * q * q) % p;
            E.B = (r*BigInteger.Pow(q,3))%p;
            E.P = p;
            return E;
        }
    }
}
