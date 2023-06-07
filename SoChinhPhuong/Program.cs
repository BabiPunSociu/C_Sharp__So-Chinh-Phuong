using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoChinhPhuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Nhập số tự nhiên a:\ta = ");
                a = Convert.ToInt32(Console.ReadLine());
            }while (a < 0);

            Console.WriteLine("a = " + a + " là số chính phương?\t" + KiemTra.check_SCP(a));

            // in tất cả các số chính phương trong đoạn [a,b]
            inDaySo.inSCP(0, 1000);
        }
    }
}
