namespace Ch_4_in_class
{
    partial class MainForm
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
            this.NewCheckBox = new System.Windows.Forms.CheckBox();
            this.FormatGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDRadioButton = new System.Windows.Forms.RadioButton();
            this.BDRadioButton = new System.Windows.Forms.RadioButton();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MemberCheckBox = new System.Windows.Forms.CheckBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.OCButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MsgTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movieTextBox = new System.Windows.Forms.TextBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.FormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewCheckBox
            // 
            this.NewCheckBox.AutoSize = true;
            this.NewCheckBox.Location = new System.Drawing.Point(78, 115);
            this.NewCheckBox.Name = "NewCheckBox";
            this.NewCheckBox.Size = new System.Drawing.Size(90, 17);
            this.NewCheckBox.TabIndex = 0;
            this.NewCheckBox.Text = "New Release";
            this.NewCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormatGroupBox
            // 
            this.FormatGroupBox.Controls.Add(this.DVDRadioButton);
            this.FormatGroupBox.Controls.Add(this.BDRadioButton);
            this.FormatGroupBox.Location = new System.Drawing.Point(41, 12);
            this.FormatGroupBox.Name = "FormatGroupBox";
            this.FormatGroupBox.Size = new System.Drawing.Size(145, 97);
            this.FormatGroupBox.TabIndex = 1;
            this.FormatGroupBox.TabStop = false;
            this.FormatGroupBox.Text = "Select Movie Format";
            // 
            // DVDRadioButton
            // 
            this.DVDRadioButton.AutoSize = true;
            this.DVDRadioButton.Location = new System.Drawing.Point(33, 57);
            this.DVDRadioButton.Name = "DVDRadioButton";
            this.DVDRadioButton.Size = new System.Drawing.Size(94, 17);
            this.DVDRadioButton.TabIndex = 1;
            this.DVDRadioButton.TabStop = true;
            this.DVDRadioButton.Text = "Standard DVD";
            this.DVDRadioButton.UseVisualStyleBackColor = true;
            this.DVDRadioButton.Click += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // BDRadioButton
            // 
            this.BDRadioButton.AutoSize = true;
            this.BDRadioButton.Location = new System.Drawing.Point(33, 33);
            this.BDRadioButton.Name = "BDRadioButton";
            this.BDRadioButton.Size = new System.Drawing.Size(94, 17);
            this.BDRadioButton.TabIndex = 0;
            this.BDRadioButton.TabStop = true;
            this.BDRadioButton.Text = "Blue Ray DVD";
            this.BDRadioButton.UseVisualStyleBackColor = true;
            this.BDRadioButton.Click += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(204, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(211, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // MemberCheckBox
            // 
            this.MemberCheckBox.AutoSize = true;
            this.MemberCheckBox.Location = new System.Drawing.Point(351, 51);
            this.MemberCheckBox.Name = "MemberCheckBox";
            this.MemberCheckBox.Size = new System.Drawing.Size(64, 17);
            this.MemberCheckBox.TabIndex = 3;
            this.MemberCheckBox.Text = "Member";
            this.MemberCheckBox.UseVisualStyleBackColor = true;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(31, 151);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(113, 23);
            this.CalcButton.TabIndex = 4;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // OCButton
            // 
            this.OCButton.Location = new System.Drawing.Point(31, 209);
            this.OCButton.Name = "OCButton";
            this.OCButton.Size = new System.Drawing.Size(113, 23);
            this.OCButton.TabIndex = 5;
            this.OCButton.Text = "Order Complete";
            this.OCButton.UseVisualStyleBackColor = true;
            this.OCButton.Visible = false;
            this.OCButton.Click += new System.EventHandler(this.OCButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(322, 307);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(31, 307);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(75, 23);
            this.SummaryButton.TabIndex = 7;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Visible = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(31, 180);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(113, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear for Next Item";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MsgTextBox
            // 
            this.MsgTextBox.Location = new System.Drawing.Point(175, 133);
            this.MsgTextBox.Multiline = true;
            this.MsgTextBox.Name = "MsgTextBox";
            this.MsgTextBox.ReadOnly = true;
            this.MsgTextBox.Size = new System.Drawing.Size(240, 168);
            this.MsgTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer Name";
            // 
            // movieTextBox
            // 
            this.movieTextBox.Location = new System.Drawing.Point(207, 107);
            this.movieTextBox.Name = "movieTextBox";
            this.movieTextBox.Size = new System.Drawing.Size(190, 20);
            this.movieTextBox.TabIndex = 11;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(207, 88);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(87, 13);
            this.movieLabel.TabIndex = 12;
            this.movieLabel.Text = "Enter Movie Title";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 371);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.movieTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OCButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.MemberCheckBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FormatGroupBox);
            this.Controls.Add(this.NewCheckBox);
            this.Name = "MainForm";
            this.Text = "Xtreme Cinema";
            this.FormatGroupBox.ResumeLayout(false);
            this.FormatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NewCheckBox;
        private System.Windows.Forms.GroupBox FormatGroupBox;
        private System.Windows.Forms.RadioButton DVDRadioButton;
        private System.Windows.Forms.RadioButton BDRadioButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckBox MemberCheckBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button OCButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox MsgTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieTextBox;
        private System.Windows.Forms.Label movieLabel;
    }
}

