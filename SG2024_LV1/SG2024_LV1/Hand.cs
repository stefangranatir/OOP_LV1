using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG2024_LV1
{
    internal class Hand
    {
        public List<Die> kocke= new List<Die>(6);
        int ukupnobacanje = 0;
        int[] brojevi= new int[6];
        public Hand()
        {
            Die prva= new Die();
            Die druga = new Die();
            Die treca= new Die();
            Die cetvrta = new Die();
            Die peta = new Die();
            Die sesta= new Die();
            kocke.Add(prva);
            prva.SetId(1);
            kocke.Add(druga);
            druga.SetId(2);
            kocke.Add(treca);
            treca.SetId(3);
            kocke.Add(cetvrta);
            cetvrta.SetId(4);
            kocke.Add(peta);
            peta.SetId(5);
            kocke.Add(sesta);
            sesta.SetId(6);
        }
        public Hand(Die prva, Die druga, Die treca, Die cetvrta, Die peta, Die sesta)
        {
            kocke.Add(prva);
            prva.SetId(1);
            kocke.Add(druga);
            druga.SetId(2);
            kocke.Add(treca);
            treca.SetId(3);
            kocke.Add(cetvrta);
            cetvrta.SetId(4);
            kocke.Add(peta);
            peta.SetId(5);
            kocke.Add(sesta);
            sesta.SetId(6);
        }
        public void zakljucaj(int id)
        {
            foreach (Die kocka in kocke)
            {
                if(kocka.GetId() == id)
                {
                    kocka.Setzakljucan(true);
                }
            }
        }
        public void Otkljucaj(int id)
        {
            foreach (Die kocka in kocke)
            {
                if (kocka.GetId() == id)
                {
                    kocka.Setzakljucan(false);
                }
            }
        }
        public void Bacanje()
        {
            int i = 0;
            foreach(Die kocka in kocke){
    
                if(kocka.GetZakljucan() == false)
                {
                    kocka.Roll();
                    this.ukupnobacanje += kocka.GetRolledNumber();
                    brojevi[i] = kocka.GetRolledNumber();
                }
                i++;
            }
        }
        public int[] VratiBrojeve()
        {
            return brojevi;
        }


    }
}
