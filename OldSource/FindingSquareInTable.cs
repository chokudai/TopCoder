using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FindingSquareInTable {

    int lenx;
    int leny;
    public int findMaximalSquare(string[] table) {
        lenx = table.Length;
        leny = table[0].Length;
        int i, j, k, vx, vy,l;
        int maxscore = -1;
        for (i = 0; i < lenx; i++)
        {
            for (j = 0; j < leny; j++)
            {
                for (vx = -9; vx < 10; vx++)
                {
                    for (vy = -9; vy < 10; vy++)
                    {
                        if (vx == 0 && vy == 0) continue;
                        int X = i;
                        int Y = j;
                        string ss = "";
                        for (l = 0; ; l++)
                        {
                            if (!ok(X, Y)) break;
                            ss = ss + table[X][Y];
                            int c = int.Parse(ss);
                            if (check(c)) maxscore = Math.Max(c, maxscore);
                            X += vx;
                            Y += vy;
                        }
                    }
                }
            }
        }
        return maxscore;
    }

    bool check(int a)
    {
        int b = (int)(Math.Sqrt(a));
        return a == b * b || a == (b + 1) * (b + 1) || a == (b - 1) * (b - 1);
    }

    bool ok(int x, int y) { if (x < 0 || y < 0 || x >= lenx || y >= leny) return false; return true; }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
