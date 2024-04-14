using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DefusalAssistTool
{
    public partial class MultiButtons : Form
    {
        bool ValidInput = false;
        int digit1, digit2, digit3, digit4, digit5, digit6;

        public MultiButtons()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void MultiButtonsInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MultiButtonsInput.Text) && MultiButtonsInput.Text.Length == 6 && int.TryParse(MultiButtonsInput.Text, out _))
            {
                ValidInput = true;
                digit1 = int.Parse(MultiButtonsInput.Text[0].ToString());
                digit2 = int.Parse(MultiButtonsInput.Text[1].ToString());
                digit3 = int.Parse(MultiButtonsInput.Text[2].ToString());
                digit4 = int.Parse(MultiButtonsInput.Text[3].ToString());
                digit5 = int.Parse(MultiButtonsInput.Text[4].ToString());
                digit6 = int.Parse(MultiButtonsInput.Text[5].ToString());
            }
            else
            {
                ValidInput = false;
            }
            CheckSolution();
        }

        private void CheckSolution()
        {
            if (ValidInput)
            {
                if (digit1 < 6)
                {
                    MultiButtonsSolution.Text = "Red, ";
                }
                else
                {
                    MultiButtonsSolution.Text = "Orange, ";
                }

                if (digit2 < 6)
                {
                    MultiButtonsSolution.Text += "Yellow, ";
                }
                else
                {
                    MultiButtonsSolution.Text += "Green, ";
                }

                if (digit3 < 6)
                {
                    MultiButtonsSolution.Text += "Blue, \r\n";
                }
                else
                {
                    MultiButtonsSolution.Text += "Purple, \r\n";
                }

                if (digit4 < 7)
                {
                    MultiButtonsSolution.Text += "5, 6, 4";
                }
                else if (digit5 < 7)
                {
                    MultiButtonsSolution.Text += "6, 5, 4";
                }
                else if (digit6 > 5)
                {
                    MultiButtonsSolution.Text += "4, 5, 6";
                }
                else
                {
                    MultiButtonsSolution.Text += "4, 6, 5";
                }
            }
            else
            {
                MultiButtonsSolution.Text = "Waiting for input";
            }
        }
    }
}
