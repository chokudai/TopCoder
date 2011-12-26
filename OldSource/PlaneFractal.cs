using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PlaneFractal {
    public string[] getPattern(int s, int N, int K, int r1, int r2, int c1, int c2)
    {
        string[] res = new string[r2 - r1 + 1];
        int i, x,y;
        for (x = r1; x <= r2; x++)
        {
            res[x - r1] = "";
            for (y = c1; y <= c2; y++)
            {
                int X = x;
                int Y = y;
                for (i = 0; i < s; i++)
                {
                    if (check(X % N, Y % N, N, K)) break;
                    X /= N;
                    Y /= N;
                }
                if (i == s) res[x - r1] += "0";
                else res[x - r1] += "1";
            }
        }
        return res;
    }

    bool check(int x, int y, int N, int K)
    {
        int start = (N - K) / 2;
        int end = (N + K) / 2;
        if ((x < start || x >= end)) return false;
        if ((y < start || y >= end)) return false;
        return true;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
