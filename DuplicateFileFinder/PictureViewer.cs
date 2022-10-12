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
		public string Name
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

		public PictureViewer()
		{
			InitializeComponent();
		}
	}
}
