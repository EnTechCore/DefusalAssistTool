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
    public partial class Maths : Form
    {
        int Number1;
        int Number2;
        int EndResult;
        bool ValidInput;
        public Maths()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void MathsInput_TextChanged(object sender, EventArgs e)
        {
            // Reset variable
            ValidInput = true;
            // Convert to uppercase and remove spaces
            string input = MathsInput.Text.ToUpper().Replace(" ", "");

            // Check if input length is exactly 4
            if (input.Length != 4)
            {
                ValidInput = false;
            }
            else
            { // Translation
                int digit1 = TranslateChar(input[0]);
                int digit2 = TranslateChar(input[1]);
                int digit3 = TranslateChar(input[2]);
                int digit4 = TranslateChar(input[3]);

                if (digit1 == -1 || digit2 == -1 || digit3 == -1 || digit4 == -1)
                {
                    ValidInput = false;
                }
                else
                {
                    Number1 = digit1 * 10 + digit2;
                    Number2 = digit3 * 10 + digit4;
                }
            }
            CheckSolution();
        }

        private int TranslateChar(char c)
        {
            // Translation
            switch (c)
            {
                case 'A': return 1;
                case 'B': return 3;
                case 'C': return 7;
                case 'D': return 2;
                case 'E': return 4;
                case 'F': return 5;
                case 'G': return 6;
                case 'H': return 0;
                case 'I': return 8;
                case 'J': return 9;
                default: return -1; // Return -1 for invalid characters
            }
        }

        private void CheckSolution()
        {
            if (ValidInput)
            {
                EndResult = Number1 * Number2;
                MathsSolution.Text = EndResult.ToString();
            }
            else
            {
                MathsSolution.Text = "Waiting for input";
            }
        }
    }
}
