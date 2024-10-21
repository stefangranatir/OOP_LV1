using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG2024_LV1
{
    internal class HandEvaluator
    {
        Hand predana = new Hand();
        int[] brojevi = new int[6];
        public HandEvaluator(Hand ruka)
        {
            predana = ruka; 
        }
        public string provjeri()
        {
            brojevi = predana.VratiBrojeve();
            Array.Sort(brojevi);
            if (brojevi[0]==1 && brojevi[1]==2 && brojevi[2]==3 && brojevi[3]==4 && brojevi[4]==5 && brojevi[5] == 6)
            {
                return "Skala";
            }
            else if (brojevi[0] == brojevi[1] && brojevi[0] == brojevi[2] && brojevi[0] == brojevi[3] && brojevi[0] == brojevi[4] && brojevi[0] == brojevi[5])
            {
                return "Jamb";
            }
            return "nista";
        }
    }
}
