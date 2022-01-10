using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
	class Program
	{
		public static Logger logger = LogManager.GetCurrentClassLogger();
		public static List<string> Words; // if not initialized, it is set to null.
		static void Main(string[] args)
		{
			logger.Trace("The program started.");
			Words = new List<string>(); // At this point of code, the List is being initialized to empty.
			Words.Add("break");
			Words.Add("milk");
			Words.Add("cheese");

			CrazyMathProblem();
			ReadTextFile();
			Console.ReadLine();
		}


		// 01
		private static int CrazyMathProblem()
		{
			var income = 1000;
			
			for(var i = 10; i > 0; i--)
			{
				income = income = (income / i);
			}
			return income;
		}

		// 02
		private static void ReadTextFile()
		{
			try
			{
				using (var sr = new StreamReader(@"C:\Temp\text.txt"))
				{
					string contents = sr.ReadToEnd();
					Console.WriteLine(contents);
				}
			}
			catch(System.IO.DirectoryNotFoundException ex) // catch 1, specific exception
			{
				Console.WriteLine("Couldn't find the directory.");
				logger.Error("The directory was not found." + ex.Message);
			}
			catch(System.IO.FileNotFoundException ex) // catch 2, specific exception
			{
				Console.WriteLine("Couldn't find the file.");
				logger.Error(ex.Message);
			}
			catch (Exception ex) // catch 3, general exception
			{
				Console.WriteLine("An unknown error ocurred " + ex.Message);
			}
			finally
			{
				Console.WriteLine("The \"finally\" runs no matter what.");
				// This block is can be used for cleaning up database or network connections.
			}

		}


	}
}
