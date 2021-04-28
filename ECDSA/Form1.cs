using System;
using System.Windows.Forms;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Globalization;
using System.Diagnostics;
namespace ECDSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //prime

        // testing curve y2=x3+7 mod x


        HashAlgorithm sha512 = SHA512.Create();
        EllipticCurve E;
        Tuple<BigInteger, Point> keyPair;
        Tuple<BigInteger, BigInteger> sign;
        String mess;
        private void verify_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            if (ECDSAType.Text == "ECDSA")
            {
                output.Text += ("Verification...\n" + ECDSA.VerifySign(E, keyPair.Item2, sha512, sign, mess) + "\n");
            }
            else if (ECDSAType.Text == "ECGDSA")
            {
                output.Text += ("Verification...\n" + ECGDSA.VerifySign(E, keyPair.Item2, sha512, sign, mess) + "\n");
            }
            watch.Stop();
            output.Text += ($"Verify in: {watch.ElapsedMilliseconds} ms \n\n");

        }
        private void sign_Click(object sender, EventArgs e)
        {
            mess = message.Text;
            var watch = new Stopwatch();
            watch.Start();
            if (ECDSAType.Text == "ECDSA")
            {
                sign = ECDSA.SignData(E, mess, keyPair.Item1, sha512);
            }
            else if (ECDSAType.Text == "ECGDSA")
            {
                sign = ECGDSA.SignData(E, mess, keyPair.Item1, sha512);
            }
            watch.Stop();
            output.Text += ("Your signature is\nr = " + sign.Item1 + "\ns = " + sign.Item2 + "\n");
            output.Text += ($"Generate signature in: {watch.ElapsedMilliseconds} ms\n\n");
        }

        private void bitCurves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ECbit.SelectedIndex == 0)
            {
                namedCurves.Items.Clear();
                List<String> items = new List<string> { "secp112r1", "secp112r2" };
                namedCurves.Items.AddRange(items.ToArray());
            }
            else if (ECbit.SelectedIndex == 1)
            {
                namedCurves.Items.Clear();
                List<String> items = new List<string> { "secp128r1", "secp128r2" };
                namedCurves.Items.AddRange(items.ToArray());
            }else if (ECbit.SelectedIndex == 7)
            {
                namedCurves.Items.Clear();
                List<String> items = new List<string> { "secp521r1" };
                namedCurves.Items.AddRange(items.ToArray());
            }
        }

        private void GenerateKeyPair_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            if (ECDSAType.SelectedIndex == 0)
            {
                keyPair = ECDSA.keyGen(E);
            }
            else if (ECDSAType.SelectedIndex == 1)
            {
                keyPair = ECGDSA.keyGen(E);
            }
            privatekey.Text += keyPair.Item1;
            publickey.Text = Point.pointPrinter(keyPair.Item2);
            output.Text += ("private key = " + privatekey.Text + "\n");
            output.Text += ("public key = " + publickey.Text + "\n");
            watch.Stop();
            output.Text += ($"Generate key pair in: {watch.ElapsedMilliseconds} ms\n\n");
        }

        private void namedCurves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (namedCurves.Text == "secp112r1")
            {
                BigInteger p = (BigInteger.Pow(2, 128) - 3) / 76439;
                BigInteger a = BigInteger.Parse("0DB7C2ABF62E35E668076BEAD2088", NumberStyles.AllowHexSpecifier);
                BigInteger b = BigInteger.Parse("0659EF8BA043916EEDE8911702B22", NumberStyles.AllowHexSpecifier);
                BigInteger xG = BigInteger.Parse("009487239995A5EE76B55F9C2F098", NumberStyles.AllowHexSpecifier);
                BigInteger yG = BigInteger.Parse("0A89CE5AF8724C0A23E0E0FF77500", NumberStyles.AllowHexSpecifier);
                BigInteger n = BigInteger.Parse("0DB7C2ABF62E35E7628DFAC6561C5", NumberStyles.AllowHexSpecifier);
                BigInteger h = 1;
                Point G = new Point(xG, yG);
                E = new EllipticCurve(p, a, b, G, n, h);
                output.Clear();
                output.Text += EllipticCurve.ECPrinter(E) + "\n";
            }else if(namedCurves.Text == "secp521r1")
            {
                BigInteger p = BigInteger.Pow(2, 521) - 1;
                BigInteger a = BigInteger.Parse("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC", NumberStyles.AllowHexSpecifier);
                BigInteger b = BigInteger.Parse("0051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00", NumberStyles.AllowHexSpecifier);
                BigInteger xG = BigInteger.Parse("00C6858E06B70404E9CD9E3ECB662395B4429C648139053FB521F828AF606B4D3DBAA14B5E77EFE75928FE1DC127A2FFA8DE3348B3C1856A429BF97E7E31C2E5BD66", NumberStyles.AllowHexSpecifier);
                BigInteger yG = BigInteger.Parse("011839296A789A3BC0045C8A5FB42C7D1BD998F54449579B446817AFBD17273E662C97EE72995EF42640C550B9013FAD0761353C7086A272C24088BE94769FD16650", NumberStyles.AllowHexSpecifier);
                BigInteger n = BigInteger.Parse("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409", NumberStyles.AllowHexSpecifier);
                BigInteger h = 1;
                Point G = new Point(xG, yG);
                E = new EllipticCurve(p, a, b, G, n, h);
                output.Clear();
                output.Text += EllipticCurve.ECPrinter(E) + "\n";
            }
        }

        private void ECDSAType_SelectedIndexChanged(object sender, EventArgs e)
        {
            output.Text += (ECDSAType.Text + "\n");

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
            privatekey.Text = string.Empty;
            publickey.Text = string.Empty;
            message.Text = string.Empty;
        }
    }
}