namespace C2_OOP_B6
{
    class NhanVien
    {
        private string hoten;
        private int namsinh;
        private string diachí;
        private double luongcoban;
        private int heso;
        private double phucap;
        private double tongtien;

        public NhanVien() { }

        public NhanVien(string hoten, int namsinh, string diachí, double luongcoban, int heso, double phucap, double tongtien)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.diachí = diachí;
            this.luongcoban = luongcoban;
            this.heso = heso;
            this.phucap = phucap;
            this.tongtien = tongtien;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Nhan vien");
            hoten = Console.ReadLine();
            namsinh = int.Parse(Console.ReadLine());
            diachí = Console.ReadLine();
            luongcoban = double.Parse(Console.ReadLine());
            heso = int.Parse(Console.ReadLine());
            phucap = double.Parse(Console.ReadLine());
            tongtien = double.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return luongcoban * heso + phucap;
        }

        public void Xuat()
        {
            Console.WriteLine("In Nhan vien");
            Console.WriteLine(hoten + " - " + namsinh + " - " + diachí + " - " + luongcoban + " - " + heso + " - " + phucap + " - " + tongtien);
        }
    }
}