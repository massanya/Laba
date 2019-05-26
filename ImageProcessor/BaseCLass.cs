using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageProcessor
{
	public class BaseCLass
	{
		public FileInfo[] files;

		public string newpathdirectory;

		public BaseCLass(string pathdirectory, string namenewdirectory)
		{
			newpathdirectory = pathdirectory + namenewdirectory;

			var olddirectory = new DirectoryInfo(pathdirectory);

			if (olddirectory.Exists)
			{
				var newdirectory = new DirectoryInfo(newpathdirectory);

				if (!newdirectory.Exists)
				{
					newdirectory.Create();
				}
			}
			else
			{
				throw new Exception("Такой папки не существует!");
			}

			files = olddirectory.GetFiles(@"*.jpg", SearchOption.TopDirectoryOnly);
		}
	}
}
