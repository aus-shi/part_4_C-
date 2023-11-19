// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// int[] data = new int[3];

// string shortenedString = "Hello world!";
// Console.WriteLine(shortenedString);


/* Convert data types using casting and conversion techniques in C# */

// int first = 23;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);


// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

//Performing a cast
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// Example of narrowing conversion , meaning value become less sensitive
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");


//Use ToString() to convert a number to a string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// int message2 = first + second;
// Console.WriteLine(message);
// Console.WriteLine(message2);

//Convert a string to an int using the Parse() helper method
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Convert a string to a int using the Convert class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);


// // Compare casting and converting a decimal into an int
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

//Exercise - Examine the TryParse() method
// string name = "Bob";
// Console.WriteLine(int.Parse(name)); //unable to convert this string into int, because it is not a digit at all

/*However any error can be catch using TryParse() */
//Example
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}"); //if result is able to changed to int, then the value will != 50

//Example with int value that cant be parsed
// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");


/* Exercise - Complete a challenge to combine string array values as strings and as integers */
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");


/* Exercise - Complete a challenge to output math operations as specific number types */

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
// int  result1 = value1 / (int)value2;
// Console.WriteLine($"Divide value1: {value1} by value2: {value2}, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2: {value2} by value3: {value3}  display the result as a decimal: {result2}");

// float result3 = value3 / (float)value1;
// Console.WriteLine($"Divide value3: {value3} by value1:  {value1}, display the result as a float: {result3:F7}");

//Example of implicit conversion
// int smallNumber = 5;        // This is a small number
// double bigNumber = smallNumber;  // Implicit conversion: Small to Big

// Console.WriteLine($"Small Number: {smallNumber}");
// Console.WriteLine($"Big Number: {bigNumber}");

//Example of explicit conversion
double bigNumber = 10.75;  // This is a big number
int smallNumber = (int)bigNumber;  // Explicit conversion: Big to Small

Console.WriteLine($"Big Number: {bigNumber}");
Console.WriteLine($"Small Number: {smallNumber}");
