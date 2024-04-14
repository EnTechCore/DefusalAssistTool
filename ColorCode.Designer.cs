namespace DefusalAssistTool
{
    partial class ColorCode
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
            label9 = new Label();
            label1 = new Label();
            label4 = new Label();
            ColorCodeSolution = new Label();
            label2 = new Label();
            LightInput = new TextBox();
            label3 = new Label();
            DisplayInput = new TextBox();
            VersionLabel = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(208, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 61;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 132);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 60;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 26);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 59;
            label4.Text = "1";
            // 
            // ColorCodeSolution
            // 
            ColorCodeSolution.Font = new Font("Segoe UI", 18F);
            ColorCodeSolution.Location = new Point(81, 155);
            ColorCodeSolution.Name = "ColorCodeSolution";
            ColorCodeSolution.Size = new Size(287, 70);
            ColorCodeSolution.TabIndex = 58;
            ColorCodeSolution.Text = "Waiting for input";
            ColorCodeSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 34);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 57;
            label2.Text = "Input light colours (R, G, B, Y, W):";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LightInput
            // 
            LightInput.Location = new Point(124, 52);
            LightInput.Name = "LightInput";
            LightInput.Size = new Size(197, 23);
            LightInput.TabIndex = 56;
            LightInput.TextChanged += LightInput_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 91);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 65;
            label3.Text = "Input display letters:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DisplayInput
            // 
            DisplayInput.Location = new Point(124, 109);
            DisplayInput.Name = "DisplayInput";
            DisplayInput.Size = new Size(197, 23);
            DisplayInput.TabIndex = 64;
            DisplayInput.TextChanged += DisplayInput_TextChanged;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = Color.Gray;
            VersionLabel.Location = new Point(319, 212);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(52, 15);
            VersionLabel.TabIndex = 67;
            VersionLabel.Text = "DAT v0.2";
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(294, 227);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 66;
            CreditLabel.Text = "@entechcore";
            // 
            // ColorCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 251);
            Controls.Add(VersionLabel);
            Controls.Add(CreditLabel);
            Controls.Add(label3);
            Controls.Add(DisplayInput);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(ColorCodeSolution);
            Controls.Add(label2);
            Controls.Add(LightInput);
            Name = "ColorCode";
            Text = "ColorCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label1;
        private Label label4;
        internal Label ColorCodeSolution;
        private Label label2;
        private TextBox LightInput;
        private Label label3;
        private TextBox DisplayInput;
        private Label VersionLabel;
        private Label CreditLabel;
    }
}