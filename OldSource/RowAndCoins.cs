using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RowAndCoins {
    string s;
    int len;
    int[,] dp;
    int MAX;

    public string getWinner(string cells)
    {
        s = cells;
        len = cells.Length;
        MAX = (1 << len) - 1;
        dp = new int[1 << len, 2];
        if (saiki(MAX, 0) == 0) return "Alice";
        else return "Bob";
    }

    int saiki(int a, int b)
    {
        if (dp[a, b] != 0) return dp[a, b] - 1;
        int i, j, k;
        for (i = 0; i < len; i++)
        {
            if (a == 1 << i)
            {
                if (s[i] == 'A')
                {
                    dp[a, b] = 1;
                    return 0;
                }
                else
                {
                    dp[a, b] = 2;
                    return 1;
                }
            }
        }
        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j <= len; j++)
            {
                int dec = 0;
                for (k = i; k < j; k++)
                {
                    if ((a >> k) % 2 == 0) break;
                    dec += 1 << k;
                }
                if (k != j) continue;
                if (a - dec == 0) continue;
                if (saiki(a - dec, 1 - b) == b)
                {
                    dp[a, b] = b + 1;
                    return b;
                }
            }
        }
        dp[a, b] = 2 - b;
        return 1 - b;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
