Console.Write("Enter amount of pounds: ");
double pounds = double.Parse(Console.ReadLine());
double converter = pounds * 1.31;
Console.WriteLine($"{pounds}£ = {converter:F2}$");