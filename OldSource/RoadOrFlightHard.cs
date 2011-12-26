using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RoadOrFlightHard {
    public long minTime(int N, int roadFirst, int roadProd, int roadAdd, int roadMod, int flightFirst, int flightProd, int flightAdd, int flightMod, int K)
    {
        long[] roadTime = new long[N];
        long[] flightTime = new long[N];
        int i, j;
        roadTime[0] = roadFirst % roadMod;
        flightTime[0] = flightFirst % flightMod;
        for (i = 1; i < N; i++)
        {
            roadTime[i] = ((long)roadTime[i - 1] * roadProd + roadAdd) % roadMod;
            flightTime[i] = ((long)flightTime[i - 1] * flightProd + flightAdd) % flightMod;
        }
        long[,] dp = new long[K + 2, 2];
        for (j = 0; j <= K + 1; j++)
        {
            dp[j, 0] = dp[j, 1] = long.MaxValue >> 1;
        }
        dp[0, 0] = 0;
        for (i = 0; i < N; i++)
        {
            long[,] ndp = new long[K + 2, 2];
            for (j = 0; j <= K + 1; j++)
            {
                ndp[j, 0] = ndp[j, 1] = long.MaxValue >> 1;
            }
            for (j = 0; j <= K; j++)
            {
                ndp[j + 1, 1] = Math.Min(ndp[j + 1, 1], dp[j, 0] + flightTime[i]);
                ndp[j, 1] = Math.Min(ndp[j, 1], dp[j, 1] + flightTime[i]);
                ndp[j, 0] = Math.Min(ndp[j, 0], dp[j, 0] + roadTime[i]);
                ndp[j, 0] = Math.Min(ndp[j, 0], dp[j, 1] + roadTime[i]);
            }
            dp = (long[,])ndp.Clone();
        }
        long res = long.MaxValue >> 1;
        for (i = 0; i <= K; i++)
        {
            for (j = 0; j < 2; j++) res = Math.Min(res, dp[i, j]);
        }
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
