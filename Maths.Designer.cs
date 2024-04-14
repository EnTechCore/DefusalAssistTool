namespace DefusalAssistTool
{
    partial class Maths
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
            MathsInput = new TextBox();
            MathsSolution = new Label();
            label1 = new Label();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            VersionLabel = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 38);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 49;
            label2.Text = "Input letters:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MathsInput
            // 
            MathsInput.Location = new Point(98, 56);
            MathsInput.Name = "MathsInput";
            MathsInput.Size = new Size(197, 23);
            MathsInput.TabIndex = 48;
            MathsInput.TextChanged += MathsInput_TextChanged;
            // 
            // MathsSolution
            // 
            MathsSolution.Font = new Font("Segoe UI", 18F);
            MathsSolution.Location = new Point(98, 114);
            MathsSolution.Name = "MathsSolution";
            MathsSolution.Size = new Size(197, 70);
            MathsSolution.TabIndex = 50;
            MathsSolution.Text = "Waiting for input";
            MathsSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 92);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 52;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 2);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 51;
            label4.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(154, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 53;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 114);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 56;
            label3.Text = "Submit the following:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = Color.Gray;
            VersionLabel.Location = new Point(264, 172);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(53, 15);
            VersionLabel.TabIndex = 58;
            VersionLabel.Text = "DAT V0.2";
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(240, 187);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 57;
            CreditLabel.Text = "@entechcore";
            // 
            // Maths
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 211);
            Controls.Add(VersionLabel);
            Controls.Add(CreditLabel);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(MathsSolution);
            Controls.Add(label2);
            Controls.Add(MathsInput);
            Name = "Maths";
            Text = "Maths";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox MathsInput;
        internal Label MathsSolution;
        private Label label1;
        private Label label4;
        private Label label9;
        private Label label3;
        private Label VersionLabel;
        private Label CreditLabel;
    }
}