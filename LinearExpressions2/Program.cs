using System.Runtime.CompilerServices;
double
    // 1 - ий приклад
    z1, z2, m, n, a, b, x, y, sin;
Console.WriteLine("enter number m");
m = double.Parse(Console.ReadLine());
Console.WriteLine("enter number n");
n = double.Parse(Console.ReadLine());
z1 = ((m - 1) * (Math.Sqrt(m)) - (n - 1) * (Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n)) + n * m + (Math.Pow(m, 2)) - m;
Console.WriteLine(z1);
z2 = (Math.Sqrt(m)) - (Math.Sqrt(n)) / m;
Console.WriteLine(z2);
//2 - ий приклад
Console.WriteLine("enter number x");
x = double.Parse(Console.ReadLine());
Console.WriteLine("enter number b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("enter number a");
a = double.Parse(Console.ReadLine());
sin = double.Parse(Console.ReadLine());
y = 2.4 * (Math.Abs((Math.Pow(x, 2) + b) / a)) + (a - b) * (Math.Pow(sin, 2)) * (a - b) + (Math.Pow(10, -2)) * (x - b);
Console.WriteLine(y);
