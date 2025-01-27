﻿namespace Snap2HTMLNG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabSnapshot = new System.Windows.Forms.TabPage();
            this.btnFileDateConfigure = new System.Windows.Forms.Button();
            this.chkFileDateEnable = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFileDate = new System.Windows.Forms.DateTimePicker();
            this.lblFileDate = new System.Windows.Forms.Label();
            this.cbDirectoriesOnly = new System.Windows.Forms.CheckBox();
            this.txtSearchPattern = new System.Windows.Forms.TextBox();
            this.lblSearchPattern = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkOpenOutput = new System.Windows.Forms.CheckBox();
            this.txtLinkRoot = new System.Windows.Forms.TextBox();
            this.chkLinkFiles = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.labelRootFolder = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.tabCustomDesign = new System.Windows.Forms.TabPage();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.gbPreferences = new System.Windows.Forms.GroupBox();
            this.lblCheckForUpdatesNotice = new System.Windows.Forms.Label();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.linkLabelDonate = new System.Windows.Forms.LinkLabel();
            this.linkLabelLaim = new System.Windows.Forms.LinkLabel();
            this.lblLaimAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelAboutSoftware = new System.Windows.Forms.Label();
            this.labelAboutVersion = new System.Windows.Forms.Label();
            this.labelAboutTitle = new System.Windows.Forms.Label();
            this.fbdScanDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCtrl.SuspendLayout();
            this.tabSnapshot.SuspendLayout();
            this.tabCustomDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.gbPreferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabSnapshot);
            this.tabCtrl.Controls.Add(this.tabCustomDesign);
            this.tabCtrl.Controls.Add(this.tabAbout);
            this.tabCtrl.Location = new System.Drawing.Point(11, 10);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(451, 521);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabSnapshot
            // 
            this.tabSnapshot.Controls.Add(this.btnFileDateConfigure);
            this.tabSnapshot.Controls.Add(this.chkFileDateEnable);
            this.tabSnapshot.Controls.Add(this.dateTimePickerFileDate);
            this.tabSnapshot.Controls.Add(this.lblFileDate);
            this.tabSnapshot.Controls.Add(this.cbDirectoriesOnly);
            this.tabSnapshot.Controls.Add(this.txtSearchPattern);
            this.tabSnapshot.Controls.Add(this.lblSearchPattern);
            this.tabSnapshot.Controls.Add(this.label2);
            this.tabSnapshot.Controls.Add(this.txtTitle);
            this.tabSnapshot.Controls.Add(this.label6);
            this.tabSnapshot.Controls.Add(this.chkOpenOutput);
            this.tabSnapshot.Controls.Add(this.txtLinkRoot);
            this.tabSnapshot.Controls.Add(this.chkLinkFiles);
            this.tabSnapshot.Controls.Add(this.chkHidden);
            this.tabSnapshot.Controls.Add(this.chkSystem);
            this.tabSnapshot.Controls.Add(this.cmdCreate);
            this.tabSnapshot.Controls.Add(this.txtRoot);
            this.tabSnapshot.Controls.Add(this.labelRootFolder);
            this.tabSnapshot.Controls.Add(this.cmdBrowse);
            this.tabSnapshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSnapshot.Location = new System.Drawing.Point(4, 25);
            this.tabSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.tabSnapshot.Name = "tabSnapshot";
            this.tabSnapshot.Padding = new System.Windows.Forms.Padding(4);
            this.tabSnapshot.Size = new System.Drawing.Size(443, 492);
            this.tabSnapshot.TabIndex = 0;
            this.tabSnapshot.Text = "Snapshot";
            this.tabSnapshot.UseVisualStyleBackColor = true;
            // 
            // btnFileDateConfigure
            // 
            this.btnFileDateConfigure.Location = new System.Drawing.Point(258, 328);
            this.btnFileDateConfigure.Name = "btnFileDateConfigure";
            this.btnFileDateConfigure.Size = new System.Drawing.Size(86, 23);
            this.btnFileDateConfigure.TabIndex = 25;
            this.btnFileDateConfigure.Text = "Configure";
            this.btnFileDateConfigure.UseVisualStyleBackColor = true;
            this.btnFileDateConfigure.Click += new System.EventHandler(this.btnFileDateConfigure_Click);
            // 
            // chkFileDateEnable
            // 
            this.chkFileDateEnable.AutoSize = true;
            this.chkFileDateEnable.Location = new System.Drawing.Point(352, 328);
            this.chkFileDateEnable.Name = "chkFileDateEnable";
            this.chkFileDateEnable.Size = new System.Drawing.Size(74, 21);
            this.chkFileDateEnable.TabIndex = 24;
            this.chkFileDateEnable.Text = "Enable";
            this.chkFileDateEnable.UseVisualStyleBackColor = true;
            this.chkFileDateEnable.CheckedChanged += new System.EventHandler(this.chkFileDateEnable_CheckedChanged);
            // 
            // dateTimePickerFileDate
            // 
            this.dateTimePickerFileDate.Enabled = false;
            this.dateTimePickerFileDate.Location = new System.Drawing.Point(31, 352);
            this.dateTimePickerFileDate.Name = "dateTimePickerFileDate";
            this.dateTimePickerFileDate.Size = new System.Drawing.Size(399, 23);
            this.dateTimePickerFileDate.TabIndex = 23;
            // 
            // lblFileDate
            // 
            this.lblFileDate.AutoSize = true;
            this.lblFileDate.Location = new System.Drawing.Point(28, 332);
            this.lblFileDate.Name = "lblFileDate";
            this.lblFileDate.Size = new System.Drawing.Size(64, 17);
            this.lblFileDate.TabIndex = 22;
            this.lblFileDate.Text = "File Date";
            // 
            // cbDirectoriesOnly
            // 
            this.cbDirectoriesOnly.AutoSize = true;
            this.cbDirectoriesOnly.Location = new System.Drawing.Point(213, 76);
            this.cbDirectoriesOnly.Name = "cbDirectoriesOnly";
            this.cbDirectoriesOnly.Size = new System.Drawing.Size(131, 21);
            this.cbDirectoriesOnly.TabIndex = 21;
            this.cbDirectoriesOnly.Text = "Directories Only";
            this.cbDirectoriesOnly.UseVisualStyleBackColor = true;
            this.cbDirectoriesOnly.CheckedChanged += new System.EventHandler(this.cbDirectoriesOnly_CheckedChanged);
            // 
            // txtSearchPattern
            // 
            this.txtSearchPattern.Location = new System.Drawing.Point(31, 287);
            this.txtSearchPattern.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPattern.Name = "txtSearchPattern";
            this.txtSearchPattern.Size = new System.Drawing.Size(399, 23);
            this.txtSearchPattern.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtSearchPattern, "This is the target files will be linked to. See ReadMe.txt for examples of how to" +
        " make links");
            // 
            // lblSearchPattern
            // 
            this.lblSearchPattern.Location = new System.Drawing.Point(27, 267);
            this.lblSearchPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchPattern.Name = "lblSearchPattern";
            this.lblSearchPattern.Size = new System.Drawing.Size(404, 16);
            this.lblSearchPattern.TabIndex = 19;
            this.lblSearchPattern.Text = "Search Pattern:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Page title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(31, 160);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(399, 23);
            this.txtTitle.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtTitle, "Set the html page title");
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Link files:";
            // 
            // chkOpenOutput
            // 
            this.chkOpenOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOpenOutput.AutoSize = true;
            this.chkOpenOutput.Location = new System.Drawing.Point(213, 458);
            this.chkOpenOutput.Margin = new System.Windows.Forms.Padding(4);
            this.chkOpenOutput.Name = "chkOpenOutput";
            this.chkOpenOutput.Size = new System.Drawing.Size(211, 21);
            this.chkOpenOutput.TabIndex = 18;
            this.chkOpenOutput.Text = "Open in browser when ready";
            this.chkOpenOutput.UseVisualStyleBackColor = true;
            // 
            // txtLinkRoot
            // 
            this.txtLinkRoot.Location = new System.Drawing.Point(31, 224);
            this.txtLinkRoot.Margin = new System.Windows.Forms.Padding(4);
            this.txtLinkRoot.Name = "txtLinkRoot";
            this.txtLinkRoot.Size = new System.Drawing.Size(399, 23);
            this.txtLinkRoot.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtLinkRoot, "This is the target files will be linked to. See ReadMe.txt for examples of how to" +
        " make links");
            // 
            // chkLinkFiles
            // 
            this.chkLinkFiles.AutoSize = true;
            this.chkLinkFiles.Location = new System.Drawing.Point(352, 199);
            this.chkLinkFiles.Margin = new System.Windows.Forms.Padding(4);
            this.chkLinkFiles.Name = "chkLinkFiles";
            this.chkLinkFiles.Size = new System.Drawing.Size(74, 21);
            this.chkLinkFiles.TabIndex = 5;
            this.chkLinkFiles.Text = "Enable";
            this.toolTip1.SetToolTip(this.chkLinkFiles, "Files can be linked so you can open them from within the html document");
            this.chkLinkFiles.UseVisualStyleBackColor = true;
            this.chkLinkFiles.CheckedChanged += new System.EventHandler(this.chkLinkFiles_CheckedChanged);
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(31, 76);
            this.chkHidden.Margin = new System.Windows.Forms.Padding(4);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(163, 21);
            this.chkHidden.TabIndex = 2;
            this.chkHidden.Text = "Exclude hidden items";
            this.toolTip1.SetToolTip(this.chkHidden, "This applies to both files and folders");
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Location = new System.Drawing.Point(31, 105);
            this.chkSystem.Margin = new System.Windows.Forms.Padding(4);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(164, 21);
            this.chkSystem.TabIndex = 3;
            this.chkSystem.Text = "Exclude system items";
            this.toolTip1.SetToolTip(this.chkSystem, "This applies to both files and folders");
            this.chkSystem.UseVisualStyleBackColor = true;
            // 
            // cmdCreate
            // 
            this.cmdCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreate.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreate.Image")));
            this.cmdCreate.Location = new System.Drawing.Point(213, 401);
            this.cmdCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(213, 49);
            this.cmdCreate.TabIndex = 7;
            this.cmdCreate.Text = " Create Snapshot";
            this.cmdCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(31, 44);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(353, 23);
            this.txtRoot.TabIndex = 0;
            // 
            // labelRootFolder
            // 
            this.labelRootFolder.Location = new System.Drawing.Point(27, 25);
            this.labelRootFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRootFolder.Name = "labelRootFolder";
            this.labelRootFolder.Size = new System.Drawing.Size(359, 16);
            this.labelRootFolder.TabIndex = 1;
            this.labelRootFolder.Text = "Root folder:";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.Image = ((System.Drawing.Image)(resources.GetObject("cmdBrowse.Image")));
            this.cmdBrowse.Location = new System.Drawing.Point(389, 38);
            this.cmdBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdBrowse.Size = new System.Drawing.Size(37, 34);
            this.cmdBrowse.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmdBrowse, "Browse for root folder");
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // tabCustomDesign
            // 
            this.tabCustomDesign.Controls.Add(this.linkLabel5);
            this.tabCustomDesign.Controls.Add(this.linkLabel4);
            this.tabCustomDesign.Controls.Add(this.label8);
            this.tabCustomDesign.Controls.Add(this.label7);
            this.tabCustomDesign.Controls.Add(this.pictureBox4);
            this.tabCustomDesign.Controls.Add(this.label4);
            this.tabCustomDesign.Location = new System.Drawing.Point(4, 25);
            this.tabCustomDesign.Margin = new System.Windows.Forms.Padding(4);
            this.tabCustomDesign.Name = "tabCustomDesign";
            this.tabCustomDesign.Padding = new System.Windows.Forms.Padding(4);
            this.tabCustomDesign.Size = new System.Drawing.Size(443, 492);
            this.tabCustomDesign.TabIndex = 2;
            this.tabCustomDesign.Text = "Custom Design";
            this.tabCustomDesign.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel5.Location = new System.Drawing.Point(23, 235);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(121, 16);
            this.linkLabel5.TabIndex = 7;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Open contact page";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel4.Location = new System.Drawing.Point(23, 138);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(188, 16);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Open template.html in notepad";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 41);
            this.label8.TabIndex = 8;
            this.label8.Text = "If you know some html/css you can modify the template yourself to better suit you" +
    "r needs:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "You are also welcome to contact RL Vision and they can help you for a small compe" +
    "nsation:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(240, 246);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 90);
            this.label4.TabIndex = 0;
            this.label4.Text = "Did you know that it is possible to change the appearance of the generated html f" +
    "ile? For example you might want to change the logo and colors to match your comp" +
    "any\'s.";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.gbPreferences);
            this.tabAbout.Controls.Add(this.linkLabelDonate);
            this.tabAbout.Controls.Add(this.linkLabelLaim);
            this.tabAbout.Controls.Add(this.lblLaimAbout);
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.linkLabel1);
            this.tabAbout.Controls.Add(this.labelAboutSoftware);
            this.tabAbout.Controls.Add(this.labelAboutVersion);
            this.tabAbout.Controls.Add(this.labelAboutTitle);
            this.tabAbout.Location = new System.Drawing.Point(4, 25);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4);
            this.tabAbout.Size = new System.Drawing.Size(443, 492);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // gbPreferences
            // 
            this.gbPreferences.Controls.Add(this.lblCheckForUpdatesNotice);
            this.gbPreferences.Controls.Add(this.cbCheckForUpdates);
            this.gbPreferences.Location = new System.Drawing.Point(27, 295);
            this.gbPreferences.Name = "gbPreferences";
            this.gbPreferences.Size = new System.Drawing.Size(394, 118);
            this.gbPreferences.TabIndex = 10;
            this.gbPreferences.TabStop = false;
            this.gbPreferences.Text = "Preferences";
            // 
            // lblCheckForUpdatesNotice
            // 
            this.lblCheckForUpdatesNotice.Location = new System.Drawing.Point(17, 53);
            this.lblCheckForUpdatesNotice.Name = "lblCheckForUpdatesNotice";
            this.lblCheckForUpdatesNotice.Size = new System.Drawing.Size(356, 56);
            this.lblCheckForUpdatesNotice.TabIndex = 1;
            this.lblCheckForUpdatesNotice.Text = "This will allow the application to automatically check for updates.  The updates " +
    "are NOT automatically downloaded.";
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AutoSize = true;
            this.cbCheckForUpdates.Location = new System.Drawing.Point(20, 30);
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.Size = new System.Drawing.Size(140, 20);
            this.cbCheckForUpdates.TabIndex = 0;
            this.cbCheckForUpdates.Text = "Check for Updates";
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            this.cbCheckForUpdates.CheckedChanged += new System.EventHandler(this.cbCheckForUpdates_CheckedChanged);
            // 
            // linkLabelDonate
            // 
            this.linkLabelDonate.AutoSize = true;
            this.linkLabelDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelDonate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelDonate.Location = new System.Drawing.Point(219, 126);
            this.linkLabelDonate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelDonate.Name = "linkLabelDonate";
            this.linkLabelDonate.Size = new System.Drawing.Size(125, 16);
            this.linkLabelDonate.TabIndex = 9;
            this.linkLabelDonate.TabStop = true;
            this.linkLabelDonate.Text = "Donate to RL Vision";
            this.linkLabelDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDonate_LinkClicked);
            // 
            // linkLabelLaim
            // 
            this.linkLabelLaim.AutoSize = true;
            this.linkLabelLaim.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelLaim.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelLaim.Location = new System.Drawing.Point(219, 169);
            this.linkLabelLaim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLaim.Name = "linkLabelLaim";
            this.linkLabelLaim.Size = new System.Drawing.Size(166, 16);
            this.linkLabelLaim.TabIndex = 8;
            this.linkLabelLaim.TabStop = true;
            this.linkLabelLaim.Text = "Snap2HTML-NG on Github";
            this.linkLabelLaim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLaim_LinkClicked);
            // 
            // lblLaimAbout
            // 
            this.lblLaimAbout.AutoSize = true;
            this.lblLaimAbout.Location = new System.Drawing.Point(219, 153);
            this.lblLaimAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaimAbout.Name = "lblLaimAbout";
            this.lblLaimAbout.Size = new System.Drawing.Size(157, 16);
            this.lblLaimAbout.TabIndex = 7;
            this.lblLaimAbout.Text = "Snap2HTML-NG by Laim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(219, 106);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.rlvision.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelAboutSoftware
            // 
            this.labelAboutSoftware.AutoSize = true;
            this.labelAboutSoftware.Location = new System.Drawing.Point(219, 90);
            this.labelAboutSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutSoftware.Name = "labelAboutSoftware";
            this.labelAboutSoftware.Size = new System.Drawing.Size(161, 16);
            this.labelAboutSoftware.TabIndex = 2;
            this.labelAboutSoftware.Text = "Snap2HTML by RL Vision";
            // 
            // labelAboutVersion
            // 
            this.labelAboutVersion.AutoSize = true;
            this.labelAboutVersion.Location = new System.Drawing.Point(208, 55);
            this.labelAboutVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutVersion.Name = "labelAboutVersion";
            this.labelAboutVersion.Size = new System.Drawing.Size(51, 16);
            this.labelAboutVersion.TabIndex = 1;
            this.labelAboutVersion.Text = "version";
            // 
            // labelAboutTitle
            // 
            this.labelAboutTitle.AutoSize = true;
            this.labelAboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutTitle.Location = new System.Drawing.Point(205, 25);
            this.labelAboutTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutTitle.Name = "labelAboutTitle";
            this.labelAboutTitle.Size = new System.Drawing.Size(216, 31);
            this.labelAboutTitle.TabIndex = 0;
            this.labelAboutTitle.Text = "Snap2HTML-NG";
            // 
            // fbdScanDirectory
            // 
            this.fbdScanDirectory.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdScanDirectory.ShowNewFolderButton = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.Text = "Ready";
            // 
            // frmMain
            // 
            this.AcceptButton = this.cmdCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabCtrl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snap2HTML-NG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.tabCtrl.ResumeLayout(false);
            this.tabSnapshot.ResumeLayout(false);
            this.tabSnapshot.PerformLayout();
            this.tabCustomDesign.ResumeLayout(false);
            this.tabCustomDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.gbPreferences.ResumeLayout(false);
            this.gbPreferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabSnapshot;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label labelRootFolder;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.FolderBrowserDialog fbdScanDirectory;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label labelAboutSoftware;
		private System.Windows.Forms.Label labelAboutVersion;
		private System.Windows.Forms.Label labelAboutTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOpenOutput;
        private System.Windows.Forms.TextBox txtLinkRoot;
        private System.Windows.Forms.CheckBox chkLinkFiles;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkSystem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TabPage tabCustomDesign;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelLaim;
        private System.Windows.Forms.Label lblLaimAbout;
        private System.Windows.Forms.TextBox txtSearchPattern;
        private System.Windows.Forms.Label lblSearchPattern;
        private System.Windows.Forms.LinkLabel linkLabelDonate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox gbPreferences;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private System.Windows.Forms.Label lblCheckForUpdatesNotice;
        private System.Windows.Forms.CheckBox cbDirectoriesOnly;
        private System.Windows.Forms.Label lblFileDate;
        private System.Windows.Forms.CheckBox chkFileDateEnable;
        private System.Windows.Forms.DateTimePicker dateTimePickerFileDate;
        private System.Windows.Forms.Button btnFileDateConfigure;
    }
}

