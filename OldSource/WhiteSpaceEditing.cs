using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class WhiteSpaceEditing {
    int MAX = 999999999;
    public int getMinimum(int[] lines)
    {
        int[] li = new int[lines.Length + 2];
        int[,] dp = new int[lines.Length + 2,lines.Length + 2];
        int i, j, k, l;
        for (i = 0; i < lines.Length; i++) li[i + 1] = lines[i]; 
        if (lines.Length == 1) return lines[0];
        for (i = 0; i < li.Length; i++)
        {
            for (j = 0; j < li.Length; j++)
            {
                dp[i, j] = MAX;
            }
        }
        for (i = 0; i < li.Length; i++) dp[i, i] = 0;
        for (i = 0; i < li.Length- 1; i++)
        {
            //if (i == 0 || i == li.Length - 2) dp[i, i + 1] = 0;
            //else
            dp[i, i + 1] = 0;
        }
        for (k = 2; k < li.Length; k++)
        {
            for (i = 0; i < li.Length; i++)
            {
                for (j = i; j < li.Length; j++)
                {
                    if (j - i != k) continue;
                    //if (i == 2 && j == 4) Console.WriteLine("Yes");
                    for (l = i + 1; l < j; l++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], Math.Min(Math.Abs(li[l] - li[i]), Math.Abs(li[l] - li[j])) + dp[i, l] + dp[l, j] + 1);
                    }
                }
            }
        }
        return dp[0, li.Length - 1] - 1;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
