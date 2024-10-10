using System;

Number entry_num = new Number();
entry_num.Print();

if (entry_num.IsThreeRank())
{
    Console.WriteLine($"Число единиц в введеном числе: {entry_num.Units()}");
    Console.WriteLine($"Число десятков в введеном числе: {entry_num.Tens()}");
    Console.WriteLine($"Сумма цифр в введеном числе: {entry_num.Sum()}");
    Console.WriteLine($"Произведение цифр в введеном числе: {entry_num.Product()}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
