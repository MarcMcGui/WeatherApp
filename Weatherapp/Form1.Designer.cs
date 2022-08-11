namespace Weatherapp
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
            this.enterZipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterZipButton
            // 
            this.enterZipButton.Location = new System.Drawing.Point(216, 240);
            this.enterZipButton.Name = "enterZipButton";
            this.enterZipButton.Size = new System.Drawing.Size(75, 23);
            this.enterZipButton.TabIndex = 0;
            this.enterZipButton.Text = "Enter";
            this.enterZipButton.UseVisualStyleBackColor = true;
            this.enterZipButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 392);
            this.Controls.Add(this.enterZipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterZipButton;
    }
}

