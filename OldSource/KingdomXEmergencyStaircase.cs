using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KingdomXEmergencyStaircase {
public long determineCost(string leftBuilding, string rightBuilding, int[] cost) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "YNYY"; string Arg1 = "NNNY"; int[] Arg2 = new int[]{10, 40, 18, 25}; long Arg3 = 98l; verify_case(0, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string Arg0 = "N"; string Arg1 = "Y"; int[] Arg2 = new int[]{1, 1000}; long Arg3 = 1000l; verify_case(1, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string Arg0 = "NNNNNNNY"; string Arg1 = "NNNNNNNY"; int[] Arg2 = new int[]{1, 2}; long Arg3 = 17l; verify_case(2, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string Arg0 = "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN"; string Arg1 = "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNY"; int[] Arg2 = new int[]{800000000,800000000,800000000,800000000,800000000,800000000,800000000,800000000}; long Arg3 = 6400000000l; verify_case(3, Arg3, determineCost(Arg0, Arg1, Arg2)); }
	private void test_case_4() { string Arg0 = "NNY"; string Arg1 = "NNYYY"; int[] Arg2 = new int[]{10000, 10, 40, 10000, 80, 80}; long Arg3 = 220l; verify_case(4, Arg3, determineCost(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KingdomXEmergencyStaircase ___test = new KingdomXEmergencyStaircase();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
