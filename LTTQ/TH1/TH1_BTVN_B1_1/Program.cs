namespace TH1_BTVN_B1_1
{
    internal class SinhVien
    {
        public String hoten;
        public DateOnly ngaysinh;
        public double lt;
        public double csdl;
        public double tkw;

        public void Nhap()
        {
            hoten = Console.ReadLine();
            ngaysinh = DateOnly.Parse(Console.ReadLine());
            lt = double.Parse(Console.ReadLine());  
            csdl = double.Parse(Console.ReadLine());
            tkw = double.Parse(Console.ReadLine());
        }
        
        public double TrungBinh()
        {
            return (lt + csdl + tkw) / 3;
        }

        public Boolean Tren5()
        {
            if (lt >= 5 && csdl >= 5 && tkw >= 5) return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SinhVien[] s = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                s[i] = new SinhVien();
                Console.WriteLine("Sinh vien " + (i + 1));
                s[i].Nhap();
            }


            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i].Tren5())
                {
                    c2++;
                    if (s[i].TrungBinh() >= 8)
                    {
                        c1++;
                    }
                }
            }

            Console.WriteLine("KL = " + c1 + " - CD = " + c2);
        }
    }
}
