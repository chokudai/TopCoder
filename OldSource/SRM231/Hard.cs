using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

public class SalesPromotion
{
    int[,,] dp = new int[200000, 2,2];
	public int bestPrice(int points, int halfPrice, int discount, string[] items)
	{
        int i, j,k;
        for (i = 0; i < 200000; i++) for (j = 0; j < 2; j++) dp[i, j,0] = int.MaxValue;
        dp[0, 0,0] = 0;
        for (k = 0; k < items.Length; k++)
        {
            for (i = 0; i < 200000; i++) for (j = 0; j < 2; j++) dp[i, j, (k+1%2)] = int.MaxValue;
            for (i = 0; i < 200000; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    if (dp[i, j, k % 2] != 0) continue;
                }
            }
        }
        return 1;
	}

    //<%:testing-code%>
}
//Powered by [KawigiEdit] 2.0!