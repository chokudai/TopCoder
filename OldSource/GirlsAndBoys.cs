using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GirlsAndBoys {
    public int sortThem(string row)
    {
        int res = int.MaxValue;
        int i, j;
        int len = row.Length;
        int now = 0;
        int nowres = 0;
        for (i = 0; i < len; i++)
        {
            if (row[i] == 'B')
            {
                nowres += i - now;
                now++;
            }
        }
        res = Math.Min(nowres, res);
        nowres = 0;
        now = 0;
        for (i = 0; i < len; i++)
        {
            if (row[i] == 'G')
            {
                nowres += i - now;
                now++;
            }
        }
        res = Math.Min(nowres, res);
        nowres = 0;

        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
