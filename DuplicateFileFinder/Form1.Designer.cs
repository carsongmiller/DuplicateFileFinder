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
			this.lblTopmostDir = new System.Windows.Forms.Label();
			this.btnBrowse_TopmostDir = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnAllImages = new System.Windows.Forms.Button();
			this.lblFileExtensions = new System.Windows.Forms.Label();
			this.tbTopmostDir = new System.Windows.Forms.TextBox();
			this.tbFileExtensions = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dgvFoundFiles = new System.Windows.Forms.DataGridView();
			this.imageContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.btnClearFoundFiles = new System.Windows.Forms.Button();
			this.btnCopyUnique = new System.Windows.Forms.Button();
			this.btnBrowse_DestDir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDestinationDir = new System.Windows.Forms.TextBox();
			this.lblTotalFilesFound = new System.Windows.Forms.Label();
			this.tbTotalFilesFound = new System.Windows.Forms.TextBox();
			this.lblUniqueFilesFound = new System.Windows.Forms.Label();
			this.tbUniqueFilesFound = new System.Windows.Forms.TextBox();
			this.cbSearchSubDirs = new System.Windows.Forms.CheckBox();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.btnCopyAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTopmostDir
			// 
			this.lblTopmostDir.AutoSize = true;
			this.lblTopmostDir.Location = new System.Drawing.Point(10, 13);
			this.lblTopmostDir.Name = "lblTopmostDir";
			this.lblTopmostDir.Size = new System.Drawing.Size(130, 13);
			this.lblTopmostDir.TabIndex = 1;
			this.lblTopmostDir.Text = "Topmost Search Directory";
			// 
			// btnBrowse_TopmostDir
			// 
			this.btnBrowse_TopmostDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse_TopmostDir.Location = new System.Drawing.Point(424, 7);
			this.btnBrowse_TopmostDir.Name = "btnBrowse_TopmostDir";
			this.btnBrowse_TopmostDir.Size = new System.Drawing.Size(64, 23);
			this.btnBrowse_TopmostDir.TabIndex = 2;
			this.btnBrowse_TopmostDir.Text = "Browse";
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
			// tbTopmostDir
			// 
			this.tbTopmostDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTopmostDir.Location = new System.Drawing.Point(146, 10);
			this.tbTopmostDir.Name = "tbTopmostDir";
			this.tbTopmostDir.ReadOnly = true;
			this.tbTopmostDir.Size = new System.Drawing.Size(272, 20);
			this.tbTopmostDir.TabIndex = 0;
			this.tbTopmostDir.Text = ".\\..\\..\\..\\..\\..\\source";
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
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(10, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Find all files";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.dgvFoundFiles.Location = new System.Drawing.Point(3, 180);
			this.dgvFoundFiles.Name = "dgvFoundFiles";
			this.dgvFoundFiles.RowTemplate.Height = 25;
			this.dgvFoundFiles.Size = new System.Drawing.Size(627, 306);
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
			// btnClearFoundFiles
			// 
			this.btnClearFoundFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearFoundFiles.Location = new System.Drawing.Point(558, 151);
			this.btnClearFoundFiles.Name = "btnClearFoundFiles";
			this.btnClearFoundFiles.Size = new System.Drawing.Size(71, 23);
			this.btnClearFoundFiles.TabIndex = 11;
			this.btnClearFoundFiles.Text = "Clear List";
			this.btnClearFoundFiles.UseVisualStyleBackColor = true;
			this.btnClearFoundFiles.Click += new System.EventHandler(this.btnClearFoundFiles_Click);
			// 
			// btnCopyUnique
			// 
			this.btnCopyUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyUnique.Location = new System.Drawing.Point(186, 150);
			this.btnCopyUnique.Name = "btnCopyUnique";
			this.btnCopyUnique.Size = new System.Drawing.Size(114, 23);
			this.btnCopyUnique.TabIndex = 12;
			this.btnCopyUnique.Text = "Copy Only Unique";
			this.btnCopyUnique.UseVisualStyleBackColor = true;
			this.btnCopyUnique.Click += new System.EventHandler(this.btnCopyUnique_Click);
			// 
			// btnBrowse_DestDir
			// 
			this.btnBrowse_DestDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse_DestDir.Location = new System.Drawing.Point(565, 62);
			this.btnBrowse_DestDir.Name = "btnBrowse_DestDir";
			this.btnBrowse_DestDir.Size = new System.Drawing.Size(64, 23);
			this.btnBrowse_DestDir.TabIndex = 15;
			this.btnBrowse_DestDir.Text = "Browse";
			this.btnBrowse_DestDir.UseVisualStyleBackColor = true;
			this.btnBrowse_DestDir.Click += new System.EventHandler(this.btnBrowse_DestDir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Copy-To Directory";
			// 
			// tbDestinationDir
			// 
			this.tbDestinationDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDestinationDir.Location = new System.Drawing.Point(106, 62);
			this.tbDestinationDir.Name = "tbDestinationDir";
			this.tbDestinationDir.ReadOnly = true;
			this.tbDestinationDir.Size = new System.Drawing.Size(453, 20);
			this.tbDestinationDir.TabIndex = 13;
			this.tbDestinationDir.Text = ".\\..\\..\\..\\..\\..\\dest";
			// 
			// lblTotalFilesFound
			// 
			this.lblTotalFilesFound.AutoSize = true;
			this.lblTotalFilesFound.Location = new System.Drawing.Point(10, 126);
			this.lblTotalFilesFound.Name = "lblTotalFilesFound";
			this.lblTotalFilesFound.Size = new System.Drawing.Size(88, 13);
			this.lblTotalFilesFound.TabIndex = 17;
			this.lblTotalFilesFound.Text = "Total Files Found";
			// 
			// tbTotalFilesFound
			// 
			this.tbTotalFilesFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tbTotalFilesFound.Location = new System.Drawing.Point(114, 122);
			this.tbTotalFilesFound.Name = "tbTotalFilesFound";
			this.tbTotalFilesFound.ReadOnly = true;
			this.tbTotalFilesFound.Size = new System.Drawing.Size(66, 23);
			this.tbTotalFilesFound.TabIndex = 16;
			this.tbTotalFilesFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblUniqueFilesFound
			// 
			this.lblUniqueFilesFound.AutoSize = true;
			this.lblUniqueFilesFound.Location = new System.Drawing.Point(10, 156);
			this.lblUniqueFilesFound.Name = "lblUniqueFilesFound";
			this.lblUniqueFilesFound.Size = new System.Drawing.Size(98, 13);
			this.lblUniqueFilesFound.TabIndex = 18;
			this.lblUniqueFilesFound.Text = "Unique Files Found";
			// 
			// tbUniqueFilesFound
			// 
			this.tbUniqueFilesFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tbUniqueFilesFound.Location = new System.Drawing.Point(114, 151);
			this.tbUniqueFilesFound.Name = "tbUniqueFilesFound";
			this.tbUniqueFilesFound.ReadOnly = true;
			this.tbUniqueFilesFound.Size = new System.Drawing.Size(66, 23);
			this.tbUniqueFilesFound.TabIndex = 19;
			this.tbUniqueFilesFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.cbSearchSubDirs.UseVisualStyleBackColor = true;
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
			this.splitContainer.Panel1.Controls.Add(this.btnCopyAll);
			this.splitContainer.Panel1.Controls.Add(this.lblTopmostDir);
			this.splitContainer.Panel1.Controls.Add(this.tbTopmostDir);
			this.splitContainer.Panel1.Controls.Add(this.cbSearchSubDirs);
			this.splitContainer.Panel1.Controls.Add(this.btnBrowse_TopmostDir);
			this.splitContainer.Panel1.Controls.Add(this.tbUniqueFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.btnAllImages);
			this.splitContainer.Panel1.Controls.Add(this.lblUniqueFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.lblFileExtensions);
			this.splitContainer.Panel1.Controls.Add(this.lblTotalFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.tbFileExtensions);
			this.splitContainer.Panel1.Controls.Add(this.tbTotalFilesFound);
			this.splitContainer.Panel1.Controls.Add(this.button1);
			this.splitContainer.Panel1.Controls.Add(this.btnBrowse_DestDir);
			this.splitContainer.Panel1.Controls.Add(this.dgvFoundFiles);
			this.splitContainer.Panel1.Controls.Add(this.label1);
			this.splitContainer.Panel1.Controls.Add(this.btnClearFoundFiles);
			this.splitContainer.Panel1.Controls.Add(this.tbDestinationDir);
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
			// btnCopyAll
			// 
			this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyAll.Location = new System.Drawing.Point(306, 150);
			this.btnCopyAll.Name = "btnCopyAll";
			this.btnCopyAll.Size = new System.Drawing.Size(76, 23);
			this.btnCopyAll.TabIndex = 21;
			this.btnCopyAll.Text = "Copy All";
			this.btnCopyAll.UseVisualStyleBackColor = true;
			this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
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
		private Label lblTopmostDir;
		private Button btnBrowse_TopmostDir;
		private FolderBrowserDialog folderBrowserDialog1;
		private Button btnAllImages;
		private Label lblFileExtensions;
		private TextBox tbTopmostDir;
		private TextBox tbFileExtensions;
		private ToolTip toolTip1;
		private Button button1;
		private ContextMenuStrip contextMenuStrip1;
		private DataGridView dgvFoundFiles;
		private FlowLayoutPanel imageContainer;
		private Button btnClearFoundFiles;
		private Button btnCopyUnique;
		private Button btnBrowse_DestDir;
		private Label label1;
		private TextBox tbDestinationDir;
		private Label lblTotalFilesFound;
		private TextBox tbTotalFilesFound;
		private Label lblUniqueFilesFound;
		private TextBox tbUniqueFilesFound;
		private CheckBox cbSearchSubDirs;
		private SplitContainer splitContainer;
		private Button btnCopyAll;
	}
}

