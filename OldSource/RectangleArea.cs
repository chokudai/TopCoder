using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RectangleArea {
    int m, n;
    public int minimumQueries(string[] known)
    {
        m = known.Length;
        n = known[0].Length;
        Queue<int> q = new Queue<int>();
        bool[,] board = new bool[m, n];
        int i, j = 0;
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (known[i][j] == 'Y')
                {
                    q.Enqueue(i * 50 + j);
                    board[i, j] = true;
                }
                else board[i, j] = false;
            }
        }
        int count = 0;
        while (true)
        {
            while (q.Count != 0)
            {
                int next = q.Dequeue();
                int nexti = next / 50;
                int nextj = next % 50;
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        int now = 1;
                        if (board[i, nextj]) now++;
                        if (board[nexti, j]) now++;
                        if (board[i, j]) now++;
                        if (now == 3)
                        {
                            int ni = i, nj = j;
                            if (!board[i, nextj]) { ni = i; nj = nextj; }
                            else if (!board[nexti, j]) { ni = nexti; nj = j; }
                            board[ni, nj] = true;
                            q.Enqueue(ni * 50 + nj);
                        }
                    }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (!board[i, j])
                    {
                        break;
                    }
                }
                if (j != n) break;
            }
            if (i == m) break;
            count++;
            q.Enqueue(i * 50 + j);
            board[i, j] = true;
        }
        return count;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
