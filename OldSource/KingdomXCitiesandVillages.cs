using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KingdomXCitiesandVillages {
    public double determineLength(int[] cityX, int[] cityY, int[] villageX, int[] villageY)
    {
        int i, j, k;
        int vlen = villageX.Length;
        int clen = cityX.Length;
        double res = 0;
        for (i = 0; i < vlen; i++)
        {
            double p = 1;
            bool[] vuse = new bool[vlen];
            vuse[i] = true;
            for (k = 0; ; k++)
            {
                int bestc = -1;
                double bestdis = double.MaxValue;
                int bestnum = -1;
                for (j = 0; j < clen; j++)
                {
                    double dis = Math.Sqrt(Math.Pow(cityX[j] - villageX[i], 2) + Math.Pow(cityY[j] - villageY[i], 2));
                    if (dis < bestdis)
                    {
                        bestc = 0;
                        bestdis = dis;
                        bestnum = i;
                    }
                }
                for (j = 0; j < vlen; j++)
                {
                    if (vuse[j]) continue;
                    double dis = Math.Sqrt(Math.Pow(villageX[j] - villageX[i], 2) + Math.Pow(villageY[j] - villageY[i], 2));
                    if (dis < bestdis)
                    {
                        bestc = 1;
                        bestdis = dis;
                        bestnum = j;
                    }
                }
                if (bestc == 0)
                {
                    res += p * bestdis;
                    break;
                }
                else
                {
                    vuse[bestnum] = true;
                    res += (p / (2.0 + k)) * bestdis;
                    p -= p / (2.0 + k);
                    continue;
                }
            }
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
