using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BrokenButtons {
    public int minPresses(int page, int[] broken)
    {
        int i;
        bool[] b = new bool[10];
        for (i = 0; i < broken.Length; i++) b[broken[i]] = true;
        int res = Math.Abs(page - 100);
        if (!b[0])
        {
            res = Math.Min(res, page + 1);
        }
        for (i = 1; i <= 1100000; i++)
        {
            int now = i;
            int count = 0;
            while (now != 0)
            {
                count++;
                if (b[now % 10]) break;
                now /= 10;
            }
            if (now != 0) continue;
            count += Math.Abs(page - i);
            res = Math.Min(res, count);
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
