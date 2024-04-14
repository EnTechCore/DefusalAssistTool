namespace DefusalAssistTool
{
    partial class MultiButtons
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
            MultiButtonsInput = new TextBox();
            MultiButtonsSolution = new Label();
            label9 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // MultiButtonsInput
            // 
            MultiButtonsInput.Location = new Point(116, 53);
            MultiButtonsInput.Name = "MultiButtonsInput";
            MultiButtonsInput.Size = new Size(198, 23);
            MultiButtonsInput.TabIndex = 0;
            MultiButtonsInput.TextChanged += MultiButtonsInput_TextChanged;
            // 
            // MultiButtonsSolution
            // 
            MultiButtonsSolution.Font = new Font("Segoe UI", 18F);
            MultiButtonsSolution.Location = new Point(72, 141);
            MultiButtonsSolution.Name = "MultiButtonsSolution";
            MultiButtonsSolution.Size = new Size(287, 70);
            MultiButtonsSolution.TabIndex = 59;
            MultiButtonsSolution.Text = "Waiting for input";
            MultiButtonsSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(201, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 64;
            label9.Text = "Close the window to go back.";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 35);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 67;
            label3.Text = "Input display numbers (6 digits):";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(-4, 115);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 69;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(-4, -1);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 68;
            label4.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 126);
            label2.Name = "label2";
            label2.Size = new Size(198, 15);
            label2.TabIndex = 70;
            label2.Text = "Press buttons in the following order:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(287, 203);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 71;
            CreditLabel.Text = "@entechcore";
            // 
            // MultiButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 227);
            Controls.Add(CreditLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(MultiButtonsSolution);
            Controls.Add(MultiButtonsInput);
            Name = "MultiButtons";
            Text = "MultiButtons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MultiButtonsInput;
        internal Label MultiButtonsSolution;
        private Label label9;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label CreditLabel;
    }
}