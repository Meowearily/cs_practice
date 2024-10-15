using System;

class PrimeNum
{
    int num = Convert.ToInt32(Console.ReadLine());

    //public static int Sqrt(int num);
    public void IfPrimeNum()
    {
        int counter = 0;

        for (int i=1; i<=num; i++)
        {
            for (int j = 1; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0) { counter++; }
            }

            if (counter == 1)
            {
                Console.WriteLine(i);
            }

            counter = 0;
        }
    }
}
