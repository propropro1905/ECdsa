using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using System.Collections;
using System.Security.Cryptography;

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
              () =>
              {
                  return new Random();
              }
            );

        // Random generator (thread safe)
        public static Random Gen
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
            if (IsProbablyPrime(b))
            {
                return BigInteger.ModPow(a, b - 2, b);
            }
            
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
            
        }

        public static bool isFieldElement(BigInteger p, BigInteger n)
        {
            if (n < 0 || n > p - 1) return false;
            return true;
        }
        /***
         * functions to process binary string
         * 
         * 
         * 
         */
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
            for (int i = 0; i < number; i++)
            {
                RightMost[i] = bitArray[len - number + i];
            }

            return RightMost;
        }

        public static byte[] BitArrayToBytes(BitArray bitarray)
        {
            if (bitarray.Length == 0)
            {
                throw new System.ArgumentException("must have at least length 1", "bitarray");
            }

            int num_bytes = bitarray.Length / 8;
            if (bitarray.Length % 8 != 0)
            {
                num_bytes += 1;
            }

            var bytes = new byte[num_bytes];
            bitarray.CopyTo(bytes, 0);
            return bytes;
        }
        public static string BitArrayToStringFormat(BitArray bitt)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var bit in bitt)
            {
                if ((bool)bit) sb.Append("1");
                else sb.Append("0");
            }
            return sb.ToString();
        }
        public static BitArray StringToBitArray(string s)
        {
            BitArray bitt = new BitArray(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0') bitt[i] = false;
                else bitt[i] = true;
            }
            return bitt;
        }
        public static string byteArrayToBinaryString(Byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Convert.ToString(bytes[bytes.Length - 1], 2));
            for (int i = bytes.Length - 2; i >= 0; i--)
            {
                sb.Append(Convert.ToString(bytes[i], 2).PadLeft(8, '0')); //fill empty bit with 0
            }
            return sb.ToString();
        }
        /// <summary>
        /// random big integer below N
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static BigInteger RandomIntegerBelow(BigInteger N)
        {
            byte[] bytes = N.ToByteArray();
            BigInteger R;

            do
            {
                Gen.NextBytes(bytes);
                bytes[bytes.Length - 1] &= (byte)0x7F; //force sign bit to positive
                R = new BigInteger(bytes);
            }
            while (R > N || R < 1);
            return R;
        }
        /***
         * process text for cryptosystem
         * 
         * 
         */
        public static BigInteger GetProcessedNumber(Byte[] basenumber, int numberofbit)
        {
            int partition = (numberofbit / 8 - basenumber.Length);
            int firstArrayLength;
            int lastArrayLength;
            if (partition % 2 == 0)
            {
                firstArrayLength = partition / 2;
                lastArrayLength = partition / 2;
            }
            else
            {
                firstArrayLength = partition / 2 + 1;
                lastArrayLength = partition / 2;
            }
            byte[] firstRandomPart = new byte[firstArrayLength];
            byte[] lastRandomPart = new byte[lastArrayLength];

            Gen.NextBytes(firstRandomPart);
            Gen.NextBytes(lastRandomPart);
            //make sure number is positive
            lastRandomPart[lastRandomPart.Length - 1] &= (byte)0x7F;
            IEnumerable<byte> number = firstRandomPart.Concat(basenumber).Concat(lastRandomPart);
            return new BigInteger(number.ToArray());
        }
        public static string GetTextFromProcessedNumber(BigInteger processedNum, int textbit )
        {
            byte[] bytes = processedNum.ToByteArray();
            int partition = (bytes.Length - textbit / 8);
            int firstArrayLength;

            if (partition % 2 == 0)
            {
                firstArrayLength = partition / 2;
            }
            else
            {
                firstArrayLength = partition / 2 + 1;
            }
            byte[] messageToByte = new byte[textbit/8];
            for (int i = 0; i < textbit / 8; i++)
            {
                messageToByte[i] = bytes[i + firstArrayLength];
            }
            return Encoding.ASCII.GetString(messageToByte);
        }
        /***
         * calculate x^2=y mod p
         * using euclide citerion to determine if n has squareroot mod p
         * using formular in the case p = 3 mod 4
         * to do : develope Tonelli–Shanks algorithm for 
         */
        public static bool hasSquareRoot(BigInteger n, BigInteger p)
        {
            if (n == 0) return false;
            if (BigInteger.ModPow(n, (p - 1) / 2, p) == 1) return true;
            return false;

        }
        public static BigInteger squareRoot(BigInteger n, BigInteger p)
        {
            if (p % 4 != 3)
            {
                return BigInteger.Zero;
            }

            // Try "+-(n^((p + 1)/4))"
            n = n % p;
            BigInteger x = BigInteger.ModPow(n, (p + 1) / 4, p);
            if ((x * x) % p == n)
            {
                return x;
            }
            x = p - x;
            if ((x * x) % p == n)
            {
                return x;
            }
            return BigInteger.Zero;
        }
        /// <summary>
        /// embed text on elliptic curve
        /// </summary>
        /// <param name="m"></param>
        /// <param name="E"></param>
        /// <returns></returns>
        public static List<Point> EmbededTextOnCurve(string m, EllipticCurve E)
        {
            List<Point> messagePoints = new List<Point>();


            int lengthOfPoint = (int)((BigInteger.Log(E.P, 2)) / 8);//get a point with x smaller than P
            int lengthEmbeded = 64; // embed per 64 bits
            while (m.Length % (lengthEmbeded / 8) != 0) // fill m with " " until m.Length % 8 = 0 
            {
                m += " ";
            }
            List<string> substring = Split(m, lengthEmbeded / 8).ToList();


            foreach (string s in substring)
            {
                BigInteger xP = 0, yP = 0;
                do
                {
                    do
                    {
                        xP = Utility.GetProcessedNumber(Encoding.ASCII.GetBytes(s), lengthOfPoint * 8);
                    } while (!Utility.hasSquareRoot(xP, E.P));
                    yP = Utility.squareRoot(BigInteger.Pow(xP, 3) + E.A * xP + E.B, E.P);
                } while (yP == 0);

                messagePoints.Add(new Point(xP, yP));
            }

            return messagePoints;
        }
        private static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
