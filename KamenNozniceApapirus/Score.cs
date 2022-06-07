using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace KamenNozniceApapirus
{
    internal class Score
    {
        public int TvojeScore { get; set; }
        public int celkoveTvojeScore { get; set; }
        public int EnemyScore { get; set; }
       public bool playAgain { get; set; }
        public bool restart { get; set; }
        public bool mamtitul { get; set; }
        public bool doubleskore { get; set; }
        public bool sestsestsest { get; set; }
        public bool ctiristadvacet { get; set; }
        public void lol()
        {
            celkoveTvojeScore = 200;
            doubleskore = false;
            mamtitul = false;
            sestsestsest = false;
            ctiristadvacet = false;
            //TvojeScore = 0;
            //EnemyScore = 0;
            //celkoveTvojeScore = 0;
            
        }
        public void Obchod()
        {
       


        }
        public void ResetSkore()
        {
            TvojeScore = 0;
            EnemyScore = 0;
        }
    }
    
}
