using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DuplicateFileFinder
{
	internal class foundFile
	{
		[DisplayName("Path")]
		public string? path { get; set; }

		[DisplayName("File Name"), Description("Test Desc")]
		public string? filename { get; set; }

		[DisplayName("Duplicate")]
		public bool duplicate { get; set; } = false;

		[DisplayName("Count")]
		public int count { get; set; } = 0;

		//[DisplayName("Delete?")]
		//public bool markedToDelete { get; set; } = false;
	}
}
