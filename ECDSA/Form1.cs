using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;
namespace ECDSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //prime
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
        Point G = new Point(13, 2);
        Tuple<BigInteger, BigInteger> sign;
        HashAlgorithm sha256 = SHA256.Create();
        string message = "hello";
        private void verify_Click(object sender, EventArgs e)
        {
            EllipticCurve E = new EllipticCurve(23, -3, 8, G, 31, 1);
            BigInteger d = BigInteger.Parse(PrivateKey.Text);

            Point Publickey = Point.Multiply(G, d, -3, 23);
            if (ECDSA.VerifySign(E, Publickey, sha256, sign,message)){
                richTextBox1.Text = "true";
            }else
            {
                richTextBox1.Text = "false";
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            EllipticCurve E = new EllipticCurve(23, -3, 8, G, 31, 1);
            string message = "hello";
            BigInteger d = BigInteger.Parse(PrivateKey.Text);
            
            sign = ECDSA.SignData(E, message, d, sha256);
            richTextBox1.Text = (sign.Item1+"\n"+sign.Item2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            EllipticCurve E = EllipticCurve.ECRandomGenerator(x);
            richTextBox1.Text = ("Elliptic Curve: y^2 = x^3 + " + E.A + " + " + E.B + "(mod " + E.P + ") \n Seed :" + E.Seed);

        }
    }
}