namespace C2_OOP_B4
{
    class Mang1Chieu
    {
        private int n;
        private int[] a;

        public Mang1Chieu() { }

        public Mang1Chieu(int n)
        {
            this.n = n; 
            a = new int[n];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap mang");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.WriteLine("In mang");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public void SapXep(int thutu)
        {
            if (thutu == 0) Array.Sort(a);
            else Array.Reverse(a);
        }

        public int TimKiem(int m)
        {
            for (int i = 0; i < a.Length;i++)
            {
                if (a[i] == m) return i;
            }

            return -1;
        }
    }
}