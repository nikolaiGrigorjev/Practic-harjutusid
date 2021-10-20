using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_harjutusid
{
    class Program
    {
        static int Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus : 1,2,3");
            int suurus = int.Parse(Console.ReadLine());
            return suurus;
        }
        static int[,] saal = new int[,] { };

        static int kohad, ridad;

        static void Saali_taitmine(int suurus)
        {
            Random rnd = new Random();
            if(suurus==1)
            {
                kohad = 20;
                ridad = 10;

            }
            else if (suurus == 2)
            {
                kohad = 20;
                ridad = 20;

            }
            else 
            {
                kohad = 20;
                ridad = 30;

            }
            saal = new int[ridad, kohad];
            for ( int rida=0;rida<ridad;rida++)
            {
                for(int koht = 0; koht <kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }

        }


        static void Saal_ekraanile()
        {
            for (int rida = 0; rida < ridad; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {

                    Console.Write(saal[rida, koht]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static bool Muuk()
        {

            Console.WriteLine("Rida:");
            int pileti_rida = int.Parse(Console.ReadLine());
            Console.WriteLine("Koht:");
            int pileti_koht = int.Parse(Console.ReadLine());
            if (saal[pileti_rida-1,pileti_koht-1]==0)
            {
                saal[pileti_rida - 1, pileti_koht - 1] = 1;
                return true;
            }
            else
            { 
                return false;
            }


        }
        
        


         public static void Main(string[] args)
        {

            int suurus = Saali_suurus();
            while(true)
            {
                Saal_ekraanile();
                bool ost = Muuk();
                Console.WriteLine(ost);
            }
            Console.ReadLine();

        }
    }
}
