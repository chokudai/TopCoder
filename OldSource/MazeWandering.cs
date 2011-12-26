using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MazeWandering {

    int x, y;
    string[] m;
    int[] vx = new int[4] { 1, 0, -1, 0 };
    int[] vy = new int[4] { 0, 1, 0, -1 };
    double[,] res;

    public double expectedTime(string[] maze)
    {
        m = maze;
        x = maze[0].Length;
        y = maze.Length;
        if(x==0 && y==0) return 0.0;
        res = new double[x, y];
        int i, j, k;
        for (i = 0; i < y; i++)
        {
            for (j = 0; j < x; j++)
            {
                if (ok(j, i))
                {
                    if (m[i][j] == '*') res[j, i] = 0;
                    else res[j, i] = 10000000000;
                }
            }
        }
        for (int loop = 0; loop < 10000; loop++)
        {
            for (i = 0; i < y; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if (ok(j, i))
                    {
                        int count = 0;
                        double sum = 0;
                        for (k = 0; k < 4; k++)
                        {
                            int Y = j + vy[k];
                            int X = i + vx[k];
                            if (ok(Y, X))
                            {
                                count++;
                                sum += res[Y, X];
                            }
                        }
                        res[j, i] = Math.Min(res[j, i], sum / count + 1);
                    }
                }
            }
        }
        double rsum = 0;
        int rcount = 0;
        for (i = 0; i < y; i++)
        {
            for (j = 0; j < x; j++)
            {
                if (ok(j, i))
                {
                    rcount++;
                    rsum += res[j, i];
                }
            }
        }
        return rsum / rcount;
    }

    bool ok(int a, int b)
    {
        if (a < 0 || b < 0 || a >= x || b >= y) return false;
        if (m[b][a] == 'X') return false;
        return true;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
