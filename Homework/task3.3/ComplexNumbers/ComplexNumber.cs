using System;

class ComplexNumber
{
    double Re, Im;
    public ComplexNumber(double Re, double Im)
    {
        this.Re = Re;
        this.Im = Im;
    }

    public override string ToString()
    {
        return String.Format("{0:F3}+{1:F3}i", Re, Im);
    }


    public static ComplexNumber operator -(ComplexNumber first) => new ComplexNumber(-first.Re, -first.Im);

    public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second) 
        => new ComplexNumber(first.Re+second.Re, first.Im+second.Im);

    public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
        => new ComplexNumber(first.Re - second.Re, first.Im - second.Im);

    public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        => new ComplexNumber(first.Re*second.Re - first.Im*second.Im, first.Re*second.Im + first.Im*second.Re);

    public static ComplexNumber operator /(ComplexNumber first, ComplexNumber second)
    {
        double temp = Abs(second);
        return new ComplexNumber((first.Re * second.Re + first.Im * second.Im) / temp, (first.Im * second.Re - first.Re * second.Im) / temp);
    }

    public static double Abs(ComplexNumber first) => Math.Sqrt(first.Re*first.Re + first.Im*first.Im);

    public static double Angle(ComplexNumber first) {
        if (first.Re == 0)
        {
            if (first.Im >= 0) return Math.PI / 2;
            else return 3 * Math.PI / 2;
        }
        else if (first.Re > 0)
        {
            if (first.Im >= 0) return Math.Atan(first.Im / first.Re);
            else return Math.Atan(first.Im / first.Re) + 2 * Math.PI;
        }
        else return Math.Atan(first.Im / first.Re) + Math.PI;
    }

    public static ComplexNumber FromTrigonometric(double mod, double angl)
        => new ComplexNumber(mod * Math.Cos(angl), mod * Math.Sin(angl));

    public static ComplexNumber Pow(ComplexNumber first, double k)
    {
        double module = Abs(first);
        double fi = Angle(first);

        return FromTrigonometric(Math.Pow(module, k), k*fi);
    }

    public static ComplexNumber Sqrt(ComplexNumber first, double k)
        => Pow(first, 1 / k);
}