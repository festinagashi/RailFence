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
            int c = Convert.ToInt32(key.Text);
            string s = TxtPlan.Text;

            var lines = new List<StringBuilder>();

            for (int i = 0; i < c; i++)
                lines.Add(new StringBuilder());
            int currentLine = 0;
            int direction = 1;

            for (int i =0; i < s.Length; i++)
            {
                lines[currentLine].Append(s[i]);
                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == c - 1)
                    direction = -1;

                currentLine += direction;
            }
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < c; i++)
                result.Append(lines[i].ToString());

            TxtCipher.Text = result.ToString();

        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(key.Text);
            string s = TxtCipher.Text;
            int n = s.Length;
            var lines = new List<StringBuilder>();

            for (int i = 0; i < c; i++)
                lines.Add(new StringBuilder());
     
            int[] linesLenght = Enumerable.Repeat(0, c).ToArray();


            int currentLine = 0;
            int direction = 0;


            for (int i = 0; i < n; i++)
            {
                linesLenght[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == c - 1)
                    direction = -1;

                currentLine += direction;
            }

            int currentChar = 0;

            for (int line = 0; line < c; line++)
            {
                for (int j = 0; j < linesLenght[line]; j++)
                {
                    lines[line].Append(s[currentChar]);
                    currentChar++;
                }
            }

            StringBuilder result = new StringBuilder();

            currentLine = 0;
            direction = 1;

         
            int[] currentReadLine = Enumerable.Repeat(0, c).ToArray();

            for (int i = 0; i < n; i++)
            {

                result.Append(lines[currentLine][currentReadLine[currentLine]]);
                currentReadLine[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == c - 1)
                    direction = -1;

                currentLine += direction;
            }

            TxtDecipher.Text = result.ToString();
                  
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
            key.Text = "";
        }
    }
}
