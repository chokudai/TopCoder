using System;
using System.Collections.Generic;
using System.Text;

public class TimeTravellingTour {
    public long determineCost(int N, int[] cities, string[] roads)
    {
        long max = long.MaxValue >> 2;
        long[,] dist = new long[N, N];
        int i, j, k, l;
        string s = "";
        foreach (string ss in roads) s += ss;
        string[] sss = s.Split(' ');
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < N; j++)
            {
                dist[i, j] = max;
            }
            dist[i, i] = 0;
        }
        foreach (string ss in sss)
        {
            string[] st = ss.Split(',');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            long d = long.Parse(st[2]);
            dist[a, b] = Math.Min(dist[a, b], d);
            dist[b, a] = Math.Min(dist[b, a], d);
        }
        for (k = 0; k < N; k++)
        {
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);
                }
            }
        }
        long[,,] dp = new long[cities.Length, cities.Length, N];
        for (i = 0; i < cities.Length; i++) if (dist[0, cities[i]] == max) return -1;

        for (i = 0; i < cities.Length; i++)
        {
            for (j = 0; j < cities.Length; j++)
            {
                for (k = 0; k < N; k++)
                {
                    dp[i, j, k] = max;
                }
            }
            for (k = 0; k < N; k++)
            {
                dp[i, i, k] = dist[cities[i], k];
            }
        }
        for (i = 1; i < cities.Length; i++)
        {
            for (j = 0; j < cities.Length - i; j++)
            {
                int first = j;
                int last = j + i;
                for (k = 0; k < N; k++)
                {
                    for (l = first; l < last; l++)
                    {
                        dp[first, last, k] = Math.Min(dp[first, last, k], dp[first, l, k] + dp[l + 1, last, k]);
                    }
                }
                //SPFA
                Queue<int> q = new Queue<int>();
                bool[] b = new bool[N];
                for (k = 0; k < N; k++)
                {
                    b[k] = true;
                    q.Enqueue(k);
                }
                while (q.Count != 0)
                {
                    int now = q.Dequeue();
                    b[now] = false;
                    for (k = 0; k < N; k++)
                    {
                        if (dp[first, last, k] > dp[first, last, now] + dist[now, k])
                        {
                            dp[first, last, k] = dp[first, last, now] + dist[now, k];
                            if (!b[k])
                            {
                                q.Enqueue(k);
                                b[k] = true;
                            }
                        }
                    }
                }
            }
        }

        long res = max;
        for (i = 0; i < N; i++)
        {
            res = Math.Min(res, dp[0, cities.Length - 1, i] + dist[0, i]);
        }
        return res;

    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 5; int[] Arg1 = new int[]{2,3,2,4}; string[] Arg2 = new string[]{"0,2,4 0,1,2 2,1,2 1,3,3 4,0,4"}; long Arg3 = 13l; verify_case(0, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 3; int[] Arg1 = new int[]{1,0,1}; string[] Arg2 = new string[]{"0,2,1"," 2",",1,5"}; long Arg3 = 12l; verify_case(1, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 3; int[] Arg1 = new int[]{2}; string[] Arg2 = new string[]{"0,1,2"}; long Arg3 = -1l; verify_case(2, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 6; int[] Arg1 = new int[]{4, 1, 3, 2}; string[] Arg2 = new string[]{"0,1,5 0,2,5 0,5,2 2,3,5 2,4,2 3,4,4 3,5,1"}; long Arg3 = 19l; verify_case(3, Arg3, determineCost(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    TimeTravellingTour ___test = new TimeTravellingTour();
    ___test.run_test(-1);
try {

} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
