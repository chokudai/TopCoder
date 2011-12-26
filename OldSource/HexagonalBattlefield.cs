using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HexagonalBattlefield {
    public int countArrangements(int[] X, int[] Y, int N)
    {
        int len = N * 2 + 1;
        long prev = (1 << (len + 1)) - 1;
        Dictionary<long,long> now = 

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
	private void test_case_0() { int[] Arg0 = new int[]{-2,0,1,1,0}; int[] Arg1 = new int[]{-2,0,1,0,2}; int Arg2 = 3; int Arg3 = 10; verify_case(0, Arg3, countArrangements(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{0}; int[] Arg1 = new int[]{0}; int Arg2 = 2; int Arg3 = 2; verify_case(1, Arg3, countArrangements(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{0}; int[] Arg1 = new int[]{0}; int Arg2 = 3; int Arg3 = 104; verify_case(2, Arg3, countArrangements(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{-1,0,0,1,2}; int[] Arg1 = new int[]{0,0,1,0,0}; int Arg2 = 3; int Arg3 = 6; verify_case(3, Arg3, countArrangements(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{0,1,0,0,1,-1,-1}; int[] Arg1 = new int[]{0,0,-1,1,1,0,-1}; int Arg2 = 2; int Arg3 = 1; verify_case(4, Arg3, countArrangements(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
HexagonalBattlefield ___test = new HexagonalBattlefield();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
