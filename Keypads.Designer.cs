namespace DefusalAssistTool
{
    partial class Keypads
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            keypadBox1 = new TextBox();
            keypadBox2 = new TextBox();
            keypadBox3 = new TextBox();
            keypadBox4 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label11 = new Label();
            KeypadsSolution = new Label();
            label9 = new Label();
            VersionLabel = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(-1, 21);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 24;
            label4.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(-1, 141);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 25;
            label1.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 166);
            label2.Name = "label2";
            label2.Size = new Size(198, 15);
            label2.TabIndex = 33;
            label2.Text = "Press buttons in the following order:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // keypadBox1
            // 
            keypadBox1.Location = new Point(144, 61);
            keypadBox1.Name = "keypadBox1";
            keypadBox1.Size = new Size(44, 23);
            keypadBox1.TabIndex = 34;
            keypadBox1.TextChanged += keypadBox1_TextChanged;
            // 
            // keypadBox2
            // 
            keypadBox2.Location = new Point(210, 61);
            keypadBox2.Name = "keypadBox2";
            keypadBox2.Size = new Size(44, 23);
            keypadBox2.TabIndex = 35;
            keypadBox2.TextChanged += keypadBox2_TextChanged;
            // 
            // keypadBox3
            // 
            keypadBox3.Location = new Point(144, 101);
            keypadBox3.Name = "keypadBox3";
            keypadBox3.Size = new Size(44, 23);
            keypadBox3.TabIndex = 36;
            keypadBox3.TextChanged += keypadBox3_TextChanged;
            // 
            // keypadBox4
            // 
            keypadBox4.Location = new Point(210, 101);
            keypadBox4.Name = "keypadBox4";
            keypadBox4.Size = new Size(44, 23);
            keypadBox4.TabIndex = 37;
            keypadBox4.TextChanged += keypadBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(128, 43);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 40;
            label3.Text = "#1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(254, 43);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 41;
            label5.Text = "#2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(128, 127);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 42;
            label6.Text = "#3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(254, 127);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 43;
            label7.Text = "#4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(144, 28);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 44;
            label11.Text = "Input keypad labels:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KeypadsSolution
            // 
            KeypadsSolution.Font = new Font("Segoe UI", 18F);
            KeypadsSolution.Location = new Point(89, 166);
            KeypadsSolution.Name = "KeypadsSolution";
            KeypadsSolution.Size = new Size(234, 70);
            KeypadsSolution.TabIndex = 45;
            KeypadsSolution.Text = "Waiting for input";
            KeypadsSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 5);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 46;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = Color.Gray;
            VersionLabel.Location = new Point(289, 227);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(52, 15);
            VersionLabel.TabIndex = 48;
            VersionLabel.Text = "DAT v0.2";
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(264, 242);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 47;
            CreditLabel.Text = "@entechcore";
            // 
            // Keypads
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 266);
            Controls.Add(VersionLabel);
            Controls.Add(CreditLabel);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(KeypadsSolution);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(keypadBox4);
            Controls.Add(keypadBox3);
            Controls.Add(keypadBox2);
            Controls.Add(keypadBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Keypads";
            Text = "Keypads";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox keypadBox1;
        private TextBox keypadBox2;
        private TextBox keypadBox3;
        private TextBox keypadBox4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label11;
        internal Label KeypadsSolution;
        private Label label9;
        private Label VersionLabel;
        private Label CreditLabel;
    }
}