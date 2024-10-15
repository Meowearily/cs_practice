using System;
using System.Diagnostics;

class Factorial
{
    System.Numerics.BigInteger num;
    System.Numerics.BigInteger factorial = 1;
    public Factorial(System.Numerics.BigInteger num)
    {
        this.num = num;
    }

    public System.Numerics.BigInteger FactorialRecursion(System.Numerics.BigInteger num)
    {
        if (num == 1) return 1;
        return num * FactorialRecursion(num - 1);
    }

    public System.Numerics.BigInteger FactorialIteration(System.Numerics.BigInteger num)
    {
        for (System.Numerics.BigInteger i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}