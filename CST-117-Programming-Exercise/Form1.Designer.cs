namespace CST_117_Programming_Exercise
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.raceListBox = new System.Windows.Forms.ListBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.engineerCheckBox = new System.Windows.Forms.CheckBox();
            this.captainCheckBox = new System.Windows.Forms.CheckBox();
            this.scienceCheckBox = new System.Windows.Forms.CheckBox();
            this.tacticsCheckBox = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(378, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Star Trek Character Creator";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(13, 100);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender:";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(13, 132);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 13);
            this.raceLabel.TabIndex = 3;
            this.raceLabel.Text = "Race:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(58, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(65, 100);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(119, 100);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // raceListBox
            // 
            this.raceListBox.FormattingEnabled = true;
            this.raceListBox.Items.AddRange(new object[] {
            "Human",
            "Klingon",
            "Ferengi",
            "Romulan",
            "Vulcan"});
            this.raceListBox.Location = new System.Drawing.Point(56, 132);
            this.raceListBox.Name = "raceListBox";
            this.raceListBox.Size = new System.Drawing.Size(120, 95);
            this.raceListBox.TabIndex = 7;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(12, 257);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(49, 13);
            this.positionLabel.TabIndex = 8;
            this.positionLabel.Text = "Positions";
            // 
            // engineerCheckBox
            // 
            this.engineerCheckBox.AutoSize = true;
            this.engineerCheckBox.Location = new System.Drawing.Point(56, 286);
            this.engineerCheckBox.Name = "engineerCheckBox";
            this.engineerCheckBox.Size = new System.Drawing.Size(68, 17);
            this.engineerCheckBox.TabIndex = 9;
            this.engineerCheckBox.Text = "Engineer";
            this.engineerCheckBox.UseVisualStyleBackColor = true;
            // 
            // captainCheckBox
            // 
            this.captainCheckBox.AutoSize = true;
            this.captainCheckBox.Location = new System.Drawing.Point(56, 309);
            this.captainCheckBox.Name = "captainCheckBox";
            this.captainCheckBox.Size = new System.Drawing.Size(62, 17);
            this.captainCheckBox.TabIndex = 10;
            this.captainCheckBox.Text = "Captain";
            this.captainCheckBox.UseVisualStyleBackColor = true;
            // 
            // scienceCheckBox
            // 
            this.scienceCheckBox.AutoSize = true;
            this.scienceCheckBox.Location = new System.Drawing.Point(56, 332);
            this.scienceCheckBox.Name = "scienceCheckBox";
            this.scienceCheckBox.Size = new System.Drawing.Size(65, 17);
            this.scienceCheckBox.TabIndex = 11;
            this.scienceCheckBox.Text = "Science";
            this.scienceCheckBox.UseVisualStyleBackColor = true;
            // 
            // tacticsCheckBox
            // 
            this.tacticsCheckBox.AutoSize = true;
            this.tacticsCheckBox.Location = new System.Drawing.Point(56, 355);
            this.tacticsCheckBox.Name = "tacticsCheckBox";
            this.tacticsCheckBox.Size = new System.Drawing.Size(61, 17);
            this.tacticsCheckBox.TabIndex = 12;
            this.tacticsCheckBox.Text = "Tactics";
            this.tacticsCheckBox.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(316, 388);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 418);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.tacticsCheckBox);
            this.Controls.Add(this.scienceCheckBox);
            this.Controls.Add(this.captainCheckBox);
            this.Controls.Add(this.engineerCheckBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.raceListBox);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Star Trek Character Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.ListBox raceListBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.CheckBox engineerCheckBox;
        private System.Windows.Forms.CheckBox captainCheckBox;
        private System.Windows.Forms.CheckBox scienceCheckBox;
        private System.Windows.Forms.CheckBox tacticsCheckBox;
        private System.Windows.Forms.Button submitButton;
    }
}

