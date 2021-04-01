using System;
using System.Text;

public static class MainClass
{
    public static void Main()
    {
        double counter = -2;
        OrderedPairs[] o = new OrderedPairs[400];
        double[] xVals = new double[400];
        double[] yVals = new double[400];

        for (int i = 0; i < xVals.Length; i++)
        {
            xVals[i] = counter;
            counter += 0.01;
        }

        for (int i = 0; i < yVals.Length; i++)
        {
            yVals[i] = new TaylorSeries(5, xVals[i]).SumSeries();
        }

        for (int i = 0; i < o.Length; i++)
        {
            o[i] = new OrderedPairs(xVals[i], yVals[i]);
        }

        dumpArray(o, "out.csv");
        Console.WriteLine("DONE!");
        Console.ReadKey();
    }

    public static void dumpArray(Array arr, string fileName)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
        {
            foreach (Object obj in arr)
            {
                file.Write(obj.ToString() + "\n");
            }
        }
    }
}