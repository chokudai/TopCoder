using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PalindromfulString {
    public long count(int N, int M, int K)
    {
        int i, j, k;
        int len = N - M + 1;
        long res = 0;
        if (K == 0) return (long)(Math.Pow(26, N) + 1e-9);

        long[] mul = new long[len + 1];
        if (len >= K) mul[K] = 1;
        for (i = K + 1; i <= len; i++)
        {
            long now = 0;
            for (j = 0; j < i; j++)
            {
                now -= c(i, j) * mul[j];
            }
            mul[i] = now + 1;
        }

        for (i = 0; i < (1 << len); i++)
        {
            int count = 0;
            Unionfind uni = new Unionfind(N);
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    count++;
                    for (k = 0; k <= (M - 1) / 2; k++)
                    {
                        uni.connect(j + k, j + M - k - 1);
                    }
                }
            }
            if (K > count) continue;
            long now = 1;
            for (j = 0; j < N; j++)
            {
                if (uni.root(j) == j)
                {
                    now *= 26;
                }
            }
            res += now * mul[count];
        }
        return res;
    }

    long c(int a, int b)
    {
        long first = 1;
        int i;
        if (b > a - b) return c(a, a - b);
        for (i = 0; i < b; i++)
        {
            first *= a - i;
            first /= i + 1;
        }
        return first;
    }

    class Unionfind
    {
        int[] dp;

        public Unionfind(int n)
        {
            dp = new int[n];
            for (int i = 0; i < n; i++) dp[i] = -1;
        }

        public bool connect(int a, int b)
        {
            a = root(a);
            b = root(b);
            if (a != b)
            {
                dp[a] += dp[b];
                dp[b] = a;
                return true;
            }
            else return false;
        }

        public int root(int a)
        {
            if (dp[a] < 0) return a;
            else return dp[a] = root(dp[a]);
        }
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 1; long Arg3 = 26l; verify_case(0, Arg3, count(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 0; long Arg3 = 676l; verify_case(1, Arg3, count(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 2; int Arg2 = 1; long Arg3 = 1326l; verify_case(2, Arg3, count(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 1; long Arg3 = 676l; verify_case(3, Arg3, count(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 7; int Arg1 = 3; int Arg2 = 3; long Arg3 = 4310176l; verify_case(4, Arg3, count(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        PalindromfulString ___test = new PalindromfulString();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
