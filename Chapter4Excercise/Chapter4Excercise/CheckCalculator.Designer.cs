namespace Chapter4Excercise
{
    partial class Check_Calculator
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
            this.calcButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.completedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MsgTextBox = new System.Windows.Forms.TextBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 133);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(409, 335);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(12, 162);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(75, 23);
            this.summaryButton.TabIndex = 2;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(114, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // completedTextBox
            // 
            this.completedTextBox.Location = new System.Drawing.Point(114, 49);
            this.completedTextBox.Name = "completedTextBox";
            this.completedTextBox.Size = new System.Drawing.Size(100, 20);
            this.completedTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pieces Completed: ";
            // 
            // MsgTextBox
            // 
            this.MsgTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MsgTextBox.Location = new System.Drawing.Point(163, 93);
            this.MsgTextBox.Multiline = true;
            this.MsgTextBox.Name = "MsgTextBox";
            this.MsgTextBox.ReadOnly = true;
            this.MsgTextBox.Size = new System.Drawing.Size(273, 162);
            this.MsgTextBox.TabIndex = 7;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(13, 191);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 8;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            // 
            // Check_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 370);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.MsgTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.completedTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.calcButton);
            this.Name = "Check_Calculator";
            this.Text = "Check Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox completedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MsgTextBox;
        private System.Windows.Forms.Button clearAllButton;
    }
}

