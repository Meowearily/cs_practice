using System;

class Number
{
    public int num = Convert.ToInt32(Console.ReadLine());

    public void Print()
    {
        Console.WriteLine($"Вы ввели число: {num}");
    }

    public bool IsThreeRank()
    {
        return !((num / 1000 > 0) || (num / 100 % 10 == 0));
    }
    public int Units()
    {
        return num % 10;
    }

    public int Tens()
    {
        return num / 10 % 10;
    }

    public int Hundreds()
    {
        return num / 100 % 10;
    }

    public int Sum()
    {
        return this.Units() + this.Tens() + this.Hundreds();
    }

    public int Product()
    {
        return this.Units() * this.Tens() * this.Hundreds();
    }
}
