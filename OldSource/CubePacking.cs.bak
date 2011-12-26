using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CubePacking {

    long sum, ns, nb, ls;
    long nownum;
    public int getMinimumVolume(int Ns, int Nb, int L)
    {
        sum = (long)L * L * L * Nb + Ns;
        ns = Ns;
        nb = Nb;
        ls = L;
        for (long res = sum; ; res++)
        {
            nownum = res;
            if (make(Ns, Nb, L, res)) return (int)res;
        }
    }

    bool make(int Ns, int Nb, int L, long res)
    {
        long[,] p = prime(res);
        return ok(0, 0, p, 1, 1);
    }

    bool ok(int a, int b, long[,] p, long num1, long num2)
    {
        long len = p.GetLength(0);
        int i, j;
        if (num1 < num2) return false;
        if (a == 0)
        {
            if (b == len) return ok(a + 1, 0, p, num1, num2);
            long kake = 1;
            for (j = 0; j <= p[b, 1]; j++)
            {
                p[b, 1] -= j;
                if (ok(a, b + 1, p, num1 * kake, num2)) return true;
                p[b, 1] += j;
                kake *= p[b, 0];
            }
        }
        if (a == 1)
        {
            if (b == len) return ok(a + 1, 0, p, num1, num2);
            long kake = 1;
            for (j = 0; j <= p[b, 1]; j++)
            {
                p[b, 1] -= j;
                if (ok(a, b + 1, p, num1, num2 * kake)) return true;
                p[b, 1] += j;
                kake *= p[b, 0];
            }
        }
        if (a == 2)
        {
            long num3 = nownum / num1 / num2;
            long c = 1;
            c *= num1 / ls;
            c *= num2 / ls;
            c *= num3 / ls;
            if (c >= nb) return true;
        }
        return false;
    }

    

    long[,] prime(long r)
    {
        long i = 2;
        List<long> t = new List<long>();
        List<long> num = new List<long>();
        for (i = 2; i * i <= r; i++)
        {
            long count = 0;
            while (r % i == 0)
            {
                count++;
                r /= i;
            }
            if (count != 0)
            {
                t.Add(i);
                num.Add(count);
            }
        }
        if (r != 1)
        {
            t.Add(r);
            num.Add(1);
        }
        int len = t.Count;
        long[] tar = t.ToArray();
        long[] numar = num.ToArray();
        long[,] res = new long[len, 2];
        int j;
        for (j = 0; j < len; j++)
        {
            res[j, 0] = tar[j];
            res[j, 1] = numar[j];
        }
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
