﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.Collections;
namespace ECDSA
{
    class EllipticCurve
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
            // get random 160 bit string seed
            Byte[] bytes = new byte[20]; //160 bit string;
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);



            string seedE = Convert.ToBase64String(bytes);
            E.seed = seedE;
            SHA1 sha1 = SHA1.Create();

            Byte[] h = sha1.ComputeHash(bytes);
            // c0 is the rightmost v bit of h
            BitArray w0 = Utility.GetRightMost(new BitArray(h), v);
            // Make sure r<p
            if (w0[0]) w0[0] = false;

            BigInteger z = new BigInteger(bytes);
            string[] w = new string[s+1];
            w[0] = Encoding.Default.GetString(Utility.BitArrayToBytes(w0));
            for (int i =1; i <= s; i++)
            {
                BigInteger a = Utility.Modulo(z + i, BigInteger.Pow(2, 160));
            }
            return E;

        }
    }
}
