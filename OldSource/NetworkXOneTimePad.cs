using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NetworkXOneTimePad {
    public int crack(string[] plaintexts, string[] ciphertexts)
    {
        Dictionary<long, int> dic = new Dictionary<long, int>();
        long[] a = new long[plaintexts.Length];
        long[] b = new long[ciphertexts.Length];

        int i, j;
        for (i = 0; i < plaintexts.Length; i++)
        {
            a[i] = 0;
            for (j = 0; j < plaintexts[i].Length; j++)
            {
                if (plaintexts[i][plaintexts[i].Length - j - 1] == '1') a[i] |= ((long)1 << j);
            }
        }

        for (i = 0; i < ciphertexts.Length; i++)
        {
            b[i] = 0;
            for (j = 0; j < ciphertexts[i].Length; j++)
            {
                if (ciphertexts[i][ciphertexts[i].Length - j - 1] == '1') b[i] |= ((long)1 << j);
            }
        }

        foreach (long aa in a)
        {
            foreach (long bb in b)
            {
                dic[aa ^ bb] = 1;
            }
        }

        return dic.Count;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
