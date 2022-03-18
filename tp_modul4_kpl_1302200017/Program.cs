using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_kpl_1302200017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<String> data = new DataGeneric<string>("nim");
            data.PrintData();
        }
    }
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("data yang tersimpan adalah: " + this.data);
        }
    }
}