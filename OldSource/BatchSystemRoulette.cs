using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BatchSystemRoulette {
    public double[] expectedFinishTimes(int[] duration, string[] user)
    {
        double[] res = new double[user.Length];
        int i, j;
        for (i = 0; i < user.Length; i++) res[i] = 0;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (i = 0; i < user.Length; i++)
        {
            dic[user[i]] = 0;
        }
        for (i = 0; i < user.Length; i++)
        {
            dic[user[i]] += duration[i];
        }
        for (i = 0; i < user.Length; i++)
        {
            for (j = 0; j < user.Length; j++)
            {
                if (i == j)
                {
                    res[i] += duration[j];
                }
                else
                {
                    int a = user[i].CompareTo(user[j]);
                    if (dic[user[i]] > dic[user[j]]) res[i] += duration[j];
                    else if (dic[user[i]] == dic[user[j]]) res[i] += duration[j] / 2.0;
                }
            }
        }
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
