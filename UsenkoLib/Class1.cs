namespace UsenkoLib
{
    public class Class1
    {
        public double Zfunc1(double x, double y, double a)
        {
            return (2 * y) + ((2 * 3 * a) / ((10 * x) - (3 * a))) + (2 * a);
        }
    }
    public class Class2
    {
        public double Zfunc2(double x2, double y2, double a2)
        {
            return Math.Round(7 + (((a2 * x2) / (2 * y2)) / ((3 + a2) / x2)) * y2 - (((2 * x2) + y2 + x2 - (3 * a2)) / (a2 + x2 - (8 * y2))));
        }
    }
}
