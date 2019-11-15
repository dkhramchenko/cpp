namespace task2
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
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxCreationTime = new System.Windows.Forms.TextBox();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(583, 62);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(156, 68);
            this.buttonDisplay.TabIndex = 0;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(79, 82);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(378, 31);
            this.textBoxInput.TabIndex = 1;
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.ItemHeight = 25;
            this.listBoxFolders.Location = new System.Drawing.Point(99, 249);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(120, 79);
            this.listBoxFolders.TabIndex = 2;
            this.listBoxFolders.SelectedIndexChanged += new System.EventHandler(this.listBoxFolders_SelectedIndexChanged);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 25;
            this.listBoxFiles.Location = new System.Drawing.Point(291, 249);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(120, 79);
            this.listBoxFiles.TabIndex = 3;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(79, 154);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(100, 31);
            this.textBoxFolder.TabIndex = 4;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(255, 153);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(100, 31);
            this.textBoxFileName.TabIndex = 5;
            // 
            // textBoxCreationTime
            // 
            this.textBoxCreationTime.Location = new System.Drawing.Point(437, 168);
            this.textBoxCreationTime.Name = "textBoxCreationTime";
            this.textBoxCreationTime.Size = new System.Drawing.Size(100, 31);
            this.textBoxCreationTime.TabIndex = 6;
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Location = new System.Drawing.Point(437, 233);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.Size = new System.Drawing.Size(100, 31);
            this.textBoxFileSize.TabIndex = 7;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(609, 154);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(130, 62);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 482);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textBoxFileSize);
            this.Controls.Add(this.textBoxCreationTime);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxCreationTime;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Button buttonUp;
    }
}

