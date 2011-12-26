using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BunnyComputer {
    public int getMaximum(int[] preference, int k)
    {
        int mod = k + 1;
        int len = preference.Length;
        int i, j;
        int res = 0;
        for (i = 0; i < mod; i++)
        {
            int minnum = int.MaxValue;
            for (j = 0; i + mod * j < len; j++)
            {
                int nextnum = i + mod * j;
                if (j % 2 == 0) minnum = Math.Min(minnum, preference[nextnum]);
                res += preference[nextnum];
            }
            if (j % 2 == 1) res -= minnum;
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{ 3, 1, 4, 1, 5, 9, 2, 6 }; int Arg1 = 2; int Arg2 = 28; verify_case(0, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 3, 1, 4, 1, 5, 9, 2, 6 }; int Arg1 = 1; int Arg2 = 31; verify_case(1, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 1, 2, 3, 4, 5, 6 }; int Arg1 = 3; int Arg2 = 14; verify_case(2, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 487, 2010 }; int Arg1 = 2; int Arg2 = 0; verify_case(3, Arg2, getMaximum(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BunnyComputer ___test = new BunnyComputer();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
