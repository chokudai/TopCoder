using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class IsoscelesTriangulations {

    long[, ,] dp;
    int N, K;
    long mod = 123456789;

    public int getCount(int n, int k)
    {
        dp = new long[n + 1, n + 1, n];
        N = n; K = k;
        int i, j, l;
        for (i = 0; i <= n; i++) for (j = 0; j <= n; j++) for (l = 0; l < n; l++) dp[i, j, l] = -1;
        dfs(0, n - 1);
        return (int)dp[0, n - 1, k];
    }

    void dfs(int start, int end)
    {
        if (dp[start, end, 0] != -1) return;
        int i, j, l;
        for (i = 0; i < N; i++) dp[start, end, i] = 0;
        if (end - start == 1)
        {
            dp[start, end, 0] = 1;
            return;
        }
        for (l = start + 1; l < end; l++)
        {
            int temp = 0;
            if (end - start != N)
            {
                if (dist(start, l) == dist(l, end)) temp++;
                else if (dist(l, end) == dist(end, start)) temp++;
                else if (dist(end, start) == dist(start, l)) temp++;
            }
            dfs(start, l); dfs(l, end);
            for (i = 0; i < N; i++)
            {
                for (j = 0; i + j + temp < N; j++)
                {
                    dp[start, end, i + j + temp] += dp[start, l, i] * dp[l, end, j];
                    dp[start, end, i + j + temp] %= mod;
                }
            }
        }
    }

    int dist(int a, int b)
    {
        if (a < b) return dist(b, a);
        return Math.Min(a - b, N - (a - b));
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 4; int Arg1 = 2; int Arg2 = 2; verify_case(0, Arg2, getCount(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 0; int Arg2 = 0; verify_case(1, Arg2, getCount(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 5; int Arg1 = 3; int Arg2 = 5; verify_case(2, Arg2, getCount(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 6; int Arg1 = 2; int Arg2 = 12; verify_case(3, Arg2, getCount(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 10; int Arg1 = 8; int Arg2 = 10; verify_case(4, Arg2, getCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
IsoscelesTriangulations ___test = new IsoscelesTriangulations();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
