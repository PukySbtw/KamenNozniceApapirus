using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNozniceApapirus
{
    internal class Score
    {
        public int TvojeScore { get; set; }
        public int EnemyScore { get; set; }
        public bool playAgain { get; set; }
        public void lol()
        {
            TvojeScore = 0;
            EnemyScore = 0;
            playAgain = true;
        }
    }
    
}
