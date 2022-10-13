using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DuplicateFileFinder
{
	public partial class Form1 : Form
	{
		List<string> imageFileExtensions = new List<string> { "jpg", "png", "bmp", "tiff" };
		BindingList<foundFile> foundFiles = new BindingList<foundFile>();
		/// <summary>
		/// Comparing by filename: Key = filename. By hash: Key = hash.  Always: Value = list of paths
		/// </summary>
		Dictionary<string, List<string>> duplicateDict = new Dictionary<string, List<string>>();
		private bool ComparedByFilename = true;

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
			if (Directory.Exists(tbSourceDir.Text))
			{
				folderBrowserDialog1.SelectedPath = Path.GetFullPath(tbSourceDir.Text);
			}

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbSourceDir.Text = folderBrowserDialog1.SelectedPath;
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

		private void btnFindFiles_Click(object sender, EventArgs e)
		{
			tbTotalFilesFound.Clear();
			tbUniqueFilesFound.Clear();
			ClearImagePreviews();

			Cursor = Cursors.WaitCursor;

			if (radCompareFilenames.Checked)
			{
				FindDuplicates_Filenames(FindFiles());
			}
			else if (radCompareContents.Checked)
			{
				FindDuplicates_Contents(FindFiles());
			}
			else
			{
				MessageBox.Show("Must choose to compare files by either filename or contents", "Invalid Choice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			Cursor = Cursors.Default;

			tbTotalFilesFound.Text = foundFiles.Count.ToString();
			tbUniqueFilesFound.Text = duplicateDict.Count.ToString();
		}


		private List<string> FindFiles()
		{
			//create search pattern
			var patterns = new List<string>();
			var extensionList = tbFileExtensions.Text.Split(',');
			for (int i = 0; i < extensionList.Length; i++)
			{
				patterns.Add("*." + extensionList[i].Trim());
			}

			//Get topmost dir
			string sourceDir = Path.GetFullPath(tbSourceDir.Text);

			//Make sure dir is valid
			if (!Directory.Exists(sourceDir))
			{
				MessageBox.Show($"Invalid source directory:\n\n{sourceDir}", "Invalid source Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			var files = new List<string>();

			foreach (var pattern in patterns)
			{
				var rawFiles = Directory.GetFiles(sourceDir, pattern, cbSearchSubDirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
				files.AddRange(rawFiles);
			}

			return files;
		}

		private void FindDuplicates_Filenames(List<string> files)
		{
			foundFiles.Clear();
			duplicateDict.Clear();
			ComparedByFilename = true;

			foreach (var file in files)
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
		}

		private void FindDuplicates_Contents(List<string> files)
		{
			foundFiles.Clear();
			duplicateDict.Clear();
			ComparedByFilename = false;

			foreach (var file in files)
			{
				var fileHash = GetFileHash(file);

				if (!duplicateDict.ContainsKey(fileHash))
				{
					duplicateDict.Add(fileHash, new List<string> { file });
				}
				else
				{
					duplicateDict[fileHash].Add(file);
				}
			}

			foreach (var kvp in duplicateDict)
			{
				foreach (var path in kvp.Value)
				{
					var newFile = new foundFile();
					newFile.duplicate = kvp.Value.Count > 1;
					newFile.path = path;
					newFile.filename = Path.GetFileName(path);
					newFile.count = kvp.Value.Count;
					newFile.hash = kvp.Key;

					foundFiles.Add(newFile);
				}
			}
		}

		private void dgvFoundFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0) return;  //they clicked a column header
				var row = ((DataGridView)sender).Rows[e.RowIndex];
				var cell = row.Cells[e.ColumnIndex];
				var columnName = cell.OwningColumn.Name;

				if (columnName == "viewSingle")
				{
					//View just this picture
					SetPreviewImages(new List<string> { (string)dgvFoundFiles.Rows[e.RowIndex].Cells["path"].Value });

				}
				else if (columnName == "viewDuplicates")
				{
					//View this picture and all with duplicate names
					if (ComparedByFilename)
					{
						SetPreviewImages(duplicateDict[row.Cells["filename"].Value.ToString()]);
					}
					else
					{
						string hash = GetFileHash(row.Cells["path"].Value.ToString());
						SetPreviewImages(duplicateDict[hash]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error handling cell content click.\n\n{ex.Message}");
			}
			
		}

		private void SetPreviewImages(List<string> paths)
		{
			try
			{
				ClearImagePreviews();

				foreach (var path in paths)
				{
					var newPV = new PictureViewer();
					newPV.Filename = Path.GetFileName(path);
					newPV.Path = path;
					newPV.Image = Image.FromFile(path);
					newPV.Width = 400;
					newPV.Height = 300;
					imageContainer.Controls.Add(newPV);

					newPV.DeleteRequested += NewPV_DeleteRequested;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error adding images to view.\n\n{ex.Message}");
			}
		}

		private void ClearImagePreviews()
		{
			foreach (var control in imageContainer.Controls)
			{
				if (control is PictureViewer)
				{
					((PictureViewer)control).Image.Dispose();
					((PictureViewer)control).Dispose();
				}
			}
			imageContainer.Controls.Clear();
		}

		private void NewPV_DeleteRequested(object sender, EventArgs e)
		{
			DeleteImage(((PictureViewer)sender));
		}

		private void DeleteImage(PictureViewer pv)
		{
			//First let go of the image
			var path = pv.Path;
			var filename = pv.Filename;
			var hash = GetFileHash(path);

			imageContainer.Controls.Remove(pv);
			pv.Image.Dispose();
			pv.Dispose();

			//Delete the image
			try
			{
				Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(path, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
			}
			catch (OperationCanceledException ex)
			{
				//do nothing, the user just cancelled the operation
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error while attempting to delete file\n\n{path}\n\n{ex.Message}");
				return;
			}

			//Deletion was successful
			//Delete the records of the image
			string key = "";
			for (int i = 0; i < foundFiles.Count; i++)
			{
				if (foundFiles[i].path == path)
				{
					foundFiles.RemoveAt(i);
					

					if (ComparedByFilename)
						key = filename;
					else
						key = hash;

					duplicateDict[key].Remove(path);
					if (duplicateDict[key].Count == 0)
					{
						duplicateDict.Remove(key);
					}

					break;
				}
			}

			//update the counts of the other copies of that image
			var otherDuplicates = foundFiles.Where(x => x.hash == key);
			foreach (var otherDuplicate in otherDuplicates)
			{
				otherDuplicate.count--;
			}

			tbTotalFilesFound.Text = foundFiles.Count.ToString();
			tbUniqueFilesFound.Text = duplicateDict.Count.ToString();
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

			if (new string[] { "duplicate", "count", "viewSingle", "viewDuplicates" }.Contains(e.Column.Name))
			{
				e.Column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}
		}

		private void btnClearFoundFiles_Click(object sender, EventArgs e)
		{
			foundFiles.Clear();
			duplicateDict.Clear();

			tbTotalFilesFound.Clear();
			tbUniqueFilesFound.Clear();

			ClearImagePreviews();
		}

		private void btnBrowse_DestDir_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(tbDestDir.Text))
			{
				folderBrowserDialog1.SelectedPath = Path.GetFullPath(tbDestDir.Text);
			}

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbDestDir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnCopyUnique_Click(object sender, EventArgs e)
		{
			string dest = tbDestDir.Text;
			var fileList = new List<string>();
			foreach (var kvp in duplicateDict)
			{
				fileList.Add(kvp.Value[0]);
			}

			CopyFiles(fileList, dest);
		}

		private void btnCopyAll_Click(object sender, EventArgs e)
		{
			string dest = tbDestDir.Text;
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

		private string GetFileHash(string file)
		{
			try
			{
				HashAlgorithm hash = HashAlgorithm.Create();
				byte[] fileHash;

				using (FileStream fileStream1 = new FileStream(file, FileMode.Open, FileAccess.Read))
				{
					// Compute file hashes
					fileHash = hash.ComputeHash(fileStream1);
				}

				hash.Dispose();

				return BitConverter.ToString(fileHash);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error generating file hash for:\n\n{file}\n\n{ex.Message}");
				return null;
			}
		}

		private long GetFileSize(string file)
		{
			return new FileInfo(file).Length;
		}

		private void btnOpenSourceDir_Click(object sender, EventArgs e)
		{
			var dir = tbSourceDir.Text;
			if (Directory.Exists(dir))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					Arguments = dir,
					FileName = "explorer.exe"
				};

				Process.Start(startInfo);
			}
			else
			{
				MessageBox.Show($"Directory does not exist:\n\n{dir}");
			}
		}

		private void btnOpenDestDir_Click(object sender, EventArgs e)
		{
			var dir = tbDestDir.Text;
			if (Directory.Exists(dir))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					Arguments = dir,
					FileName = "explorer.exe"
				};

				Process.Start(startInfo);
			}
			else
			{
				MessageBox.Show($"Directory does not exist:\n\n{dir}");
			}
		}

		private void btnExportAll_Click(object sender, EventArgs e)
		{
			string contents = "";
			var fullpath = Path.GetFullPath(tbDestDir.Text) + "\\AllFiles.txt";

			contents += $"Created on: {DateTime.Now}\n";
			if (ComparedByFilename)
			{
				contents += "Files compared by filename\n\n";
			}
			else
			{
				contents += "Files compared by contents\n\n";
			}

			foreach (var file in foundFiles)
			{
				contents += $"{file.path}\n";
			}

			WriteToTxt(fullpath, contents);
		}

		private void btnExportUnique_Click(object sender, EventArgs e)
		{
			string contents = "";
			var fullpath = Path.GetFullPath(tbDestDir.Text) + "\\UniqueFiles.txt";


			contents += $"Created on: {DateTime.Now}\n";
			if (ComparedByFilename)
			{
				contents += "Files compared by filename\n\n";
			}
			else
			{
				contents += "Files compared by contents\n\n";
			}

			foreach (var kvp in duplicateDict)
			{
				contents += $"{kvp.Value[0]}\n";
			}

			WriteToTxt(fullpath, contents);
		}

		private void WriteToTxt(string filepath, string contents, bool openWhenComplete = true)
		{
			string dir = Path.GetDirectoryName(filepath);

			try
			{
				if (!Directory.Exists(dir))
				{
					if (MessageBox.Show
						($"Destination directory does not exist:\n\n{dir}\n\nCreate it now?",
						"Directory Does Not Exist",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Directory.CreateDirectory(dir);
					}
					else
					{
						return;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error concerning destination directory:\n\n{dir}\n\n{ex.Message}");
				return;
			}

			try
			{
				using (StreamWriter sw = File.CreateText(filepath))
				{
					sw.Write(contents);
				}
				Process.Start(filepath);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error writing to text file\n\n{ex.Message}");
			}
		}
	}
}
