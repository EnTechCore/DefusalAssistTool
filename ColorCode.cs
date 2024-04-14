using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefusalAssistTool
{
    public partial class ColorCode : Form
    {
        int X = -1;
        int Y = -1;
        bool ValidInput = false;
        public ColorCode()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void LightInput_TextChanged(object sender, EventArgs e)
        {
            // Reset variable
            if (X != -1)
            {
                ValidInput = true;
            }
            // Convert to uppercase and remove spaces
            string input = LightInput.Text.ToUpper().Replace(" ", "");

            // Check if input length is exactly 5
            if (input.Length != 5)
            {
                ValidInput = false;
            }
            else
            { // Translation
                int Light1 = LightTranslateChar(input[0]);
                int Light2 = LightTranslateChar(input[1]);
                int Light3 = LightTranslateChar(input[2]);
                int Light4 = LightTranslateChar(input[3]);
                int Light5 = LightTranslateChar(input[4]);
                if (Light1 == -1 || Light2 == -1 || Light3 == -1 || Light4 == -1 || Light5 == -1)
                { // Invalid char check
                    ValidInput = false;
                }
                else
                {
                    Y = Light1 + Light2 + Light3 + Light4 + Light5;
                }
            }
            CheckSolution();
        }

        private void DisplayInput_TextChanged(object sender, EventArgs e)
        {
            // Reset variable
            if (Y != -1)
            {
                ValidInput = true;
            }
            // Convert to uppercase and remove spaces
            string input = DisplayInput.Text.ToUpper().Replace(" ", "");

            // Check if input length is exactly 5
            if (input.Length != 5)
            {
                ValidInput = false;
            }
            else
            { // Translation
                int Display1 = DisplayTranslateChar(input[0]);
                int Display2 = DisplayTranslateChar(input[1]);
                int Display3 = DisplayTranslateChar(input[2]);
                int Display4 = DisplayTranslateChar(input[3]);
                int Display5 = DisplayTranslateChar(input[4]);
                if (Display1 == -1 || Display2 == -1 || Display3 == -1 || Display4 == -1 || Display5 == -1)
                { // Invalid char check
                    ValidInput = false;
                }
                else
                {
                    X = Display1 + Display2 + Display3 + Display4 + Display5;
                }
            }
            CheckSolution();
        }

        private int LightTranslateChar(char c)
        {
            switch (c)
            {
                // Translation
                case 'R': return 0;
                case 'G': return 0;
                case 'B': return 1;
                case 'Y': return 2;
                case 'W': return 3;
                default: return -1; // Return -1 for invalid characters
            }
        }

        private int DisplayTranslateChar(char c)
        {
            switch (c)
            {
                // Translation
                case 'R': return 1;
                case 'G': return 3;
                case 'B': return 2;
                case 'Y': return 3;
                case 'W': return 4;
                default: return -1; // Return -1 for invalid characters
            }
        }

        private void CheckSolution()
        {
            if (ValidInput == false)
            {
                ColorCodeSolution.Text = "Waiting for input";
            }
            else
            {
                int Z = X - Y;
                if (Z > 0)
                {
                    ColorCodeSolution.Text = "Press red " + Z + " times, then\r\nPress green";
                }
                else
                {
                    ColorCodeSolution.Text = "Press green";
                }
            }
        }
    }
}
