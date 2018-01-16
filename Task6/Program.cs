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

        static void OutMas(int[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++) Console.Write("{0} ", a[i]);
        }

        static int Func(int[] a, int N, int M)
        {
            if ((a[N] = a[N - 1] * a[N - 2] + a[N - 3]) >= M)
                return ++N;
            else N = Func(a, ++N, M);
            return N;
        }

        static void Main(string[] args)
        {
            int[] a = new int[10000];
            a[0] = ReadInt("a1=");
            a[1] = ReadInt("a2=");
            a[2] = ReadInt("a3=");
            int M = ReadInt("M=");
            int N = 0;

            if (a[0] >= M) N = 1;
            else if (a[1] >= M)
                N = 2;
            else if (a[2] >= M)
                N = 3;
            else
                N=Func(a, 3, M);

            Console.Write("Последовательность: ");
            OutMas(a,N);
            Console.WriteLine();
            Console.WriteLine("N={0}",N);
            if (a[N-1]==M) Console.WriteLine("Равенство (aN==m) выполняется");
            else
            {
                Console.WriteLine("Равенство (aN==m) невыполняется");
            }

            Console.ReadLine();
        }
    }
}
