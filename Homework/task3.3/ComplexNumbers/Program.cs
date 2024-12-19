using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


ComplexNumber a = new ComplexNumber(1, -1);
ComplexNumber b = new ComplexNumber(2, 3);

Console.WriteLine(-a);
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(string.Format("{0:F3}",ComplexNumber.Abs(a)));
Console.WriteLine(string.Format("{0:F3}", ComplexNumber.Angle(a)));
Console.WriteLine(ComplexNumber.Pow(a, 2));
Console.WriteLine(ComplexNumber.Sqrt(a, 2));
