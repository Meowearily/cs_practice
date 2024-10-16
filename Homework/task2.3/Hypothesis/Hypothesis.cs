using System;

class Hypothesis
{
    int num;

    public Hypothesis(int num)
    {
        this.num = num;
    }

    public void HypothesisTesting(int num)
    {
        int counter = 0;
        //Console.WriteLine($"Сейчас число {num}, число замен равно {counter}");

        while (num != 1)
        {
            if (num % 2 == 0)
            {
                num = IfEven(num);
            } else
            {
                num = IfOdd(num);
            }

            counter++;

            //Console.WriteLine($"Сейчас число {num}, число переходов равно {counter}");
        }

        Console.WriteLine($"Число замен равно {counter}");
    }

    public int IfEven(int num)
    {
        num /= 2;
        return num;
    }

    public int IfOdd(int num)
    {
        num = 3 * num + 1;
        return num;
    }
}