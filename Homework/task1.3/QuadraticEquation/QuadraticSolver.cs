using System;

class Equations
{
    double a, b, c;
    double x1, x2;

    public Equations(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void HowManyRoots()
    {
        if (a == 0)
        {
            Linear();
        } else
        {
            Quadratic();
        }
    }

    public void Linear()
    {
        if (b == 0)
        {
            if (c == 0)
            {
                Console.WriteLine("бесконечно много корней");
            }
            else
            {
                Console.WriteLine("корней нет");
            }
        } else
        {
            x1 = -c / b;
            Console.WriteLine($"один корень: {x1}");
        }
    }

    public void Quadratic()
    {
        double d = Math.Pow(b, 2) - 4*a*c;

        if (d < 0)
        {
            Console.WriteLine("нет вещественных корней");
        } else if (d == 0)
        {
            x1 = (-b / (2 * a));
            Console.WriteLine($"один корень: {x1}");
        } else
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"два корня: {x1}, {x2}");
        }
    }
}