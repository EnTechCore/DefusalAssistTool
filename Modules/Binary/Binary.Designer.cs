namespace DefusalAssistTool
{
    partial class Binary
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
            label9 = new Label();
            label1 = new Label();
            label4 = new Label();
            BinarySolution = new Label();
            BinaryInput = new TextBox();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 33);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 47;
            label2.Text = "Input binary (7 digits):";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 44;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(-6, 85);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 43;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(-6, -5);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 42;
            label4.Text = "1";
            // 
            // BinarySolution
            // 
            BinarySolution.Font = new Font("Segoe UI", 18F);
            BinarySolution.Location = new Point(92, 111);
            BinarySolution.Name = "BinarySolution";
            BinarySolution.Size = new Size(341, 70);
            BinarySolution.TabIndex = 41;
            BinarySolution.Text = "Waiting for input";
            BinarySolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BinaryInput
            // 
            BinaryInput.Location = new Point(146, 51);
            BinaryInput.Name = "BinaryInput";
            BinaryInput.Size = new Size(230, 23);
            BinaryInput.TabIndex = 40;
            BinaryInput.TextChanged += BinaryInput_TextChanged;
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(385, 171);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 48;
            CreditLabel.Text = "@entechcore";
            // 
            // Binary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 195);
            Controls.Add(CreditLabel);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(BinarySolution);
            Controls.Add(BinaryInput);
            Name = "Binary";
            Text = "Binary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label9;
        private Label label1;
        private Label label4;
        internal Label BinarySolution;
        private TextBox BinaryInput;
        private Label CreditLabel;
    }
}