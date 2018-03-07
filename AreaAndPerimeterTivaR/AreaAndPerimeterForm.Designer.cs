namespace AreaAndPerimeterTivaR
{
    partial class frmAreaAndPerimeter
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLengthText = new System.Windows.Forms.Label();
            this.lblWidthText = new System.Windows.Forms.Label();
            this.txtLengthBox = new System.Windows.Forms.TextBox();
            this.txtWidthBox = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAreaText = new System.Windows.Forms.Label();
            this.lblPerimeterText = new System.Windows.Forms.Label();
            this.lblPerimeterAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(458, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblLengthText
            // 
            this.lblLengthText.AutoSize = true;
            this.lblLengthText.Location = new System.Drawing.Point(46, 68);
            this.lblLengthText.Name = "lblLengthText";
            this.lblLengthText.Size = new System.Drawing.Size(57, 13);
            this.lblLengthText.TabIndex = 1;
            this.lblLengthText.Text = "Length (m)";
            // 
            // lblWidthText
            // 
            this.lblWidthText.AutoSize = true;
            this.lblWidthText.Location = new System.Drawing.Point(49, 125);
            this.lblWidthText.Name = "lblWidthText";
            this.lblWidthText.Size = new System.Drawing.Size(52, 13);
            this.lblWidthText.TabIndex = 2;
            this.lblWidthText.Text = "Width (m)";
            // 
            // txtLengthBox
            // 
            this.txtLengthBox.Location = new System.Drawing.Point(142, 68);
            this.txtLengthBox.Name = "txtLengthBox";
            this.txtLengthBox.Size = new System.Drawing.Size(100, 20);
            this.txtLengthBox.TabIndex = 3;
            // 
            // txtWidthBox
            // 
            this.txtWidthBox.Location = new System.Drawing.Point(142, 125);
            this.txtWidthBox.Name = "txtWidthBox";
            this.txtWidthBox.Size = new System.Drawing.Size(100, 20);
            this.txtWidthBox.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(312, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAreaText
            // 
            this.lblAreaText.AutoSize = true;
            this.lblAreaText.Location = new System.Drawing.Point(91, 209);
            this.lblAreaText.Name = "lblAreaText";
            this.lblAreaText.Size = new System.Drawing.Size(63, 13);
            this.lblAreaText.TabIndex = 6;
            this.lblAreaText.Text = "The area is:";
            // 
            // lblPerimeterText
            // 
            this.lblPerimeterText.AutoSize = true;
            this.lblPerimeterText.Location = new System.Drawing.Point(69, 235);
            this.lblPerimeterText.Name = "lblPerimeterText";
            this.lblPerimeterText.Size = new System.Drawing.Size(85, 13);
            this.lblPerimeterText.TabIndex = 7;
            this.lblPerimeterText.Text = "The perimeter is:";
            // 
            // lblPerimeterAnswer
            // 
            this.lblPerimeterAnswer.AutoSize = true;
            this.lblPerimeterAnswer.Location = new System.Drawing.Point(266, 234);
            this.lblPerimeterAnswer.Name = "lblPerimeterAnswer";
            this.lblPerimeterAnswer.Size = new System.Drawing.Size(39, 13);
            this.lblPerimeterAnswer.TabIndex = 8;
            this.lblPerimeterAnswer.Text = "Meters";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Location = new System.Drawing.Point(266, 209);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(82, 13);
            this.lblAreaAnswer.TabIndex = 9;
            this.lblAreaAnswer.Text = "Squared Meters";
            // 
            // frmAreaAndPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 303);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerimeterAnswer);
            this.Controls.Add(this.lblPerimeterText);
            this.Controls.Add(this.lblAreaText);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidthBox);
            this.Controls.Add(this.txtLengthBox);
            this.Controls.Add(this.lblWidthText);
            this.Controls.Add(this.lblLengthText);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmAreaAndPerimeter";
            this.Text = "Changing Area and Perimeter By Tiva Rait";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblLengthText;
        private System.Windows.Forms.Label lblWidthText;
        private System.Windows.Forms.TextBox txtLengthBox;
        private System.Windows.Forms.TextBox txtWidthBox;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAreaText;
        private System.Windows.Forms.Label lblPerimeterText;
        private System.Windows.Forms.Label lblPerimeterAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
    }
}

