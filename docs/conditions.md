# Flow-control 1: Conditions

```csharp
public class FlowControl
	{
		// CASE 1, simplest case
		public bool IsYourFavoriteColorYellow(string color)
		{
			return (color.ToLower() == "yellow"); // evaluates to true/false
		}
		// CASE 2, ternary operator
		public bool IsYourFavoriteColorGreen(string color)
		{
			return (color.ToLower() == "green") ? true : false;
		}
		// CASE 3, one-liners
		public bool IsYourFavoriteColorRed(string color)
		{
			if (color.ToLower() == "red") return true;
			return false;
		}
		// CASE 4, long case
		public bool IsYourFavoriteColorBlue(string color)
		{
			if(color.ToLower() == "blue")
			{
				return true;
			} else {
				return false;
			}
		}

		// CASE 5, multiple conditions
		public string PrimaryOrSecondaryOne(string color)
		{
			string lowered = color.ToLower();
			if (lowered == "red") return "Primary";
			else if (lowered == "blue") return "Primary";
			else if (lowered == "yellow") return "Primary";
			else return "Secondary";
		}
		// CASE 6, switch statement
		public string PrimaryOrSecondaryTwo(string color)
		{
			var result = "";
			switch (color.ToLower())
			{
				case "red":
					return "Primary";
				case "blue":
					return "Primary";
				case "yellow":
					return "Primary";
				default:
					return "Secondary";
			}
		}
		// CASE 7, with compound logic
		// operator OR
		public string PrimaryOrSecondaryCompound(string color)
		{
			/* This type can detect more than one condition
			in one single statement */
			string lowered = color.ToLower();
			if (lowered == "red" || lowered == "blue" || lowered == yellow) return "Primary";
			else return "Secondary";
		}
		// CASE 8, operator AND
		public string GradeLetter(int score)
		{
			if (score >= 90) return "A";
			else if (score >= 79 && score < 90) return "B";
			else if (score >= 70 && score < 79) return "C";
			else return "F";
		}
		// CASE 9, operator NOT
		public string IsYourNameNotBruce(string yourName)
		{
			if (yourName.ToLower() != "bruce") return "Can we call you Bruce for the sake of simplicity?";
			else "G'day, Bruce.";
		}

	}
```