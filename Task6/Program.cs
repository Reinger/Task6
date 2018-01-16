using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static int ReadInt(string s)
        {
            int k;
            bool ok;

            do
            {
                Console.Write("{0}", s);
                ok = Int32.TryParse(Console.ReadLine(), out k);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести целое число");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!ok);

            return k;
        }

        static void Main(string[] args)
        {
            int[] a=new int[10000];
            a[0] = ReadInt("a1=");
            a[1] = ReadInt("a2=");
            a[2] = ReadInt("a3=");
            int M = ReadInt("M=");
        }
    }
}
