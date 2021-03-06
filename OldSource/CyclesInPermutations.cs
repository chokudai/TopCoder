using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CyclesInPermutations {
    public int maxCycle(int[] board)
    {
        int len = board.Length;
        int i;
        bool[] memo = new bool[len];
        int ret = 0;
        for (i = 0; i < len; i++)
        {
            if (!memo[i])
            {
                int now = i;
                int count = 0;
                while (!memo[now])
                {
                    count++;
                    memo[now] = true;
                    now = board[now] - 1;
                }
                ret = Math.Max(ret, count);
            }
        }
        return ret;
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
	private void test_case_0() { int[] Arg0 = new int[]{3,2,4,1,6,5}; int Arg1 = 3; verify_case(0, Arg1, maxCycle(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2,3,4,5,6}; int Arg1 = 1; verify_case(1, Arg1, maxCycle(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{5,1,2,3,4}; int Arg1 = 5; verify_case(2, Arg1, maxCycle(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{5,7,14,6,16,10,8,17,11,12,18,3,4,13,2,15,9,1,20,19}; int Arg1 = 11; verify_case(3, Arg1, maxCycle(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CyclesInPermutations ___test = new CyclesInPermutations();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
