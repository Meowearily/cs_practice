using System;

class Fibonacci
{
    System.Numerics.BigInteger num;
    System.Numerics.BigInteger f1=0, f2=1;
    public Fibonacci(System.Numerics.BigInteger num)
    {
        this.num = num;
    }

    public System.Numerics.BigInteger FibonacciRecursion(System.Numerics.BigInteger num)
    {
        if (num == 0 || num == 1) return num;
        return FibonacciRecursion(num - 1) + FibonacciRecursion(num - 2);
    }

    public System.Numerics.BigInteger FibonacciIteration(System.Numerics.BigInteger num)
    {
        for (System.Numerics.BigInteger i = 1; i < num; i++)
        {
            f2 = f2 + f1;
            f1 = f2 - f1;
        }

        return f2;
    }
}