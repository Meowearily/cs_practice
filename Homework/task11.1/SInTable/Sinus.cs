using System;

class Sinus
{
    double[][] sinus;

    public void SinusTable(double[] sinus)
    {

    }

    public void Print()
    {
        string path = "f.txt";
        string text = "x sin(x)";

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(text);
        }
    }
}