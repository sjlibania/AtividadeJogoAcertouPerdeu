using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vez;
            int li;
            int ls;
            int oculto;
            int palpite;

            vez = 1;
            li = 1;
            ls = 100;

            do
            {
                Console.Write("Jogador neutro, digite nº entre 1 e 100: ");
                oculto = int.Parse(Console.ReadLine());
            }
            while (oculto <= 1 || oculto >= 100);

            Console.Clear();

            do
            {
                do
                {
                    Console.Write("Jogado {0}, digite nº entre {1} e {2}: ", vez, li, ls);
                    palpite = int.Parse(Console.ReadLine());
                }
                while (palpite <= li || palpite >= ls);
                if (palpite == oculto)
                {
                    Console.WriteLine("Parabéns jogador {0}, você perdeu", vez);
                }
                else
                    if (palpite < oculto)
                {
                    li = palpite;
                }
                else
                {
                    ls = palpite;
                }
                vez = vez + 1;
                if (vez > 2)
                {
                    vez = 1;
                }

            }
            while (palpite != oculto);

        }
    }

}
   
