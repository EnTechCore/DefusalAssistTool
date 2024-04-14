using DefusalAssistTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defusal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;

        }

        private void MenuWires_Click_1(object sender, EventArgs e)
        {
            // Hides the current form (Menu)
            this.Hide();
            // Instantiate the Wires form
            Wires wiresForm = new Wires();
            // Subscribe to the FormClosed event of the Wires form
            wiresForm.FormClosed += (s, args) => this.Show();
            // Show the Wires form
            wiresForm.ShowDialog();
        }

        private void MenuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ButtonForm buttonForm = new ButtonForm();
            buttonForm.FormClosed += (s, args) => this.Show();
            buttonForm.ShowDialog();
        }

        private void MenuHex_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hex hex = new Hex();
            hex.FormClosed += (s, args) => this.Show();
            hex.ShowDialog();
        }

        private void MenuKeypads_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keypads keypads = new Keypads();
            keypads.FormClosed += (s, args) => this.Show();
            keypads.ShowDialog();
        }

        private void MenuBinary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Binary binary = new Binary();
            binary.FormClosed += (s, args) => this.Show();
            binary.ShowDialog();
        }

        private void MenuMaths_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maths maths = new Maths();
            maths.FormClosed += (s, args) => this.Show();
            maths.ShowDialog();
        }

        private void MenuColorCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            ColorCode colorCode = new ColorCode();
            colorCode.FormClosed += (s, args) => this.Show();
            colorCode.ShowDialog();
        }

        private void MenuMultiButtons_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiButtons multiButtons = new MultiButtons();
            multiButtons.FormClosed += (s, args) => this.Show();
            multiButtons.ShowDialog();
        }

        private void MenuTiming_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timing timing = new Timing();
            timing.FormClosed += (s, args) => this.Show();
            timing.ShowDialog();
        }

        private void MenuTiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tiles tiles = new Tiles();
            tiles.FormClosed += (s, args) => this.Show();
            tiles.ShowDialog();
        }
    }
}
