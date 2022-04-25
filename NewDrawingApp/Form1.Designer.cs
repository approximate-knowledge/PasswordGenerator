namespace NewDrawingApp
{
    partial class Form1
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PassLengthLabel = new System.Windows.Forms.Label();
            this.PasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(287, 40);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(259, 35);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "label1";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassLengthLabel
            // 
            this.PassLengthLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassLengthLabel.Location = new System.Drawing.Point(207, 230);
            this.PassLengthLabel.Name = "PassLengthLabel";
            this.PassLengthLabel.Size = new System.Drawing.Size(402, 35);
            this.PassLengthLabel.TabIndex = 1;
            this.PassLengthLabel.Text = "Password Length: 5";
            this.PassLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PassLengthLabel.Click += new System.EventHandler(this.PassLengthLabel_Click);
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.Location = new System.Drawing.Point(224, 268);
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.Size = new System.Drawing.Size(364, 45);
            this.PasswordLengthSlider.TabIndex = 2;
            this.PasswordLengthSlider.Scroll += new System.EventHandler(this.PasswordLengthSlider_Scroll);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopyPasswordButton.Location = new System.Drawing.Point(224, 319);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(364, 57);
            this.CopyPasswordButton.TabIndex = 3;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(836, 485);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.PasswordLengthSlider);
            this.Controls.Add(this.PassLengthLabel);
            this.Controls.Add(this.PasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PassLengthLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label PasswordLabel;
        private Label PassLengthLabel;
        private TrackBar PasswordLengthSlider;
        private Button CopyPasswordButton;
    }
}