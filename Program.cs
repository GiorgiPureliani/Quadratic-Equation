namespace Project5
{
    internal class Program
    {
        static void Main()
        {
            QuadraticEquation gantoleba = new QuadraticEquation();
            Console.Write("a = ");
            gantoleba.SetA(Convert.ToDouble(Console.ReadLine()));

            Console.Write("b = ");
            gantoleba.SetB(Convert.ToDouble(Console.ReadLine()));

            Console.Write("c = ");
            gantoleba.SetC(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($"D = {gantoleba.GetD()}");

            Console.WriteLine($"X1, X2 = {gantoleba.GetRoots()}");

        }
    }
    class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        #region Getters and Setters

        public double GetA()
        {
            return _a;
        }
        public void SetA(double a)
        {
            if (a == 0)
            {
                throw new Exception("a can not be set to zero");
            }
            else
            {
                _a = a;
            }
        }
        public double GetB()
        {
            return _b;
        }
        public void SetB(double b)
        {
            _b = b;
        }
        public double GetC()
        {
            return _c;
        }
        public void SetC(double c)
        {
            _c = c;
        }
        #endregion
        public double GetD()
        {
            return Math.Pow(GetB(), 2) - (4 * GetA() * GetC());
        }
        public double? GetX1()
        {
            return (-GetB() + Math.Sqrt(GetD())) / (2 * GetA());
        }
        public double? GetX2()
        {
            return (-GetB() - Math.Sqrt(GetD())) / (2 * GetA());
        }
        public (double?, double?) GetRoots()
        {
            if (GetD() >= 0 & GetX1() > GetX2())
            {
                return (GetX1(), GetX2());
            }
            else
            {
                return (null, null);
            }
        }
    }
}