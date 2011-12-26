using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RectangleAvoidingColoringEasy {

    int m, n;
    int[,] b;

    public int count(string[] board)
    {
        m = board.Length; n = board[0].Length;
        b = new int[m, n];
        return saiki(board, 0, 0);
    }

    int saiki(string[] board, int y, int x)
    {
        if (y >= m) return 1;
        if (x >= n) return saiki(board, y + 1, 0);
        int i, j;
        bool white = true;
        bool black = true;
        if (board[y][x] == 'W') black = false;
        if (board[y][x] == 'B') white = false;
        for (i = 0; i < y & (black | white); i++)
        {
            for (j = 0; j < x & (black | white); j++)
            {
                if (b[i, j] == 0 && b[i, x] == 0 && b[y, j] == 0) white = false;
                if (b[i, j] == 1 && b[i, x] == 1 && b[y, j] == 1) black = false;
            }
        }
        int res = 0;
        if (white)
        {
            b[y, x] = 0;
            res += saiki(board, y, x + 1);
        }
        if (black)
        {
            b[y, x] = 1;
            res += saiki(board, y, x + 1);
        }
        return res;
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
