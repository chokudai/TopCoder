using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KingdomMap {
public int[] getRoadsToRemove(int n, string[] roads) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int[] Expected, int[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(int[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (int o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(int[] a, int[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { int Arg0 = 5; string[] Arg1 = new string[]{"0 1,1 2,2 3"}; int[] Arg2 = new int[]{ }; verify_case(0, Arg2, getRoadsToRemove(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 7; string[] Arg1 = new string[]{"0 1,1 2,2 3,3 4,5 6,2 5"}; int[] Arg2 = new int[]{0 }; verify_case(1, Arg2, getRoadsToRemove(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 20; string[] Arg1 = new string[]{"8 17,9 12,4 7,2 7,2 19,3 12,6 12,1 9,5 18,0 12,6 1", "6,0 11,3 14,10 15,12 13,13 18,13 19,15 17,15 19"}; int[] Arg2 = new int[]{1, 3, 5, 14 }; verify_case(2, Arg2, getRoadsToRemove(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1; string[] Arg1 = new string[]{}; int[] Arg2 = new int[]{ }; verify_case(3, Arg2, getRoadsToRemove(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KingdomMap ___test = new KingdomMap();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
