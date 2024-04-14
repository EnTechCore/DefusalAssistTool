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
    public partial class Hex : Form
    {
        public Hex()
        {
            InitializeComponent();
            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize box
            this.MaximizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get input
            string hexInput = textBoxHex.Text;
            // Decode to string
            string decodedString = HexToString(hexInput);
            // Set label
            if (decodedString != "false" && decodedString != "")
            {
                HexSolution.Text = decodedString;
            }
            else
            {
                HexSolution.Text = "Waiting for input";
            }
        }


        // chatgpt bs idfk
        private string HexToString(string hexInput)
        {
            try
            {
                // Remove any spaces from input
                hexInput = hexInput.Replace(" ", "");

                // Check that input is divisible by 2
                if (hexInput.Length % 2 != 0)
                {
                    return "false";
                }

                // Allow only valid hex characters
                foreach (char c in hexInput)
                {
                    if (!((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')))
                    {
                        return "false";
                    }
                }

                // Convert hexadecimal to byte array
                byte[] bytes = new byte[hexInput.Length / 2];
                for (int i = 0; i < hexInput.Length; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
                }

                // Convert byte array to string
                string decodedString = System.Text.Encoding.UTF8.GetString(bytes);

                // Check if decoded string contains only lowercase letters
                foreach (char c in decodedString)
                {
                    if (!(c >= 'a' && c <= 'z'))
                    {
                        return "false"; // Only lowercase letters are used in Defusal
                    }
                }

                return decodedString;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                return "ERR: " + ex.Message;
            }
        }
    }
}
