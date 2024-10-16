using System;

//Введите сюда массив
//int[] array = {9, 6, 8, 3, 2, 1, 7, 5, 4};

string arrayString;
Console.WriteLine("Введите элементы массива через пробел:");
arrayString = Console.ReadLine();
int[] array = Array.ConvertAll(arrayString.Split(' '), int.Parse);

Sort solver = new Sort(array);
solver.BubbleSort(array);