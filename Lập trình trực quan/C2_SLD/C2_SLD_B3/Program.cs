namespace C2_SLD_B3
{
    class diem2d
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public diem2d() { }

        public diem2d(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void nhap()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("x: " + x + " - y: " + y);
        }

        public static double khoangCach(diem2d a, diem2d b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
