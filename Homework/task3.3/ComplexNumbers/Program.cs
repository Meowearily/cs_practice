using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Что вы хотите сделать? Выберите действие из списка: сумма, разность, умножение, деление, модуль, угол, возведение в степень, извлечение корня");
string str = Console.ReadLine();

if ((str == "модуль")||(str == "угол"))
{
    Console.WriteLine("Введите коэффициенты a и b комплексного числа z1 = a + bi: ");
    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());

    ComplexNumber solver = new ComplexNumber(a, b);

    if (str == "модуль")
    {
        solver.ComplexModule(a, b);
    }
    else if (str == "угол")
    {
        solver.ComplexAngle(a, b);
    }
} else if ((str == "сумма") || (str == "разность") || (str == "умножение") || (str == "деление"))
{
    Console.WriteLine("Введите коэффициенты a и b комплексного числа z1 = a + bi: ");
    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициенты a и b комплексного числа z2 = c + di: ");
    Console.Write("c = ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.Write("d = ");
    double d = Convert.ToDouble(Console.ReadLine());

    ComplexNumber first = new ComplexNumber(a, b);
    ComplexNumber second = new ComplexNumber(c, d);

    if (str == "сумма")
    {
        first.ComplexSum(second);
        //first + second;
    } else if (str == "разность")
    {
        first.ComplexSubtraction(a, b, c, d);
    }
    else if (str == "умножение")
    {
        first.ComplexMupltiplication(a, b, c, d);
    }
    else if (str == "деление")
    {
        first.ComplexDivision(a, b, c, d);
    }
} else if ((str == "возведение в степень") || (str == "извлечение корня"))
{
    Console.WriteLine("Введите коэффициенты a и b комплексного числа z1 = a + bi: ");
    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите в какую степень нужно возвести или корень какой степени нужно извлечь");

    ComplexNumber solver = new ComplexNumber(a, b);
    Console.Write("k = ");
    double k = Convert.ToDouble(Console.ReadLine());

    if (str == "возведение в степень")
    {
        solver.ComplexPow(a, b, k);
    }
    else if (str == "извлечение корня")
    {
        solver.ComplexSqrt(a, b, k);
    }
} else
{
    Console.WriteLine("Вы ввели недопустимое действие");
}