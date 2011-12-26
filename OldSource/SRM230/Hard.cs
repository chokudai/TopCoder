using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MultiReplacer
{
    long[,] ar = new long[3, 3];
    public long length(string arep, string brep, string crep, int iter, int m)
    {
        int i, j;
        for (i = 0; i < 3; i++) for (j = 0; j < 3; j++) ar[i, j] = 0;
        for (i = 0; i < arep.Length; i++) ar[arep[i] - 'a', 0]++;
        for (i = 0; i < brep.Length; i++) ar[brep[i] - 'a', 1]++;
        for (i = 0; i < crep.Length; i++) ar[crep[i] - 'a', 2]++;
        long res = 0;
        long[,] br = powmod(ar, iter, m);
        for (i = 0; i < 3; i++) res += br[i, 0];
        res %= m;
        return res;
    }

    long[,] powmod(long[,] a, int p, int mod)
    {
        if (p == 1) return a;
        if (p % 2 == 1)
        {
            return pow(powmod(a, p - 1, mod), ar, mod);
        }
        else
        {
            long[,] c = powmod(a, p / 2, mod);
            return pow(c, c, mod);
        }
    }

    long[,] pow(long[,] a, long[,] b, int mod)
    {
        int i, j, k;
        long[,] res = new long[3, 3];
        for (i = 0; i < 3; i++) for (j = 0; j < 3; j++) res[i, j] = 0;
        for (i = 0; i < 3; i++) for (j = 0; j < 3; j++) for (k = 0; k < 3; k++)
                {
                    res[i, j] += a[i, k] * b[k, j];
                    res[i, j] %= mod;
                }
        return res;
    }
}
