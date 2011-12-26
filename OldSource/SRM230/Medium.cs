using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PascalCount
{
    public int howMany(int ii, int d)
    {
        int n2 = 0, n3 = 0, n5 = 0;
        int i;
        int[] c2 = new int[7] { 0, 0, 1, 0, 2, 0, 1 };
        int[] c3 = new int[7] { 0, 0, 0, 1, 0, 0, 1 };
        int[] c5 = new int[7] { 0, 0, 0, 0, 0, 1, 0 };
        int res = 0;
        for (i = 0; i < ii; i++)
        {
            int p = ii - i;
            int m = i + 1;
            n2 += count(p, 2);
            n3 += count(p, 3);
            n5 += count(p, 5);
            n2 -= count(m, 2);
            n3 -= count(m, 3);
            n5 -= count(m, 5);
            if (c2[d] <= n2 && c3[d] <= n3 && c5[d] <= n5) { res++; }
        }
        return res;
    }

    int count(int n, int c)
    {
        int a = 0;
        while (n % c == 0) { a++; n /= c; }
        return a;
    }
}
