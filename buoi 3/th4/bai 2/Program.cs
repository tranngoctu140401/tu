using System;
using System.Xml;

namespace bai_4._2
{
    class NV
    {
        private string hoten, qq;
        private double hsl;
        private static double lcb;

        public string Hoten { get => hoten; set => hoten = value; }
        public double Hsl { get => hsl; set => hsl = value; }
        public void nhap()
        {
            Console.WriteLine("nhap thong tin");
            Console.WriteLine("nhap hoten");hoten = Console.ReadLine();
            Console.WriteLine("nhap que quan"); qq = Console.ReadLine();
            Console.WriteLine("nhap hsl"); hsl =double.Parse( Console.ReadLine());
            Console.WriteLine("nhap lcb"); lcb = double.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("hien thong tin");
            Console.WriteLine("hoten\t\t" + hoten);
            Console.WriteLine("que quan\t\t"+qq);
            Console.WriteLine("hsl\t\t"+ hsl);
            Console.WriteLine("tien luong \t\t"+tinhluong()); 
        }
        public double tinhluong()
        {
            return hsl * lcb;
        }
        class QUANLI
        {
            private NV[] ds;
            private int s;
            public void nhap()
            {
                Console.WriteLine("nhap so luong nv");s = int.Parse(Console.ReadLine());
                ds = new NV[s];
                for (int i = 0; i < s; i++)
                {
                    ds[i] = new NV();
                    ds[i].nhap();
                }
            }
            public void hien()
            {
                for (int i = 0; i < s; i++)
                {
                    ds[i].hien();
                    Console.WriteLine();
                }
            }
            public void sapxep()
            {
                for (int i = 0; i < s; ++i)
                {
                    for (int j = i + 1; i < s; ++j)

                        if (string.Compare(ds[i].hoten, ds[j].hoten) > 0)
                        {
                            NV t = new NV();
                             t = ds[i];
                            ds[i] = ds[j];
                            ds[j] = t;
                        }
                            
                    
                }
            }
        }
        class MyClass
        {
            static void Main(string[] args)
            {
                QUANLI q = new QUANLI();
                q.nhap();q.hien();
                q.sapxep();
                Console.ReadKey();
            }
        }
    }
}
        
