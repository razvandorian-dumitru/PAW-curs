using System;

namespace curs3
{
    class Program
    {
        delegate int opAritmetice(int x1, int x2);
        static void Main(string[] args)
        {
            #region salariat
            /* Salariat s1 = new Salariat() { Nume = "Razvan", NrOre = 40, SalOrar = 10 };
             Salariat s2 = new Salariat() { Nume = "Robert", NrOre = 20, SalOrar = 10 };
             //asa e memory leak sau nullptr
             //Salariat s3=new Salariat();
             Salariat s3;
             s3 = s1 + s2;
             Console.WriteLine(s3);

             Firma ase = new Firma();
             ////vom avea 3
             //ase = ase + s1 + s2 + s3;
             ////vom avea 1
             //ase += s1 += s2 += s3;
             Console.WriteLine(ase.NrSal);

             Console.WriteLine(ase);*/
            #endregion

            #region delegat

            static opAritmetice getFunctie(char semn)
            {
                if (semn == '*') return (int z, int p) => z * p;
                else return (int z, int p) => z / p;
            }




            static int aduna(int x, int y) => x + y;
            static int scade(int x, int y) => x - y;
            int a = 10, b = 20;
            opAritmetice functieList = new opAritmetice(aduna);
            functieList += scade;
            functieList += getFunctie('*');
            functieList += getFunctie('/');

            foreach (opAritmetice del in functieList.GetInvocationList())
                Console.WriteLine(del(a, b));



            Console.WriteLine();






            #endregion
        }

    }
}
