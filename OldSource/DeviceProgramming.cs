using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DeviceProgramming {
    public long minBytes(int[] offset, int[] size, int maxPacketSize, int overhead)
    {
        int len = offset.Length;
        long[] dp = new long[len + 1];
        int i, j;
        long packet = maxPacketSize - overhead;
        for (i = 0; i < len; i++) dp[i + 1] = long.MaxValue;
        dp[0] = 0;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (offset[j] > offset[j + 1])
                {
                    int temp = offset[j];
                    offset[j] = offset[j + 1];
                    offset[j + 1] = temp;
                    temp = size[j];
                    size[j] = size[j + 1];
                    size[j + 1] = temp;
                }
            }
        }

        for (i = 0; i < len; i++)
        {
            long start = offset[i];
            for (j = i; j < len; j++)
            {
                long goal = offset[j] + size[j] - 1;
                long l = goal - start + 1;
                if (l < 0) l = 0;
                long need = (l + packet - 1) / packet;
                dp[j + 1] = Math.Min(dp[j + 1], dp[i] + l + need * overhead);
            }
        }
        return dp[len];
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
