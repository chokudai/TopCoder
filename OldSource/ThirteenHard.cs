using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ThirteenHard {
    int BIT = 0x1FFF;
    public int calcTime(string[] city)
    {
        int N = city.Length;
        int i, j;
        int[,] distance = new int[N, N];


        int[,] dp = new int[N, BIT];
        bool[,] used = new bool[N, BIT];
        Queue<int> que = new Queue<int>();
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < BIT; j++)
            {
                dp[i, j] = int.MaxValue >> 1;
            }
        }
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < N; j++)
            {
                if (city[i][j] == '#') distance[i, j] = -1;
                else
                {
                    if (city[i][j] >= 'A' && city[i][j] <= 'Z') distance[i, j] = (int)(city[i][j] - 'A') + 1;
                    else distance[i, j] = (int)(city[i][j] - 'a') + 27;
                }
            }
        }
        dp[0, 0] = 0;
        used[0,0] = true;
        que.Enqueue(0);
        while (que.Count != 0)
        {
            int now = que.Dequeue();
            int nowcity = now >> 13;
            int nowbit = now & BIT;
            used[nowcity,nowbit] = false;
            for (i = 0; i < N; i++)
            {
                if (distance[nowcity, i] == -1) continue;
                else
                {
                    int bitmove = distance[nowcity, i] % 13;
                    int nextcity = i;
                    int nextbit = ((nowbit << bitmove) | (nowbit >> (13 - bitmove)) | (1 << bitmove)) & BIT;
                    if ((nextbit & 1) != 0) continue;
                    int nextque = (nextcity << 13) + nextbit;
                    int next = distance[nowcity, i] + dp[nowcity, nowbit];
                    if (next < dp[nextcity, nextbit])
                    {
                        if (!used[nextcity, nextbit])
                        {
                            used[nextcity, nextbit] = true;
                            que.Enqueue(nextque);
                        }
                        dp[nextcity, nextbit] = next;
                    }
                }
            }
        }
        int res = int.MaxValue;
        for (i = 0; i < BIT; i++)
        {
            res = Math.Min(dp[N - 1, i], res);
        }
        if (res == (int.MaxValue >> 1)) return -1;
        else return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
