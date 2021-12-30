using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTests
{
	[TestClass]
	public class AwesomeSauceTest
	{
		[TestMethod]
		public void IsSauceAwesomeTest()
		{
			var testInstance = new AwesomeSauce();
			testInstance.Sauces.Add("tabasco");
			testInstance.Sauces.Add("cholula");
			testInstance.Sauces.Add("trailer trash");

			// expect true
			Assert.IsTrue(testInstance.IsSauceAwesome("trailer trash"));

			// expect false
			Assert.IsFalse(testInstance.IsSauceAwesome("ketchup"));
		}
	}
}
