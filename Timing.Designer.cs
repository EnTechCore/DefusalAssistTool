namespace DefusalAssistTool
{
    partial class Timing
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            TimingSolution = new Label();
            TimingInput = new TextBox();
            VersionLabel = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 128);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 79;
            label2.Text = "Press green when the light is:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(-3, 117);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 78;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(-3, 1);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 77;
            label4.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 43);
            label3.Name = "label3";
            label3.Size = new Size(174, 15);
            label3.TabIndex = 76;
            label3.Text = "Input display (2 digits, 2 letters):";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(142, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 73;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimingSolution
            // 
            TimingSolution.Font = new Font("Segoe UI", 18F);
            TimingSolution.Location = new Point(85, 143);
            TimingSolution.Name = "TimingSolution";
            TimingSolution.Size = new Size(196, 70);
            TimingSolution.TabIndex = 72;
            TimingSolution.Text = "Waiting for input";
            TimingSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimingInput
            // 
            TimingInput.Location = new Point(95, 61);
            TimingInput.Name = "TimingInput";
            TimingInput.Size = new Size(174, 23);
            TimingInput.TabIndex = 71;
            TimingInput.TextChanged += TimingInput_TextChanged;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = Color.Gray;
            VersionLabel.Location = new Point(252, 198);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(53, 15);
            VersionLabel.TabIndex = 81;
            VersionLabel.Text = "DAT V0.2";
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(228, 214);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 80;
            CreditLabel.Text = "@entechcore";
            // 
            // Timing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 238);
            Controls.Add(VersionLabel);
            Controls.Add(CreditLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(TimingSolution);
            Controls.Add(TimingInput);
            Name = "Timing";
            Text = "Timing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label9;
        internal Label TimingSolution;
        private TextBox TimingInput;
        private Label VersionLabel;
        private Label CreditLabel;
    }
}