using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BagsOfGold {
public int netGain(int[] bags) {
    int len = bags.Length;
    int[,] dp = new int[len, len];
    int i, j, k;
    for (k = 0; k < len; k++)
    {
        for (i = 0; i < len; i++)
        {
            j = i + k;
            if (j >= len) continue;
            if (k == 0) { dp[i, j] = bags[i]; continue; }
            int now = bags[i] - dp[i + 1, j];
            now = Math.Max(now, bags[j] - dp[i, j - 1]);
            dp[i, j] = now;
        }
    }
    return dp[0, len-1];
}




// BEGIN CUT HERE
public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{7,2}; int Arg1 = 5; verify_case(0, Arg1, netGain(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{2,7,3}; int Arg1 = -2; verify_case(1, Arg1, netGain(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1000,1000,1000,1000,1000}; int Arg1 = 1000; verify_case(2, Arg1, netGain(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{823,912,345,100000,867,222,991,3,40000}; int Arg1 = -58111; verify_case(3, Arg1, netGain(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    BagsOfGold ___test = new BagsOfGold();
    ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
