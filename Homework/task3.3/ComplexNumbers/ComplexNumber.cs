using System;

class ComplexNumber
{
    double a, b;
    public ComplexNumber(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    //public ComplexNumber(double a, double b, double c, double d)
    //{
    //    this.a = a;
    //    this.b = b;
    //    this.c = c;
    //    this.d = d;
    //}

    public ComplexNumber ComplexSum(ComplexNumber other)
    {
        return new ComplexNumber(a + other.a, b + other.b);
        //Console.WriteLine($"Сумма: {a + other.a} + ({b + other.b})i");
    }
    public void ComplexSubtraction(double a, double b, double c, double d)
    {
        Console.WriteLine($"Разность: {a - c} + ({b - d})i");
    }
    public void ComplexMupltiplication(double a, double b, double c, double d)
    {
        Console.WriteLine($"Умножение: {a*c - b*d} + ({a*d + b*c})i");
    }
    public void ComplexDivision(double a, double b, double c, double d)
    {
        Console.WriteLine($"Деление: {(a*c + b*d)/(c*c+d*d)} + ({(b*c - a*d) / (c * c + d * d)})i");
    }
    public void ComplexModule(double a, double b)
    {
        Console.WriteLine($"Модуль: {Math.Sqrt(a*a+b*b)}");
    }
    public void ComplexAngle(double a, double b)
    {
        Console.WriteLine($"Угол: {Math.Atan(b/a)}");
    }
    public void ComplexPow(double a, double b, double k)
    {
        double module = Math.Sqrt(a*a + b*b);
        double angle = b / a;

        Console.WriteLine($"Возведение в степень: {a + c} + ({b + d})i");
    }
    public void ComplexSqrt(double a, double b, double k)
    {
        Console.WriteLine($"Извлечение корня: {a + c} + ({b + d})i");
    }
}