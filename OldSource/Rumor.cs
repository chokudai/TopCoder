using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Rumor {
    public int getMinimum(string knowledge, string[] graph)
    {
        int i, j, k;
        int len = knowledge.Length;
        int MAX = 99999;
        int ret = MAX;
        for (i = 0; i < (1 << len); i++)
        {
            int[,] dist = new int[len, 2];
            bool[,] memo = new bool[len, 2];
            Queue<int> q = new Queue<int>();
            for (j = 0; j < len; j++)
            {
                if (knowledge[j] == 'Y')
                {
                    dist[j, 0] = dist[j, 1] = 0;
                }
                else dist[j, 0] = dist[j, 1] = MAX;
            }
            
            int turn = 0;
            bool ok = false;
            for (turn = 0; turn < ret; turn++)
            {
                ok = true;
                for (j = 0; j < len; j++)
                {
                    if (memo[j, 0] && memo[j, 1]) continue;
                    if (dist[j, 0] <= turn && !memo[j, 0] && (i >> j) % 2 == 0)
                    {
                        memo[j, 0] = true;
                        for (k = 0; k < len; k++)
                        {
                            if (graph[j][k] == 'Y' && dist[k, 0] == MAX)
                            {
                                dist[k, 0] = turn + 1;
                                ok = false;
                            }
                        }

                    }
                    else if (dist[j, 1] <= turn && !memo[j, 1] && (i >> j) % 2 == 1)
                    {
                        memo[j, 1] = true;
                        for (k = 0; k < len; k++)
                        {
                            if (graph[j][k] == 'Y' && dist[k, 1] == MAX)
                            {
                                dist[k, 1] = turn + 1;
                                ok = false;
                            }
                        }
                    }
                    else if (dist[j, 0] <= turn && !memo[j, 0])
                    {
                        memo[j, 0] = true;
                        for (k = 0; k < len; k++)
                        {
                            if (graph[j][k] == 'Y' && dist[k, 0] == MAX)
                            {
                                dist[k, 0] = turn + 1;
                                ok = false;
                            }
                        }
                    }
                    else if (dist[j, 1] <= turn && !memo[j, 1])
                    {
                        memo[j, 1] = true;
                        for (k = 0; k < len; k++)
                        {
                            if (graph[j][k] == 'Y' && dist[k, 1] == MAX)
                            {
                                dist[k, 1] = turn + 1;
                                ok = false;
                            }
                        }
                    }
                }
                if (ok) break;
            }
            for (j = 0; j < len; j++) if (dist[j, 0] == MAX || dist[j, 1] == MAX) break;
            if (ok && j == len) ret = Math.Min(ret, turn);
        }
        if (ret == MAX) return -1;
        return ret;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
