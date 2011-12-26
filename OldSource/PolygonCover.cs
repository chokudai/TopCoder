using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PolygonCover {
public double getArea(int[] x, int[] y) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{0,10,0,-10}; int[] Arg1 = new int[]{-10,0,10,0}; double Arg2 = 200.0; verify_case(0, Arg2, getArea(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{-1,2,-2,0}; int[] Arg1 = new int[]{-1,0,2,-1}; double Arg2 = 2.0; verify_case(1, Arg2, getArea(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{2,0,-2,-1,1,0}; int[] Arg1 = new int[]{0,2,0,-2,-2,1}; double Arg2 = 3.0; verify_case(2, Arg2, getArea(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{1,0,-4,0,1,4}; int[] Arg1 = new int[]{1,4,0,-4,-1,0}; double Arg2 = 6.0; verify_case(3, Arg2, getArea(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PolygonCover ___test = new PolygonCover();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
