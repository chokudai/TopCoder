using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ComplementMachine2D {
    public int largestSubmatrix(string[] matrix)
    {
        int i, j, k, l;
        int h, w;
        h = matrix.Length;
        w = matrix[0].Length;
        bool[,] board = new bool[h, w];
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (matrix[i][j] == '1') board[i, j] = true;
                else board[i, j] = false;
            }
        }
        int res = 1;
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                bool[] b = new bool[h];
                int max = h;
                for (k = i; k < h; k++)
                {
                    if (board[k, j]) b[k] = true;
                }
                for (l = j; l < w; l++)
                {
                    int yoko = l - j + 1;
                    bool next = board[i, l] ^ b[i];
                    for (k = i; k < max; k++)
                    {
                        if (next ^ board[k, l] ^ b[k])
                        {
                            max = k;
                            break;
                        }
                    }
                    res = Math.Max(res, yoko * (max - i)); 
                }
            }
        }
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                bool[] b = new bool[h];
                int max = h;
                for (k = i; k < h; k++)
                {
                    if (!board[k, j]) b[k] = true;
                }
                for (l = j + 1; l < w; l++)
                {
                    int yoko = l - j + 1;
                    bool next = board[i, l] ^ b[i];
                    for (k = i; k < max; k++)
                    {
                        if (next ^ board[k, l] ^ b[k])
                        {
                            max = k;
                            break;
                        }
                    }
                    res = Math.Max(res, yoko * (max - i));
                }
            }
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
