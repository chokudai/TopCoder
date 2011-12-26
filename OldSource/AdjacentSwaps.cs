using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AdjacentSwaps {

    long mod = 1000000007;
    int len;
    int[] pr;
    long[,] dp;
    bool[,] used;
    long[,] C;


    public int theCount(int[] p)
    {
        len = p.Length;
        pr = p;
        dp = new long[len, len];
        C = new long[100, 100];
        int i, j;
        C[0, 0] = 1;
        for (i = 0; i < 99; i++)
        {
            for (j = 0; j < 99; j++)
            {
                C[i, j] %= mod;
                C[i + 1, j] += C[i, j];
                C[i + 1, j + 1] += C[i, j];
            }
        }


        used = new bool[len, len];
        return (int)saiki(0, len - 1);
    }

    long saiki(int a, int b)
    {
        if (a == b) return 1;
        if (used[a, b]) return dp[a, b];
        int i, j;
        int[] ar = new int[b - a + 1];
        for (i = a; i <= b; i++) ar[i - a] = pr[i];
        Dictionary<int, int > dic = new Dictionary<int,int>();
        for (i = a; i <= b; i++) dic[ar[i - a]] = i;
        Array.Sort(ar);
        long res = 0;
        used[a, b] = true;

        for (i = a; i < b; i++)
        {
            //down
            for (j = a; j < i; j++)
            {
                if (dic[ar[j - a]] > i) break;
            }
            if (j != i) continue;
            if (dic[ar[i + 1 - a]] > i) continue;

            //up
            for (j = i + 2; j <= b; j++)
            {
                if (dic[ar[j - a]] <= i) break;
            }
            if (j != b + 1) continue;
            if (dic[ar[i - a]] <= i) continue;

            res += (((saiki(a, i) * saiki(i + 1, b)) % mod) * C[(i - a) + (b - (i+1)), i - a]) % mod;
            res %= mod;
        }

        return dp[a, b] = res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
