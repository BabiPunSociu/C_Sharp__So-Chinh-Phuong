using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoChinhPhuong
{
    internal class KiemTra
    {
        public static bool check_SCP(int a)
        {
            int x = (int)Math.Sqrt(a);  // x^2 = a
            if(x*x == a)
                return true;
            return false;
        }
    }
}
