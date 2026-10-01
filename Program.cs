// See https://aka.ms/new-console-template for more information
#region 1
//1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
// passing by value make a copy of the variable value and it doesn't effect the original variable, passing by reference it pass the original variable address so any changes
// happen to the original variable.

//static void change(int x)
//{
//    x = 100;
//}
//int num = 10;
//change(num);
//Console.WriteLine(num);

//static void changeref(ref int x)
//{
//    x = 100;
//}
//changeref(ref num);
//Console.WriteLine(num);

//static void changeout(out int x)
//{
//    x = 1000;
//}
//changeout(out num);
//Console.WriteLine(num);
#endregion

#region 2
////2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
//// passing by value when creat new object only the local one change no the original. passing by value when creat new object original value change as well.

//names n1 = new names();
//n1.name = "A";
//Console.WriteLine($"class before any function: {n1.name}");

//changebyval(n1);
//Console.WriteLine($"class after changebyval function: {n1.name}");

//changebyref(ref n1);
//Console.WriteLine($"class after changebyref function: {n1.name}");

//static void changebyval(names n)
//{
//    n = new names();
//    n.name = "B";
//    Console.WriteLine($"inherit class inside changebyval function: {n.name}");
//}

//static void changebyref(ref names n)
//{
//    n = new names();
//    n.name = "C";
//    Console.WriteLine($"inherit class inside changebyref function: {n.name}");
//}

//class names
//{
//    public string? name;
//}
#endregion

#region 3
////4- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

//Console.WriteLine("Enter 1st Number");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter 2nd Number");
//double num2 = Convert.ToDouble(Console.ReadLine());
//double sum, diff;

//calculate(num1, num2, out sum, out diff);

//Console.WriteLine($"summtion is: {sum}");
//Console.WriteLine($"Difference is: {diff}");

//static void calculate(double num1, double num2, out double sum, out double substract)
//{
//    sum = num1 + num2;
//    substract = num1 - num2;
//}

#endregion

#region 4
//4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
//Output should be like 
//Enter a number: 25
//The sum of the digits of the number 25 is: 7

//Console.WriteLine("Enter your number");
//int num = int.Parse(Console.ReadLine()!);
//int sum = sumofnumbers(num);
//Console.WriteLine($"The summition of your number is: {sum}");
//static int sumofnumbers(int var)
//{
//    int sum = 0;
//    while (var > 0)
//    {
//        sum += var % 10;
//        var /= 10;
//    }
//    return sum;
//}

#endregion

#region 5
//Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

//Console.WriteLine("Enter your number to check");
//int num = int.Parse(Console.ReadLine()!);

//if (isprime(num))
//{
//    Console.Write("The number is Prime");
//}
//else
//{
//    Console.Write("The number is not Prime");

//}
//static bool isprime(int num)
//{
//    if (num <= 1) return false;

//    for (int i = 2; i <= num; i++)
//    {
//        if (num % i == 0) return false;
//    }
//    return true;
//}
#endregion

#region 6
//6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
//int[] array1 = { 1, 5, 6, 8, 12, 69, 47, 32 };
//int min = 0;
//int max = 0;
//MinMaxArray(array1, ref min, ref max);
//Console.WriteLine($" the array is: [{string.Join(",", array1)}]");
//Console.WriteLine($" the max number is: {max}");
//Console.WriteLine($" the smallest number is: {min}");

//static void MinMaxArray(int[] arr, ref int min, ref int max)
//{
//    min = arr[0];
//    max = arr[0];
//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] < min)
//        {
//            min = arr[i];
//        }
//        else if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//}
#endregion

#region 7
////7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
//Console.WriteLine("Enter your number");

//int factorial = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"your factorial result is: {factorialfunc(factorial)}");


//static long factorialfunc(int n)
//{
//    long result = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        result *= i;
//    }
//    return result;
//}

#endregion

#region 8
//8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
//using System.Text;

//Console.WriteLine("Enter your text");
//string? text = Console.ReadLine();

//Console.WriteLine("Select which letter to change");
//int position = text!.IndexOf(Console.ReadLine()!);

//Console.WriteLine("what is the new letter");
//char newChar = Convert.ToChar(Console.ReadLine()!);


//string updatedText = ChangeChar(text, position, newChar);
//Console.WriteLine($"The new text is:> {updatedText}");

//static string ChangeChar(string str, int index, char chr)
//{
//    StringBuilder sb = new StringBuilder(str);
//    sb[index] = chr;
//    return sb.ToString();
//}

#endregion

