namespace Assignment2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblListBox = new Label();
            lstModels = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            radRed = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            radWhite = new RadioButton();
            grpColors = new GroupBox();
            grpFeatures = new GroupBox();
            chkLaneAssist = new CheckBox();
            chkSyriusRadio = new CheckBox();
            chkPowerWindows = new CheckBox();
            chkAC = new CheckBox();
            btnPurchase = new Button();
            lblSummary = new Label();
            grpColors.SuspendLayout();
            grpFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblListBox
            // 
            lblListBox.AutoSize = true;
            lblListBox.Location = new Point(31, 32);
            lblListBox.Name = "lblListBox";
            lblListBox.Size = new Size(146, 25);
            lblListBox.TabIndex = 0;
            lblListBox.Text = "&Make and Model";
            // 
            // lstModels
            // 
            lstModels.FormattingEnabled = true;
            lstModels.ItemHeight = 25;
            lstModels.Items.AddRange(new object[] { "Chevy Silvarado", "Ford F-150", "Toyota Yaris", "Honda Element" });
            lstModels.Location = new Point(31, 71);
            lstModels.Name = "lstModels";
            lstModels.Size = new Size(180, 129);
            lstModels.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(272, 30);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(44, 25);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(272, 71);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 3;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Location = new Point(29, 47);
            radRed.Name = "radRed";
            radRed.Size = new Size(67, 29);
            radRed.TabIndex = 5;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Location = new Point(29, 81);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(70, 29);
            radBlue.TabIndex = 6;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(29, 117);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(77, 29);
            radBlack.TabIndex = 7;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(29, 151);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(83, 29);
            radWhite.TabIndex = 8;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            // 
            // grpColors
            // 
            grpColors.Controls.Add(radRed);
            grpColors.Controls.Add(radWhite);
            grpColors.Controls.Add(radBlue);
            grpColors.Controls.Add(radBlack);
            grpColors.Location = new Point(494, 32);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(192, 198);
            grpColors.TabIndex = 4;
            grpColors.TabStop = false;
            grpColors.Text = "&Color";
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(chkLaneAssist);
            grpFeatures.Controls.Add(chkSyriusRadio);
            grpFeatures.Controls.Add(chkPowerWindows);
            grpFeatures.Controls.Add(chkAC);
            grpFeatures.Location = new Point(766, 32);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(192, 198);
            grpFeatures.TabIndex = 9;
            grpFeatures.TabStop = false;
            grpFeatures.Text = "&Features";
            // 
            // chkLaneAssist
            // 
            chkLaneAssist.AutoSize = true;
            chkLaneAssist.Location = new Point(21, 152);
            chkLaneAssist.Name = "chkLaneAssist";
            chkLaneAssist.Size = new Size(125, 29);
            chkLaneAssist.TabIndex = 13;
            chkLaneAssist.Text = "Lane Assist";
            chkLaneAssist.UseVisualStyleBackColor = true;
            // 
            // chkSyriusRadio
            // 
            chkSyriusRadio.AutoSize = true;
            chkSyriusRadio.Location = new Point(21, 117);
            chkSyriusRadio.Name = "chkSyriusRadio";
            chkSyriusRadio.Size = new Size(135, 29);
            chkSyriusRadio.TabIndex = 12;
            chkSyriusRadio.Text = "Syrius Radio";
            chkSyriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkPowerWindows
            // 
            chkPowerWindows.AutoSize = true;
            chkPowerWindows.Location = new Point(21, 82);
            chkPowerWindows.Name = "chkPowerWindows";
            chkPowerWindows.Size = new Size(165, 29);
            chkPowerWindows.TabIndex = 11;
            chkPowerWindows.Text = "Power Windows";
            chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(21, 47);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(61, 29);
            chkAC.TabIndex = 10;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(118, 421);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(112, 34);
            btnPurchase.TabIndex = 14;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // lblSummary
            // 
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(350, 403);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(608, 114);
            lblSummary.TabIndex = 15;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 575);
            Controls.Add(lblSummary);
            Controls.Add(btnPurchase);
            Controls.Add(grpFeatures);
            Controls.Add(grpColors);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lstModels);
            Controls.Add(lblListBox);
            Name = "MainForm";
            Text = "Assignment 2";
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            grpFeatures.ResumeLayout(false);
            grpFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListBox;
        private ListBox lstModels;
        private Label lblYear;
        private TextBox txtYear;
        private RadioButton radRed;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private RadioButton radWhite;
        private GroupBox grpColors;
        private GroupBox grpFeatures;
        private CheckBox chkLaneAssist;
        private CheckBox chkSyriusRadio;
        private CheckBox chkPowerWindows;
        private CheckBox chkAC;
        private Button btnPurchase;
        private Label lblSummary;
    }
}
