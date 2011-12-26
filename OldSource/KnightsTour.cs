using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KnightsTour {
    int[] vy = new int[8] { -2, -2, -1, -1, 1, 1, 2, 2 };
    int[] vx = new int[8] { -1, 1, -2, 2, -2, 2, -1, 1 };

    public int visitedPositions(string[] board)
    {
        int i, j;
        bool[,] b = new bool[8, 8];
        int y = 0, x = 0;
        for (i = 0; i < 8; i++)
        {
            for (j = 0; j < 8; j++)
            {
                if (board[i][j] == '.') b[i, j] = true;
                else b[i, j] = false;
                if (board[i][j] == 'K') { y = i; x = j; }
            }
        }
        int res = 0;
        while (true)
        {
            int minaccess = 9;
            int next = 0;
            for (i = 0; i < 8; i++)
            {
                int ny = y + vy[i];
                int nx = x + vx[i];
                if (nx < 0 || ny < 0 || nx >= 8 || ny >= 8) continue;
                if (!b[ny, nx]) continue;
                int count = 0;
                for (j = 0; j < 8; j++)
                {
                    int nny = ny + vy[j];
                    int nnx = nx + vx[j];
                    if (nnx < 0 || nny < 0 || nnx >= 8 || nny >= 8) continue;
                    if (b[nny, nnx]) count++;
                }
                if (count < minaccess)
                {
                    next = i;
                    minaccess = count;
                }
            }
            if (minaccess == 9)
            {
                return res + 1;
            }
            y += vy[next];
            x += vx[next];
            b[y, x] = false;
            res++;
        }
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
