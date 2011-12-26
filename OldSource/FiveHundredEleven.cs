using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FiveHundredEleven {
    public string theWinner(int[] cards)
    {
        int len = cards.Length;
        bool[,] dp = new bool[512, len + 1];
        int i, j, k;
        for (j = 0; j <= len; j++) dp[511, j] = true;
        for (i = 510; i >= 0; i--) dp[i, 0] = false;
        for (i = 511; i >= 0; i--)
        {
            for (j = 1; j <= len; j++)
            {
                int count = 0;
                for (k = 0; k < len; k++)
                {
                    if ((i | cards[k]) == i) continue;
                    count++;
                    int next = i | cards[k];
                    if (!dp[next, j - 1]) dp[i, j] = true;
                }
                if (count < j)
                {
                    int next = i;
                    if (!dp[next, j - 1]) dp[i, j] = true;
                }
            }
        }
        if (dp[0, len]) return "Fox Ciel";
        else return "Toastman";
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
