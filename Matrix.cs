using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Diagsum(int[,] Matrix)
        {
            int sigane = Matrix.GetLength(0);
            int simagle = Matrix.GetLength(1);
            for (int x = 0; x<sigane; x++)
            {
                for(int y =0; y<simagle; y++)
                {
                    Console.Write(Matrix[x, y] + " ");
                }
                Console.WriteLine();
            }

            int Xjami = 0;
            int Yjami = 0;
            for(int i = 0; i<sigane; i++)
            {
                Xjami += Matrix[i, i];
            }
            for (int i = sigane - 1; i >= 0; i--)
            {
                Yjami += Matrix[sigane - i - 1,i];
            }
            Console.WriteLine();
            Console.WriteLine("ABSOLUTURI SXVAOBA ARIS: "+" "+(Math.Abs(XSum-YSum)));

        }
        static void Main(string[] args)
        {
            Console.WriteLine("SHEMOIYVANET  KVADRATULI MATRICIS ZOMA");
            int Dimesion = Convert.ToInt32(Console.ReadLine());
            int[,] Array = new int[Dimesion, Dimesion];
            Console.WriteLine("DAAKOMPLEQTET MATRICA MARCXNIDAN MARJVNIV DASAWYISIT PIRVELI RIGIDAN");
            for(int i = 0; i<Dimesion; i++)
            {
                for(int j=0; j<Dimesion; j++)
                {
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine( );

            Diagsum(Array);

        }
    }
}
