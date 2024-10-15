using System;

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

Equations solver = new Equations(a, b, c);

solver.HowManyRoots();