namespace DefusalAssistTool
{
    partial class Hex
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
            textBoxHex = new TextBox();
            HexSolution = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            VersionLabel = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // textBoxHex
            // 
            textBoxHex.Location = new Point(96, 57);
            textBoxHex.Name = "textBoxHex";
            textBoxHex.Size = new Size(230, 23);
            textBoxHex.TabIndex = 0;
            textBoxHex.TextChanged += textBox1_TextChanged;
            // 
            // HexSolution
            // 
            HexSolution.Font = new Font("Segoe UI", 18F);
            HexSolution.Location = new Point(96, 111);
            HexSolution.Name = "HexSolution";
            HexSolution.Size = new Size(230, 70);
            HexSolution.TabIndex = 33;
            HexSolution.Text = "Waiting for input";
            HexSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(-2, 85);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 35;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(-2, -5);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 34;
            label4.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 39);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 39;
            label2.Text = "Input hex:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(175, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 45;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = Color.Gray;
            VersionLabel.Location = new Point(285, 160);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(53, 15);
            VersionLabel.TabIndex = 47;
            VersionLabel.Text = "DAT V0.2";
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(261, 175);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 46;
            CreditLabel.Text = "@entechcore";
            // 
            // Hex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 199);
            Controls.Add(VersionLabel);
            Controls.Add(CreditLabel);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(HexSolution);
            Controls.Add(textBoxHex);
            Name = "Hex";
            Text = "Hex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHex;
        internal Label HexSolution;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label9;
        private Label VersionLabel;
        private Label CreditLabel;
    }
}