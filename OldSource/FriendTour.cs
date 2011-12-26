using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FriendTour {


    double[,] ara = new double[100, 100];

    public double tourProbability(string[] friends, int K)
    {
        int i, j, k;
        int count = 0;
        int len = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic[1] = count++;
        List<int>[] li = new List<int>[friends.Length];
        for (i = 0; i < 100; i++)
        {
            for (j = 0; j < 100; j++)
            {
                ara[i, j] = getper(i, j, K);
            }
        }
        for (i = 0; i < friends.Length; i++)
        {
            string[] star = friends[i].Split(' ');
            li[i] = new List<int>();
            foreach (string st in star)
            {
                int a = int.Parse(st);
                if (!dic.ContainsKey(a))
                {
                    dic[a] = count++;
                }
                li[i].Add(dic[a]);
            }
            if (i == 0)
            {
                len = count;
            }
        }
        for (i = 1; i <= friends.Length; i++)
        {
            if (!dic.ContainsKey(i))
            {
                dic[i] = count++;
            }
        }
        int[][] liar = new int[count][];
        for (i = 0; i < count; i++)
        {
            List<int> memoli = new List<int>();
            foreach (int a in li[i])
            {
                memoli.Add(a);
            }
            liar[dic[i+1]] = memoli.ToArray();
        }

        double[,] dp = new double[(1 << len) + 1, len];
        for (j = 0; j < len; j++)
        {
            dp[(1 << len)-1, j] = 1;
        }
        for (i = (1 << len) - 3; i >= 0; i-=2)
        {
            for (j = 0; j < len; j++)
            {
                double[] armemo = new double[liar[j].Length];
                for (k = 0; k < liar[j].Length; k++)
                {
                    int now = liar[j][k];
                    armemo[k] = 0;
                    if (now >= len) continue;
                    if (((1 << now) & i) != 0) continue;
                    int next = i + (1 << now);
                    armemo[k] = dp[next, now];
                    Console.WriteLine(armemo[k] + " " + next);
                }
                Array.Sort(armemo);
                Array.Reverse(armemo);
                dp[i, j] = 0;
                for (k = 0; k < liar[j].Length; k++)
                {
                    dp[i, j] += armemo[k] * ara[liar[j].Length, k];
			Console.WriteLine("myon: " +armemo[k] + " " + ara[liar[j].Length, k] + " " + liar[j].Length + " " + k);
                }
		Console.WriteLine(dp[i,j] + " " + i + " " + j);
            }
        }
        return dp[1, 0];
    }

    double getper(int all, int num, int K)
    {
        double def = 1;
        int i;
        if (all <= K)
        {
            if (num == 0) return 1;
            else return 0;
        }
        for (i = 0; i < num; i++)
        {
            def *= (double)(all - K - i) / (all - i);
        }
        if (all - i <= 0) return 0;
        return K * def / (all - i);
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
