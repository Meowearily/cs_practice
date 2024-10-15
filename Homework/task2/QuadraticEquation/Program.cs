using System;

double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double c = Convert.ToInt32(Console.ReadLine());

Equations solver = new Equations(a, b, c);

solver.HowManyRoots();