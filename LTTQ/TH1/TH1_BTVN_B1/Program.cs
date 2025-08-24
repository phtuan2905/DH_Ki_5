using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1_BTVN_B1
{
    internal class ThiSinh
    {
        public int sbd;
        public String ht = "";
        public double m1;
        public double m2;
        public double m3;

        public ThiSinh() { }

        public void Nhap()
        {
            sbd = int.Parse(Console.ReadLine());
            ht = Console.ReadLine();
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
        }

        public double TongDiem()
        {
            return m1 + m2 + m3;
        }
    }

    internal class TuyenSinh : ThiSinh
    {
        public double kv;

        public TuyenSinh() { }

        public void Nhap()
        {
            base.Nhap();
            kv = int.Parse(Console.ReadLine());
        }

        public double TongDiem()
        {
            return base.TongDiem() + kv - 1;
        }

        public void Xuat()
        {
            Console.WriteLine(base.sbd + " - " + base.ht + " - " + base.m1 + " - " + base.m2 + " - " + base.m3 + " - " + kv + " - " + TongDiem());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n");
            int n = int.Parse(Console.ReadLine());
            TuyenSinh[] t = new TuyenSinh[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tuyen sinh " + (i + 1));
                t[i] = new TuyenSinh();
                t[i].Nhap();
            }

            for (int i = 0; i < n; i++)
            {
                t[i].Xuat();
            }

        }
    }
}
