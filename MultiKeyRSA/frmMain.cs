using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace MultiKeyRSS
{
    public partial class frmMain : Form
    {
        int primeCount = 0;

        bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }

        BigInteger RandomWithGCD1(BigInteger min, BigInteger max)
        {
            RandomBigInteger rbi = new RandomBigInteger();
            BigInteger value = 0;
            do
            {
                value = rbi.NextBigInteger(min, max);
                BigInteger a = BigInteger.GreatestCommonDivisor(value, max);
            } while (BigInteger.GreatestCommonDivisor(value, max) != 1);
            return value;
        }

        public frmMain()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            primeCount = Convert.ToInt32(tbPrimeCount.Text);
            if (IsPowerOfTwo(primeCount))
            {
                flpPrimes.Controls.Clear();
                for (int i = 0; i < primeCount; i++)
                    flpPrimes.Controls.Add(new ucPrimeKey((i + 1).ToString() + ". anahtar") { Name = (i + 1).ToString() });
            }
            else
                MessageBox.Show("Girilen değer 2^n formatında olmalı");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<BigInteger> primeNumbers = new List<BigInteger>(primeCount);
            List<BigInteger> primeCopy = new List<BigInteger>(primeCount);
            List<BigInteger> eulerPhi = new List<BigInteger>();
            List<BigInteger> randome = new List<BigInteger>();
            List<BigInteger> AValues = new List<BigInteger>();
            for (int i = 0; i < primeCount; i++)
                primeNumbers.Add(new BigInteger(Convert.ToInt32(((ucPrimeKey)flpPrimes.Controls.Find((i + 1).ToString(), true)[0]).getValue())));
            primeCopy.AddRange(primeNumbers);
            int count = primeCopy.Count;
            while (count > 1)
            {
                for (int i = 0; i < count; i += 2)
                {
                    BigInteger Nn = primeCopy[i] * primeCopy[i + 1];
                    primeCopy.Add(Nn);
                    primeNumbers.Add(Nn);
                    eulerPhi.Add((primeCopy[i] - 1) * (primeCopy[i + 1] - 1));
                }
                primeCopy.RemoveRange(0, count);
                count = primeCopy.Count;
            }
            BigInteger N = primeCopy[0];

            BigInteger eulerPhiN = 1;
            for (int i = 0; i < primeCount / 2; i++)
            {
                randome.Add(RandomWithGCD1(1, eulerPhi[i]));
                eulerPhiN *= eulerPhi[i];
            }

            int primeCounter = 0;
            for (int i = 0; i < randome.Count; i += 2)
                AValues.Add(BigInteger.ModPow(randome[i], randome[i + 1], primeNumbers[3 * primeCount / 2 + primeCounter++]));

            count = AValues.Count;
            while (count > 1)
            {
                for (int i = 0; i < count; i += 2)
                    AValues.Add(BigInteger.ModPow(AValues[i], AValues[i + 1], primeNumbers[3 * primeCount / 2 + primeCounter++]));
                AValues.RemoveRange(0, count);
                count = AValues.Count;
            }

            BigInteger ESub = AValues[0];
            BigInteger E = RandomWithGCD1(1, eulerPhiN * ESub);

            TANBigInteger x = new TANBigInteger((eulerPhiN * ESub).ToString(), 10);
            TANBigInteger tanE = new TANBigInteger(E.ToString(), 10);
            BigInteger D = new BigInteger();
            BigInteger.TryParse(tanE.modInverse(x).ToString(), out D);

            BigInteger input = Convert.ToInt32(tbInput.Text);

            BigInteger output = BigInteger.ModPow(input, E, primeNumbers[primeCount]);

            BigInteger decrypted = BigInteger.ModPow(output, D, primeNumbers[primeCount]);
            sw.Stop();

            tbSteps.Text += "N = " + N + Environment.NewLine;
            tbSteps.Text += "Φ(N)= " + eulerPhiN + Environment.NewLine;
            for (int i = 0; i < primeCount / 2; i++)
                tbSteps.Text += "e" + (i + 1) + "= " + randome[i] + Environment.NewLine;
            tbSteps.Text += "E'= " + ESub + Environment.NewLine;
            tbSteps.Text += "E= " + E + Environment.NewLine;
            tbSteps.Text += "D= " + D + Environment.NewLine;
            tbSteps.Text += "input= " + input + Environment.NewLine;
            tbSteps.Text += "output= " + output + Environment.NewLine;
            tbSteps.Text += "decrypted= " + decrypted + Environment.NewLine;
            tbSteps.Text += "Süre: " + sw.ElapsedMilliseconds + " ms";
        }
    }
}
