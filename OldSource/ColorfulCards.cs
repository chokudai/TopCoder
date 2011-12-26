using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColorfulCards {

    bool[] prime;
    bool isprime(int a)
    {
        if (a <= 1) return false;
        for (int i = 2; i * i <= a; i++) if (a % i == 0) return false;
        return true;
    }

    public int[] theCards(int N, string colors)
    {
        int i, j;
        prime = new bool[1001];
        for (i = 1; i <= 1000; i++) prime[i] = isprime(i);
        int len = colors.Length;
        int[] minnum = new int[len];
        int[] maxnum = new int[len];
        int[] res = new int[len];
        for (i = 1, j = 0; i <= N && j < len; i++)
            if (prime[i] ^ (colors[j] == 'B'))
                minnum[j++] = i;
        for (i = N, j = len - 1; i >= 1 && j >= 0; i--)
            if (prime[i] ^ (colors[j] == 'B'))
                maxnum[j--] = i;
        for (i = 0; i < len; i++)
        {
            if (minnum[i] == maxnum[i]) res[i] = minnum[i];
            else res[i] = -1;
        }
        return res;
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
