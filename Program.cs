int count = 10;
byte number = 25;
char character = 'A';
bool isWorking = true;
float totalPrice = 20.95f;
string firstName = "Madhi";
const string fullName = "Mahdi Shemshadi";

Console.WriteLine("Hello, World!");

Console.WriteLine("\nWorking with variables");
Console.WriteLine(number);
Console.WriteLine(count);
Console.WriteLine(character);
Console.WriteLine(isWorking);
Console.WriteLine(totalPrice);
Console.WriteLine(firstName);

Console.WriteLine("\nWorking with format string");
Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);

Console.WriteLine("\nWorking with const variables");
Console.WriteLine("My name is {0}", fullName);

Console.WriteLine("\nWorking with type conversions");
byte b = 1;
int i = b;
Console.WriteLine(i);

int i1 = 2024;
byte b1 = (byte)i1;
Console.WriteLine(b1);

string status = "Good";
int i2 = Convert.ToInt32(status);
Console.WriteLine(i2);