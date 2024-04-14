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
    public partial class ButtonForm : Form
    {
        // Declare variables for use later
        private string ButtonColour = "None";
        private string ButtonWord = "None";
        public ButtonForm()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) // Button colour list
        {
            // Uncheck all other items
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }

            // Set variables
            if (e.NewValue == CheckState.Checked)
            {
                if (e.Index == 0)
                {
                    ButtonColour = "Blue";
                }
                else if (e.Index == 1)
                {
                    ButtonColour = "Red";
                }
                else if (e.Index == 2)
                {
                    ButtonColour = "Grey/White";
                }
                else
                {
                    ButtonColour = "None";
                }
            }
            SolutionCheck();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e) // Button word list
        {
            // Uncheck all other items
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
            }

            // Set variables
            if (e.NewValue == CheckState.Checked)
            {
                if (e.Index == 0)
                {
                    ButtonWord = "Detonate";
                }
                else if (e.Index == 1)
                {
                    ButtonWord = "Abort";
                }
                else
                {
                    ButtonWord = "None";
                }
            }
            SolutionCheck();
        }

        private void SolutionCheck()
        {
            if (ButtonColour == "None" || ButtonWord == "None")
            {
                ButtonSolution.Text = "Waiting for input";
            }
            else if (ButtonColour == "Blue" && ButtonWord == "Detonate")
            {
                ButtonSolution.Text = "Press button ONCE, then\r\nPress DOWN arrow";
            }
            else if (ButtonColour == "Red")
            {
                ButtonSolution.Text = "Press button TWICE, then\r\nPress DOWN arrow";
            }
            else if (ButtonWord == "Abort")
            {
                ButtonSolution.Text = "Press button THREE times, then\r\nPress UP arrow";
            }
            else if (ButtonColour == "Grey/White")
            {
                ButtonSolution.Text = "Press button FOUR times, then\r\nPress UP arrow";
            } // Surprisingly enough this does cover all cases
        }
    }
}
