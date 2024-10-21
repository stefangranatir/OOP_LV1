using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG2024_LV1
{
    internal class Program
    {
        public static float RunExperiment(int zeljeni, int ponavljanja)
        {
            int brojPokusaja = 0;
            Die kocka = new Die();
            for (int i = 0; i < ponavljanja; i++)
            {
                
                while (true)
                {
                    kocka.Roll();
                    Console.WriteLine(kocka.GetRolledNumber());
                    if (zeljeni == kocka.GetRolledNumber())
                    {
                        
                        Console.WriteLine("");
                        brojPokusaja++;
                        break;
                    }
                    
                    brojPokusaja++;
                }
            }
            Console.WriteLine(brojPokusaja);
            return (float)brojPokusaja / ponavljanja;
        }

        public static int MaxHand(int target)
        {
            int brojac = 0;
            Hand ruka = new Hand();
            int[] polje = new int[6];
            while (true)
            {
                ruka.Bacanje();
                brojac++;
                polje = ruka.VratiBrojeve();
                for (int i = 0; i < 6; i++)
                {
                    if (polje[i] == 6)
                    {
                        ruka.zakljucaj(i + 1);
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(polje[i]);
                }
                Console.WriteLine("");
                if (polje[0] == 6 && polje[1] == 6 && polje[2] == 6 && polje[3] == 6 && polje[4] == 6 && polje[5] == 6) {
                    break;
                }
            }
            return brojac;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(RunExperiment(3, 4));
            //Console.WriteLine(MaxHand(36));
            Hand ruka = new Hand();
            HandEvaluator provjera = new HandEvaluator(ruka);
            int[] polje = new int[6];
            string igra ="y";
            while (igra=="y") {
                ruka.Bacanje();
                polje = ruka.VratiBrojeve();
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(polje[i]);
                }
                Console.WriteLine("");
                foreach (Die kocka in ruka.kocke)
                {
                    Console.Write(kocka.GetZakljucan());
                }
                Console.WriteLine("");
                Console.WriteLine(provjera.provjeri());
                if(provjera.provjeri() == "Jamb" || provjera.provjeri() == "Skala")
                {
                    break;
                }
                
                string zakljucano = "y";
                while (zakljucano == "y")
                {
                    Console.WriteLine("Upisi index koji zelis zakljucat 1-6");
                    int index=int.Parse(Console.ReadLine());
                    ruka.zakljucaj(index);
                    Console.WriteLine(index.ToString());
                    Console.WriteLine("zakljucaj jos?");
                    zakljucano = Console.ReadLine();
                }
                foreach(Die kocka in ruka.kocke)
                {
                    Console.Write(kocka.GetRolledNumber());
                }
                Console.WriteLine("bacaj ponovno y/n");
                igra = Console.ReadLine();
            }
            Console.WriteLine("izlazi");

        }
    }
}
