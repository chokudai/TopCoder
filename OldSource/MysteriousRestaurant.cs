using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MysteriousRestaurant {
    public int maxDays(string[] prices, int budget)
    {
        int i, j, k, l, p;
        int res = 0;
        for (i = 1; i <= prices.Length; i++)
        {
            for (j = 0; j <= 0; j++)
            {
                int sum = 0;
                for (k = 0; k < 7; k++)
                {
                    int[] num = new int[prices[0].Length];
                    for (l = 0; 7 * l + k < i; l++)
                    {
                        for (p = 0; p < num.Length; p++)
                        {
                            num[p] += getcost(prices[7 * l + k + j][p]);
                        }
                    }
                    int mincost = 9999999;
                    for (p = 0; p < num.Length; p++) mincost = Math.Min(mincost, num[p]);
                    sum += mincost;
                }
                if (sum <= budget) res = Math.Max(res, i);
            }
        }
        return res;
    }

    int getcost(char c)
    {
        if (c >= '0' && c <= '9') return c - '0';
        if (c >= 'A' && c <= 'Z') return c - 'A' + 10;
        return c - 'a' + 36;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
