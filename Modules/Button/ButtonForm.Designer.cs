namespace DefusalAssistTool
{
    partial class ButtonForm
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
            label3 = new Label();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            label4 = new Label();
            ButtonSolution = new Label();
            label9 = new Label();
            CreditLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 37);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 28;
            label2.Text = "\"What is written on the button?\"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 37);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 27;
            label3.Text = "\"What colour is the button?\"";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Detonate", "Abort" });
            checkedListBox2.Location = new Point(352, 55);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(88, 40);
            checkedListBox2.TabIndex = 26;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Blue", "Red", "Grey/White" });
            checkedListBox1.Location = new Point(134, 55);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(98, 58);
            checkedListBox1.TabIndex = 25;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 60F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(1, 112);
            label1.Name = "label1";
            label1.Size = new Size(92, 106);
            label1.TabIndex = 24;
            label1.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 60F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(1, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 106);
            label4.TabIndex = 23;
            label4.Text = "1";
            // 
            // ButtonSolution
            // 
            ButtonSolution.Font = new Font("Segoe UI", 18F);
            ButtonSolution.Location = new Point(111, 138);
            ButtonSolution.Name = "ButtonSolution";
            ButtonSolution.Size = new Size(354, 70);
            ButtonSolution.TabIndex = 32;
            ButtonSolution.Text = "Waiting for input";
            ButtonSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 9);
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
            CreditLabel.Location = new Point(405, 201);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 46;
            CreditLabel.Text = "@entechcore";
            // 
            // ButtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 225);
            Controls.Add(CreditLabel);
            Controls.Add(label9);
            Controls.Add(ButtonSolution);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "ButtonForm";
            Text = "Button";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label4;
        internal Label ButtonSolution;
        private Label label9;
        private Label CreditLabel;
    }
}