namespace Simple_File_Organiser
{
    partial class GUI
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
            this.addFolderButton = new System.Windows.Forms.Button();
            this.foldersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeFolderButton = new System.Windows.Forms.Button();
            this.folderCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchList = new System.Windows.Forms.ListView();
            this.col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sortButton = new System.Windows.Forms.Button();
            this.addStringButton = new System.Windows.Forms.Button();
            this.removeSearchButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.outputAllCheckBox = new System.Windows.Forms.CheckBox();
            this.outputAllToButton = new System.Windows.Forms.Button();
            this.outputAllTextBox = new System.Windows.Forms.TextBox();
            this.seperateByFoldersCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addFolderButton
            // 
            this.addFolderButton.Location = new System.Drawing.Point(23, 247);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(159, 23);
            this.addFolderButton.TabIndex = 1;
            this.addFolderButton.Text = "Add Folder";
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // foldersList
            // 
            this.foldersList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.foldersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.foldersList.Location = new System.Drawing.Point(23, 80);
            this.foldersList.Name = "foldersList";
            this.foldersList.Size = new System.Drawing.Size(323, 161);
            this.foldersList.TabIndex = 2;
            this.foldersList.UseCompatibleStateImageBehavior = false;
            this.foldersList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Directory path";
            this.columnHeader1.Width = 300;
            // 
            // removeFolderButton
            // 
            this.removeFolderButton.Location = new System.Drawing.Point(187, 247);
            this.removeFolderButton.Name = "removeFolderButton";
            this.removeFolderButton.Size = new System.Drawing.Size(159, 23);
            this.removeFolderButton.TabIndex = 3;
            this.removeFolderButton.Text = "Remove Folder";
            this.removeFolderButton.UseVisualStyleBackColor = true;
            this.removeFolderButton.Click += new System.EventHandler(this.removeFolderButton_Click);
            // 
            // folderCheck
            // 
            this.folderCheck.AutoSize = true;
            this.folderCheck.Location = new System.Drawing.Point(136, 31);
            this.folderCheck.Name = "folderCheck";
            this.folderCheck.Size = new System.Drawing.Size(15, 14);
            this.folderCheck.TabIndex = 4;
            this.folderCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folders containing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "In these directories..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Containing...";
            // 
            // searchList
            // 
            this.searchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col});
            this.searchList.Location = new System.Drawing.Point(23, 303);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(323, 109);
            this.searchList.TabIndex = 11;
            this.searchList.UseCompatibleStateImageBehavior = false;
            this.searchList.View = System.Windows.Forms.View.Details;
            // 
            // col
            // 
            this.col.Text = "Search Terms";
            this.col.Width = 300;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(136, 506);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(94, 36);
            this.sortButton.TabIndex = 12;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // addStringButton
            // 
            this.addStringButton.Location = new System.Drawing.Point(22, 418);
            this.addStringButton.Name = "addStringButton";
            this.addStringButton.Size = new System.Drawing.Size(159, 23);
            this.addStringButton.TabIndex = 13;
            this.addStringButton.Text = "Add string";
            this.addStringButton.UseVisualStyleBackColor = true;
            this.addStringButton.Click += new System.EventHandler(this.addStringButton_Click);
            // 
            // removeSearchButton
            // 
            this.removeSearchButton.Location = new System.Drawing.Point(187, 418);
            this.removeSearchButton.Name = "removeSearchButton";
            this.removeSearchButton.Size = new System.Drawing.Size(158, 23);
            this.removeSearchButton.TabIndex = 15;
            this.removeSearchButton.Text = "Remove";
            this.removeSearchButton.UseVisualStyleBackColor = true;
            this.removeSearchButton.Click += new System.EventHandler(this.removeSearchButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(363, 31);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusBox.Size = new System.Drawing.Size(713, 511);
            this.statusBox.TabIndex = 16;
            // 
            // outputAllCheckBox
            // 
            this.outputAllCheckBox.AutoSize = true;
            this.outputAllCheckBox.Location = new System.Drawing.Point(23, 461);
            this.outputAllCheckBox.Name = "outputAllCheckBox";
            this.outputAllCheckBox.Size = new System.Drawing.Size(15, 14);
            this.outputAllCheckBox.TabIndex = 17;
            this.outputAllCheckBox.UseVisualStyleBackColor = true;
            this.outputAllCheckBox.CheckedChanged += new System.EventHandler(this.outputAllCheckBox_CheckedChanged);
            // 
            // outputAllToButton
            // 
            this.outputAllToButton.Enabled = false;
            this.outputAllToButton.Location = new System.Drawing.Point(44, 456);
            this.outputAllToButton.Name = "outputAllToButton";
            this.outputAllToButton.Size = new System.Drawing.Size(86, 23);
            this.outputAllToButton.TabIndex = 18;
            this.outputAllToButton.Text = "Output all to..";
            this.outputAllToButton.UseVisualStyleBackColor = true;
            this.outputAllToButton.Click += new System.EventHandler(this.outputAllToButton_Click);
            // 
            // outputAllTextBox
            // 
            this.outputAllTextBox.Enabled = false;
            this.outputAllTextBox.Location = new System.Drawing.Point(136, 458);
            this.outputAllTextBox.Name = "outputAllTextBox";
            this.outputAllTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outputAllTextBox.Size = new System.Drawing.Size(210, 20);
            this.outputAllTextBox.TabIndex = 19;
            // 
            // seperateByFoldersCheckbox
            // 
            this.seperateByFoldersCheckbox.AutoSize = true;
            this.seperateByFoldersCheckbox.Enabled = false;
            this.seperateByFoldersCheckbox.Location = new System.Drawing.Point(31, 485);
            this.seperateByFoldersCheckbox.Name = "seperateByFoldersCheckbox";
            this.seperateByFoldersCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.seperateByFoldersCheckbox.Size = new System.Drawing.Size(130, 17);
            this.seperateByFoldersCheckbox.TabIndex = 20;
            this.seperateByFoldersCheckbox.Text = "...And Sort into folders";
            this.seperateByFoldersCheckbox.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 556);
            this.Controls.Add(this.seperateByFoldersCheckbox);
            this.Controls.Add(this.outputAllTextBox);
            this.Controls.Add(this.outputAllToButton);
            this.Controls.Add(this.outputAllCheckBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.removeSearchButton);
            this.Controls.Add(this.addStringButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderCheck);
            this.Controls.Add(this.removeFolderButton);
            this.Controls.Add(this.foldersList);
            this.Controls.Add(this.addFolderButton);
            this.Name = "GUI";
            this.Text = "File Organiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.ListView foldersList;
        private System.Windows.Forms.Button removeFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox folderCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button addStringButton;
        private System.Windows.Forms.Button removeSearchButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader col;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.CheckBox outputAllCheckBox;
        private System.Windows.Forms.Button outputAllToButton;
        private System.Windows.Forms.TextBox outputAllTextBox;
        private System.Windows.Forms.CheckBox seperateByFoldersCheckbox;

    }
}

