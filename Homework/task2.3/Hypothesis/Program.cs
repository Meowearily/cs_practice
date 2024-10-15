using System;

int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Гипотеза не работает для нуля и отрицательных чисел");
} else
{
    Hypothesis solver = new Hypothesis(number);

    solver.HypothesisTesting(number);
}