using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GætTalSpillet
{
    class Tryllekunst
    {
        public int plade1 = 16;
        public int plade2 = 8;
        public int plade3 = 4;
        public int plade4 = 2;
        public int plade5 = 1;
        public string Svar;
        public int Sum = 0;
        public void Start()
        {

            plade1_();
            plade2_();
            plade3_();
            plade4_();
            plade5_();


            resultat();
        }

        private void resultat()
        {
            Console.WriteLine("\t\t\t\t\t  Dit tal er " + Sum + ". Er dette korrekt?");
            Svar = Console.ReadLine();
            if (Svar == "Ja")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\tTak for spillet! Det var en fornøjelse. :)");
            }

            if (Svar == "ja")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\tTak for spillet! Det var en fornøjelse. :)");
            }

            if (Svar == "Nej")
            {
                Console.WriteLine("\t\t\t\t\tFucking løgner man!");
            }

            if (Svar == "nej")
            {
                Console.WriteLine("\t\t\t\t\tFucking løgner man!");
            }
        }

        private void plade5_()
        {
            Console.WriteLine("\t\t\t\t\t+--------------------------------+" + "\n" +
                              "\t\t\t\t\t|  1        3        5        7  |" + "\n" +
                              "\t\t\t\t\t|  9        11       13       15 |" + "\n" +
                              "\t\t\t\t\t|  17       19       21       23 |" + "\n" +
                              "\t\t\t\t\t|  25       27       29       31 |" + "\n" +
                              "\t\t\t\t\t+--------------------------------+");
            Console.WriteLine("\t\t\t\t\t   Står dit tal på denne plade?");
            Svar = Console.ReadLine();
            if (Svar == "ja")
            {
                Sum += plade5;
            }

            if (Svar == "Ja")
            {
                Sum += plade5;
            }
        }

        private void plade4_()
        {
            Console.WriteLine("\t\t\t\t\t+--------------------------------+" + "\n" +
                              "\t\t\t\t\t|  2        3        6        7  |" + "\n" +
                              "\t\t\t\t\t|  10       11       14       15 |" + "\n" +
                              "\t\t\t\t\t|  18       19       22       23 |" + "\n" +
                              "\t\t\t\t\t|  26       27       30       31 |" + "\n" +
                              "\t\t\t\t\t+--------------------------------+");
            Console.WriteLine("\t\t\t\t\t   Står dit tal på denne plade?");
            Svar = Console.ReadLine();
            if (Svar == "ja")
            {
                Sum += plade4;
            }

            if (Svar == "Ja")
            {
                Sum += plade4;
            }
        }

        private void plade3_()
        {
            Console.WriteLine("\t\t\t\t\t+--------------------------------+" + "\n" +
                              "\t\t\t\t\t|  4        5        6        7  |" + "\n" +
                              "\t\t\t\t\t|  12       13       14       15 |" + "\n" +
                              "\t\t\t\t\t|  20       21       22       23 |" + "\n" +
                              "\t\t\t\t\t|  28       29       30       31 |" + "\n" +
                              "\t\t\t\t\t+--------------------------------+");
            Console.WriteLine("\t\t\t\t\t   Står dit tal på denne plade?");
            Svar = Console.ReadLine();
            if (Svar == "ja")
            {
                Sum += plade3;
            }

            if (Svar == "Ja")
            {
                Sum += plade3;
            }
        }

        private void plade2_()
        {
            Console.WriteLine("\t\t\t\t\t+--------------------------------+" + "\n" +
                              "\t\t\t\t\t|  8        9        10       11 |" + "\n" +
                              "\t\t\t\t\t|  12       13       14       15 |" + "\n" +
                              "\t\t\t\t\t|  24       25       26       27 |" + "\n" +
                              "\t\t\t\t\t|  28       29       30       31 |" + "\n" +
                              "\t\t\t\t\t+--------------------------------+");
            Console.WriteLine("\t\t\t\t\t   Står dit tal på denne plade?");
            Svar = Console.ReadLine();
            if (Svar == "ja")
            {
                Sum += plade2;
            }

            if (Svar == "Ja")
            {
                Sum += plade2;
            }
        }

        private void plade1_()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t  Velkommen til GætTalSpillet! \n\t\t\t\t\t  Tænk på et tal mellem 1 og 31");
            Console.WriteLine("\t\t\t\t\t+--------------------------------+" + "\n" +
                              "\t\t\t\t\t|  16       17       18       19 |" + "\n" +
                              "\t\t\t\t\t|  20       21       22       23 |" + "\n" +
                              "\t\t\t\t\t|  24       25       26       27 |" + "\n" +
                              "\t\t\t\t\t|  28       29       30       31 |" + "\n" +
                              "\t\t\t\t\t+--------------------------------+");
            Console.WriteLine("\t\t\t\t\t   Står dit tal på denne plade?");
            Svar = Console.ReadLine();
            if (Svar == "ja")
            {
                Sum += plade1;
            }

            if (Svar == "Ja")
            {
                Sum += plade1;
            }
        }
    }
}
