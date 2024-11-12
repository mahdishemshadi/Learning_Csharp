int count = 10;
byte number = 25;
char character = 'A';
bool isWorking = true;
float totalPrice = 20.95f;
string firstName = "Madhi";
const string fullName = "Mahdi Shemshadi";

Console.WriteLine("Hello, World!");

Console.WriteLine("Working with variables");
Console.WriteLine(number);
Console.WriteLine(count);
Console.WriteLine(character);
Console.WriteLine(isWorking);
Console.WriteLine(totalPrice);
Console.WriteLine(firstName);

Console.WriteLine("Working with format string");
Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);

Console.WriteLine("Working with const variables");
Console.WriteLine("My name is {0}", fullName);