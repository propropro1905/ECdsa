﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Numerics;
namespace ECDSA
{
    public class Point
    {
        private BigInteger x;
        private BigInteger y;
        public bool isZero = false;
        public BigInteger X { get => x; set => x = value; }
        public BigInteger Y { get => y; set => y = value; }

        public Point(BigInteger a, BigInteger b)
        {
            this.x = a;
            this.y = b;
        }
        public static bool Equal(Point P, Point Q)
        {
            if ((P.X == Q.X) && (P.Y == Q.Y))
            {
                return true;
            }
            return false;
        }

        public static Point Add(Point a, Point b, BigInteger p)
        {
            if (a.X == 0 && a.Y == 0)
            {
                return b;
            }
            else if (b.X == 0 && b.Y == 0)
            {
                return a;
            }
            else if (a.X == b.X)
            {
                return new Point(0, 0);
            }
            else
            {
                BigInteger lamda = Utility.Modulo((b.y - a.y) * Utility.Reverse_modulo(b.x - a.x, p), p);
                BigInteger cx = Utility.Modulo(lamda * lamda - a.x - b.x, p);
                BigInteger cy = Utility.Modulo(lamda * (a.x - cx) - a.y, p);
                return new Point(cx, cy);
            }
        }

        public static Point Doubling(Point P, BigInteger a, BigInteger p)
        {
            BigInteger lamda = Utility.Modulo((3 * P.x * P.x + a) % p * Utility.Reverse_modulo(2 * P.y, p), p);
            BigInteger cx = Utility.Modulo(lamda * lamda - 2 * P.x, p);
            BigInteger cy = Utility.Modulo(lamda * (P.x - cx) - P.y, p);
            return new Point(cx, cy);
        }
        public static Point Reverse(Point P, BigInteger p)
        {

            BigInteger Qx = P.X;
            BigInteger Qy = Utility.Modulo(-P.Y, p);
            return new Point(Qx, Qy);
        }

        public static Point Subtract(Point P, Point Q, BigInteger p)
        {
            Point R = Point.Add(P, Reverse(Q, p), p);
            return R;
        }

        public static string pointPrinter(Point P)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(" + P.x + "," + P.y + ")");
            return sb.ToString();
        }
        public static Point Multiply(Point P, BigInteger n, BigInteger a, BigInteger p)
        {
            Point Q = new Point(0, 0);
            Point R = P;
            // adding and doubling algorithm

            string n_bin = Utility.byteArrayToBinaryString(n.ToByteArray());
            for (int i = n_bin.Length - 1; i >= 0; i--)
            {
                if (n_bin[i] == '1')
                {
                    Q = Point.Add(Q, R, p);
                }
                R = Point.Doubling(R, a, p);
            }
            return Q;
        }

    }
}
