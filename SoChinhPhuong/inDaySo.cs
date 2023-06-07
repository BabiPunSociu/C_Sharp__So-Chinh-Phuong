using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoChinhPhuong
{
    internal class inDaySo
    {
        public static void inSCP(int a, int b)      // in tất cả các số chính phương trong [a,b]
        {
            bool empty = true;
            for(int i = a; i <= b; i++)
            {
                if(KiemTra.check_SCP(i) == true)
                {
                    empty = false;
                    Console.Write(i + " ");
                }    
            }
            if (empty == true) Console.WriteLine("Không có số chính phương nào ...");
        }
    }
}
