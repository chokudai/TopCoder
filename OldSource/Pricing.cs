using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Pricing {
    public int maxSales(int[] price)
    {
        int res = 0;
        int i, j, k, l;
        Array.Sort(price);
        Array.Reverse(price);
        int len = price.Length;
        if (len <= 3)
        {
            foreach (int a in price) res += a;
            return res;
        }
        for (i = 0; i < len - 3; i++)
        {
            for (j = i + 1; j < len - 2; j++)
            {
                for (k = j + 1; k < len - 1; k++)
                {
                    for (l = k + 1; l < len; l++)
                    {
                        res = Math.Max(res, (i + 1) * price[i] + (j - i) * price[j] + (k - j) * price[k] + (l - k) * price[l]);
                    }
                }
            }
        }
        return res;

    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] Modified for C# by ysn
// Powered by CodeProcessor
