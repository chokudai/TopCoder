using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KindAndCruel {

    int len;

    public int crossTheField(string field, int K, int C)
    {
        len = field.Length;
        int MAX = 2500 * 50 * 3 / 2;
        int i, j;
        bool[] b = new bool[len];
        b[0] = true;
        for (i = 1; i < MAX; i++)
        {
            bool[] nb = new bool[len];
            for (j = 0; j < len; j++)
            {
                if (b[j])
                {
                    if (ok(j - 1)) nb[j - 1] = true;
                    nb[j] = true;
                    if (ok(j + 1)) nb[j + 1] = true;
                }
            }
            for (j = 0; j < len; j++)
            {
                if (field[j] == 'K')
                {
                    if (i % K == 0) nb[j] = false;
                }
                if (field[j] == 'C')
                {
                    if (i % C != 0) nb[j] = false;
                }
            }
            if (nb[len - 1]) return i;
            b = (bool[])nb.Clone();
        }
        return -1;
    }

    bool ok(int x)
    {
        return x >= 0 && x < len;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
