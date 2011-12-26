using System;
using System.Collections.Generic;
using System.Text;

public class PointsOnCircle
{
    public long count(int r)
    {
        long i,j;
        int k;
        long[] dp = new long[4];
        dp[1] = 1;
        for (i = 2; i <= r; i++)
        {
            if (i * i > r) i = r;
            long[] adddp = new long[4];
            for (j = i; r % i == 0; j *= i * i)
            {
                r /= (int)i;
                for (k = 0; k < 4; k++) adddp[(k * j) % 4] += dp[k];
                for (k = 0; k < 4; k++) adddp[(k * j % 4 * i) % 4] += dp[k];
            }
            for (k = 0; k < 4; k++) dp[k] += adddp[k];
        }
        Console.WriteLine(dp[1] + " " + dp[3]);
        return 4 * (dp[1] - dp[3]);
    }
}
