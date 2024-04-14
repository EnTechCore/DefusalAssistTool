﻿using System;
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

            if (BinaryInput.Text.Length != 7)
            {
                ValidInput = false;
            }
            else
            {

                if (!int.TryParse(BinaryInput.Text[0].ToString(), out digit1) || !int.TryParse(BinaryInput.Text[1].ToString(), out digit2) || !int.TryParse(BinaryInput.Text[2].ToString(), out digit3) || !int.TryParse(BinaryInput.Text[3].ToString(), out digit4) || !int.TryParse(BinaryInput.Text[4].ToString(), out digit5) || !int.TryParse(BinaryInput.Text[5].ToString(), out digit6) || !int.TryParse(BinaryInput.Text[6].ToString(), out digit7))
                {
                    ValidInput = false; // If any fails, set this
                }
                else
                {
                    TotalOne = digit1 + digit2 + digit3 + digit4 + digit5 + digit6 + digit7;
                    TotalZero = 7 - TotalOne;
                }
            }

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
