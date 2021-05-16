using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekti1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncryption_Click(object sender, EventArgs e)
        {
            string s = TxtPlan.Text;
            string odd = "", even = "";
            for(int i =0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    even = even + s[i];
                else
                    odd = odd + s[i];
                TxtCipher.Text = even + odd;

            }

        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            string oe = "";
            string s = TxtCipher.Text;
            int i;
            int n = s.Length;
            if (n % 2 == 0)
                for (i = 0; i < n / 2; i++)
                    oe = oe + s[i]+s[i+n/2];
            else
            {
                for (i = 0; i < n / 2 +1; i++)
                {
                    if (n / 2 + i +1 != s.Length)
                    {
                        oe = oe + s[i] + s[i + n / 2 + 1];
                    }

                    else
                        oe = oe + s[i];

                }
            }
            TxtDecipher.Text = oe;
                  
        }

        private void TxtPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtPlan.Text = "";
            TxtCipher.Text = "";
            TxtDecipher.Text = "";
        }
    }
}
