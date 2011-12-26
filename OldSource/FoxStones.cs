using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxStones {
    public int getCount(int N, int M, int[] sx, int[] sy)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        int i, j, k;
        for (i = 1; i <= N; i++)
        {
            for (j = 1; j <= M; j++)
            {
                string s = "";
                for (k = 0; k < sx.Length; k++)
                {
                    s += Math.Max(Math.Abs(sx[k] - i), Math.Abs(sy[k] - j));
                    s += ",";
                }
                if (dic.ContainsKey(s)) dic[s] += 1;
                else dic[s] = 1;
            }
        }
        long mod = 1000000009;
        long res = 1;
        foreach (int num in dic.Values)
        {
            for (i = 1; i <= num; i++)
            {
                res *= i;
                res %= mod;
            }
        }
        return (int)res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
