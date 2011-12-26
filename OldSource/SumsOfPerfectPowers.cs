using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SumsOfPerfectPowers {
    public int howMany(int lowerBound, int upperBound)
    {
        int i;
        long j;
        List<int> l = new List<int>();
        l.Add(0); l.Add(1);
        bool[] dp = new bool[upperBound + 1];
        for (i = 2; i * i <= upperBound; i++)
        {
            for (j = i * i; j <= upperBound; j*=i)
            {
                l.Add((int)j);
            }
        }
        foreach (int a in l)
        {
            foreach (int b in l)
            {
                if (a + b <= upperBound) dp[a + b] = true;
            }
        }
        int res = 0;
        for (i = lowerBound; i <= upperBound; i++) if (dp[i]) res++;
        return res;
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
	private void test_case_0() { int Arg0 = 0; int Arg1 = 1; int Arg2 = 2; verify_case(0, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 5; int Arg1 = 6; int Arg2 = 1; verify_case(1, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 25; int Arg1 = 30; int Arg2 = 5; verify_case(2, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 103; int Arg1 = 103; int Arg2 = 0; verify_case(3, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 1; int Arg1 = 100000; int Arg2 = 33604; verify_case(4, Arg2, howMany(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SumsOfPerfectPowers ___test = new SumsOfPerfectPowers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
