using System.ComponentModel;

namespace DuplicateFileFinder
{
	internal class foundFile
	{
		[DisplayName("Path")]
		public string path { get; set; }

		[DisplayName("File Name"), Description("Test Desc")]
		public string filename { get; set; }

		[DisplayName("Duplicate")]
		public bool duplicate { get; set; } = false;

		[DisplayName("Count")]
		public int count { get; set; } = 0;
	}
}
