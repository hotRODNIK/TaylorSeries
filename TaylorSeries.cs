// Currently implements the Taylor series for e^x

using System;
public class TaylorSeries
{
    private LinkedList l;
    private int upperLim, lowerLim;

    public int LowerLim
    {
        set 
        {
            if (value < 0)
                this.lowerLim = 0;
            else
                this.lowerLim = value;
        }
    }

    public int UpperLim
    {
        set 
        {
            if (value < 0)
                this.upperLim = 0;
            else
                this.upperLim = value;
        }
    }

    private static double Factorial(double num)
    {
        if (num == 0)
            return 1;
        else
            return num * Factorial(num - 1);
    }

    // Ensure the value for x is within the radius of convergence
    public TaylorSeries(int upper, double x)
    {
        this.lowerLim = 0;
        this.upperLim = upper;
        this.l = new LinkedList();

        for (int i = 0; i <= upper; i++)
            this.l.AddFront(new SeriesTerm(1, Factorial(i), Math.Pow(x, i)));
    }

    public double SumSeries()
    {
        return l.Sum();
    }
}