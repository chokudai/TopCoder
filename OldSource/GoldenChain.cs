using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GoldenChain {
    public int minCuts(int[] sections)
    {
        int remain = sections.Length;
        int res = 0;
        Array.Sort(sections);
        foreach(int a in sections)
        {
            if (a > remain) return res + Math.Max(0, remain);
            else
            {
                remain -= a + 1;
                res += a;
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
	private void test_case_0() { int[] Arg0 = new int[]{3,3,3,3}; int Arg1 = 3; verify_case(0, Arg1, minCuts(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{2000000000}; int Arg1 = 1; verify_case(1, Arg1, minCuts(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,
38,39,40,41,42,43,44,45,46,47,48,49,50}; int Arg1 = 42; verify_case(2, Arg1, minCuts(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{20000000,20000000,2000000000}; int Arg1 = 3; verify_case(3, Arg1, minCuts(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{10,10,10,10,10,1,1,1,1,1}; int Arg1 = 5; verify_case(4, Arg1, minCuts(Arg0)); }
	private void test_case_5() { int[] Arg0 = new int[]{1,10}; int Arg1 = 1; verify_case(5, Arg1, minCuts(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
GoldenChain ___test = new GoldenChain();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
