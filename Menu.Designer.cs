namespace Defusal
{
    partial class Menu
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
            MenuWires = new Button();
            MenuDisclaimer1 = new Label();
            CreditLabel = new Label();
            VersionLabel = new Label();
            MenuButtonForm = new Button();
            MenuHex = new Button();
            MenuKeypads = new Button();
            MenuBinary = new Button();
            MenuDisclaimer2 = new Label();
            MenuMaths = new Button();
            MenuColorCode = new Button();
            MenuMultiButtons = new Button();
            ModuleInfo = new Label();
            MenuTiming = new Button();
            SuspendLayout();
            // 
            // MenuWires
            // 
            MenuWires.Location = new Point(216, 99);
            MenuWires.Name = "MenuWires";
            MenuWires.Size = new Size(87, 23);
            MenuWires.TabIndex = 0;
            MenuWires.Text = "Wires";
            MenuWires.UseVisualStyleBackColor = true;
            MenuWires.Click += MenuWires_Click_1;
            // 
            // MenuDisclaimer1
            // 
            MenuDisclaimer1.AutoSize = true;
            MenuDisclaimer1.ForeColor = SystemColors.ControlText;
            MenuDisclaimer1.Location = new Point(12, 157);
            MenuDisclaimer1.Name = "MenuDisclaimer1";
            MenuDisclaimer1.Size = new Size(103, 15);
            MenuDisclaimer1.TabIndex = 22;
            MenuDisclaimer1.Text = "Placeholder menu";
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.ForeColor = Color.Gray;
            CreditLabel.Location = new Point(247, 172);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(77, 15);
            CreditLabel.TabIndex = 23;
            CreditLabel.Text = "@entechcore";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = Color.Gray;
            VersionLabel.Location = new Point(272, 157);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(52, 15);
            VersionLabel.TabIndex = 27;
            VersionLabel.Text = "DAT v0.2";
            // 
            // MenuButtonForm
            // 
            MenuButtonForm.Location = new Point(30, 70);
            MenuButtonForm.Name = "MenuButtonForm";
            MenuButtonForm.Size = new Size(87, 23);
            MenuButtonForm.TabIndex = 28;
            MenuButtonForm.Text = "Button";
            MenuButtonForm.UseVisualStyleBackColor = true;
            MenuButtonForm.Click += MenuButton1_Click;
            // 
            // MenuHex
            // 
            MenuHex.Location = new Point(123, 41);
            MenuHex.Name = "MenuHex";
            MenuHex.Size = new Size(87, 23);
            MenuHex.TabIndex = 29;
            MenuHex.Text = "Hex";
            MenuHex.UseVisualStyleBackColor = true;
            MenuHex.Click += MenuHex_Click;
            // 
            // MenuKeypads
            // 
            MenuKeypads.Location = new Point(123, 70);
            MenuKeypads.Name = "MenuKeypads";
            MenuKeypads.Size = new Size(87, 23);
            MenuKeypads.TabIndex = 30;
            MenuKeypads.Text = "Keypads";
            MenuKeypads.UseVisualStyleBackColor = true;
            MenuKeypads.Click += MenuKeypads_Click;
            // 
            // MenuBinary
            // 
            MenuBinary.Location = new Point(30, 41);
            MenuBinary.Name = "MenuBinary";
            MenuBinary.Size = new Size(87, 23);
            MenuBinary.TabIndex = 31;
            MenuBinary.Text = "Binary";
            MenuBinary.UseVisualStyleBackColor = true;
            MenuBinary.Click += MenuBinary_Click;
            // 
            // MenuDisclaimer2
            // 
            MenuDisclaimer2.AutoSize = true;
            MenuDisclaimer2.ForeColor = SystemColors.ControlText;
            MenuDisclaimer2.Location = new Point(12, 172);
            MenuDisclaimer2.Name = "MenuDisclaimer2";
            MenuDisclaimer2.Size = new Size(189, 15);
            MenuDisclaimer2.TabIndex = 32;
            MenuDisclaimer2.Text = "Not representative of final product";
            // 
            // MenuMaths
            // 
            MenuMaths.Location = new Point(123, 99);
            MenuMaths.Name = "MenuMaths";
            MenuMaths.Size = new Size(87, 23);
            MenuMaths.TabIndex = 33;
            MenuMaths.Text = "Maths";
            MenuMaths.UseVisualStyleBackColor = true;
            MenuMaths.Click += MenuMaths_Click;
            // 
            // MenuColorCode
            // 
            MenuColorCode.Location = new Point(30, 99);
            MenuColorCode.Name = "MenuColorCode";
            MenuColorCode.Size = new Size(87, 23);
            MenuColorCode.TabIndex = 34;
            MenuColorCode.Text = "Color Code";
            MenuColorCode.UseVisualStyleBackColor = true;
            MenuColorCode.Click += MenuColorCode_Click;
            // 
            // MenuMultiButtons
            // 
            MenuMultiButtons.Location = new Point(216, 41);
            MenuMultiButtons.Name = "MenuMultiButtons";
            MenuMultiButtons.Size = new Size(87, 23);
            MenuMultiButtons.TabIndex = 35;
            MenuMultiButtons.Text = "Multi Buttons";
            MenuMultiButtons.UseVisualStyleBackColor = true;
            MenuMultiButtons.Click += MenuMultiButtons_Click;
            // 
            // ModuleInfo
            // 
            ModuleInfo.AutoSize = true;
            ModuleInfo.ForeColor = SystemColors.ControlText;
            ModuleInfo.Location = new Point(41, 9);
            ModuleInfo.Name = "ModuleInfo";
            ModuleInfo.Size = new Size(249, 15);
            ModuleInfo.TabIndex = 36;
            ModuleInfo.Text = "Refer to the manual for module identification.";
            // 
            // MenuTiming
            // 
            MenuTiming.Location = new Point(216, 70);
            MenuTiming.Name = "MenuTiming";
            MenuTiming.Size = new Size(87, 23);
            MenuTiming.TabIndex = 37;
            MenuTiming.Text = "Timing";
            MenuTiming.UseVisualStyleBackColor = true;
            MenuTiming.Click += MenuTiming_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 196);
            Controls.Add(MenuTiming);
            Controls.Add(ModuleInfo);
            Controls.Add(MenuMultiButtons);
            Controls.Add(MenuColorCode);
            Controls.Add(MenuMaths);
            Controls.Add(MenuDisclaimer2);
            Controls.Add(MenuBinary);
            Controls.Add(MenuKeypads);
            Controls.Add(MenuHex);
            Controls.Add(MenuButtonForm);
            Controls.Add(VersionLabel);
            Controls.Add(CreditLabel);
            Controls.Add(MenuDisclaimer1);
            Controls.Add(MenuWires);
            Name = "Menu";
            Text = "Defusal Assist Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MenuWires;
        private Label MenuDisclaimer1;
        private Label CreditLabel;
        private Label VersionLabel;
        private Button MenuButtonForm;
        private Button MenuHex;
        private Button MenuKeypads;
        private Button MenuBinary;
        private Label MenuDisclaimer2;
        private Button MenuMaths;
        private Button MenuColorCode;
        private Button MenuMultiButtons;
        private Label ModuleInfo;
        private Button MenuTiming;
    }
}