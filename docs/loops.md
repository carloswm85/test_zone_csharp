[return ←](../README.md)

# Flow-control 2: Loops

```csharp
// MAIN CLASS
public class ProgrammingLoops
{
	// 01, simple FOR loop
	public int ForLoop()
	{
		int sum = 0;
		for(var i = 0; i < 100; i++)
		{
			sum += i;
		}
		return sum;
	} // 4950

	// 02, FOR... EACH loop, for lists and arrays
	// These work with objects implementing interface IEnumerable
	public int ForEachLoop()
	{
		var numbers = new List<int> { 1, 3, 5, 7, 9 }; // With collection initialization.
		var sum = 0;
		foreach(var number in numbers)
		{
			sum += number;
		}
		return sum;
	} // 25

	// 03, WHILE loop
	public int WhileLoop()
	{
		var sum = 0;
		var counter = 0;
		while(counter < 100)
		{
			sum += counter;
			counter++;
		}
		return sum;
	} // 4950

	// 04, DO... WHILE loop
	// It runs at least ONE time
	public int DoWhileLoop()
	{
		var sum = 0; var counter = 0;
		do
		{
			sum += counter;
			counter++;
		} while (counter < 100);
		return sum;
	} // 4950

	// 05, BREAK and CONTINUE
	public string BreakAndContinue()
	{
		var sb = new StringBuilder();
		var words = new List<string>() { "bread", "milk", "eggs", "cheese", "apples", "mango", "watermelon", "banana" };
		foreach(var word in words)
		{
			if (word.StartsWith("m")) continue; // skips the loop once
			if (word.StartsWith("w")) break; // interrupts totally the loop
			sb.AppendLine(word);
		}
		return sb.ToString();
	} // "bread\r\neggs\r\ncheese\r\napples\r\n"
}
```
