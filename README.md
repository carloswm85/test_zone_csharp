# CSharp Notes - 2021

Personal notes on C# programming language.
- [CSharp Notes - 2021](#csharp-notes---2021)
- [C-Sharp](#c-sharp)
  - [Core Features](#core-features)
- [To-Learn](#to-learn)
- [Learning Sites](#learning-sites)
  - [Design/Patterns](#designpatterns)
- [Readings](#readings)
- [General Notes](#general-notes)
- [Project Instructions](#project-instructions)
  - [.NET Console Application](#net-console-application)
    - [Commands](#commands)
- [Programming Notes](#programming-notes)
  - [Arrays](#arrays)
  - [Classes](#classes)
    - [Class example:](#class-example)
  - [Collections](#collections)
    - [Generic](#generic)
    - [Concurrent](#concurrent)
    - [Simple](#simple)
  - [(Some) Concepts](#some-concepts)
  - [Unit Testing](#unit-testing)
    - [Unit Testing example:](#unit-testing-example)
- [Code Notes](#code-notes)
  - [Function-bodied expressions](#function-bodied-expressions)
  - [Overriding](#overriding)
- [Language Keywords, Concepts](#language-keywords-concepts)
  - [`abstract`](#abstract)
  - [Access Modifiers](#access-modifiers)
  - [Auto-properties](#auto-properties)
  - [Extension Methods](#extension-methods)
  - [`interface`](#interface)
  - [LINQ (Language Integrated Query)](#linq-language-integrated-query)
    - [Code Example:](#code-example)
    - [Extension Methods:](#extension-methods-1)
  - [`namespace`](#namespace)
  - [`public`](#public)
  - [`static`](#static)
  - [`this`](#this)
  - [`virtual`](#virtual)
- [Books](#books)
- [Courses](#courses)
  - [C# Path: `Become a C# Developer`](#c-path-become-a-c-developer)
    - [Courses:](#courses-1)
    - [Links:](#links)
  - [Basic Programming](#basic-programming)
  - [Other C# Courses](#other-c-courses)

# C-Sharp

## Core Features

- strong typing 
- object-oriented design
- multi-paradigm nature
# To-Learn

Focus on the core of the language.
- Learn:
  - basic syntax, program structure
  - different data types (primitive and other types)
  - how to construct a method, how to overload a method, how to extend a method, how to write a method with a specific return type, the operators, and then apply them in a small and simple project
- Learn:
  - a little bit of the .NET Framework at a time,
  - concepts of OOP, LINQ, FP, how to incorporate database types into your project (XML, JSON, SQL, ect), learn reflection,
  - I/O operations (reading/writing from/to files)
- OOP:
  - classes, objects, access modifiers, properties, interfaces, inheritance, implementation, polymorphism, and eventually learn the object-oriented design patterns.
- Advanced:
  - LINQ, Collections, Reflection, Generics, Extension Methods, Multi-threading, PLINQ (Parallel LINQ), asynchronous programming with async/await, expression trees, delegates, dynamics, events.

Learn more.

# Learning Sites

- https://refactoring.guru/design-patterns/csharp
- https://dotnettutorials.net/course/dot-net-design-patterns/ 
- https://www.kenneth-truyers.net/2016/02/02/vertical-slices-in-asp-net-mvc/ 

## Design/Patterns

- Repository Pattern and Unit of Work: [Link](https://dev.to/moe23/step-by-step-repository-pattern-and-unit-of-work-with-asp-net-core-5-3l92)


# Readings

- https://www.telerik.com/blogs/modern-tech-stack-for-asp-dotnet-apps
# General Notes

- Style: [Link](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

# Project Instructions

## .NET Console Application

- Creating: https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
- Debugging: https://docs.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code

### Commands

```console
dotnet run
```

# Programming Notes

## Arrays

```csharp
// single
var someList = new string[4]
var groceryList = new string[4] { "milk", "eggs", "cheese" };
groceryList[3] = "apples"; // It makes any change by copy
Array.Resize(ref groceryList, 6); // It operates directly in the array, by memory
public string[] AnotherList;
```

```csharp
// multi-dimensional
var multi = new int[2, 3] { // 2 rows, 3 columns
  { 0, 1, 2 },
  { 4, 5, 6 }
};
```


## Classes

### Class example:
```csharp
public class School {

  // PROPERTIES, with getters/setters, with/without logic
  public string[] aList;
  public string Name { get; set; }
	public List<string> Sauces { get; set; }
  private string _twitterAddress; // backing variable

  // setter with logic in it
  public string TwitterAddress
  {
    // make sure the twitter address starts with @
    get { return _twitterAddress;  }
    set
    {
      if (value.StartsWith("@"))
      {
        _twitterAddress = value;
      }
      else
      {
        // EXCEPTION
        throw new Exception("The Twitter address must begin with @");
      }
    }
  }

  // CONSTRUCTORS, with/without arguments
  // ctor - It creates an empty constructor
  public School()
  {
    Name = "Untitled School";
    TwitterAddress = "@USchool";
		Sauces = new List<string>();

  }

  // METHODS, with/without overload, with/without override
  // 01
  public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
  
  // 02
  public static int AverageThreeScores(int a, int b, int c)
  {
    var result = (a + b + c) / 3;
    return result;
  }

  // 03
  public bool IsSauceAwesome(string sauce)
  {
    return Sauces.Contains(sauce);
  }

  // 04
  public override string ToString()
  {
      var sb = new StringBuilder();
      sb.AppendLine(Name);
      return sb.ToString();
  }
}
```

## Collections
[External Link ↗](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections#kinds-of-collections)
### Generic
- Dictionary, List, Queue, SortedList, Stack.
- `new List<T>()` which `<T>` means a "generic", it can take a "type", any primitive/class/somethig, as part of its declaration.

```csharp
var testList = new List<string>();
var dictionaryWord = new Dictionary<string, int>(); // from implicit 0 elements on
```

### Concurrent
- The classes in the System.Collections.Concurrent namespace should be used instead of the corresponding types in the System.Collections.Generic and System.Collections namespaces whenever multiple threads are accessing the collection concurrently.
### Simple
- ArrayList, Hashtable, Queue, Stack.

## (Some) Concepts
- Strongly typed: The type of data MUST be declared (eg. In an array).
 
## Unit Testing
- Part of the AGILE Development.
- Integral part of Test-Driven Development (TDD).
- The goal is to get 100% coverage over the tested methods.
- [Short video ↗](https://www.linkedin.com/learning/c-sharp-essential-training-2-flow-control-arrays-and-exception-handling/what-is-unit-testing)
- Workflow:
  - Create or change code. →
  - Create a repeatable test. →
  - Review results. →
  - (Repeat the process as many times as you need/want.) ←

### Unit Testing example:
```csharp
namespace EssentialTrainingTests
{
	[TestClass]
	public class SimpleArrayTest
	{
		[TestMethod]
		public void TestInstantiation()
		{
			var testInstance = new SimpleArray();
			Assert.AreEqual(testInstance.GroceryList.Length, 4);
			Assert.AreEqual(testInstance.GroceryList[1], "milk");
		}

		[TestMethod]
		public void TestToString()
		{
			var testInstance = new SimpleArray();
			Assert.IsTrue(testInstance.ToString().StartsWith("There are")); // expect true
			Assert.IsFalse(testInstance.ToString().StartsWith("I like potatoes")); // expect false
		}
	}
}
```

# Code Notes

## Function-bodied expressions

```csharp
public float Score { 
  get => throw new NotImplementedException(); 
  set => throw new NotImplementedException();
}
```

```csharp
public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
```

## Overriding

```csharp
// And StringBuilder example
public override string SendMessage(string message)
{
    var original = base.SendMessage(message);
    var sb = new StringBuilder(original);
    sb.AppendLine("This message is private and confidential.");
    sb.AppendLine("(This is a new line.)");
    sb.Append("{This is appending a line.}");
    sb.AppendLine("[This is a new line again.]");
    return sb.ToString();
}
```

# Language Keywords, Concepts

## `abstract`
- Implementation is mandatory.
- Virtual method:
  - Implementation is optional.
  - They can be used as they are or they can do additional actions.

## Access Modifiers
- It enables "encapsulation".
- [StackOverflow ↗](https://stackoverflow.com/questions/614818/in-c-what-is-the-difference-between-public-private-protected-and-having-no)

| Keyword | Description |
| - | - |
| public | The type or member can be accessed by any other code in the same assembly or another assembly that refernces it. It can be seen from inside other projects. |
| private | The type or member can only be accessed by code in the same class or struct.|
| protected | The type or member can only be accessed by code in the same class or struct, or in a derived class. |
| private protected (added in C# 7.2) | The type or member can only be accessed by code in the same class or struct, or in a derived classfrom the same assembly, but not from another assembly. |
| internal | The type or member can be accessed by any code in the same assembly, but not from another assembly. |
| protected internal | The type or member can be accessed by any code in the same assembly, or by any derived class in another assembly. |


| ![image](img/access-modifiers.png) |
| :--------------------------------: |
|             *Schema.*              |

If you struggle to remember the two-worded access modifiers, remember outside-inside:
- `private protected`: `private` outside (the same assembly), `protected` inside (same assembly).
- `protected internal`: `protected` outside (the same assembly), `internal` inside (same assembly).

## Auto-properties

- They can have logic in it.
```csharp
public class ScoreUtility {
  public string Name { get; set; }
}
```
Which is the same threading:
```csharp
public class Genre {
  private string name; // "backing field", contain the actual data.
  public string Name // This is the property.
  {
    get { return this.name; } // accesor, returns
    set { this.name = value; } // mutator, assigns

    // or

    get => name;
    set => name = value;
  }
}
```


## Extension Methods
- It allows to extend any class, and give to it new methods, without needing access to the source code and without subclassing.
- It has to be `static`.
- The `this` keyword allows to associate the extension class with whatever is extending, in this clase, with `string`.
```csharp
namespace SchoolLibrary
{
  public static class ExtensionMethods
  {
    public static int WordCount(this string str)
    {
      var wordCount = str.Split(
        new char[] { ' ', '.', '?' },
        StringSplitOptions.RemoveEmptyEntries
        ).Length;
      return wordCount;
    }
  }
}
```

## `interface`
- Set of behaviours.
- It allows to require a class to implement certain properties and methods signatures, under a same name.
- It acts as a contract between developers.
- They help to reduce overload methods.
- They work with abstract classes too.

```csharp
namespace SchoolLibrary
{
  public interface IScored
  {
    float Score { get; set; }
    float MaximumScore { get; set; }
  }
}
```

```csharp
namespace SchoolLibrary
{
  public class ScoreUtility
  {
    public static IScored BestOfTwo(IScored assignmentOne, IScored assignmentTwo)
    {
      var scoreOne = assignmentOne.Score / assignmentOne.MaximumScore;
      var scoreTwo = assignmentOne.Score / assignmentOne.MaximumScore;

      if(scoreOne > scoreTwo) {
          return assignmentOne;
      } else {
        return assignmentTwo;
      }
    }
  }
}
```

## LINQ (Language Integrated Query)
- It's a feature set.
- Set of extension classes/methods that hook pretty much any kind of collection.

### Code Example:
```csharp
var listOfNumbers = new int[5] { 1, 3, 5, 7, 11 };
listOfNumbers.Sum() // 27
listOfNumbers.Average() // 5.4
listOfNumbers.Where(item => item > 5) // Enumerable.WhereArrayIterator<int> { 7, 11 }
```

### Extension Methods:
- You can add methods to something, even though you don't have access to the original source code.
- Extension methods allow developers to add new methods to the public contract of an existing CLR type, without having to sub-class it or recompile the original type.
- Extension Methods help blend the flexibility of "duck typing" support popular within dynamic languages today with the performance and compile-time validation of strongly-typed languages.
- [Additional information ↗](https://stackoverflow.com/a/403556/7389293)

## `namespace`
- They are packages in Java.
- Used for avoiding "namespace collision".
## `public`
- 
## `static`
- Used for none-instanciable methods. They belong to the class alone.
## `this`
- Current object.

## `virtual`

- It is used when we want to have an implementation and use it later ina subclass through an override.


# Books

- Microsoft Enterprise architecture,
- Clean code architectures and vertical slice
- clean code Domain driven design and vertical slice

# Courses


## C# Path: `Become a C# Developer`

### Courses:
- _C# Essential Training: 1 Syntax and Object Oriented Programming_, with Bruce Van Horn | [Course Assignments →](courses/SchoolApp/)
- _C# Essential Training: 2 Flow Control, Arrays, and Exception Handling_, with Bruce Van Horn | [Course Assignments →]()
- _Code Clinic: C#_, with | [Course →]()
- _C# Algorithms_, with | [Course →]()
- _C#: Design Patterns Part 1_, with | [Course →]()
- _Nail Your C# Developer Interview_, with | [Course →]()
- Other Courses:
  - _Visual Studio Essential Training series_, with Walt Ritscher.
  - _C# Test Driven Development_, with Reynald Adolphe.
  - _C# Object-Oriented Programming Tips and Tricks_, with Jesse Freeman. 

### Links:
  - https://www.linkedin.com/learning/paths/become-a-c-sharp-developer?u=2153100
  - [courses/README.md →](courses/README.md)

## Basic Programming
- _Programming Foundations: Fundamental_, with Simon Allardice
- _Programming Foundations: Object-Oriented Design_, with Simon Allardice
- _Introduction to Object-Oriented Languages_, with Simon Allardice

## Other C# Courses
- _LINQ with C# Essential Training_, with 