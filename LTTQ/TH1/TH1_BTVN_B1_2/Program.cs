namespace TH1_BTVN_B1_2
{
    class TtinThueXe
    {
        public String hoten = "";
        public int sogio;
        public TtinThueXe() { }

        public void Nhap()
        {
            hoten = Console.ReadLine();
            sogio = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write(hoten + " - " + sogio);
        }

        public double ThanhTien()
        {
            sogio--;
            return 250 + 220 + sogio * 70 + sogio * 85;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TtinThueXe[] t = new TtinThueXe[n];

            for (int i = 0; i < n; i++)
            {
                t[i] = new TtinThueXe();
                Console.WriteLine("Thong tin thue xe " + (i + 1));
                t[i].Nhap();
            }

            for (int i = 0; i < n; i++)
            {
                t[i].Xuat();
                Console.WriteLine(" - " + t[i].ThanhTien());
            }
        }
    }
}
