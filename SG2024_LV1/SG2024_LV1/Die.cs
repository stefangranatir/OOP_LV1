using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG2024_LV1
{
    internal class Die
    {
        private int brojStranica { get; set; }
        private int RolledNumber { get; set; }
        private bool zakljucan = false;
        private int id { get; set; }
        private static Random generator = new Random();


        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public bool GetZakljucan(){
            return this.zakljucan;
        }

        public void Setzakljucan(bool stanje)
        {
            this.zakljucan=stanje;
        }
        public int GetSideCount()
        {
            return brojStranica;
        }
        public void SetSideCount(int broj)
        {
            this.brojStranica = broj;
        }

        public int GetRolledNumber() { 
            return this.RolledNumber;
        }

        public void SetRolledNumber(int number)
        {
            if (number>=1 && number<=this.brojStranica)
            {
                this.RolledNumber = number;
            }
        }
        public Die()
        {
            this.brojStranica = 6;
            this.RolledNumber = 1;
        }
        public Die(int brojstranica, int rollednumber, Random random)
        {
            
            this.brojStranica = brojstranica;
            if (rollednumber >= 1 && rollednumber <= this.brojStranica)
            {
                this.RolledNumber = rollednumber;
            }
            else
            {
                {
                    this.RolledNumber = 1;
                }
            }
        }

        public void Roll()
        {
            this.RolledNumber=generator.Next(1,this.brojStranica+1);
            
        }

    }
}
