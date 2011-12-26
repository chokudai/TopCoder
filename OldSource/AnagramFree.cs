using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AnagramFree {
public int getMaximumSubset(string[] S) {

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
	private void test_case_0() { string[] Arg0 = new string[]{"abcd","abdc","dabc","bacd"}; int Arg1 = 1; verify_case(0, Arg1, getMaximumSubset(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"abcd","abac","aabc","bacd"}; int Arg1 = 2; verify_case(1, Arg1, getMaximumSubset(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"aa","aaaaa","aaa","a","bbaaaa","aaababaa"}; int Arg1 = 6; verify_case(2, Arg1, getMaximumSubset(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"creation","sentence","reaction","sneak","star","rats","snake"}; int Arg1 = 4; verify_case(3, Arg1, getMaximumSubset(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AnagramFree ___test = new AnagramFree();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
