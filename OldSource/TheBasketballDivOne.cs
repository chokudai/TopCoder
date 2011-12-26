using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBasketballDivOne {
    public int find(int n, int m)
    {
        int i;
        return saiki(m, n * (n - 1) - m, n - 1, 2 * (n - 1), m);
    }

    public int saiki(int max, int value, int member, int sum, int nowsum)
    {
        if (nowsum > sum) return 0;
        if (value < 0) return 0;
        if (member == 0)
        {
            if (value == 0)
            {
                return 1;
            }
            else return 0;
        }
        if (value != 0 && max == 0) return 0;
        int i;
        int res = 0;
        for (i = 0; i <= max; i++)
        {
            res += saiki(i, value - i, member - 1, sum + (member - 1) * 2, nowsum + i);
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
