namespace RintegerImageProcessing
{
    partial class RenameForm
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
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.Rename = new System.Windows.Forms.Button();
            this.Preffix = new System.Windows.Forms.TextBox();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(187, 80);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(437, 38);
            this.FolderPath.TabIndex = 0;
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(342, 318);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(149, 72);
            this.Rename.TabIndex = 1;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Preffix
            // 
            this.Preffix.Location = new System.Drawing.Point(187, 165);
            this.Preffix.Name = "Preffix";
            this.Preffix.Size = new System.Drawing.Size(437, 38);
            this.Preffix.TabIndex = 2;
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(187, 248);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(437, 38);
            this.Suffix.TabIndex = 3;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.Preffix);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.FolderPath);
            this.Name = "RenameForm";
            this.Text = "RenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.TextBox Preffix;
        private System.Windows.Forms.TextBox Suffix;
    }
}