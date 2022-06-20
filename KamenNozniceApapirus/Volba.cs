using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNozniceApapirus
{
    internal class Volba
    {
        Random generator = new Random();
        public bool KoupenyBoost = true;
        private readonly string[] nastroje = { "Kámen", "Nůžky", "Papír" };
        public void boost()
        {
            KoupenyBoost = false;
        }
        public int GenerovaniVolby()
        {
            //generuje volbu mezi 50-25-25 (4) / 40-20-40 (5)
            int volba = generator.Next(0, 2);
            int sance = 0;
            if (volba == 0)
            {
                sance = 4;
            }
            else if (volba == 1)
            {
                sance = 5;
            }
            int[] sanceNaVysledky = PowerupSance(sance); //metoda vrací 25-50-25 nebo 20-40-40
            for(int i = 0; i <= sanceNaVysledky.Length-1; i++)
            {
                Console.WriteLine(nastroje[i] + ": " + sanceNaVysledky[i] + " ");
            }
            int volbaEnemy = generator.Next(0, 101);
            int zvolenyNastroj = -1;
            if ((volbaEnemy >= 0) && (volbaEnemy < sanceNaVysledky[0]))
            {
                zvolenyNastroj = 1;
            }
            else if ((volbaEnemy >= sanceNaVysledky[0]) && (volbaEnemy < sanceNaVysledky[0] + sanceNaVysledky[1]))
            {
                zvolenyNastroj = 2;
            }
            else if ((volbaEnemy >= sanceNaVysledky[0] + sanceNaVysledky[1]) && (volbaEnemy < 101))
            {
                zvolenyNastroj = 3;
            }
            return zvolenyNastroj;
        }

        public int[] PowerupSance(int sance)
        {
            int[] vysledneSance = new int[3]; // výsledek bude mít hodnoty v poli - {40, 40, 20} - vždy budou 3

            int zvolenyNastroj1 = 0; //hodnotu jinou, než mají generované hodnoty (1-kámen,2-nůžky..)
            int zvolenyNastroj2 = 0;
            if (sance == 4)
            {
                zvolenyNastroj1 = generator.Next(1, 4); //nástroj, ná který se má aplikovat boost, v případě rozdělení na čtvrtiny
                switch (zvolenyNastroj1)
                {
                    case 1:
                        vysledneSance[0] = 50;
                        vysledneSance[1] = 25;
                        vysledneSance[2] = 25;
                        break;
                    case 2:
                        vysledneSance[0] = 25;
                        vysledneSance[1] = 50;
                        vysledneSance[2] = 25;
                        break;
                    case 3:
                        vysledneSance[0] = 25;
                        vysledneSance[1] = 25;
                        vysledneSance[2] = 50;
                        break;
                }
            }
            else if (sance == 5)
            {
                zvolenyNastroj2 = generator.Next(1, 4);
                switch (zvolenyNastroj2)
                {
                    case 1:
                        vysledneSance[0] = 40;
                        vysledneSance[1] = 40;
                        vysledneSance[2] = 20;
                        break;
                    case 2:
                        vysledneSance[0] = 20;
                        vysledneSance[1] = 40;
                        vysledneSance[2] = 40;
                        break;
                    case 3:
                        vysledneSance[0] = 40;
                        vysledneSance[1] = 20;
                        vysledneSance[2] = 40;
                        break;
                }
            }

            return vysledneSance;
        }
    }
}
