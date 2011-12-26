using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DoNotTurn {

    int len;
    int[,] map;
    bool[,] wall;
    bool[,] cometate;
    bool[,] comeyoko;
    public int minimumTurns(int N, int X0, int A, int B, int Y0, int C, int D, int P, int M)
    {
        len = N;
        map = new int[len, len];
        wall = new bool[len, len];
        cometate = new bool[len, len];
        comeyoko = new bool[len, len];
        int i, j;
        int X = X0 % P;
        int Y = Y0 % P;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                wall[i, j] = false;
            }
        }
        for (i = 0; i < M; i++)
        {
            wall[X%len, Y%len] = true;
            X = (int)(((long)X * (long)A + (long)B) % P);
            Y = (int)(((long)Y * (long)C + (long)D) % P);
        }
        wall[0, 0] = false;
        wall[len - 1, len - 1] = false;
        bool flag = true;
        bool flag2 = true;
        List<int> now = new List<int>();
        List<int> next = new List<int>();
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                map[i, j] = 99999999;
            }
            if (wall[i, 0]) flag = false;
            if (wall[0, i]) flag2 = false;
            if (flag) { map[i, 0] = 0; now.Add(i<<10); }
            if (flag2) { map[0, i] = 0; now.Add(i); }
        }
        int flagcount = 0;
        while (true)
        {
            foreach (int a in now)
            {
                int x = a >>10;
                int y = a % (1 << 10);
                for (i = x + 1; i < len; i++)
                {
                    if (wall[i, y]) break;
                    if (cometate[i, y]) break;
                    cometate[i, y] = true;
                    if (map[i, y] > flagcount + 1)
                    {
                        map[i, y] = flagcount + 1;
                        next.Add((i << 10) + y);
                    }
                }
                for (i = x - 1; i >= 0; i--)
                {
                    if (wall[i, y]) break;
                    if (cometate[i, y]) break;
                    cometate[i, y] = true;
                    if (map[i, y] > flagcount + 1)
                    {
                        map[i, y] = flagcount + 1;
                        next.Add((i << 10) + y);
                    }
                }
                for (i = y + 1; i < len; i++)
                {
                    if (wall[x, i]) break;
                    if (comeyoko[x, i]) break;
                    comeyoko[x, i] = true;
                    if (map[x, i] > flagcount + 1)
                    {
                        map[x, i] = flagcount + 1;
                        next.Add((x << 10) + i);
                    }
                }
                for (i = y - 1; i >= 0; i--)
                {
                    if (wall[x, i]) break;
                    if (comeyoko[x, i]) break;
                    comeyoko[x, i] = true;
                    if (map[x, i] > flagcount + 1)
                    {
                        map[x, i] = flagcount + 1;
                        next.Add((x << 10) + i);
                    }
                }
            }
            flagcount++;
            if (next.Count == 0) break;
            now = new List<int>();
            foreach (int a in next) now.Add(a);
            next = new List<int>();
        }
        if (map[len - 1, len - 1] > 9999999) return -1;
        else return map[len - 1, len - 1];
    }

    bool ok(int x, int y)
    {
        return x >= 0 && y >= 0 && x < len && y < len;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
