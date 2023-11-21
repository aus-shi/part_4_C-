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

// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

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
// double bigNumber = 10.75;  // This is a big number
// int smallNumber = (int)bigNumber;  // Explicit conversion: Big to Small

// Console.WriteLine($"Big Number: {bigNumber}");
// Console.WriteLine($"Small Number: {smallNumber}");

/* Perform operations on arrays using helper methods in C#  */
//Sorting the order of values in array
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets); //Sort helper
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// //Reversing the order of pallets
// Console.WriteLine("");
// Console.WriteLine("Reverse order....");
// Array.Reverse(pallets);

// foreach (var pallett in pallets)
// {
//     Console.WriteLine($"-- {pallett}");
// }

//Use array methods to clear and resize an array
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2); //(array, index to clear, how many index needs to be cleared)
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Empty string versus null
// When you use Array.Clear(), the elements that were cleared no longer reference a string in memory. In fact, the element points to nothing at all.
//  pointing to nothing is an important concept that can be difficult to grasp at first.
// What if you attempt to retrieve the value of an element that was affected by the Array.Clear() method, could you do it?


//Acess the value of cleared element
//Exception will be thrown bcs of the null value
//It is better to check for null first before accessing the element
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// //Calculating null in pallets
// int totalNull = 0;
// foreach (var pallet in pallets)
// {
//     if (pallet == null)
//     {
//         totalNull += 1;
//     }
// }
// Console.WriteLine($"\nTotal null:...{totalNull}");


/* Exercise - Discover Split() and Join() */

// string value = "abc123"; //string
// char[] valueArray = value.ToCharArray(); //change the string to char array
// Array.Reverse(valueArray); //Sort desc the valueArray
// string result = new string(valueArray); //Change the valueArray into a string
// Console.WriteLine(result);

/* Combine all of the chars into a new comma-separated-value string using Join() */

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

/* Split() the comma-separated-value string into an array of strings */
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

/* Exercise - Complete a challenge to reverse words in a sentence */

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);


/* Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors */

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderStreamArray = orderStream.Split(",");

// Array.Sort(orderStreamArray);

// foreach (var orders in orderStreamArray)
// {
//     if (orders.Length != 4)
//     {
//         // Console.WriteLine($"{orders} - Error");
//         Console.WriteLine(orders + "\t- Error");
//     }
//     else
//     {
//         Console.WriteLine(orders);
//     }
// }


/* Format alphanumeric data for presentation in C# */
/*Exercise - Investigate string formatting basics*/
/* 1. This is called Composite Formatting*/
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

/* 2. This is called, string interpolation */
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

/* 3. Formatting currency */
/* The currency is based on your PC region/country settings */
// decimal price = 123.45m;
// int discount = 50;
// decimal discounted = price - discount;
// Console.WriteLine($"Price: {price:C} (Save {discount:C}), After discounted price: {discounted:C}");

/* 4. Formatting numbers */
// The N numeric format specifier makes numbers more readable.
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units"); //uses N, numeric format specifier

// //To display with more precision, example: up to 4 decimal places: use N4
// Console.WriteLine($"Measurement: {measurement:N4} units");

/* 5. Formatting percentage */
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P4}");

/* 6. Combining formatting approaches */
//Using Composite formatting
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount);


/* Using string interpolation, no need to use String.Format() */
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

/* Display the invoice number using string interpolation */
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");


/* Exercise - Discover padding and alignment */
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

/* Formatting strings by adding whitespace before or after */
// string input = "Pad this";
//  Console.WriteLine(input.PadLeft(12));
//  Console.WriteLine(input.PadRight(12));

/* Overloaded Method */
// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));


/* Exercise - Working with padded strings */
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";
// string myWords = "Learning C#";
// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine(formattedLine);
// Console.WriteLine(myWords.PadLeft(12));
// Console.WriteLine("1234567890123456789012345678901234567890");

/* Exercise - Complete a challenge to apply string interpolation to a form letter */
//Desired output//
/* 
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   $55,000,000.00      
Glorious Future     13.13 %   $63,000,000.00
*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

string currentReturnString = $"{currentReturn:P2}";
string newReturnString = $"{newReturn:P2}";
string currentProfitString = $"{currentProfit:C2}";
string newProfitString = $"{newProfit:C2}";

string comparisonMessage = "";
string comparisonMessage2 = "";
Console.WriteLine($"Dear {customerName}. As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:C3} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:C2}. Given your current volumne, your potential profis would be {newProfit:C6}");
// Your logic here
Console.WriteLine("Here's a quick comparison:\n");

comparisonMessage += currentProduct.PadLeft(11);
comparisonMessage += currentReturnString.PadLeft(18);
comparisonMessage += currentProfitString.PadLeft(20);

comparisonMessage2 += newProduct.PadLeft(11);
comparisonMessage2 += newReturnString.PadLeft(14);
comparisonMessage2 += newProfitString.PadLeft(20);

// Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(comparisonMessage);
Console.WriteLine(comparisonMessage2);