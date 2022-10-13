using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
	public partial class PictureViewer : UserControl
	{
		public string Filename
		{
			get
			{
				return tbName.Text;
			}
			set
			{
				tbName.Text = value;
				toolTip1.SetToolTip(tbName, value);
			}
		}

		public string Path
		{
			get
			{
				return tbPath.Text;
			}
			set
			{
				tbPath.Text = value;
				toolTip1.SetToolTip(pictureBox, value);
				toolTip1.SetToolTip(tbPath, value);
			}
		}

		public Image Image
		{
			get
			{
				return pictureBox.Image;
			}
			set
			{
				pictureBox.Image = value;
			}
		}

		/// <summary>
		/// The user requested the image to be deleted.  Please do so
		/// </summary>
		public event EventHandler DeleteRequested;


		public PictureViewer()
		{
			InitializeComponent();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you'd like to delete this image?  Image will be moved to the recycle bin.", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//Let the image be deleted a level up
				//Can't be deleted here because the main form is using the image
				DeleteRequested?.Invoke(this, EventArgs.Empty);
			}
		}
	}
}
