using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_lab1
{
    class Saper
    {
        void Main()
        {
            Random rnd = new Random();
            int check = 0;
            int[,] pole = new int[,] { { 0, 0, 0 }, { 0, 0, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int q = rnd.Next(1);
                    if (q == 1) { check++; }
                    if (check == 3)
                        break;
                    else
                        pole[i, j] = q;
                }
            }
            outp(pole);
        }

        int Sosed(ref int[,] pole)
        {
            int sosed = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (pole[i, j] == 1)
                    {
                        sosed++;
                    }
                    sosed--;
                }
            }
            return sosed;
        }
        void outp(int[,] pole)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
