using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("1. Переименование изображении в соответствии с датой сьемки. \n" +
								  "2. Добавления на изображение отметку, когда фото было сделано.\n" +
								  "3. Сортировка изображений по папкам по годам.");

				//Console.ForegroundColor = color;
				Console.WriteLine();
				Console.WriteLine("Введите путь к папке с изображениями");
				string PathDirectory = Console.ReadLine();
				try
				{
					Console.WriteLine("Выберите требуемое действие:");
					int command = Convert.ToInt32(Console.ReadLine());

					switch (command)
					{
						case 1:
							var a = new RenameByYear(PathDirectory, @"_RenameByYear\");
							a.GetFiles();
							break;
						case 2:
							var b = new AddDate(PathDirectory, @"_AddDate\");
							b.GetFiles();
							break;
						case 3:
							var c = new SortByYear(PathDirectory, @"_SortByYear\");
							c.GetFiles();
							continue;
					}
				}
				catch (Exception ex)
				{
					//color = Console.ForegroundColor;
					//Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(ex.Message);
					//Console.ForegroundColor = color;
				}
			}
		}
	}
}
