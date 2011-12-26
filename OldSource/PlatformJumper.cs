using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PlatformJumper {
    public int maxCoins(string[] platforms, int v, int g)
    {
        int len = platforms.Length;
        int[] dp = new int[len];
        int[] x = new int[len];
        int[] y = new int[len];
        int[] c = new int[len];
        int i, j, k;
        for (i = 0; i < len; i++)
        {
            string[] st = platforms[i].Split(' ');
            x[i] = int.Parse(st[0]);
            y[i] = int.Parse(st[1]);
            c[i] = int.Parse(st[2]);
        }
        bool[,] b = new bool[len, len];
        double EPS = 1e-9;
        for (i = 0; i < len; i++)
        {
            dp[i] = c[i];
            for (j = 0; j < len; j++)
            {
                double fall = g * Math.Pow(Math.Abs(x[i] - x[j]) / (double)v, 2) / 2;
                if (fall <= y[i] - y[j] + EPS) b[i, j] = true;
                else b[i, j] = false;
            }
        }
        bool[] used = new bool[len]; //‚±‚±‚ª‚à‚¤’²‚×‚½‚©‚Ç‚¤‚©
        for (i = 0; i < len; i++)
        {
            int next = -1;
            for (j = 0; j < len; j++)
            {
                if (used[j]) continue;
                if (next == -1 || y[next] < y[j]) next = j;
            }
            used[next] = true;
            for (j = 0; j < len; j++)
            {                
                if (j == next) continue;
                if (b[next, j])
                {
                    dp[j] = Math.Max(dp[j], dp[next] + c[j]);
                }
            }
        }
        int res = 0;
        for (i = 0; i < len; i++)
        {
            res = Math.Max(res, dp[i]);
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"3 10 7", "5 15 7", "8 9 12" }; int Arg1 = 2; int Arg2 = 10; int Arg3 = 14; verify_case(0, Arg3, maxCoins(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"0 0 1", "2 4 1", "4 0 1"}; int Arg1 = 1; int Arg2 = 2; int Arg3 = 2; verify_case(1, Arg3, maxCoins(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0 0 1", "5000 5000 10"}; int Arg1 = 100; int Arg2 = 87; int Arg3 = 10; verify_case(2, Arg3, maxCoins(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PlatformJumper ___test = new PlatformJumper();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
