using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CubeBuilding {
    public int getCount(int R, int G, int B, int N)
    {

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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 0; int Arg2 = 1; int Arg3 = 2; int Arg4 = 4; verify_case(0, Arg4, getCount(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 2; int Arg3 = 1; int Arg4 = 0; verify_case(1, Arg4, getCount(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 1; int Arg3 = 3; int Arg4 = 162; verify_case(2, Arg4, getCount(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 0; int Arg1 = 0; int Arg2 = 10; int Arg3 = 12; int Arg4 = 372185933; verify_case(3, Arg4, getCount(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CubeBuilding ___test = new CubeBuilding();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
