using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "milk", "eggs", "cheese", "apples" };
        }

        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
        }
    }
}
