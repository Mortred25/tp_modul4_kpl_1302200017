using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_modul4_kpl_1302200017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String x = "davi";
            halo.SapaUser(x);
            
        }
    }
    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("halo" + x);
        }
    }
}