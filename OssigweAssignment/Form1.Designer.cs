namespace SEGroup5
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.pnlCount = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblView = new System.Windows.Forms.Label();
            this.pnlFoundFiles = new System.Windows.Forms.Panel();
            this.lblFoundFiles = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.progressBarMonitored = new System.Windows.Forms.ProgressBar();
            this.tvMonitored = new System.Windows.Forms.TreeView();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblMonitored = new System.Windows.Forms.Label();
            this.tbSearchView = new System.Windows.Forms.TabPage();
            this.pnlSummary2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLSWord1 = new System.Windows.Forms.Label();
            this.lblShortestIndexedWord1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSearchedWord1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblShortestIndexedWord = new System.Windows.Forms.Label();
            this.lblLSWord = new System.Windows.Forms.Label();
            this.lblSearchedWord = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.textReader = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabSearchHistory = new System.Windows.Forms.TabPage();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblTotalIndexedWords3 = new System.Windows.Forms.Label();
            this.lblTotalIndexedWords2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblShortestIndexedWord3 = new System.Windows.Forms.Label();
            this.lblMosttIndexedWord3 = new System.Windows.Forms.Label();
            this.lblMosttIndexedWord2 = new System.Windows.Forms.Label();
            this.lblShortestIndexedWord2 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblSummary2 = new System.Windows.Forms.Label();
            this.lblTop25SearchedWords = new System.Windows.Forms.Label();
            this.lbTopSearchView = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlHTMLContents = new System.Windows.Forms.Panel();
            this.btnExtractTags = new System.Windows.Forms.Button();
            this.lblURLSearch = new System.Windows.Forms.Label();
            this.txtURLSearch = new System.Windows.Forms.TextBox();
            this.lbAnchorView = new System.Windows.Forms.ListBox();
            this.lbScriptView = new System.Windows.Forms.ListBox();
            this.lbTitleView = new System.Windows.Forms.ListBox();
            this.lblScriptTags = new System.Windows.Forms.Label();
            this.lblAnchorTags = new System.Windows.Forms.Label();
            this.lblTitleTags = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbSearch.SuspendLayout();
            this.pnlCount.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlFoundFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tbSearchView.SuspendLayout();
            this.pnlSummary2.SuspendLayout();
            this.tabSearchHistory.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlHTMLContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 614);
            this.panel1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tbSearch);
            this.tabControl2.Controls.Add(this.tbSearchView);
            this.tabControl2.Controls.Add(this.tabSearchHistory);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1155, 614);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl2.TabIndex = 3;
            this.tabControl2.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSearch.Controls.Add(this.pnlCount);
            this.tbSearch.Controls.Add(this.pnlView);
            this.tbSearch.Controls.Add(this.pnlFoundFiles);
            this.tbSearch.Controls.Add(this.panel2);
            this.tbSearch.Controls.Add(this.panel5);
            this.tbSearch.Location = new System.Drawing.Point(4, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.Size = new System.Drawing.Size(1147, 585);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search";
            // 
            // pnlCount
            // 
            this.pnlCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCount.Controls.Add(this.lblCount);
            this.pnlCount.Location = new System.Drawing.Point(976, 50);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Size = new System.Drawing.Size(84, 517);
            this.pnlCount.TabIndex = 6;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(-1, -1);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(86, 34);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlView
            // 
            this.pnlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Controls.Add(this.lblView);
            this.pnlView.Location = new System.Drawing.Point(1058, 50);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(86, 517);
            this.pnlView.TabIndex = 4;
            // 
            // lblView
            // 
            this.lblView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(-1, 0);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(86, 33);
            this.lblView.TabIndex = 1;
            // 
            // pnlFoundFiles
            // 
            this.pnlFoundFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoundFiles.Controls.Add(this.lblFoundFiles);
            this.pnlFoundFiles.Location = new System.Drawing.Point(234, 50);
            this.pnlFoundFiles.Name = "pnlFoundFiles";
            this.pnlFoundFiles.Size = new System.Drawing.Size(742, 517);
            this.pnlFoundFiles.TabIndex = 5;
            // 
            // lblFoundFiles
            // 
            this.lblFoundFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoundFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoundFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundFiles.Location = new System.Drawing.Point(0, 0);
            this.lblFoundFiles.Name = "lblFoundFiles";
            this.lblFoundFiles.Size = new System.Drawing.Size(740, 33);
            this.lblFoundFiles.TabIndex = 0;
            this.lblFoundFiles.Text = "Found Files";
            this.lblFoundFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.OpenFile);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(228, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 41);
            this.panel2.TabIndex = 2;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(716, 2);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(163, 33);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.Text = "Add Folder To Monitor";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(559, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(31, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(131, 30);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtSearch.Location = new System.Drawing.Point(168, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(373, 33);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnRemoveNode);
            this.panel5.Controls.Add(this.progressBarMonitored);
            this.panel5.Controls.Add(this.tvMonitored);
            this.panel5.Controls.Add(this.panel18);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 579);
            this.panel5.TabIndex = 3;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNode.Location = new System.Drawing.Point(-1, 507);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(221, 36);
            this.btnRemoveNode.TabIndex = 4;
            this.btnRemoveNode.Text = "Remove Node";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBarMonitored
            // 
            this.progressBarMonitored.Location = new System.Drawing.Point(-4, 549);
            this.progressBarMonitored.Name = "progressBarMonitored";
            this.progressBarMonitored.Size = new System.Drawing.Size(228, 23);
            this.progressBarMonitored.TabIndex = 3;
            // 
            // tvMonitored
            // 
            this.tvMonitored.CheckBoxes = true;
            this.tvMonitored.Location = new System.Drawing.Point(-4, 41);
            this.tvMonitored.Name = "tvMonitored";
            this.tvMonitored.Scrollable = false;
            this.tvMonitored.Size = new System.Drawing.Size(229, 534);
            this.tvMonitored.TabIndex = 2;
            this.tvMonitored.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tvMonitored.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.lblMonitored);
            this.panel18.Location = new System.Drawing.Point(-1, -1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(225, 41);
            this.panel18.TabIndex = 1;
            // 
            // lblMonitored
            // 
            this.lblMonitored.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitored.Location = new System.Drawing.Point(0, 0);
            this.lblMonitored.Name = "lblMonitored";
            this.lblMonitored.Size = new System.Drawing.Size(211, 35);
            this.lblMonitored.TabIndex = 2;
            this.lblMonitored.Text = "Monitored Folders and Text Files";
            this.lblMonitored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSearchView
            // 
            this.tbSearchView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSearchView.Controls.Add(this.pnlSummary2);
            this.tbSearchView.Controls.Add(this.textReader);
            this.tbSearchView.Controls.Add(this.panel7);
            this.tbSearchView.Location = new System.Drawing.Point(4, 25);
            this.tbSearchView.Name = "tbSearchView";
            this.tbSearchView.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearchView.Size = new System.Drawing.Size(1147, 585);
            this.tbSearchView.TabIndex = 1;
            this.tbSearchView.Text = "View Search";
            // 
            // pnlSummary2
            // 
            this.pnlSummary2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary2.Controls.Add(this.label12);
            this.pnlSummary2.Controls.Add(this.label5);
            this.pnlSummary2.Controls.Add(this.lblLSWord1);
            this.pnlSummary2.Controls.Add(this.lblShortestIndexedWord1);
            this.pnlSummary2.Controls.Add(this.label14);
            this.pnlSummary2.Controls.Add(this.lblSearchedWord1);
            this.pnlSummary2.Controls.Add(this.label11);
            this.pnlSummary2.Controls.Add(this.lblShortestIndexedWord);
            this.pnlSummary2.Controls.Add(this.lblLSWord);
            this.pnlSummary2.Controls.Add(this.lblSearchedWord);
            this.pnlSummary2.Controls.Add(this.lblSummary);
            this.pnlSummary2.Location = new System.Drawing.Point(3, 6);
            this.pnlSummary2.Name = "pnlSummary2";
            this.pnlSummary2.Size = new System.Drawing.Size(282, 576);
            this.pnlSummary2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(183, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 12;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total indexed word:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLSWord1
            // 
            this.lblLSWord1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLSWord1.Location = new System.Drawing.Point(183, 65);
            this.lblLSWord1.Name = "lblLSWord1";
            this.lblLSWord1.Size = new System.Drawing.Size(94, 19);
            this.lblLSWord1.TabIndex = 10;
            this.lblLSWord1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShortestIndexedWord1
            // 
            this.lblShortestIndexedWord1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShortestIndexedWord1.Location = new System.Drawing.Point(183, 94);
            this.lblShortestIndexedWord1.Name = "lblShortestIndexedWord1";
            this.lblShortestIndexedWord1.Size = new System.Drawing.Size(94, 19);
            this.lblShortestIndexedWord1.TabIndex = 9;
            this.lblShortestIndexedWord1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(180, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 19);
            this.label14.TabIndex = 8;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSearchedWord1
            // 
            this.lblSearchedWord1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchedWord1.Location = new System.Drawing.Point(183, 43);
            this.lblSearchedWord1.Name = "lblSearchedWord1";
            this.lblSearchedWord1.Size = new System.Drawing.Size(94, 19);
            this.lblSearchedWord1.TabIndex = 7;
            this.lblSearchedWord1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Most Frequent Word Indexed:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblShortestIndexedWord
            // 
            this.lblShortestIndexedWord.AutoSize = true;
            this.lblShortestIndexedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestIndexedWord.Location = new System.Drawing.Point(4, 100);
            this.lblShortestIndexedWord.Name = "lblShortestIndexedWord";
            this.lblShortestIndexedWord.Size = new System.Drawing.Size(141, 13);
            this.lblShortestIndexedWord.TabIndex = 4;
            this.lblShortestIndexedWord.Text = "Shortest Word Indexed:";
            this.lblShortestIndexedWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLSWord
            // 
            this.lblLSWord.AutoSize = true;
            this.lblLSWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLSWord.Location = new System.Drawing.Point(4, 72);
            this.lblLSWord.Name = "lblLSWord";
            this.lblLSWord.Size = new System.Drawing.Size(139, 13);
            this.lblLSWord.TabIndex = 3;
            this.lblLSWord.Text = "Longest Word Indexed:";
            this.lblLSWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSearchedWord
            // 
            this.lblSearchedWord.AutoSize = true;
            this.lblSearchedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedWord.Location = new System.Drawing.Point(4, 43);
            this.lblSearchedWord.Name = "lblSearchedWord";
            this.lblSearchedWord.Size = new System.Drawing.Size(99, 13);
            this.lblSearchedWord.TabIndex = 1;
            this.lblSearchedWord.Text = "Searched Word:";
            this.lblSearchedWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSummary
            // 
            this.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(-4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(293, 23);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Summary";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textReader
            // 
            this.textReader.AutoWordSelection = true;
            this.textReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textReader.Location = new System.Drawing.Point(291, 6);
            this.textReader.Name = "textReader";
            this.textReader.Size = new System.Drawing.Size(850, 567);
            this.textReader.TabIndex = 4;
            this.textReader.Text = "";
            this.textReader.TextChanged += new System.EventHandler(this.textReader_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(376, 208);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 7;
            // 
            // tabSearchHistory
            // 
            this.tabSearchHistory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabSearchHistory.Controls.Add(this.pnlSummary);
            this.tabSearchHistory.Controls.Add(this.lblTop25SearchedWords);
            this.tabSearchHistory.Controls.Add(this.lbTopSearchView);
            this.tabSearchHistory.Location = new System.Drawing.Point(4, 25);
            this.tabSearchHistory.Name = "tabSearchHistory";
            this.tabSearchHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchHistory.Size = new System.Drawing.Size(1147, 585);
            this.tabSearchHistory.TabIndex = 2;
            this.tabSearchHistory.Text = "Search History";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblTotalIndexedWords3);
            this.pnlSummary.Controls.Add(this.lblTotalIndexedWords2);
            this.pnlSummary.Controls.Add(this.label20);
            this.pnlSummary.Controls.Add(this.lblShortestIndexedWord3);
            this.pnlSummary.Controls.Add(this.lblMosttIndexedWord3);
            this.pnlSummary.Controls.Add(this.lblMosttIndexedWord2);
            this.pnlSummary.Controls.Add(this.lblShortestIndexedWord2);
            this.pnlSummary.Controls.Add(this.label26);
            this.pnlSummary.Controls.Add(this.lblSummary2);
            this.pnlSummary.Location = new System.Drawing.Point(8, 11);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(352, 571);
            this.pnlSummary.TabIndex = 9;
            // 
            // lblTotalIndexedWords3
            // 
            this.lblTotalIndexedWords3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIndexedWords3.Location = new System.Drawing.Point(179, 165);
            this.lblTotalIndexedWords3.Name = "lblTotalIndexedWords3";
            this.lblTotalIndexedWords3.Size = new System.Drawing.Size(152, 18);
            this.lblTotalIndexedWords3.TabIndex = 12;
            this.lblTotalIndexedWords3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalIndexedWords2
            // 
            this.lblTotalIndexedWords2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIndexedWords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIndexedWords2.Location = new System.Drawing.Point(3, 162);
            this.lblTotalIndexedWords2.Name = "lblTotalIndexedWords2";
            this.lblTotalIndexedWords2.Size = new System.Drawing.Size(134, 18);
            this.lblTotalIndexedWords2.TabIndex = 11;
            this.lblTotalIndexedWords2.Text = "Total Indexed Word:";
            this.lblTotalIndexedWords2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Location = new System.Drawing.Point(176, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 18);
            this.label20.TabIndex = 10;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShortestIndexedWord3
            // 
            this.lblShortestIndexedWord3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShortestIndexedWord3.Location = new System.Drawing.Point(179, 94);
            this.lblShortestIndexedWord3.Name = "lblShortestIndexedWord3";
            this.lblShortestIndexedWord3.Size = new System.Drawing.Size(167, 18);
            this.lblShortestIndexedWord3.TabIndex = 9;
            this.lblShortestIndexedWord3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMosttIndexedWord3
            // 
            this.lblMosttIndexedWord3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMosttIndexedWord3.Location = new System.Drawing.Point(179, 134);
            this.lblMosttIndexedWord3.Name = "lblMosttIndexedWord3";
            this.lblMosttIndexedWord3.Size = new System.Drawing.Size(152, 18);
            this.lblMosttIndexedWord3.TabIndex = 8;
            this.lblMosttIndexedWord3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMosttIndexedWord2
            // 
            this.lblMosttIndexedWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosttIndexedWord2.Location = new System.Drawing.Point(3, 130);
            this.lblMosttIndexedWord2.Name = "lblMosttIndexedWord2";
            this.lblMosttIndexedWord2.Size = new System.Drawing.Size(134, 18);
            this.lblMosttIndexedWord2.TabIndex = 5;
            this.lblMosttIndexedWord2.Text = "Most Indexed Word:";
            this.lblMosttIndexedWord2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShortestIndexedWord2
            // 
            this.lblShortestIndexedWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestIndexedWord2.Location = new System.Drawing.Point(3, 90);
            this.lblShortestIndexedWord2.Name = "lblShortestIndexedWord2";
            this.lblShortestIndexedWord2.Size = new System.Drawing.Size(156, 18);
            this.lblShortestIndexedWord2.TabIndex = 4;
            this.lblShortestIndexedWord2.Text = "Shortest Indexed Word:";
            this.lblShortestIndexedWord2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(156, 18);
            this.label26.TabIndex = 3;
            this.label26.Text = "Longest Indexed Word:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSummary2
            // 
            this.lblSummary2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary2.Location = new System.Drawing.Point(-4, 0);
            this.lblSummary2.Name = "lblSummary2";
            this.lblSummary2.Size = new System.Drawing.Size(351, 23);
            this.lblSummary2.TabIndex = 0;
            this.lblSummary2.Text = "Summary";
            this.lblSummary2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTop25SearchedWords
            // 
            this.lblTop25SearchedWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTop25SearchedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop25SearchedWords.Location = new System.Drawing.Point(783, 7);
            this.lblTop25SearchedWords.Name = "lblTop25SearchedWords";
            this.lblTop25SearchedWords.Size = new System.Drawing.Size(358, 40);
            this.lblTop25SearchedWords.TabIndex = 8;
            this.lblTop25SearchedWords.Text = "Top 25 Searched Words";
            this.lblTop25SearchedWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTopSearchView
            // 
            this.lbTopSearchView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTopSearchView.BackColor = System.Drawing.SystemColors.Window;
            this.lbTopSearchView.FormattingEnabled = true;
            this.lbTopSearchView.Location = new System.Drawing.Point(783, 50);
            this.lbTopSearchView.Name = "lbTopSearchView";
            this.lbTopSearchView.Size = new System.Drawing.Size(361, 537);
            this.lbTopSearchView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.pnlHTMLContents);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 585);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Search Html Content";
            // 
            // pnlHTMLContents
            // 
            this.pnlHTMLContents.Controls.Add(this.btnExtractTags);
            this.pnlHTMLContents.Controls.Add(this.lblURLSearch);
            this.pnlHTMLContents.Controls.Add(this.txtURLSearch);
            this.pnlHTMLContents.Controls.Add(this.lbAnchorView);
            this.pnlHTMLContents.Controls.Add(this.lbScriptView);
            this.pnlHTMLContents.Controls.Add(this.lbTitleView);
            this.pnlHTMLContents.Controls.Add(this.lblScriptTags);
            this.pnlHTMLContents.Controls.Add(this.lblAnchorTags);
            this.pnlHTMLContents.Controls.Add(this.lblTitleTags);
            this.pnlHTMLContents.Location = new System.Drawing.Point(8, 6);
            this.pnlHTMLContents.Name = "pnlHTMLContents";
            this.pnlHTMLContents.Size = new System.Drawing.Size(1125, 571);
            this.pnlHTMLContents.TabIndex = 0;
            // 
            // btnExtractTags
            // 
            this.btnExtractTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractTags.Location = new System.Drawing.Point(874, 12);
            this.btnExtractTags.Name = "btnExtractTags";
            this.btnExtractTags.Size = new System.Drawing.Size(190, 23);
            this.btnExtractTags.TabIndex = 8;
            this.btnExtractTags.Text = "Extract Tags";
            this.btnExtractTags.UseVisualStyleBackColor = true;
            this.btnExtractTags.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblURLSearch
            // 
            this.lblURLSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblURLSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLSearch.Location = new System.Drawing.Point(50, 12);
            this.lblURLSearch.Name = "lblURLSearch";
            this.lblURLSearch.Size = new System.Drawing.Size(210, 23);
            this.lblURLSearch.TabIndex = 7;
            this.lblURLSearch.Text = "Enter Url To Html page";
            this.lblURLSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtURLSearch
            // 
            this.txtURLSearch.Location = new System.Drawing.Point(283, 12);
            this.txtURLSearch.Multiline = true;
            this.txtURLSearch.Name = "txtURLSearch";
            this.txtURLSearch.Size = new System.Drawing.Size(540, 23);
            this.txtURLSearch.TabIndex = 6;
            // 
            // lbAnchorView
            // 
            this.lbAnchorView.FormattingEnabled = true;
            this.lbAnchorView.Location = new System.Drawing.Point(50, 338);
            this.lbAnchorView.Name = "lbAnchorView";
            this.lbAnchorView.Size = new System.Drawing.Size(710, 212);
            this.lbAnchorView.TabIndex = 5;
            // 
            // lbScriptView
            // 
            this.lbScriptView.FormattingEnabled = true;
            this.lbScriptView.Location = new System.Drawing.Point(50, 71);
            this.lbScriptView.Name = "lbScriptView";
            this.lbScriptView.Size = new System.Drawing.Size(710, 212);
            this.lbScriptView.TabIndex = 4;
            // 
            // lbTitleView
            // 
            this.lbTitleView.FormattingEnabled = true;
            this.lbTitleView.Location = new System.Drawing.Point(800, 71);
            this.lbTitleView.Name = "lbTitleView";
            this.lbTitleView.Size = new System.Drawing.Size(322, 472);
            this.lbTitleView.TabIndex = 3;
            // 
            // lblScriptTags
            // 
            this.lblScriptTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScriptTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScriptTags.Location = new System.Drawing.Point(50, 45);
            this.lblScriptTags.Name = "lblScriptTags";
            this.lblScriptTags.Size = new System.Drawing.Size(322, 23);
            this.lblScriptTags.TabIndex = 2;
            this.lblScriptTags.Text = "Script Tag(s)";
            this.lblScriptTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnchorTags
            // 
            this.lblAnchorTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnchorTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnchorTags.Location = new System.Drawing.Point(50, 296);
            this.lblAnchorTags.Name = "lblAnchorTags";
            this.lblAnchorTags.Size = new System.Drawing.Size(322, 23);
            this.lblAnchorTags.TabIndex = 1;
            this.lblAnchorTags.Text = "Anchor Tag(s)";
            this.lblAnchorTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleTags
            // 
            this.lblTitleTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTags.Location = new System.Drawing.Point(800, 45);
            this.lblTitleTags.Name = "lblTitleTags";
            this.lblTitleTags.Size = new System.Drawing.Size(322, 23);
            this.lblTitleTags.TabIndex = 0;
            this.lblTitleTags.Text = "Title Tag";
            this.lblTitleTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 614);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbSearch.ResumeLayout(false);
            this.pnlCount.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlFoundFiles.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.tbSearchView.ResumeLayout(false);
            this.pnlSummary2.ResumeLayout(false);
            this.pnlSummary2.PerformLayout();
            this.tabSearchHistory.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlHTMLContents.ResumeLayout(false);
            this.pnlHTMLContents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.Panel pnlCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Panel pnlFoundFiles;
        private System.Windows.Forms.Label lblFoundFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar progressBarMonitored;
        private System.Windows.Forms.TreeView tvMonitored;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblMonitored;
        private System.Windows.Forms.TabPage tbSearchView;
        private System.Windows.Forms.Panel pnlSummary2;
        private System.Windows.Forms.Label lblLSWord1;
        private System.Windows.Forms.Label lblShortestIndexedWord1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSearchedWord1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblShortestIndexedWord;
        private System.Windows.Forms.Label lblLSWord;
        private System.Windows.Forms.Label lblSearchedWord;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.RichTextBox textReader;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.TabPage tabSearchHistory;
        private System.Windows.Forms.ListBox lbTopSearchView;
        private System.Windows.Forms.Label lblTop25SearchedWords;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTotalIndexedWords3;
        private System.Windows.Forms.Label lblTotalIndexedWords2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblShortestIndexedWord3;
        private System.Windows.Forms.Label lblMosttIndexedWord3;
        private System.Windows.Forms.Label lblMosttIndexedWord2;
        private System.Windows.Forms.Label lblShortestIndexedWord2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblSummary2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlHTMLContents;
        private System.Windows.Forms.Label lblScriptTags;
        private System.Windows.Forms.Label lblAnchorTags;
        private System.Windows.Forms.Label lblTitleTags;
        private System.Windows.Forms.Button btnExtractTags;
        private System.Windows.Forms.Label lblURLSearch;
        private System.Windows.Forms.TextBox txtURLSearch;
        private System.Windows.Forms.ListBox lbAnchorView;
        private System.Windows.Forms.ListBox lbScriptView;
        private System.Windows.Forms.ListBox lbTitleView;
    }
}

