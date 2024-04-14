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
    public partial class Keypads : Form
    {
        int keypad1 = -1;
        int keypad2 = -1;
        int keypad3 = -1;
        int keypad4 = -1;
        bool ValidInput = false;
        int X;
        int Y;
        int Z;
        public Keypads()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void SolutionCheck() // This one in particular is also an absolute mess, enjoy
        {
            if (keypad1 == -1 || keypad2 == -1 || keypad3 == -1 || keypad4 == -1)
            {
                KeypadsSolution.Text = "Waiting for input";
                ValidInput = false;
            }
            else
            {
                ValidInput = true;
            }
            if (ValidInput)
            {
                // First step
                if (keypad1 < 10)
                {
                    X = 15;
                }
                else if (keypad1 > 10 && keypad1 < 20)
                {
                    X = 20;
                }
                else if (keypad1 > 20 && keypad1 < 80)
                {
                    X = 30;
                }
                else
                {
                    X = 10;
                }

                // Second step
                if (keypad2 < 10)
                {
                    X += 10;
                }
                else if (keypad2 > 10 && keypad2 < 20)
                {
                    X *= 2;
                }
                else if (keypad2 > 20 && keypad2 < 80)
                {
                    X *= 3;
                }
                else
                {
                    X -= 10;
                }

                // Third step
                if (keypad3 < 10)
                {
                    X *= 2;
                }
                else if (keypad3 > 10 && keypad3 < 20)
                {
                    X *= 3;
                }
                else if (keypad3 > 20 && keypad3 < 80)
                {
                    X -= 5;
                }

                // Fourth step
                if (keypad4 < 10)
                {
                    X *= 2;
                }
                else if (keypad4 > 10 && keypad4 < 20)
                {
                    X += 20;
                }
                else if (keypad4 > 20 && keypad4 < 80)
                {
                    X += 50;
                }
                else
                {
                    X *= 3;
                }

                // 5th step
                Y = keypad1 + keypad2 + keypad3 + keypad4;
                Y /= 2;
                Z = X - Y;

                if (Z == 0 || Z < 0)
                {
                    KeypadsSolution.Text = "1, 2, 3, 4";
                }
                else if (Z == 0.5 || (Z > 0.5 && Z < 19.5) || Z == 19.5)
                {
                    KeypadsSolution.Text = "1, 2, 4, 3";
                }
                else if (Z == 20 || (Z > 20 && Z < 49.5) || Z == 49.5)
                {
                    KeypadsSolution.Text = "4, 3, 2, 1";
                }
                else if (Z == 50 || (Z > 50 && Z < 89.5) || Z == 89.5)
                {
                    KeypadsSolution.Text = "3, 1, 4, 2";
                }
                else if (Z == 90 || Z > 90)
                {
                    KeypadsSolution.Text = "2, 3, 1, 4";
                }
                else
                {
                    KeypadsSolution.Text = "Waiting for input";
                }
            }
        }
        private void keypadBox1_TextChanged(object sender, EventArgs e)
        {
            if (keypadBox1.Text == "")
            {
                keypad1 = -1;
            }
            else if (Int32.TryParse(keypadBox1.Text, out keypad1))
            {
                // No need to do anything with keypad1
            }
            else
            {
                keypad1 = -1;
            }
            SolutionCheck();
        }

        private void keypadBox2_TextChanged(object sender, EventArgs e)
        {
            if (keypadBox2.Text == "")
            {
                keypad2 = -1;
            }
            else if (Int32.TryParse(keypadBox2.Text, out keypad2))
            {
                // No need to do anything with keypad2
            }
            else
            {
                keypad2 = -1;
            }
            SolutionCheck();
        }

        private void keypadBox3_TextChanged(object sender, EventArgs e)
        {
            if (keypadBox3.Text == "")
            {
                keypad3 = -1;
            }
            else if (Int32.TryParse(keypadBox3.Text, out keypad3))
            {
                // No need to do anything with keypad3
            }
            else
            {
                keypad3 = -1;
            }
            SolutionCheck();
        }

        private void keypadBox4_TextChanged(object sender, EventArgs e)
        {
            if (keypadBox4.Text == "")
            {
                keypad4 = -1;
            }
            else if (Int32.TryParse(keypadBox4.Text, out keypad4))
            {
                // No need to do anything with keypad4
            }
            else
            {
                keypad4 = -1;
            }
            SolutionCheck();
        }
    }
}
