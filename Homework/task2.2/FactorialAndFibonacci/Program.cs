using System;
using System.Diagnostics;

System.Numerics.BigInteger number = Convert.ToInt32(Console.ReadLine());
System.Numerics.BigInteger temp;

Factorial solverFa = new Factorial(number);
Fibonacci solverFi = new Fibonacci(number);
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
temp = solverFa.FactorialRecursion(number);
stopwatch.Stop();
Console.WriteLine($"Факториал от числа {number} (рекурсивно): {temp}, время выполнения: {stopwatch}");
stopwatch.Reset();

stopwatch.Start();
temp = solverFa.FactorialIteration(number);
stopwatch.Stop();
Console.WriteLine($"Факториал от числа {number} (итеративно): {temp}, время выполнения: {stopwatch}");
stopwatch.Reset();

//начиная с около 300-х время вычисления становится на порядок больше

stopwatch.Start();
temp = solverFi.FibonacciRecursion(number);
stopwatch.Stop();
Console.WriteLine($"Число Фибоначчи с номером {number} (рекурсивно): {temp}, время выполнения: {stopwatch}");
stopwatch.Reset();

stopwatch.Start();
temp = solverFi.FibonacciIteration(number);
stopwatch.Stop();
Console.WriteLine($"Число Фибоначчи с номером {number} (итеративно): {temp}, время выполнения: {stopwatch}");
stopwatch.Reset();

//начиная с около 20-х время вычисления становится на порядок больше...так быстро?