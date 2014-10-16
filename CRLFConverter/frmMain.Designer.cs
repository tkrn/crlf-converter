namespace CRLFConverter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.selectedFilesFoldersListBox = new System.Windows.Forms.ListBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.convertProgressBar = new System.Windows.Forms.ProgressBar();
            this.rbOverwrite = new System.Windows.Forms.RadioButton();
            this.rbCreateFile = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedFilesFoldersListBox
            // 
            this.selectedFilesFoldersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedFilesFoldersListBox.FormattingEnabled = true;
            this.selectedFilesFoldersListBox.Location = new System.Drawing.Point(13, 13);
            this.selectedFilesFoldersListBox.Name = "selectedFilesFoldersListBox";
            this.selectedFilesFoldersListBox.Size = new System.Drawing.Size(634, 160);
            this.selectedFilesFoldersListBox.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(489, 182);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(570, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 182);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Add File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(93, 182);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // convertProgressBar
            // 
            this.convertProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.convertProgressBar.Location = new System.Drawing.Point(12, 212);
            this.convertProgressBar.Name = "convertProgressBar";
            this.convertProgressBar.Size = new System.Drawing.Size(632, 23);
            this.convertProgressBar.TabIndex = 0;
            // 
            // rbOverwrite
            // 
            this.rbOverwrite.AutoSize = true;
            this.rbOverwrite.Location = new System.Drawing.Point(356, 185);
            this.rbOverwrite.Name = "rbOverwrite";
            this.rbOverwrite.Size = new System.Drawing.Size(128, 17);
            this.rbOverwrite.TabIndex = 5;
            this.rbOverwrite.Text = "Overwrite Existing File";
            this.rbOverwrite.UseVisualStyleBackColor = true;
            // 
            // rbCreateFile
            // 
            this.rbCreateFile.AutoSize = true;
            this.rbCreateFile.Checked = true;
            this.rbCreateFile.Location = new System.Drawing.Point(255, 185);
            this.rbCreateFile.Name = "rbCreateFile";
            this.rbCreateFile.Size = new System.Drawing.Size(100, 17);
            this.rbCreateFile.TabIndex = 6;
            this.rbCreateFile.TabStop = true;
            this.rbCreateFile.Text = "Create New File";
            this.rbCreateFile.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(174, 182);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 247);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.rbCreateFile);
            this.Controls.Add(this.rbOverwrite);
            this.Controls.Add(this.convertProgressBar);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.selectedFilesFoldersListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 285);
            this.MinimumSize = new System.Drawing.Size(675, 285);
            this.Name = "frmMain";
            this.Text = "CRLF Converter - Unix to Windows Text File Converter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox selectedFilesFoldersListBox;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.ProgressBar convertProgressBar;
        private System.Windows.Forms.RadioButton rbOverwrite;
        private System.Windows.Forms.RadioButton rbCreateFile;
        private System.Windows.Forms.Button btnRemove;
    }
}

