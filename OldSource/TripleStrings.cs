using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TripleStrings {
    public int getMinimumOperations(string init, string goal)
    {
        int i, j;
        int len = init.Length;
        int res = len * 2;
        for (i = 0; i < len; i++)
        {
            bool flag = true;
            for (j = i; j < len; j++)
            {
                if (init[j] != goal[j - i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                res = Math.Min(i * 2, res);
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "ooxxox"; string Arg1 = "xoxoxo"; int Arg2 = 6; verify_case(0, Arg2, getMinimumOperations(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "oooxxoo"; string Arg1 = "oooxxoo"; int Arg2 = 0; verify_case(1, Arg2, getMinimumOperations(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "ox"; string Arg1 = "xo"; int Arg2 = 2; verify_case(2, Arg2, getMinimumOperations(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "ooxxooxx"; string Arg1 = "xxoxoxoo"; int Arg2 = 12; verify_case(3, Arg2, getMinimumOperations(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "oxxoxxoooxooooxxxoo"; string Arg1 = "oxooooxxxooooxoxxxo"; int Arg2 = 16; verify_case(4, Arg2, getMinimumOperations(Arg0, Arg1)); }
	private void test_case_5() { string Arg0 = "xxxoxoxxooxooxoxooo"; string Arg1 = "oxxooxxooxxoxoxooxo"; int Arg2 = 36; verify_case(5, Arg2, getMinimumOperations(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TripleStrings ___test = new TripleStrings();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
