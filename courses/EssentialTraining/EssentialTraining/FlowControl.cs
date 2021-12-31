using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
	public class FlowControl
	{
		// CASE 1
		public bool IsYourFavoriteColorYellow(string color)
		{
			return (color.ToLower() == "yellow"); // evaluates to true/false
		}
		// CASE 2
		// ternary operator
		public bool IsYourFavoriteColorGreen(string color)
		{
			return (color.ToLower() == "green") ? true : false;
		}
		// CASE 3
		public bool IsYourFavoriteColorRed(string color)
		{
			if (color.ToLower() == "red") return true;
			return false;
		}
		// CASE 4
		public bool IsYourFavoriteColorBlue(string color)
		{
			if(color.ToLower() == "blue")
			{
				return true;
			} else {
				return false;
			}
		}


	}
}
