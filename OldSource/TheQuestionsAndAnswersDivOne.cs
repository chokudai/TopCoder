using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheQuestionsAndAnswersDivOne {
    public int find(int questions, string[] answers)
    {
        int res = 0;
        int yes = 0;
        int no = 0;
        int i;
        for (i = 0; i < answers.Length; i++)
        {
            if (answers[i] == "Yes") yes++;
            else no++;
        }
        for (i = 0; i <= questions; i++)
        {
            res += calc2(yes, i) * calc2(no, questions - i) * calc(questions, i);
        }
        return res;
    }

    int calc(int a, int b)
    {
        if (a == 0 && b == 0) return 1;
        else if (a < b) return 0;
        long res = 1;
        int i;
        for (i = 0; i < b; i++)
        {
            res *= a - i;
            res /= i + 1;
        }
        return (int)res;
    }

    int calc2(int a, int b)
    {
        if (a == 0 && b == 0) return 1;
        else if (b <= 0) return 0;
        else if (a < b) return 0;
        int[] dp = new int[b + 2];
        int i,j;
        dp[0] = 1;
        for (i = 0; i < a; i++)
        {
            int[] dp2 = new int[b + 2];
            for (j = 0; j <= b; j++)
            {
                dp2[j] += dp[j] * j;
                dp2[j + 1] += dp[j] * (b - j);
            }
            dp = (int[])dp2.Clone();
        }
        return dp[b];
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
