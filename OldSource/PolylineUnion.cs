using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PolylineUnion {
public int countComponents(string[] polylines) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); if ((Case == -1) || (Case == 7)) test_case_7(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"0,0-10,10 0,10-10,0"}; int Arg1 = 1; verify_case(0, Arg1, countComponents(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"0,0-10,5 5,0-15,5-10,10-5,5"}; int Arg1 = 2; verify_case(1, Arg1, countComponents(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"1","3,0-5,5 4,0-4,20"}; int Arg1 = 2; verify_case(2, Arg1, countComponents(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"10,0-10,1-9,2-9,3-8,4 ","8,2-9,2-10,3 ","12,2-11,2-9,1"}; int Arg1 = 1; verify_case(3, Arg1, countComponents(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"0,0-10,0-0,0 20,0-8,0-20,0"}; int Arg1 = 1; verify_case(4, Arg1, countComponents(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"1,1 2,2 3,3 4,4 3,3-4,4"}; int Arg1 = 3; verify_case(5, Arg1, countComponents(Arg0)); }
	private void test_case_6() { string[] Arg0 = new string[]{"10,10-20,10 20,10-15,18 15,18-10,10"}; int Arg1 = 1; verify_case(6, Arg1, countComponents(Arg0)); }
	private void test_case_7() { string[] Arg0 = new string[]{"1,1 1,1"}; int Arg1 = 1; verify_case(7, Arg1, countComponents(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PolylineUnion ___test = new PolylineUnion();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
