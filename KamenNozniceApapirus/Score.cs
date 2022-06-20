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
        public bool sus { get; set; }
        public int TvojeScore { get; set; }
        public int celkoveTvojeScore { get; set; }
        public int EnemyScore { get; set; }
       public bool playAgain { get; set; }
        public bool restart { get; set; }
        public bool mamtitul { get; set; }
        public bool doubleskore { get; set; }
        public bool sestsestsest { get; set; }
        public bool ctiristadvacet { get; set; }
        public bool rockG { get; set; }
        public bool paperG { get; set; }
        public bool scissorsG { get; set; }
        public bool jgdiff { get; set; }
        public bool gergelos { get; set; }
        public void lol()
        {
            sus = false;
            gergelos = false;
            scissorsG = false;
            paperG = false;
            rockG = false;
            celkoveTvojeScore = 0;
            doubleskore = false;
            mamtitul = false;
            sestsestsest = false;
            ctiristadvacet = false;
            jgdiff = false;
            
            
        }
        public void ResetSkore()
        {
            TvojeScore = 0;
            EnemyScore = 0;
        }
    }
    
}
