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
    public partial class Binary : Form
    {
        int TotalZero;
        int TotalOne;
        bool ValidInput;
        int digit1, digit2, digit3, digit4, digit5, digit6, digit7;

        public Binary()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void BinaryInput_TextChanged(object sender, EventArgs e)
        {
            TotalZero = 0;
            TotalOne = 0;
            ValidInput = true;
            string input = BinaryInput.Text;

            if (input.Length != 7 || (!int.TryParse(input[0].ToString(), out digit1) || !int.TryParse(input[1].ToString(), out digit2) || !int.TryParse(input[2].ToString(), out digit3) || !int.TryParse(input[3].ToString(), out digit4) || !int.TryParse(input[4].ToString(), out digit5) || !int.TryParse(input[5].ToString(), out digit6) || !int.TryParse(input[6].ToString(), out digit7)))
            {
                ValidInput = false; // If length != 7 or any inputs != numbers
            }
            else
            {
                TotalOne = digit1 + digit2 + digit3 + digit4 + digit5 + digit6 + digit7;
                TotalZero = 7 - TotalOne;
            }
            SolutionCheck();
        }

        private void SolutionCheck()
        {
            if (ValidInput)
            {
                if (TotalOne == 0)
                {
                    BinarySolution.Text = "Press red ONCE, then\r\nPress green";
                }
                else if (digit2 == 1 && digit7 == 0)
                {
                    BinarySolution.Text = "Press red TWICE, then\r\nPress green";
                }
                else if (digit1 == 1 && digit2 == 1)
                {
                    BinarySolution.Text = "Press red THREE times, then\r\nPress green";
                }
                else if (digit1 == 0 && digit7 == 0)
                {
                    BinarySolution.Text = "Press red FOUR times, then\r\nPress green";
                }
                else if (digit1 == 1 && digit2 == 1 && digit3 == 1)
                {
                    BinarySolution.Text = "Press red FIVE times, then\r\nPress green";
                }
                else if (digit1 == 1 && digit2 == 1 && digit3 == 1 && digit4 == 1)
                {
                    BinarySolution.Text = "Press red SIX times, then\r\nPress green";
                }
                else if (TotalZero > 3)
                {
                    BinarySolution.Text = "Press red SEVEN times, then\r\nPress green";
                }
                else if (TotalOne > 5)
                {
                    BinarySolution.Text = "Press red EIGHT times, then\r\nPress green";
                }
                else if (TotalOne == 7)
                {
                    BinarySolution.Text = "Press red NINE times, then\r\nPress green";
                }
                else
                {
                    BinarySolution.Text = "Press red TEN times, then\r\nPress green";
                }
            }
            else
            {
                BinarySolution.Text = "Waiting for input";
            }
        }
    }
}
