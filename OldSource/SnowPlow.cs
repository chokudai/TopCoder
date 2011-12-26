using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SnowPlow {

    int[] uni;
    
    public int solve(string[] roads)
    {
        int i,j;
        int n = roads.Length;
        uni = new int[n];
        bool[] hasroad = new bool[n];
        for (i = 0; i < n; i++)
        {
            uni[i] = -1;
        }
        int res = 0;
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (roads[i][j] != '0')
                {
                    res += (int)(roads[i][j] - (int)'0');
                    connect(i, j);
                    hasroad[i] = hasroad[j] = true;
                }
            }
        }
        for (i = 0; i < n; i++)
        {
            if (!hasroad[i]) continue;
            for (j = 0; j < n; j++)
            {
                if (!hasroad[j]) continue;
                if (!check(i, j)) return -1;
            }
        }
        return res;
        
    }

    int seed(int a)
    {
        if (uni[a] == -1) return a;
        else return uni[a] = seed(uni[a]);
    }

    bool check(int a, int b)
    {
        return seed(a) == seed(b);
    }

    void set(int a, int b)
    {
        if (uni[a] != -1) set(uni[a], b);
        uni[a] = b;
    }

    void connect(int a, int b)
    {
        if (check(a, b)) return;
        if (seed(a) < seed(b))
        {
            set(b, a);
        }
        else
        {
            set(a, b);
        }
    }





}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
