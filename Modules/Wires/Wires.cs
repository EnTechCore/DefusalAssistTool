using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This one in particular is an absolute mess since this is the one I started this solution on.
// Good fucking luck understanding this

namespace Defusal
{
    public partial class Wires : Form
    {
        // Declare variables for use later
        private int WireCount = 0;
        private string LightColour = "nil";
        private bool RedWiresPresent = false;
        private bool GreenWiresPresent = false;
        private bool BlueWiresPresent = false;
        private bool WhiteWiresPresent = false;

        public Wires()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }
        private void SolutionCheck()
        {
            if (WireCount == 3)
            {
                if (RedWiresPresent == false)
                {
                    WiresSolution.Text = "Cut the first wire";
                }
                else if (WhiteWiresPresent)
                {
                    WiresSolution.Text = "Cut the second wire";
                }
                else if (BlueWiresPresent)
                {
                    WiresSolution.Text = "Cut the last wire";
                }
                else
                {
                    WiresSolution.Text = "Waiting for input"; // Manual does not say "If none of the above apply"; suggests there are no other valid cases. Looks janky asf in operation but should be correct
                }
            }
            else if (WireCount == 4)
            {
                if (GreenWiresPresent == false)
                {
                    WiresSolution.Text = "Cut the first wire";
                }
                else if (BlueWiresPresent == false)
                {
                    WiresSolution.Text = "Cut the second wire";
                }
                else if (WhiteWiresPresent == false)
                {
                    WiresSolution.Text = "Cut the third wire";
                }
                else
                {
                    WiresSolution.Text = "Cut the last wire";
                }
            }
            else if (WireCount == 5)
            {
                if (LightColour == "Red")
                {
                    WiresSolution.Text = "Cut the first wire";
                }
                else if (LightColour == "Green")
                {
                    WiresSolution.Text = "Cut the second wire";
                }
                else if (LightColour == "Blue")
                {
                    WiresSolution.Text = "Cut the third wire";
                }
                else if (LightColour == "Yellow")
                {
                    WiresSolution.Text = "Cut the fourth wire";
                }
                else if (LightColour == "None")
                {
                    WiresSolution.Text = "Cut the last wire";
                }
            }
            else
            {
                WiresSolution.Text = "Waiting for input";
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) // Wire count list
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
                    WireCount = 3;
                }
                else if (e.Index == 1)
                {
                    WireCount = 4;
                }
                else if (e.Index == 2)
                {
                    WireCount = 5;
                }
            }


            // Show/Hide modules
            if (e.NewValue == CheckState.Checked) // Is specific item checked
            {
                if (e.Index == 0 || e.Index == 1) // First/Second item on list
                {
                    wiresCover.Visible = false;
                }
            }
            else
            {
                wiresCover.Visible = true;
            }

            if (e.NewValue == CheckState.Checked) // Is specific item checked
            {
                if (e.Index == 2)
                {  // First/Second item on list
                    lightCover.Visible = false;
                }
            }
            else
            {
                lightCover.Visible = true;
            }

            SolutionCheck();
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e) // Module light list
        {
            // Uncheck all other items
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox3.SetItemChecked(i, false);
                }
            }

            if (e.NewValue == CheckState.Checked)
            {
                if (e.Index == 0)
                {
                    LightColour = "Red";
                }
                else if (e.Index == 1)
                {
                    LightColour = "Green";
                }
                else if (e.Index == 2)
                {
                    LightColour = "Blue";
                }
                else if (e.Index == 3)
                {
                    LightColour = "Yellow";
                }
                else if (e.Index == 4)
                {
                    LightColour = "None";
                }
                else
                {
                    LightColour = "nil";
                }
            }
            if (WireCount == 5)
            {
                UpdateCheckedListBox2State();
            }

            SolutionCheck();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e) // Wire colors list
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (e.Index == 0)
                {
                    RedWiresPresent = true;
                }
                else if (e.Index == 1)
                {
                    GreenWiresPresent = true;
                }
                else if (e.Index == 2)
                {
                    BlueWiresPresent = true;
                }
                else if (e.Index == 3)
                {
                    WhiteWiresPresent = true;
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                if (e.Index == 0)
                {
                    RedWiresPresent = false;
                }
                else if (e.Index == 1)
                {
                    GreenWiresPresent = false;
                }
                else if (e.Index == 2)
                {
                    BlueWiresPresent = false;
                }
                else if (e.Index == 3)
                {
                    WhiteWiresPresent = false;
                }
            }

            if (WireCount == 3 || WireCount == 4)
            {
                UpdateCheckedListBox3State();
            }

            SolutionCheck();

        }

        private void UpdateCheckedListBox2State()
        {
            // Untick all boxes in checkedListBox2
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }
            // Reset variables
            RedWiresPresent = false;
            GreenWiresPresent = false;
            BlueWiresPresent = false;
            WhiteWiresPresent = false;
        }

        private void UpdateCheckedListBox3State()
        {
            // Untick all boxes in checkedListBox3
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }
            // Reset variable
            LightColour = "nil";
        }
    }
}
