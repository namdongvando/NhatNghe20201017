using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHam
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("Nguyen Van Teo");
            try
            {
                double kq = PhuongTrinhBac1(2, 3);
                Console.WriteLine(kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static double PhuongTrinhBac1
            (double a, double b)
        {
            if (a == 0)
                if (b == 0)
             throw new Exception("Phuong Trinh Vo So Nghiem");
                else
             throw new Exception("Phuong Trinh Vo Nghiem");

            return -b / a;

        }

        private static void XinChao(string v)
        {
            Console.WriteLine("Xin chao! {0}",v);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chao");
        }
    }
}
