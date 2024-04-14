namespace Defusal
{
    partial class Wires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox3 = new CheckedListBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lightCover = new Panel();
            wiresCover = new Panel();
            WiresSolution = new Label();
            label9 = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "3 wires", "4 wires", "5 wires" });
            checkedListBox1.Location = new Point(282, 48);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(74, 58);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Red wires", "Green wires", "Blue wires", "White wires" });
            checkedListBox2.Location = new Point(146, 139);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(101, 76);
            checkedListBox2.TabIndex = 1;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // checkedListBox3
            // 
            checkedListBox3.CheckOnClick = true;
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Red light", "Green light", "Blue light", "Yellow light", "None of the above" });
            checkedListBox3.Location = new Point(362, 139);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(126, 94);
            checkedListBox3.TabIndex = 2;
            checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(119, 221);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(151, 34);
            textBox2.TabIndex = 4;
            textBox2.Text = "Colours not mentioned are not necessary.";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 121);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 11;
            label1.Text = "\"What coloured wires are present?\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 121);
            label2.Name = "label2";
            label2.Size = new Size(244, 15);
            label2.TabIndex = 12;
            label2.Text = "\"What colour is the light above the module?\"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 30);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 13;
            label3.Text = "\"How many wires are there?\"";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 14;
            label4.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 60F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(0, 121);
            label5.Name = "label5";
            label5.Size = new Size(92, 106);
            label5.TabIndex = 15;
            label5.Text = "2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 60F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(0, 227);
            label6.Name = "label6";
            label6.Size = new Size(92, 106);
            label6.TabIndex = 16;
            label6.Text = "3";
            // 
            // lightCover
            // 
            lightCover.Location = new Point(299, 121);
            lightCover.Name = "lightCover";
            lightCover.Size = new Size(244, 134);
            lightCover.TabIndex = 17;
            // 
            // wiresCover
            // 
            wiresCover.Location = new Point(98, 121);
            wiresCover.Name = "wiresCover";
            wiresCover.Size = new Size(195, 134);
            wiresCover.TabIndex = 18;
            // 
            // WiresSolution
            // 
            WiresSolution.Font = new Font("Segoe UI", 18F);
            WiresSolution.Location = new Point(98, 253);
            WiresSolution.Name = "WiresSolution";
            WiresSolution.Size = new Size(445, 59);
            WiresSolution.TabIndex = 19;
            WiresSolution.Text = "Waiting for input";
            WiresSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 45;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(503, 310);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 46;
            CreditLabel.Text = "@entechcore";
            // 
            // Wires
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 334);
            Controls.Add(CreditLabel);
            Controls.Add(lightCover);
            Controls.Add(wiresCover);
            Controls.Add(label9);
            Controls.Add(WiresSolution);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Name = "Wires";
            Text = "Wires";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel lightCover;
        private Panel wiresCover;
        private Label WiresSolution;
        private Label label9;
        private Label CreditLabel;
    }
}