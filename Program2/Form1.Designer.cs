
namespace Program2
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
            this.guestsLabel = new System.Windows.Forms.Label();
            this.nightsLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.costOutputLabel = new System.Windows.Forms.Label();
            this.guestsInputTextBox = new System.Windows.Forms.TextBox();
            this.nightsInputTextBox = new System.Windows.Forms.TextBox();
            this.starsInputComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.Location = new System.Drawing.Point(50, 30);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(95, 13);
            this.guestsLabel.TabIndex = 0;
            this.guestsLabel.Text = "Number of Guests:";
            // 
            // nightsLabel
            // 
            this.nightsLabel.AutoSize = true;
            this.nightsLabel.Location = new System.Drawing.Point(50, 70);
            this.nightsLabel.Name = "nightsLabel";
            this.nightsLabel.Size = new System.Drawing.Size(92, 13);
            this.nightsLabel.TabIndex = 1;
            this.nightsLabel.Text = "Number of Nights:";
            // 
            // starsLabel
            // 
            this.starsLabel.AutoSize = true;
            this.starsLabel.Location = new System.Drawing.Point(50, 108);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(62, 13);
            this.starsLabel.TabIndex = 2;
            this.starsLabel.Text = "Hotel Stars:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(123, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(50, 185);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(59, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Hotel Cost:";
            // 
            // costOutputLabel
            // 
            this.costOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOutputLabel.Location = new System.Drawing.Point(174, 184);
            this.costOutputLabel.Name = "costOutputLabel";
            this.costOutputLabel.Size = new System.Drawing.Size(100, 19);
            this.costOutputLabel.TabIndex = 5;
            this.costOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guestsInputTextBox
            // 
            this.guestsInputTextBox.Location = new System.Drawing.Point(174, 27);
            this.guestsInputTextBox.Name = "guestsInputTextBox";
            this.guestsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestsInputTextBox.TabIndex = 6;
            // 
            // nightsInputTextBox
            // 
            this.nightsInputTextBox.Location = new System.Drawing.Point(174, 67);
            this.nightsInputTextBox.Name = "nightsInputTextBox";
            this.nightsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.nightsInputTextBox.TabIndex = 7;
            // 
            // starsInputComboBox
            // 
            this.starsInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starsInputComboBox.FormattingEnabled = true;
            this.starsInputComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.starsInputComboBox.Location = new System.Drawing.Point(174, 105);
            this.starsInputComboBox.Name = "starsInputComboBox";
            this.starsInputComboBox.Size = new System.Drawing.Size(100, 21);
            this.starsInputComboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 237);
            this.Controls.Add(this.starsInputComboBox);
            this.Controls.Add(this.nightsInputTextBox);
            this.Controls.Add(this.guestsInputTextBox);
            this.Controls.Add(this.costOutputLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.nightsLabel);
            this.Controls.Add(this.guestsLabel);
            this.Name = "Form1";
            this.Text = "Program 2 - Hotel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guestsLabel;
        private System.Windows.Forms.Label nightsLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costOutputLabel;
        private System.Windows.Forms.TextBox guestsInputTextBox;
        private System.Windows.Forms.TextBox nightsInputTextBox;
        private System.Windows.Forms.ComboBox starsInputComboBox;
    }
}

