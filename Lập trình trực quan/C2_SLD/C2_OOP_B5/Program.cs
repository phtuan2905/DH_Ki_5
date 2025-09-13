namespace C2_OOP_B5
{
    class MaTran
    {
        private int m;
        private int n;
        private int[,] mt;

        public MaTran() { }

        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            mt = new int[m,n];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ma tran");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mt[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine("In ma tran");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mt[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        public static MaTran Cong(MaTran a, MaTran b)
        {
            if (a.m == b.m && a.n == b.n)
            {
                MaTran c = new MaTran(a.m, a.n);
                for (int i = 0; i < a.m;i++)
                {
                    for (int j = 0; j < a.n; j++) 
                    {
                        c.mt[i, j] = a.mt[i, j] + b.mt[i, j];
                    }
                }
                return c;
            }
            else
            {
                return null;
            }
        }
    }
}