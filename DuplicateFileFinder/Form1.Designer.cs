using System.Windows.Forms;

namespace DuplicateFileFinder
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblSourceDir = new System.Windows.Forms.Label();
			this.btnBrowse_TopmostDir = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnAllImages = new System.Windows.Forms.Button();
			this.lblFileExtensions = new System.Windows.Forms.Label();
			this.tbSourceDir = new System.Windows.Forms.TextBox();
			this.tbFileExtensions = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.radCompareContents = new System.Windows.Forms.RadioButton();
			this.radCompareFilenames = new System.Windows.Forms.RadioButton();
			this.btnCopyAll = new System.Windows.Forms.Button();
			this.btnCopyUnique = new System.Windows.Forms.Button();
			this.btnExportAll = new System.Windows.Forms.Button();
			this.btnExportUnique = new System.Windows.Forms.Button();
			this.btnFindFiles = new System.Windows.Forms.Button();
			this.btnClearFoundFiles = new System.Windows.Forms.Button();
			this.btnBrowse_DestDir = new System.Windows.Forms.Button();
			this.cbSearchSubDirs = new System.Windows.Forms.CheckBox();
			this.btnOpenDestDir = new System.Windows.Forms.Button();
			this.btnOpenSourceDir = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dgvFoundFiles = new System.Windows.Forms.DataGridView();
			this.imageContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.lblDestDir = new System.Windows.Forms.Label();
			this.tbDestDir = new System.Windows.Forms.TextBox();
			this.lblTotalFilesFound = new System.Windows.Forms.Label();
			this.tbTotalFilesFound = new System.Windows.Forms.TextBox();
			this.lblUniqueFilesFound = new System.Windows.Forms.Label();
			this.tbUniqueFilesFound = new System.Windows.Forms.TextBox();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSourceDir
			// 
			this.lblSourceDir.AutoSize = true;
			this.lblSourceDir.Location = new System.Drawing.Point(10, 13);
			this.lblSourceDir.Name = "lblSourceDir";
			this.lblSourceDir.Size = new System.Drawing.Size(86, 13);
			this.lblSourceDir.TabIndex = 1;
			this.lblSourceDir.Text = "Source Directory";
			// 
			// btnBrowse_TopmostDir
			// 
			this.btnBrowse_TopmostDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse_TopmostDir.Location = new System.Drawing.Point(354, 8);
			this.btnBrowse_TopmostDir.Name = "btnBrowse_TopmostDir";
			this.btnBrowse_TopmostDir.Size = new System.Drawing.Size(64, 23);
			this.btnBrowse_TopmostDir.TabIndex = 2;
			this.btnBrowse_TopmostDir.Text = "Browse";
			this.toolTip1.SetToolTip(this.btnBrowse_TopmostDir, "Browser for a source directory");
			this.btnBrowse_TopmostDir.UseVisualStyleBackColor = true;
			this.btnBrowse_TopmostDir.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnAllImages
			// 
			this.btnAllImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAllImages.Location = new System.Drawing.Point(565, 34);
			this.btnAllImages.Name = "btnAllImages";
			this.btnAllImages.Size = new System.Drawing.Size(64, 23);
			this.btnAllImages.TabIndex = 3;
			this.btnAllImages.Text = "All Images";
			this.btnAllImages.UseVisualStyleBackColor = true;
			this.btnAllImages.Click += new System.EventHandler(this.btnAllImages_Click);
			// 
			// lblFileExtensions
			// 
			this.lblFileExtensions.AutoSize = true;
			this.lblFileExtensions.Location = new System.Drawing.Point(10, 39);
			this.lblFileExtensions.Name = "lblFileExtensions";
			this.lblFileExtensions.Size = new System.Drawing.Size(170, 13);
			this.lblFileExtensions.TabIndex = 4;
			this.lblFileExtensions.Text = "File Extensions (comma separated)";
			this.toolTip1.SetToolTip(this.lblFileExtensions, "Not case sensitive.  Do not need to include a decimal place");
			// 
			// tbSourceDir
			// 
			this.tbSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSourceDir.Location = new System.Drawing.Point(102, 10);
			this.tbSourceDir.Name = "tbSourceDir";
			this.tbSourceDir.ReadOnly = true;
			this.tbSourceDir.Size = new System.Drawing.Size(246, 20);
			this.tbSourceDir.TabIndex = 0;
			this.tbSourceDir.Text = ".\\..\\..\\..\\..\\source";
			// 
			// tbFileExtensions
			// 
			this.tbFileExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFileExtensions.Location = new System.Drawing.Point(186, 36);
			this.tbFileExtensions.Name = "tbFileExtensions";
			this.tbFileExtensions.Size = new System.Drawing.Size(373, 20);
			this.tbFileExtensions.TabIndex = 5;
			this.tbFileExtensions.Text = "jpg, png, bmp, tiff";
			this.toolTip1.SetToolTip(this.tbFileExtensions, "Not case sensitive.  Do not need to include a decimal place");
			// 
			// radCompareContents
			// 
			this.radCompareContents.AutoSize = true;
			this.radCompareContents.Location = new System.Drawing.Point(227, 91);
			this.radCompareContents.Name = "radCompareContents";
			this.radCompareContents.Size = new System.Drawing.Size(131, 17);
			this.radCompareContents.TabIndex = 23;
			this.radCompareContents.Text = "Compare File Contents";
			this.toolTip1.SetToolTip(this.radCompareContents, "Slow and Smart");
			this.radCompareContents.UseVisualStyleBackColor = true;
			// 
			// radCompareFilenames
			// 
			this.radCompareFilenames.AutoSize = true;
			this.radCompareFilenames.Checked = true;
			this.radCompareFilenames.Location = new System.Drawing.Point(104, 91);
			this.radCompareFilenames.Name = "radCompareFilenames";
			this.radCompareFilenames.Size = new System.Drawing.Size(117, 17);
			this.radCompareFilenames.TabIndex = 22;
			this.radCompareFilenames.TabStop = true;
			this.radCompareFilenames.Text = "Compare Filenames";
			this.toolTip1.SetToolTip(this.radCompareFilenames, "Fast and Dumb");
			this.radCompareFilenames.UseVisualStyleBackColor = true;
			// 
			// btnCopyAll
			// 
			this.btnCopyAll.Location = new System.Drawing.Point(130, 202);
			this.btnCopyAll.Name = "btnCopyAll";
			this.btnCopyAll.Size = new System.Drawing.Size(71, 23);
			this.btnCopyAll.TabIndex = 21;
			this.btnCopyAll.Text = "Copy All";
			this.toolTip1.SetToolTip(this.btnCopyAll, "Copy all discovered files to the destination directory entered above");
			this.btnCopyAll.UseVisualStyleBackColor = true;
			this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
			// 
			// btnCopyUnique
			// 
			this.btnCopyUnique.Location = new System.Drawing.Point(10, 202);
			this.btnCopyUnique.Name = "btnCopyUnique";
			this.btnCopyUnique.Size = new System.Drawing.Size(114, 23);
			this.btnCopyUnique.TabIndex = 12;
			this.btnCopyUnique.Text = "Copy Only Unique";
			this.toolTip1.SetToolTip(this.btnCopyUnique, "Copy only one unique copy of each photo to the destination directory entered abov" +
        "e");
			this.btnCopyUnique.UseVisualStyleBackColor = true;
			this.btnCopyUnique.Click += new System.EventHandler(this.btnCopyUnique_Click);
			// 
			// btnExportAll
			// 
			this.btnExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportAll.Location = new System.Drawing.Point(273, 202);
			this.btnExportAll.Name = "btnExportAll";
			this.btnExportAll.Size = new System.Drawing.Size(158, 23);
			this.btnExportAll.TabIndex = 26;
			this.btnExportAll.Text = "Export All Filenames to txt";
			this.toolTip1.SetToolTip(this.btnExportAll, "Create a text document containing all discovered file paths (including duplicates" +
        ")");
			this.btnExportAll.UseVisualStyleBackColor = true;
			this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
			// 
			// btnExportUnique
			// 
			this.btnExportUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportUnique.Location = new System.Drawing.Point(437, 202);
			this.btnExportUnique.Name = "btnExportUnique";
			this.btnExportUnique.Size = new System.Drawing.Size(192, 23);
			this.btnExportUnique.TabIndex = 27;
			this.btnExportUnique.Text = "Export only unique filenames to txt";
			this.toolTip1.SetToolTip(this.btnExportUnique, "Create a text document containing containing only unique filepaths");
			this.btnExportUnique.UseVisualStyleBackColor = true;
			this.btnExportUnique.Click += new System.EventHandler(this.btnExportUnique_Click);
			// 
			// btnFindFiles
			// 
			this.btnFindFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnFindFiles.Location = new System.Drawing.Point(10, 88);
			this.btnFindFiles.Name = "btnFindFiles";
			this.btnFindFiles.Size = new System.Drawing.Size(88, 23);
			this.btnFindFiles.TabIndex = 6;
			this.btnFindFiles.Text = "Find all files";
			this.toolTip1.SetToolTip(this.btnFindFiles, "Search the source directory entered above (and sub-directories if specified) for " +
        "files with the given extensions, and compare the discovered files to mark duplic" +
        "ates");
			this.btnFindFiles.UseVisualStyleBackColor = true;
			this.btnFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
			// 
			// btnClearFoundFiles
			// 
			this.btnClearFoundFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearFoundFiles.Location = new System.Drawing.Point(558, 173);
			this.btnClearFoundFiles.Name = "btnClearFoundFiles";
			this.btnClearFoundFiles.Size = new System.Drawing.Size(71, 23);
			this.btnClearFoundFiles.TabIndex = 11;
			this.btnClearFoundFiles.Text = "Clear";
			this.toolTip1.SetToolTip(this.btnClearFoundFiles, "Clear file list and image previews");
			this.btnClearFoundFiles.UseVisualStyleBackColor = true;
			this.btnClearFoundFiles.Click += new System.EventHandler(this.btnClearFoundFiles_Click);
			// 
			// btnBrowse_DestDir
			// 
			this.btnBrowse_DestDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse_DestDir.Location = new System.Drawing.Point(495, 60);
			this.btnBrowse_DestDir.Name = "btnBrowse_DestDir";
			this.btnBrowse_DestDir.Size = new System.Drawing.Size(64, 23);
			this.btnBrowse_DestDir.TabIndex = 15;
			this.btnBrowse_DestDir.Text = "Browse";
			this.toolTip1.SetToolTip(this.btnBrowse_DestDir, "Browse for a destination directory");
			this.btnBrowse_DestDir.UseVisualStyleBackColor = true;
			this.btnBrowse_DestDir.Click += new System.EventHandler(this.btnBrowse_DestDir_Click);
			// 
			// cbSearchSubDirs
			// 
			this.cbSearchSubDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbSearchSubDirs.AutoSize = true;
			this.cbSearchSubDirs.Checked = true;
			this.cbSearchSubDirs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSearchSubDirs.Location = new System.Drawing.Point(494, 10);
			this.cbSearchSubDirs.Name = "cbSearchSubDirs";
			this.cbSearchSubDirs.Size = new System.Drawing.Size(135, 17);
			this.cbSearchSubDirs.TabIndex = 20;
			this.cbSearchSubDirs.Text = "Search Sub-Directories";
			this.toolTip1.SetToolTip(this.cbSearchSubDirs, "Select whether to include sub-directories within the sourec directory in the sear" +
        "ch");
			this.cbSearchSubDirs.UseVisualStyleBackColor = true;
			// 
			// btnOpenDestDir
			// 
			this.btnOpenDestDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenDestDir.Location = new System.Drawing.Point(565, 60);
			this.btnOpenDestDir.Name = "btnOpenDestDir";
			this.btnOpenDestDir.Size = new System.Drawing.Size(64, 23);
			this.btnOpenDestDir.TabIndex = 25;
			this.btnOpenDestDir.Text = "Open";
			this.toolTip1.SetToolTip(this.btnOpenDestDir, "Open destination directory");
			this.btnOpenDestDir.UseVisualStyleBackColor = true;
			this.btnOpenDestDir.Click += new System.EventHandler(this.btnOpenDestDir_Click);
			// 
			// btnOpenSourceDir
			// 
			this.btnOpenSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenSourceDir.Location = new System.Drawing.Point(424, 8);
			this.btnOpenSourceDir.Name = "btnOpenSourceDir";
			this.btnOpenSourceDir.Size = new System.Drawing.Size(64, 23);
			this.btnOpenSourceDir.TabIndex = 24;
			this.btnOpenSourceDir.Text = "Open";
			this.toolTip1.SetToolTip(this.btnOpenSourceDir, "Open source directory");
			this.btnOpenSourceDir.UseVisualStyleBackColor = true;
			this.btnOpenSourceDir.Click += new System.EventHandler(this.btnOpenSourceDir_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// dgvFoundFiles
			// 
			this.dgvFoundFiles.AllowUserToAddRows = false;
			this.dgvFoundFiles.AllowUserToDeleteRows = false;
			this.dgvFoundFiles.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvFoundFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFoundFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFoundFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFoundFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFoundFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoundFiles.Location = new System.Drawing.Point(3, 231);
			this.dgvFoundFiles.Name = "dgvFoundFiles";
			this.dgvFoundFiles.RowTemplate.Height = 25;
			this.dgvFoundFiles.Size = new System.Drawing.Size(627, 255);
			this.dgvFoundFiles.TabIndex = 8;
			this.dgvFoundFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoundFiles_CellContentClick);
			this.dgvFoundFiles.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvFoundFiles_ColumnAdded);
			// 
			// imageContainer
			// 
			this.imageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageContainer.Location = new System.Drawing.Point(0, 0);
			this.imageContainer.Name = "imageContainer";
			this.imageContainer.Size = new System.Drawing.Size(480, 489);
			this.imageContainer.TabIndex = 10;
			// 
			// lblDestDir
			// 
			this.lblDestDir.AutoSize = true;
			this.lblDestDir.Location = new System.Drawing.Point(10, 64);
			this.lblDestDir.Name = "lblDestDir";
			this.lblDestDir.Size = new System.Drawing.Size(105, 13);
			this.lblDestDir.TabIndex = 14;
			this.lblDestDir.Text = "Destination Directory";
			// 
			// tbDestDir
			// 
			this.tbDestDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDestDir.Location = new System.Drawing.Point(121, 62);
			this.tbDestDir.Name = "tbDestDir";
			this.tbDestDir.ReadOnly = true;
			this.tbDestDir.Size = new System.Drawing.Size(367, 20);
			this.tbDestDir.TabIndex = 13;
			this.tbDestDir.Text = ".\\..\\..\\..\\..\\dest";
			// 
			// lblTotalFilesFound
			// 
			this.lblTotalFilesFound.AutoSize = true;
			this.lblTotalFilesFound.Location = new System.Drawing.Point(10, 148);
			this.lblTotalFilesFound.Name = "lblTotalFilesFound";
			this.lblTotalFilesFound.Size = new System.Drawing.Size(88, 13);
			this.lblTotalFilesFound.TabIndex = 17;
			this.lblTotalFilesFound.Text = "Total Files Found";
			// 
			// tbTotalFilesFound
			// 
			this.tbTotalFilesFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tbTotalFilesFound.Location = new System.Drawing.Point(114, 144);
			this.tbTotalFilesFound.Name = "tbTotalFilesFound";
			this.tbTotalFilesFound.ReadOnly = true;
			this.tbTotalFilesFound.Size = new System.Drawing.Size(66, 23);
			this.tbTotalFilesFound.TabIndex = 16;
			this.tbTotalFilesFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblUniqueFilesFound
			// 
			this.lblUniqueFilesFound.AutoSize = true;
			this.lblUniqueFilesFound.Location = new System.Drawing.Point(10, 178);
			this.lblUniqueFilesFound.Name = "lblUniqueFilesFound";
			this.lblUniqueFilesFound.Size = new System.Drawing.Size(98, 13);
			this.lblUniqueFilesFound.TabIndex = 18;
			this.lblUniqueFilesFound.Text = "Unique Files Found";
			// 
			// tbUniqueFilesFound
			// 
			this.tbUniqueFilesFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tbUniqueFilesFound.Location = new System.Drawing.Point(114, 173);
			this.tbUniqueFilesFound.Name = "tbUniqueFilesFound";
			this.tbUniqueFilesFound.ReadOnly = true;
			this.tbUniqueFilesFound.Size = new System.Drawing.Size(66, 23);
			this.tbUniqueFilesFound.TabIndex = 19;
			this.tbUniqueFilesFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// splitContainer
			// 
			this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.btnExportUnique);
			this.splitContainer.Panel1.Controls.Add(this.btnExportAll);
			this.splitContainer.Panel1.Controls.Add(this.btnOpenDestDir);
			this.splitContainer.Panel1.Controls.Add(this.btnOpenSourceDir);
			this.splitContainer.Panel1.Controls.Add(this.radCompareContents);
			this.splitContainer.Panel1.Controls.Add(this.radCompareFilenames);
			this.splitContainer.Panel1.Controls.Add(this.btnCopyAll);
			this.splitContainer.Panel1.Controls.Add(this.lblSourceDir);
			this.splitContainer.Panel1.Controls.Add(this.tbSourceDir);
			this.splitContainer.Panel1.Controls.Add(this.cbSearchSubDirs);
			this.splitContainer.Panel1.Controls.Add(this.btnBrowse_TopmostDir);
			this.splitContainer.Panel1.Controls.Add(this.tbUniqueFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.btnAllImages);
			this.splitContainer.Panel1.Controls.Add(this.lblUniqueFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.lblFileExtensions);
			this.splitContainer.Panel1.Controls.Add(this.lblTotalFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.tbFileExtensions);
			this.splitContainer.Panel1.Controls.Add(this.tbTotalFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.btnFindFiles);
			this.splitContainer.Panel1.Controls.Add(this.btnBrowse_DestDir);
			this.splitContainer.Panel1.Controls.Add(this.dgvFoundFiles);
			this.splitContainer.Panel1.Controls.Add(this.lblDestDir);
			this.splitContainer.Panel1.Controls.Add(this.btnClearFoundFiles);
			this.splitContainer.Panel1.Controls.Add(this.tbDestDir);
			this.splitContainer.Panel1.Controls.Add(this.btnCopyUnique);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.imageContainer);
			this.splitContainer.Size = new System.Drawing.Size(1123, 493);
			this.splitContainer.SplitterDistance = 636;
			this.splitContainer.SplitterWidth = 3;
			this.splitContainer.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1123, 493);
			this.Controls.Add(this.splitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Duplicate File Finder";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).EndInit();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Label lblSourceDir;
		private Button btnBrowse_TopmostDir;
		private FolderBrowserDialog folderBrowserDialog1;
		private Button btnAllImages;
		private Label lblFileExtensions;
		private TextBox tbSourceDir;
		private TextBox tbFileExtensions;
		private ToolTip toolTip1;
		private Button btnFindFiles;
		private ContextMenuStrip contextMenuStrip1;
		private DataGridView dgvFoundFiles;
		private FlowLayoutPanel imageContainer;
		private Button btnClearFoundFiles;
		private Button btnBrowse_DestDir;
		private Label lblDestDir;
		private TextBox tbDestDir;
		private Label lblTotalFilesFound;
		private TextBox tbTotalFilesFound;
		private Label lblUniqueFilesFound;
		private TextBox tbUniqueFilesFound;
		private CheckBox cbSearchSubDirs;
		private SplitContainer splitContainer;
		private Button btnCopyAll;
		private RadioButton radCompareContents;
		private RadioButton radCompareFilenames;
		private Button btnOpenDestDir;
		private Button btnOpenSourceDir;
		private Button btnExportUnique;
		private Button btnExportAll;
		private Button btnCopyUnique;
	}
}

