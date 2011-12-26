using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CarrotBoxes {
    public double theProbability(string[] information)
    {
        int i, j, k;
        int len = information.Length;
        bool[,] info = new bool[len, len];
        for (i = 0; i < len; i++)
            for (j = 0; j < len; j++)
                if (information[i][j] == 'Y') info[i, j] = true;
        for (k = 0; k < len; k++)
            for (i = 0; i < len; i++)
                for (j = 0; j < len; j++)
                    info[i, j] |= info[i, k] & info[k, j];
        int minres = len;
        for (j = 0; j < len; j++)
        {
            int res = 0;
            bool[] used = new bool[len];
            while (true)
            {
                int nokori = 0;
                int best = -1;
                int bestcount = -1;
                for (i = 0; i < len; i++)
                {
                    if (used[i]) continue;
                    nokori++;
                    if (i == j) continue;
                    int count = 0;
                    for (k = 0; k < len; k++) if (info[i, k] && !used[k]) count++;
                    if (count > bestcount)
                    {
                        bestcount = count;
                        best = i;
                    }
                }
                if (nokori <= 1) break;
                for (k = 0; k < len; k++) used[k] |= info[best, k];
                res++;
            }
            minres = Math.Min(minres, res);
        }
        return (double)(len - minres) / len;
    }
}
