using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SignificanceArithmetic {
    public string evaluate(string expression)
    {
        int i;
        int[] res = new int[20];
        int border = 0;
        string[] s = expression.Split('+');
        foreach (string ss in s)
        {
            string[] st = ss.Split('.');
            for (i = 0; i < st[0].Length; i++)
            {
                res[10 + i] += st[0][st[0].Length - 1 - i] - '0';
            }
            if (st.Length != 1)
            {
                for (i = 0; i < st[1].Length; i++)
                {
                    res[10 - i - 1] += st[1][i] - '0';
                }
                border = Math.Max(10 - st[1].Length, border);
            }
            else
            {
                border = 10;
            }
        }
        for (i = 0; i < 18; i++)
        {
            res[i + 1] += res[i] / 10;
            res[i] %= 10;
        }
        bool flag = false;
        if (res[border - 1] > 5) flag = true;
        if (res[border - 1] == 5)
        {
            for (i = border - 2; i >= 0; i--) if (res[i] != 0) flag = true;
            if (res[border] % 2 == 1) flag = true;
        }
        if (flag)
        {
            res[border]++;
            for (i = border - 1; i >= 0; i--) res[i] = 0;
        }
        for (i = 0; i < 18; i++)
        {
            res[i + 1] += res[i] / 10;
            res[i] %= 10;
        }
        string ret = "";
        for (i = 19; i > 10; i--) if (res[i] != 0) break;
        for (; i >= 10; i--) ret += res[i];
        if (border != 10)
        {
            ret += ".";
            for (; i >= border; i--) ret += res[i];
        }
        return ret;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
