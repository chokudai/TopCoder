using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxMakingDiceEasy {
    public int theCount(int N, int K)
    {
        int i;
        long res = 0;
        for (i = K; i <= N * 2; i++)
        {
            int low = i / 2;
            if (i % 2 == 0) low--;
            int high = N - i / 2;
            res += getnum(Math.Min(low, high)) * 2;
        }
        return (int)res;
    }

    long getnum(int num)
    {
        if (num < 3) return 0;
        return (long)num * (num - 1) * (num - 2) / 6;
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
	private void test_case_0() { int Arg0 = 6; int Arg1 = 7; int Arg2 = 2; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 5; int Arg1 = 7; int Arg2 = 0; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 50; int Arg1 = 1; int Arg2 = 105800; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 31; int Arg1 = 46; int Arg2 = 504; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 48; verify_case(4, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoxMakingDiceEasy ___test = new FoxMakingDiceEasy();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
