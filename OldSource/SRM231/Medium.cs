using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
/*
public class LargeSignTest
{
    public string pvalue(int N, int K)
    {
        double res = 0;
        int i;
        double now = 1;
        double count = N - 1;
        if (N - K < K) return pvalue(N, N - K);
        if (N - K == K) return "100.0%";
        for (i = 0; i <= K; i++)
        {
            while (now > 1)
            {
                count--;
                res /= 2;
                now /= 2;
            }
            res += now;
            now *= (N - i);
            now /= (i + 1);
        }
        for (i = 0; i < count; i++) res /= 2;
        res *= 1000;
        res += 0.05;
        int r = (int)res;
        return string.Concat(r / 10, ".", r % 10, "%");
    }
}
*/