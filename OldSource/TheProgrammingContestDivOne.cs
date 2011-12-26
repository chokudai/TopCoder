using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheProgrammingContestDivOne {
    public int find(int T, int[] maxPoints, int[] pointsPerMinute, int[] requiredTime)
    {
        int i, j;
        for (i = 0; i < requiredTime.Length; i++)
        {
            for (j = 0; j < requiredTime.Length - 1; j++)
            {
                if (pointsPerMinute[j] * (long)requiredTime[j + 1] < pointsPerMinute[j + 1] * (long)requiredTime[j])
                {
                    int temp = requiredTime[j];
                    requiredTime[j] = requiredTime[j + 1];
                    requiredTime[j + 1] = temp;
                    temp = pointsPerMinute[j];
                    pointsPerMinute[j] = pointsPerMinute[j + 1];
                    pointsPerMinute[j + 1] = temp;
                    temp = maxPoints[j];
                    maxPoints[j] = maxPoints[j + 1];
                    maxPoints[j + 1] = temp;
                }
            }
        }
        long[] dp = new long[T + 1];
        long res = 0;
        for (i = 0; i <= T; i++) dp[i] = 0;
        for (i = 0; i < pointsPerMinute.Length; i++)
        {
            for (j = T - requiredTime[i]; j >= 0; j--)
            {
                int now = j;
                int next = j + requiredTime[i];
                dp[next] = Math.Max(dp[next], dp[now] + maxPoints[i] - (long)pointsPerMinute[i] * next);
                res = Math.Max(res, dp[next]);
            }
        }
        return (int)res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
