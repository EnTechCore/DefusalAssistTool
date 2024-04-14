using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefusalAssistTool
{
    public partial class Timing : Form
    {
        int digit1, digit2, letter1, letter2;
        bool ValidInput = false;
        public Timing()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void TimingInput_TextChanged(object sender, EventArgs e)
        {
            ValidInput = true;
            string input = TimingInput.Text.ToUpper().Replace(" ", "");

            if (input.Length == 4 && char.IsDigit(input[0]) && char.IsDigit(input[1]) && char.IsLetter(input[2]) && char.IsLetter(input[3]))
            {
                digit1 = int.Parse(input[0].ToString());
                digit2 = int.Parse(input[1].ToString());
                letter1 = TranslateChar(input[2]);
                letter2 = TranslateChar(input[3]);

                if (letter1 == -1 || letter2 == -1)
                {
                    ValidInput = false;
                }
            }
            else
            {
                ValidInput = false;
            }
            CheckSolution();
        }
        private int TranslateChar(char c)
        {
            // Translation
            switch (c)
            {
                case 'A': return 4;
                case 'B': return 3;
                case 'C': return 7;
                case 'D': return 9;
                default: return -1; // Return -1 for invalid characters
            }
        }
        private void CheckSolution()
        {
            if (ValidInput)
            {
                int X = digit1 + digit2;
                int Y = letter1 + letter2;
                int Z = X * Y;

                if (Z >= 0 && Z <= 59)
                {
                    TimingSolution.Text = "White";
                }
                else if (Z >= 60 && Z <= 99)
                {
                    TimingSolution.Text = "Red";
                }
                else if (Z >= 100 && Z <= 199)
                {
                    TimingSolution.Text = "Yellow";
                }
                else if (Z >= 200 && Z <= 299)
                {
                    TimingSolution.Text = "Green";
                }
                else if (Z >= 300 && Z <= 399)
                {
                    TimingSolution.Text = "Blue";
                }
                else if (Z >= 400 && Z <= 499)
                {
                    TimingSolution.Text = "Yellow";
                }
                else if (Z >= 500 && Z <= 599)
                {
                    TimingSolution.Text = "Red";
                }
                else if (Z >= 600)
                {
                    TimingSolution.Text = "White";
                }
                else
                {
                    TimingSolution.Text = "Waiting for input";
                }
            }
            else
            {
                TimingSolution.Text = "Waiting for input";
            }
        }
    }
}
