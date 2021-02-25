﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using System.Collections;

namespace ECDSA
{
    public class Utility
    {
        public int CharToIndex(char c)
        {
            int d = char.ToUpper(c) - 64;
            return d;
        }
        public char IndexToChar(int index)
        {
            return (char)(index + 96);
        }
        public static BigInteger Modulo(BigInteger a, BigInteger b) // return a mod b
        {
            if (a % b < 0)
            {
                return b + a % b;
            }
            return a % b;
        }


        /// <summary>
        /// Prime for big interger
        /// </summary>
        private static ThreadLocal<Random> s_Gen = new ThreadLocal<Random>(
              () => {
                  return new Random();
              }
            );

        // Random generator (thread safe)
        private static Random Gen
        {
            get
            {
                return s_Gen.Value;
            }
        }
        // miller-rabin standard
        public static bool IsProbablyPrime(BigInteger number, int witnesses = 10)
        {
            if (number <= 1)
                return false;


            BigInteger m = number - 1;
            int s = 0;
            while (m % 2 == 0)
            {
                m /= 2;
                s++;
            }

            Byte[] bytes = new Byte[number.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < witnesses; i++)
            {
                do
                {
                    Gen.NextBytes(bytes);

                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= number - 2);

                BigInteger x = BigInteger.ModPow(a, m, number);
                if (x == 1 || x == number - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, number);

                    if (x == 1)
                        return false;
                    if (x == number - 1)
                        break;
                }

                if (x != number - 1)
                    return false;
            }

            return true;
        }
        public static BigInteger Reverse_modulo(BigInteger a, BigInteger b) // return a^-1 mod b
        {
            return BigInteger.ModPow(a, b - 2, b);
            /*
            else
            {
                BigInteger i = b, v = 0, d = 1;
                while (a > 0)
                {
                    BigInteger t = i / a, x = a;
                    a = i % x;
                    i = x;
                    x = d;
                    d = v - t * x;
                    v = x;
                }
                v %= b;
                if (v < 0) v = (v + b) % b;
                return v;
            }
            */
        }


        public static string PrintBitArray(BitArray bits)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < bits.Count; i++)
            {
                char c = bits[i] ? '1' : '0';
                sb.Append(c);
            }

            return sb.ToString();
        }

        public static BitArray GetRightMost(BitArray bitArray, int number)
        {
            BitArray RightMost = new BitArray(number);
            int len = bitArray.Count;
            for(int i = 0 ; i < number; i++)
            {
                RightMost[i] = bitArray[len-number+i] ;
            }

            return RightMost;
        }


    }
}
