namespace RintegerImageProcessing
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
            this.RenameFile = new System.Windows.Forms.Button();
            this.CompressFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RenameFile
            // 
            this.RenameFile.Location = new System.Drawing.Point(124, 170);
            this.RenameFile.Name = "RenameFile";
            this.RenameFile.Size = new System.Drawing.Size(297, 83);
            this.RenameFile.TabIndex = 0;
            this.RenameFile.Text = "RenameFile";
            this.RenameFile.UseVisualStyleBackColor = true;
            this.RenameFile.Click += new System.EventHandler(this.RenameFile_Click);
            // 
            // CompressFile
            // 
            this.CompressFile.Location = new System.Drawing.Point(432, 170);
            this.CompressFile.Name = "CompressFile";
            this.CompressFile.Size = new System.Drawing.Size(212, 83);
            this.CompressFile.TabIndex = 1;
            this.CompressFile.Text = "CompressFile";
            this.CompressFile.UseVisualStyleBackColor = true;
            this.CompressFile.Click += new System.EventHandler(this.CompressFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.CompressFile);
            this.Controls.Add(this.RenameFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RenameFile;
        private System.Windows.Forms.Button CompressFile;
    }
}

