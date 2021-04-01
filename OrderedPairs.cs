public class OrderedPairs
{
    public double a, b;

    public OrderedPairs(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override string ToString()
    {
        return this.a.ToString() + ", " + this.b.ToString();
    }
}