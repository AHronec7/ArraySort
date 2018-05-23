namespace WindowsFormsApp1
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
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.DisplayNamesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalCountLabel = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NamesListBox
            // 
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.Location = new System.Drawing.Point(12, 15);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(298, 394);
            this.NamesListBox.TabIndex = 0;
            // 
            // DisplayNamesButton
            // 
            this.DisplayNamesButton.BackColor = System.Drawing.Color.White;
            this.DisplayNamesButton.Location = new System.Drawing.Point(357, 25);
            this.DisplayNamesButton.Name = "DisplayNamesButton";
            this.DisplayNamesButton.Size = new System.Drawing.Size(75, 48);
            this.DisplayNamesButton.TabIndex = 1;
            this.DisplayNamesButton.Text = "Display Names";
            this.DisplayNamesButton.UseVisualStyleBackColor = false;
            this.DisplayNamesButton.Click += new System.EventHandler(this.DisplayNamesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(338, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count of items:";
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalCountLabel.Location = new System.Drawing.Point(453, 143);
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(100, 30);
            this.TotalCountLabel.TabIndex = 3;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.White;
            this.SortButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SortButton.Location = new System.Drawing.Point(478, 25);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 48);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "A-Z Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(579, 421);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.TotalCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayNamesButton);
            this.Controls.Add(this.NamesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.Button DisplayNamesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalCountLabel;
        private System.Windows.Forms.Button SortButton;
    }
}

