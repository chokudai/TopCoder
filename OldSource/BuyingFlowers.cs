using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BuyingFlowers {

    int len;
    int best;
    public int buy(int[] roses, int[] lilies)
    {
        len = roses.Length;
        best = int.MaxValue;
        dfs(0, 0, roses, lilies, 0);
        if (best == int.MaxValue) return -1;
        else return best;
    }

    void dfs(int r, int l, int[] roses, int[] lilies, int index)
    {
        if (index == len)
        {
            if (Math.Abs(r - l) >= 2) return;
            int sum = r + l;
            for (int i = 1; i * i <= sum; i++)
            {
                if (sum % i == 0) best = Math.Min(Math.Abs(i - sum / i), best);
            }
        }
        else
        {
            dfs(r, l, roses, lilies, index + 1);
            dfs(r + roses[index], l + lilies[index], roses, lilies, index + 1);
        }
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