#region Enum-1
//Console.WriteLine("Enter week day number");
//byte day = Convert.ToByte(Console.ReadLine());
//if (Enum.IsDefined(typeof(WeekDays), (int)day))
//{
//    Console.WriteLine($"week day is: {(WeekDays)day}");
//}
//else
//{
//    Console.WriteLine("Wrong number, Enter only 0 to 6");
//}
//enum WeekDays
//{
//    Saturday,
//    Sunday,
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday
//}

#endregion

#region struct 2
////2- Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
//Person[] people = new Person[3];
//people[0] = new Person("A", 25);
//people[1] = new Person("B", 30);
//people[2] = new Person("C", 22);
//Console.WriteLine("people list:");
//foreach (Person p in people)
//{
//    Console.WriteLine($"person name : {p.Name} | age : {p.Age}");
//}
//struct Person(string s, int i)
//{
//    public string Name { get; set; } = s;
//    public int Age { get; set; } = i;
//} 
#endregion

#region Enum 3
////3- Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
////Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
////Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
//Console.WriteLine("Enter Season name (Spring, Summer, Autumn, Winter):");
//string? userInput = Console.ReadLine();

//if (Enum.TryParse(userInput, true, out Season chosenSeason))
//{
//    switch (chosenSeason)
//    {
//        case Season.Spring:
//            Console.WriteLine("Spring range: March - April - May");
//            break;

//        case Season.Summer:
//            Console.WriteLine("Summer range: June - Jule - August");
//            break;

//        case Season.Autumn:
//            Console.WriteLine("Autumn range: September - October - November");
//            break;

//        case Season.Winter:
//            Console.WriteLine("Winter range: December - January - February");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Season name is not correct");
//}
//enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//} 
#endregion

#region Enum 4
// Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
//Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

//Permissions myPermissions = Permissions.Read | Permissions.Execute;
//Console.WriteLine($"current permission: {myPermissions}");

//myPermissions |= Permissions.Write;
//Console.WriteLine($"after writing: {myPermissions}");

//myPermissions &= ~Permissions.Execute;
//Console.WriteLine($"after delete: {myPermissions}");

//bool hasDelete = myPermissions.HasFlag(Permissions.Delete);
//Console.WriteLine($"can delete? {hasDelete}");

//[Flags]
//enum Permissions
//{
//    None = 0,
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}
#endregion

#region Enum 5
//Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
//Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

//Console.WriteLine("Enter Color name");
//string? input = Console.ReadLine();

//if (Enum.TryParse(input, true, out Colors chosenColor))
//{
//    Console.WriteLine($"{chosenColor} is a primary color.");
//}
//else
//{
//    Console.WriteLine($"\"{input}\" is not a primary color");
//}
//enum Colors
//{
//    Red,
//    Green,
//    Blue
//}

#endregion

#region Enum 6
////Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
////Write a C# program that takes two points as input from the user and calculates the distance between them.

//Console.WriteLine(" Enter first point (X1 then Y1)");
//double x1 = Convert.ToDouble(Console.ReadLine());
//double y1 = Convert.ToDouble(Console.ReadLine());
//Point p1 = new Point(x1, y1);

//Console.WriteLine(" Enter second point (X1 then Y1)");
//double x2 = Convert.ToDouble(Console.ReadLine());
//double y2 = Convert.ToDouble(Console.ReadLine());
//Point p2 = new Point(x2, y2);

//double distance = CalculateDistance(p1, p2);
//Console.WriteLine($"Distance between the two points is : {distance:F2}");
//static double CalculateDistance(Point p1, Point p2)
//{
//    double deltaX = p2.X - p1.X;
//    double deltaY = p2.Y - p1.Y;

//    return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
//}
//struct Point
//{
//    public double X;
//    public double Y;

//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//}

#endregion

//7. Create a struct called "Person" with properties "Name" and "Age".
//Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


#region Enum 7
//Person[] people = new Person[3];
//for (int i = 0; i < people.Length; i++)
//{
//    Console.WriteLine($"\n Enter Data for person number : {i + 1}:");

//    Console.Write("name: ");
//    string? name = Console.ReadLine();

//    Console.Write("age: ");
//    int age = Convert.ToInt32(Console.ReadLine());

//    people[i] = new Person(name!, age);

//    Person oldest = people[0];
//    for (int i = 1; i < people.Length; i++)
//    {
//        if (people[i].Age > oldest.Age)
//        {
//            oldest = people[i];
//        }
//    }

//    Console.WriteLine($"\n The Eldest person is : {oldest.Name} who's {oldest.Age} years old.");

//}
//struct Person(string name, int age)
//{
//    public required string Name;
//    public int Age;
//} 
#endregion