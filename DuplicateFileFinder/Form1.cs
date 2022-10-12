using System.ComponentModel;
using System.Threading;
using System.Diagnostics;

namespace DuplicateFileFinder
{
	public partial class Form1 : Form
	{
		List<string> imageFileExtensions = new List<string> { "jpg", "png", "bmp", "tiff" };
		BindingList<foundFile> foundFiles = new BindingList<foundFile>();
		Dictionary<string, List<string>> duplicateDict = new Dictionary<string, List<string>>();
		int test = 1;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvFoundFiles.DataSource = foundFiles;

			var viewSingleCol = new DataGridViewButtonColumn();
			viewSingleCol.HeaderText = "Single";
			viewSingleCol.Text = "View";
			viewSingleCol.Name = "viewSingle";
			viewSingleCol.UseColumnTextForButtonValue = true;
			dgvFoundFiles.Columns.Add(viewSingleCol);

			var viewDuplicatesCol = new DataGridViewButtonColumn();
			viewDuplicatesCol.HeaderText = "Duplicates";
			viewDuplicatesCol.Text = "View";
			viewDuplicatesCol.Name = "viewDuplicates";
			viewDuplicatesCol.UseColumnTextForButtonValue = true;
			dgvFoundFiles.Columns.Add(viewDuplicatesCol);
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbTopmostDir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnAllImages_Click(object sender, EventArgs e)
		{
			tbFileExtensions.Text = "";
			foreach (string imageType in imageFileExtensions)
			{
				tbFileExtensions.Text += $"{imageType}, ";
			}
			tbFileExtensions.Text = tbFileExtensions.Text.Trim().Trim(',');
		}

		private void button1_Click(object sender, EventArgs e)
		{
			findFiles();
		}


		private BindingList<foundFile> findFiles()
		{
			//BeginInvoke(delegate 
			//{
			foundFiles.Clear();
			duplicateDict.Clear();
			tbTotalFilesFound.Clear();
			tbUniqueFilesFound.Clear();
			Cursor = Cursors.WaitCursor;
			//});

			//create search pattern
			var patterns = new List<string>();
			var extensionList = tbFileExtensions.Text.Split(',');
			for (int i = 0; i < extensionList.Length; i++)
			{
				patterns.Add("*." + extensionList[i].Trim());
			}

			//Get topmost dir
			string topmostDir = Path.GetFullPath(tbTopmostDir.Text);

			//Make sure dir is valid
			if (!Directory.Exists(topmostDir))
			{
				MessageBox.Show($"Invalid TopmostDirectory:\n\n{topmostDir}", "Invalid Topmost Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			var files = new BindingList<foundFile>();

			foreach (var pattern in patterns)
			{
				//Start searching
				var rawFiles = Directory.GetFiles(topmostDir, pattern, cbSearchSubDirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

				foreach (var file in rawFiles)
				{
					var filename = Path.GetFileName(file);

					if (!duplicateDict.ContainsKey(filename))
					{
						duplicateDict.Add(filename, new List<string> { file });
					}
					else
					{
						duplicateDict[filename].Add(file);
					}
				}
			}
			
			//first build a dictionary of all found files, then add them to foundFiles
			foreach (var kvp in duplicateDict)
			{
				foreach (var path in kvp.Value)
				{
					var newFile = new foundFile();
					newFile.duplicate = kvp.Value.Count > 1;
					newFile.path = path;
					newFile.filename = kvp.Key;
					newFile.count = kvp.Value.Count;
					foundFiles.Add(newFile);
				}
			}

			tbTotalFilesFound.Text = foundFiles.Count.ToString();
			tbUniqueFilesFound.Text = duplicateDict.Count.ToString();

			Cursor = Cursors.Default;

			return files;
		}

		private void dgvFoundFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;  //they clicked a column header
			var row = ((DataGridView)sender).Rows[e.RowIndex];
			var cell = row.Cells[e.ColumnIndex];
			var columnName = cell.OwningColumn.Name;

			if (columnName == "viewSingle")
			{
				//View just this picture
				AddImagesToView(new List<string> { (string)dgvFoundFiles.Rows[e.RowIndex].Cells["path"].Value });
				
			}
			else if (columnName == "viewDuplicates")
			{
				//View this picture and all with duplicate names
				AddImagesToView(duplicateDict[row.Cells["filename"].Value.ToString()]);
			}
		}

		private void AddImagesToView(List<string> paths, bool clearView = true)
		{
			if (clearView) imageContainer.Controls.Clear();

			foreach (var path in paths)
			{
				var newPV = new PictureViewer();
				newPV.Name = Path.GetFileName(path);
				newPV.Path = path;
				newPV.Image = Image.FromFile(path);
				newPV.Width = 400;
				newPV.Height = 300;
				imageContainer.Controls.Add(newPV);
			}
		}

		private void dgvFoundFiles_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			if (e.Column.Name == "path" || e.Column.Name == "filename" || e.Column.Name == "duplicate")
			{
				e.Column.ReadOnly = true;
			}

			if (e.Column.Name == "count")
			{
				e.Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}

			if (new string[] {"duplicate", "count", "viewSingle", "viewDuplicates"}.Contains(e.Column.Name))
			{
				e.Column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}
		}

		private void btnClearFoundFiles_Click(object sender, EventArgs e)
		{
			foundFiles.Clear();
			duplicateDict.Clear();
		}

		private void btnBrowse_DestDir_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbDestinationDir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnCopyUnique_Click(object sender, EventArgs e)
		{
			string dest = tbDestinationDir.Text;
			var fileList = new List<string>();
			foreach (var kvp in duplicateDict)
			{
				fileList.Add(kvp.Value[0]);
			}

			CopyFiles(fileList, dest);
		}

		private void btnCopyAll_Click(object sender, EventArgs e)
		{
			string dest = tbDestinationDir.Text;
			var fileList = new List<string>();
			foreach (var file in foundFiles)
			{
				fileList.Add(file.path);
			}

			CopyFiles(fileList, dest);
		}

		private void CopyFiles(List<string> files, string dest)
		{
			if (files.Count == 0)
			{
				MessageBox.Show("No files to copy", "No files to copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string text = $"{files.Count} Files will be copied to:\n\n{Path.GetFullPath(dest)}\n\nProceed?";
			if (MessageBox.Show(text, "Confirm File Copy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			//make sure destination directory exists
			if (!Directory.Exists(dest))
			{
				Directory.CreateDirectory(dest);
			}

			var existingFileCount = Directory.GetFileSystemEntries(dest).Length;
			if (existingFileCount > 0)
			{
				text = $"Destination diretory is not empty.\n\nAny files with conflicting names will be overwritten.\n\nProceed?";
				if (MessageBox.Show(text, "Confirm File Copy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				{
					return;
				}
			}

			Cursor = Cursors.WaitCursor;

			int successCount = 0;
			foreach (var file in files)
			{
				try
				{
					File.Copy(file, $"{dest}\\{Path.GetFileName(file)}", true);
					successCount += 1;
				}
				catch (Exception ex)
				{
					//do nothing for now
				}
			}

			Cursor = Cursors.Default;

			MessageBox.Show($"Successfully copied {successCount} of {files.Count} files", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}